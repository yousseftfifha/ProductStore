using System.Collections.Generic;
using System.Linq;
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class CategoryService:ICategoryService
    {
        PSContext ctxt;
        public CategoryService(IDatabaseFactory databaseFactory)
        {
            this.ctxt = databaseFactory.DataContext;
        }
        public void Add(Category category)
        {
             ctxt.Categories.Add(category);
             ctxt.SaveChanges();
        }
        public void Remove(Category category)
        {
            ctxt.Categories.Remove(category);
            ctxt.SaveChanges();        }

        public IList<Category> GetAll()
        {
         return   ctxt.Categories.ToList();
        }
    }
}