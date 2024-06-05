using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public interface IServicoBaralho
    {
        public void Inserir(Baralho baralho);
        public Baralho ObterPorId(int idBaralho);
        public List<Baralho> ObterTodos();
        int GerarIdBaralho(int quantidadeDeBaralhosDoJogadorNoBancoDeDados);
        decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        List<CoresEnum> ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        bool ValidacaoTipoDeBaralho(List<CopiaDeCartasNoBaralho> cartas, FormatoDeJogoEnum formatoDeJogo);
    }
}