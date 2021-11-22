using System;

namespace PS.Data.Infrastructures
{
    public interface IUnitOfWork :IDisposable
    {
        void Commit(); 
        //void Dispose(); Hidden from IDisposable interface
        IRepository<T> getRepository<T>() where T : class;
    }
}