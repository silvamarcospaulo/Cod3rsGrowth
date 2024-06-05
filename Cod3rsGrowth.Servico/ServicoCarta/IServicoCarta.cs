using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public interface IServicoCarta
    {
        void Inserir(Carta carta);
        Carta ObterPorId(int idCarta);
        List<Carta> ObterTodos();
        int GerarIdCarta(int quantidadeDeCartasNoBancoDeDados);
        decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta);
        List<CoresEnum> AdicionarCoresDaCarta(string cor);
    }
}