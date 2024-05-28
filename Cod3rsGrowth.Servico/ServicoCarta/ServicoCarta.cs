using System;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ServicoCarta : IServicoCarta
    {
        public const decimal precoCartaCommon = 0.5m;
        public const decimal precoCartaUncommon = 2.5m;
        public const decimal precoCartaRare = 5m;
        public const decimal precoCartaMythic = 7.5m;

        public int GerarIdCarta(int quantidadeDeCartasNoBancoDeDados)
        {
            return quantidadeDeCartasNoBancoDeDados + 1;
        }

        public decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta)
        {
            decimal valorCarta = 0;

            switch (raridadeDaCarta)
            {
                case RaridadeEnum.Common:
                    valorCarta = precoCartaCommon;
                    break;
                case RaridadeEnum.Uncommon:
                    valorCarta = precoCartaUncommon;
                    break;
                case RaridadeEnum.Rare:
                    valorCarta = precoCartaRare;
                    break;
                case RaridadeEnum.Mythic:
                    valorCarta = precoCartaMythic;
                    break;
            }
            return valorCarta;
        }

        public List<CoresEnum> AdicionarCoresDaCarta(string cor)
        {
            List<CoresEnum> cores = new();

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
            return cores.Distinct().ToList();
        }
    }
}