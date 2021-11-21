using System;

namespace PS.Data.Infrastructures
{
    public class Disposable:IDisposable
    {
    
        public bool disposedValue;
        private  void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing) {
                    DisposeCore();
                }
                disposedValue = true; 

            }
        }

        protected virtual void DisposeCore()
        { 
            //insert code 
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Disposable()
        {
            // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
            Dispose(disposing: false);
        }
    }
}