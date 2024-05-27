using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class ListaDeCartasTabela
    {
        public ListaDeCartasTabela()
        {
            List<List<CopiaDeCartasNoBaralho>> copiaDeCartasNoBaralhos = new List<List<CopiaDeCartasNoBaralho>>()
            {
                new List<CopiaDeCartasNoBaralho>
                {
                    new CopiaDeCartasNoBaralho ()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 1,
                            NomeCarta = "Ilha",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 49
                    },
                    new CopiaDeCartasNoBaralho ()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 5,
                            NomeCarta = "Montanha",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 50
                    },
                    new CopiaDeCartasNoBaralho ()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 8,
                            NomeCarta = "Niv-Mizzet, Parum",
                            CustoDeManaConvertidoCarta = 6,
                            TipoDeCarta = TipoDeCartaEnum.Criatura,
                            RaridadeCarta = RaridadeEnum.Rare,
                            PrecoCarta = Convert.ToDecimal(5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 1
                    }
                },
                new List<CopiaDeCartasNoBaralho>
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 10,
                            NomeCarta = "Ghalta, Fome Primordial",
                            CustoDeManaConvertidoCarta = 12,
                            TipoDeCarta = TipoDeCartaEnum.Criatura,
                            RaridadeCarta = RaridadeEnum.Rare,
                            PrecoCarta = Convert.ToDecimal(5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Vermelho }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 1
                    },
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 99
                    }
                }
            };
        }
    }
}