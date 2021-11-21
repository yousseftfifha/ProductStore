using System;

namespace PS.Data.Infrastructures
{
    public class DatabaseFactory:Disposable,IDatabaseFactory

    {
        public PSContext DataContext => new PSContext();

        protected override void DisposeCore()
        {
            DataContext.Dispose();
        }
    }
}