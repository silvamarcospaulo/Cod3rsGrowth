using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servico.ServicoCarta
{
    public class ServicoCarta : IServicoCarta
    {
        public static readonly decimal PRECO_CARTA_COMMON = Convert.ToDecimal(0.5);
        public static readonly decimal PRECO_CARTA_UNCOMMON = Convert.ToDecimal(2.5);
        public static readonly decimal PRECO_CARTA_RARE = Convert.ToDecimal(5);
        public static readonly decimal PRECO_CARTA_MYTHIC = Convert.ToDecimal(7.5);

        public int GerarIdCarta(int quantidadeDeCartasNoBancoDeDados)
        {
            return quantidadeDeCartasNoBancoDeDados + 1;
        }

        public decimal GerarPrecoCarta(RaridadeEnum raridadeDaCarta)
        {
            decimal valorCarta;

            switch (raridadeDaCarta)
            {
                case RaridadeEnum.Common:
                    valorCarta = PRECO_CARTA_COMMON;
                    break;
                case RaridadeEnum.Uncommon:
                    valorCarta = PRECO_CARTA_UNCOMMON;
                    break;
                case RaridadeEnum.Rare:
                    valorCarta = PRECO_CARTA_RARE;
                    break;
                case RaridadeEnum.Mythic:
                    valorCarta = PRECO_CARTA_MYTHIC;
                    break;
            }
            return valorCarta;
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
            return cores.Distinct().ToList();
        }
    }
}