using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Test
{
    public class TesteBase : IDisposable
    {
        protected ServiceProvider ServiceProvider { get; set; }

        public TesteBase()
        {
            var service = new ServiceCollection();
            ModuloInjetor.implementarServico(service);
            ServiceProvider = service.BuildServiceProvider();
        }

        public void Dispose()
        {
            ServiceProvider.Dispose();
        }
    }
}