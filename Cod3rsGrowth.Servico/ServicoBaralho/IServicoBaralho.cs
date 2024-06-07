using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public interface IServicoBaralho
    {
        public Baralho ObterPorId(int idBaralho);
        public List<Baralho> ObterTodos();
        void CriarBaralho(int idJogador, string nomeBaralho, FormatoDeJogoEnum formatoDeJogoDoBaralho,
            List<CopiaDeCartasNoBaralho> cartasDoBaralho);
    }
}