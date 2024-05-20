﻿using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ServicoCarta : IServicoCarta
    {
        public Carta NovaCarta(int idCarta, string nomeCarta, double custoDeManaConvetido, RaridadeEnum raridadeCarta, List<CoresEnum> corCarta)
        {
            return new Carta();
        }

        public decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta)
        {
            if(raridadeDaCarta == RaridadeEnum.Common)
            {
                return Convert.ToDecimal(0.5);
            }
            else if(raridadeDaCarta == RaridadeEnum.Uncommon)
            {
                return Convert.ToDecimal(2.5);
            }
            else if (raridadeDaCarta == RaridadeEnum.Rare)
            {
                return Convert.ToDecimal(5.0);
            }

            return Convert.ToDecimal(7.5);
        }

        public int GerarIdCarta(List<Carta> quantidadeDeCartasNoBancoDeDados)
        {
            return quantidadeDeCartasNoBancoDeDados.Count + 1;
        }
    }
}