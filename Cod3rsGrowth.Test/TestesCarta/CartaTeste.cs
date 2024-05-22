using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class CartaTeste : TesteBase
    {
        public CartaTeste()
        {
            Carta _carta = Singleton<Carta>.SingletonTabelas.Instance();
        }
    }
}