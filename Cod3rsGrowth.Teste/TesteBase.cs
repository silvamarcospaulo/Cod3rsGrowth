using System;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste
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
            ServiceProvider.Dispose();
        }
    }
}