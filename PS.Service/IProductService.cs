using System.Collections.Generic;
using PS.Domain;

namespace PS.Service
{
    public interface IProductService :IService<Product>
    {
        IList<Product> FindMost5ExpensiveProds();
       double UnavailableProdPercentage();

       IList<Product> GetProdByClient(Client client);

       void DeleteOldProducts();
    }
}