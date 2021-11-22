using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class CategoryService:ICategoryService
    {
        private IRepository<Category> repository;
        IUnitOfWork UnitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
            this.repository = UnitOfWork.getRepository<Category>();
        }
        public void Add(Category category)
        {
            repository.Add(category);
        }
        public void Remove(Category category)
        {
            repository.Delete(category);
               }

        public IList<Category> GetAll()
        {
         return   repository.GetAll().ToList();
        }
        public void Commit()
        {
            UnitOfWork.Commit();
        }
    }
}