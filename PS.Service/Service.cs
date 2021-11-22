using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PS.Data.Infrastructures;

namespace PS.Service
{
    public class Service<T>:IService<T> where T:class 
    {
        IRepository<T> repository;
        IUnitOfWork unitOfWork;
        public Service(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repository = this.unitOfWork.getRepository<T>();
        }
        public void Dispose()
        {
           unitOfWork.Dispose();
        }

        public void Add(T entity)
        {
            repository.Add(entity);
        }

        public void Update(T entity)
        {
            repository.Update(entity);
        }

        public void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public void Delete(Expression<Func<T, bool>> @where)
        {
            repository.Delete(where);
        }

        public T GetById(int id)
        {
           return repository.GetById(id);
        }

        public T GetById(string id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> @where = null)
        {
            return repository.GetMany(where);
        }

        public T Get(Expression<Func<T, bool>> @where)
        {
            return repository.Get(where);
        }

        public void Commit()
        {
            unitOfWork.Commit();
        }
    }
}