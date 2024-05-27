using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ServicoBaralho : IServicoBaralho
    {
        public const int quantidadeBaralhoCommander = 100;
        public const int quantidadeBaralhoPauper = 60;
        public const int quantidadeBaralhoStandard = 60;
        public const int quantidadeMaximaDeCopiaDeCartasCommander = 1;
        public const int quantidadeMaximaDeCopiaDeCartasPauper = 4;
        public const int quantidadeMaximaDeCopiaDeCartasStandard = 4;
        public int GerarIdBaralho(int quantidadeDeBaralhosDoJogadorNoBancoDeDados)
        {
            return quantidadeDeBaralhosDoJogadorNoBancoDeDados + 1;
        }

        public decimal SomarPrecoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return baralho.Sum(carta => carta.Carta.PrecoCarta *
            carta.QuantidadeCopiasDaCartaNoBaralho);
        }

        public int SomarQuantidadeDeCartasDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return baralho.Sum(cartas => cartas.QuantidadeCopiasDaCartaNoBaralho);
        }

        public int SomarCustoDeManaConvertidoDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return Convert.ToInt32(baralho.Sum(cartas => cartas.Carta.CustoDeManaConvertidoCarta)
                /SomarQuantidadeDeCartasDoBaralho(baralho));
        }

        public List<CoresEnum> ConferirCoresDoBaralho(List<CopiaDeCartasNoBaralho> baralho)
        {
            return baralho.SelectMany(carta => carta.Carta.CorCarta).Distinct().ToList();
        }

        public bool ValidacaoTipoDeBaralho(List<CopiaDeCartasNoBaralho> cartas, FormatoDeJogoEnum formatoDeJogo)
        {
            switch (formatoDeJogo)
            {
                case FormatoDeJogoEnum.Commander:
                    if (SomarQuantidadeDeCartasDoBaralho(cartas) != quantidadeBaralhoCommander) return false;
                    if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasCommander))) return false;
                    break;

                case FormatoDeJogoEnum.Pauper:
                    if (SomarQuantidadeDeCartasDoBaralho(cartas) < quantidadeBaralhoPauper) return false;
                    if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasPauper))) return false;
                    if (cartas.All(c => c.Carta.RaridadeCarta != RaridadeEnum.Common)) return false;
                    break;
                case FormatoDeJogoEnum.Standard:
                    if (SomarQuantidadeDeCartasDoBaralho(cartas) < quantidadeBaralhoStandard) return false;
                    if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > quantidadeMaximaDeCopiaDeCartasStandard))) return false;
                    break;
            }
            return true;
        }
    }
}