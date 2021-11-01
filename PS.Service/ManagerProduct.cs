using System;
using System.Collections.Generic;
using System.Linq;
using PS.Domain;

namespace PS.Service
{
    public class ManagerProduct
    {
        public IList<Product> Products { get; set; }
        public IList<Product> Get5Chemical(double price)
        {

            return (IList<Product>)(from p in Products
                                    where p.Price >= price && p is Chemical
                                    select p).Take(5);

        }

        public IList<Product> GetProductPrice(double price)
        {

            return (IList<Product>)(from p in Products
                                    where p.Price > price
                                    select p).Skip(2);

        }

        public double GetAvergePrice()
        {

            return (from p in Products

                    select p.Price).Average();

        }

        public Product GetMaxPrice()
        {

            return (from p in Products
                    orderby p.Price descending
                    select p).First();


        }



        public IList<Product> GetChemicalCity()
        {
            var query = from p in Products
                        orderby ((Chemical)p).Address.City ascending
                        where p is Chemical
                        select p;

            return (IList<Product>)query;

        }

        public void GetChemicalGroupByCity()
        {
            var query = from c in Products
                            // where c is Chemical
                        orderby ((Chemical)c).Address.City ascending
                        group c by ((Chemical)c).Address.City;

            foreach (var map in query)
            {
                Console.WriteLine("City name : " + map.Key);
                foreach (var val in map)
                {
                    Console.WriteLine("Chemical product name" + val.Name);
                }
            }

        }



        public int GetCountProduct(string city)
        {
            var query = from p in Products
                        where p is Chemical && ((Chemical)p).Address.City.Equals(city)
                        select p;

            return query.Count();
        }





        // les expressions lamda

        public IList<Product> FindProduct(Char c)
        {
            return (IList<Product>)Products.Where(p=>p.Name.StartsWith(c));

        }
        public  void FindProduct(Category c)
        {
            var result=Products.Where(p=>p.MyCategory == c);
        }

    }
}
