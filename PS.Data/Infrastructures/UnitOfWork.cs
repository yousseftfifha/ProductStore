namespace PS.Data.Infrastructures
{
    public class UnitOfWork:IUnitOfWork
    {
        private IDatabaseFactory databaseFactory;
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }     
        public void Dispose()
        {
            databaseFactory.Dispose();
        }

        public void Commit()
        {
            databaseFactory.DataContext.SaveChanges();
        }

        public IRepository<T> getRepository<T>() where T : class
        {
            return new Repository<T>(databaseFactory);
        }
    }
}