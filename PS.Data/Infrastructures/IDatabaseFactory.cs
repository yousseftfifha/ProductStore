
using System;

namespace PS.Data.Infrastructures
{
    public interface IDatabaseFactory:IDisposable
    {
        PSContext DataContext { get; } 

    }
}