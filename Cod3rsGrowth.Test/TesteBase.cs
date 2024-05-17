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
        protected ServiceProvider ServiceProvider;

        public TesteBase()
        {
            IServiceCollection service = new ServiceCollection();
            ServiceProvider = service.BuildServiceProvider();
        }

        public void Dispose()
        {
            ServiceProvider.Dispose();
        }
    }
}