using System;
using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Domain;
using PS.Service;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 20/09/2021

            /*Category cat1, cat2, cat3;
            cat1 = new Category() {Name = "cat1"};
            cat2 = new Category() {Name = "cat2"};
            cat3 = new Category() {Name = "cat3"};
            
            Provider provider1, provider2, provider3, provider4, provider5;
            provider1 = new Provider() { UserName = "email1"};
            provider2 = new Provider() { UserName = "email2"};
            provider3 = new Provider() { UserName = "email3"};
            provider4 = new Provider() { UserName = "email4"};
            provider5 = new Provider() { UserName = "email5"};
            
            Product product1, product2, product3, product4, product5, product6;
            product1 = new Product() { Name = "product1"};
            product2 = new Product() { Name = "product2"};
            product3 = new Product() { Name = "product3"};
            product4 = new Product() { Name = "product4"};
            product5= new Product()  { Name = "product5"};
            product6 = new Product() { Name = "product6"};

            cat1.ListProducts = new List<Product> { product1, product2 };
            cat2.ListProducts = new List<Product> {  product5 };
            cat3.ListProducts = new List<Product> {  product3,product6, };

            provider1.ListProducts = new List<Product> {product1, product2,product3};
            provider2.ListProducts = new List<Product> {product1, product5};
            provider3.ListProducts = new List<Product> {product1, product4};
            provider4.ListProducts = new List<Product> {product4, product6};
            provider5.ListProducts = new List<Product> {product4, product6};
            
            provider1.GetDetails();

            #endregion
            #region 03/10/2021
            ManagerProvider managerProvider = new ManagerProvider();
            managerProvider.providers = new List<Provider>() {provider1, provider2};
           */
            #endregion
            #region 17/10/2021
            /*/PSContext ctxt = new PSContext();
            Product p =  new Product()
            {
                Name = "PROD1",
                DateProd = DateTime.Now
            };
            ctxt.Products.Add(p);
            ctxt.SaveChanges();*/
            #endregion
            #region 26/10/2021

           /* Product p = new Product()
            {
                Name = "prod1",
                DateProd = DateTime.Now


            };
            PSContext ctxt = new PSContext();
            ctxt.Products.Add(p);
            ctxt.SaveChanges();
*/


            #endregion

            #region 08/11/2021
            Category c = new Category()
            {
                Name = "cat1",
            };
            Product p = new Product()
            {
                Name = "prod1",
                DateProd = DateTime.Now,
                MyCategory = c
            };
            PSContext ctxt = new PSContext();
            // ctxt.Categories.Add(c);
            // ctxt.Products.Add(p);
            // ctxt.SaveChanges();
            Product product = ctxt.Products.ToList().FirstOrDefault(p => p.Name == "prod1");
            product.GetDetails();

            #endregion
        }
    }
}