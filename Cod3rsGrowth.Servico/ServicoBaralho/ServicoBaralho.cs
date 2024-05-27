using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ServicoBaralho : IServicoBaralho
    {
        public static readonly int TAMANHO_MINIMO_BARALHO_COMMANDER = 100;
        public static readonly int TAMANHO_MINIMO_BARALHO_PAUPER = 60;
        public static readonly int TAMANHO_MINIMO_BARALHO_STANDARD = 60;
        public static readonly int QUANTIDADE_MAXIMA_DE_CARTAS_COMMANDER = 1;
        public static readonly int QUANTIDADE_MAXIMA_DE_CARTAS_PAUPER = 4;
        public static readonly int QUANTIDADE_MAXIMA_DE_CARTAS_STANDARD = 4;
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
                    if (SomarQuantidadeDeCartasDoBaralho(cartas) != TAMANHO_MINIMO_BARALHO_COMMANDER) return false;
                    if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > QUANTIDADE_MAXIMA_DE_CARTAS_COMMANDER))) return false;
                    break;

                case FormatoDeJogoEnum.Pauper:
                    if (SomarQuantidadeDeCartasDoBaralho(cartas) < TAMANHO_MINIMO_BARALHO_PAUPER) return false;
                    if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > QUANTIDADE_MAXIMA_DE_CARTAS_PAUPER))) return false;
                    if (cartas.All(c => c.Carta.RaridadeCarta != RaridadeEnum.Common)) return false;
                    break;
                case FormatoDeJogoEnum.Standard:
                    if (SomarQuantidadeDeCartasDoBaralho(cartas) < TAMANHO_MINIMO_BARALHO_STANDARD) return false;
                    if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                    (c.QuantidadeCopiasDaCartaNoBaralho > QUANTIDADE_MAXIMA_DE_CARTAS_STANDARD))) return false;
                    break;
            }
            return true;
        }
    }
}