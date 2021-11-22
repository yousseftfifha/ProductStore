using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace PS.Data.Infrastructures
{
    public class Repository<T>:IRepository<T> where T:class 
    {
        PSContext ctxt;
        DbSet<T> dbSet;
        public Repository(IDatabaseFactory databaseFactory)
        {
            this.ctxt = databaseFactory.DataContext;
            this.dbSet = ctxt.Set<T>();
        }       
        public void Add(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            dbSet.Update(obj);
        }

        public void Delete(T obj)
        {
            dbSet.Remove(obj);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            dbSet.RemoveRange(dbSet.Where(condition));
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public T GetById(string id)
        {
            return dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> condition)
        {
            return dbSet.Where(condition).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable<T>();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null)
        {
            return dbSet.Where(condition).AsEnumerable();
        }
    }
}