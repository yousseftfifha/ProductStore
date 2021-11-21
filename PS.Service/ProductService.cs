using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class ProductService:IProductService
    {
        PSContext ctxt;
        public ProductService(IDatabaseFactory databaseFactory)
        {
            this.ctxt = databaseFactory.DataContext;
        }
        public void Add(Product product)
        {
            ctxt.Products.Add(product);
            ctxt.SaveChanges();        }

        public void Remove(Product product)
        {
            ctxt.Products.Remove(product);
            ctxt.SaveChanges();         }

        public IList<Product> GetAll()
        {
            return   ctxt.Products.ToList();
        }
    }
}