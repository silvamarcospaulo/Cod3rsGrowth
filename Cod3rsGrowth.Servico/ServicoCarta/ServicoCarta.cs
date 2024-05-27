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
        public int GerarIdCarta(int quantidadeDeCartasNoBancoDeDados)
        {
            return quantidadeDeCartasNoBancoDeDados + 1;
        }

        public decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta)
        {
            switch (raridadeDaCarta)
            {
                case RaridadeEnum.Common:
                    return Convert.ToDecimal(0.5);
                case RaridadeEnum.Uncommon:
                    return Convert.ToDecimal(2.5);
                case RaridadeEnum.Rare:
                    return Convert.ToDecimal(5.0);
                case RaridadeEnum.Mythic:
                    return Convert.ToDecimal(7.5);
                default:
                    return Convert.ToDecimal(0);
            }
        }

        public List<CoresEnum> AdicionarCoresDaCarta(string cor)
        {
            List<CoresEnum> cores = new List<CoresEnum>();

            foreach (char c in cor)
            {
                switch (c)
                {
                    case 'W':
                            cores.Add(CoresEnum.Branco);
                        break;
                    case 'B':
                            cores.Add(CoresEnum.Preto);
                        break;
                    case 'G':
                        cores.Add(CoresEnum.Verde);
                        break;
                    case 'R':
                        cores.Add(CoresEnum.Vermelho);
                        break;
                    case 'U':
                        cores.Add(CoresEnum.Azul);
                        break;
                    default:
                        break;
                }
            }
            return cores;
        }
    }
}