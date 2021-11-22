using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class ProductService:IProductService
    {
         IRepository<Product> repository;
         IUnitOfWork UnitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
            this.repository = UnitOfWork.getRepository<Product>();
        }
        public void Add(Product product)
        {
            repository.Add(product);
        }

        public void Remove(Product product)
        {
            repository.Delete(product);
        }

        public IList<Product> GetAll()
        {
            return   repository.GetAll().ToList();
        }

        public void Commit()
        {
            UnitOfWork.Commit();
        }

    }
}