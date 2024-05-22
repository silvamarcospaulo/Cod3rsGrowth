using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository;
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
        public ServicoCarta()
        {
        }

        public int GerarIdCarta(int quantidadeDeCartasNoBancoDeDados)
        {
            return quantidadeDeCartasNoBancoDeDados + 1;
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

        public List<CoresEnum> AdicionarCoresDaCarta(string cor)
        {
            List<CoresEnum> cores = new List<CoresEnum>();
            if (cor.Contains("W")) cores.Add(CoresEnum.Branco);
            if (cor.Contains("R")) cores.Add(CoresEnum.Vermelho);
            if (cor.Contains("G")) cores.Add(CoresEnum.Verde);
            if (cor.Contains("B")) cores.Add(CoresEnum.Preto);
            if (cor.Contains("U")) cores.Add(CoresEnum.Azul);

            return cores;
        }
    }
}