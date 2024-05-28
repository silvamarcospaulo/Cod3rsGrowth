using System;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Test
{
    public class TesteBase : IDisposable
    {
        protected ServiceProvider ServiceProvider;

        public TesteBase()
        {
            var service = new ServiceCollection();
            ModuloInjetor.ModuloInjetorTeste(service);
            ServiceProvider = service.BuildServiceProvider();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}