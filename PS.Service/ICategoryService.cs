using System.Collections.Generic;
using PS.Domain;

namespace PS.Service
{
    public interface ICategoryService
    {
        public void Add(Category category);
        public void Remove(Category category);
        public IList<Category> GetAll();

    }
}