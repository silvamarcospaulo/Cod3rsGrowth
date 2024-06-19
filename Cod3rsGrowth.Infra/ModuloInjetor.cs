using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Infra
{
    public static class ModuloInjetor
    {
        public static void ModuloInjetorInfra(ServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<ConexaoDados>();
        }
    }
}