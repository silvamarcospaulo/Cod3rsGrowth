using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoBaralho
{
    public class ServicoBaralho : IServicoBaralho
    {
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
            if (formatoDeJogo == FormatoDeJogoEnum.Commander)
            {
                if (SomarQuantidadeDeCartasDoBaralho(cartas) != 100){ return false; }
                if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                (c.QuantidadeCopiasDaCartaNoBaralho > 1))) { return false; }
            }

            if (formatoDeJogo == FormatoDeJogoEnum.Pauper)
            {
                if (SomarQuantidadeDeCartasDoBaralho(cartas) < 60) { return false; }
                if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                (c.QuantidadeCopiasDaCartaNoBaralho > 4))) { return false; }
                if (cartas.All(c => c.Carta.RaridadeCarta != RaridadeEnum.Common)) { return false; }
            }

            if (formatoDeJogo == FormatoDeJogoEnum.Standard)
            {
                if (SomarQuantidadeDeCartasDoBaralho(cartas) < 60) { return false; }
                if (cartas.All(c => (c.Carta.TipoDeCarta != TipoDeCartaEnum.TerrenoBasico) &&
                (c.QuantidadeCopiasDaCartaNoBaralho > 4))) { return false; }
            }

            return true;
        }
    }
}