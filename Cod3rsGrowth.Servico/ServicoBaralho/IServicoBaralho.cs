using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public interface IServicoBaralho
    {
        int GerarIdBaralho(int quantidadeDeBaralhosDoJogadorNoBancoDeDados);
        decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        List<CoresEnum> ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho);
        bool ValidacaoTipoDeBaralho(List<CopiaDeCartasNoBaralho> cartas, FormatoDeJogoEnum formatoDeJogo);
    }
}