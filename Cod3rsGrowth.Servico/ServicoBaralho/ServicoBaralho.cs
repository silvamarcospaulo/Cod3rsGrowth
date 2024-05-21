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
        public int GerarIdCarta(List<Baralho> quantidadeDeBaralhosDoJogadorNoBancoDeDados)
        {
            return quantidadeDeBaralhosDoJogadorNoBancoDeDados.Count + 1;
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
            List<CoresEnum> coresDoBaralho = new List<CoresEnum>();

            foreach (CopiaDeCartasNoBaralho copia in baralho)
            {
                foreach (CoresEnum cor in copia.Carta.CorCarta)
                {
                    if (cor == CoresEnum.Branco) { if (!(coresDoBaralho.Contains(cor))) { coresDoBaralho.Add(cor); } }
                    if (cor == CoresEnum.Verde) { if (!(coresDoBaralho.Contains(cor))) { coresDoBaralho.Add(cor); } }
                    if (cor == CoresEnum.Vermelho) { if (!(coresDoBaralho.Contains(cor))) { coresDoBaralho.Add(cor); } }
                    if (cor == CoresEnum.Azul) { if (!(coresDoBaralho.Contains(cor))) { coresDoBaralho.Add(cor); } }
                    if (cor == CoresEnum.Preto) { if (!(coresDoBaralho.Contains(cor))) { coresDoBaralho.Add(cor); } }
                }
            }
            return coresDoBaralho;
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