using System;
using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class ProductService:Service<Product>,IProductService
    {
        IInvoiceService invoiceService ;

        public ProductService(IUnitOfWork unitOfWork,InvoiceService invoiceService) : base(unitOfWork)
        {
            this.invoiceService = invoiceService;
        }

        public IList<Product> FindMost5ExpensiveProds()
        {
            return GetMany().OrderByDescending(product => product.Price).Take(5).ToList();
        }

        public double UnavailableProdPercentage()
        {
            return ((double)(GetMany(product => product.Quantity == 0).Count() ) / GetMany().Count())* 100;
        }

        public IList<Product> GetProdByClient(Client client)
        {
            return invoiceService.GetMany(invoice => invoice.clientFk == client.Cin)
                .Select(invoice => invoice.Product).ToList();
            
        }

        public void DeleteOldProducts()
        {
            Delete(product => product.DateProd.AddYears(1)>DateTime.Now);
        }
    }
}