using System.Collections.Generic;
using PS.Domain;

namespace PS.Service
{
    public interface IProductService
    {
        public void Add(Product product);
        public void Remove(Product product);
        public IList<Product> GetAll();
        
    }
}