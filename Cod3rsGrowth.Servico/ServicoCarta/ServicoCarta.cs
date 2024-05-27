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
            switch (raridadeDaCarta)
            {
                case RaridadeEnum.Common:
                    return PRECO_CARTA_COMMON;
                case RaridadeEnum.Uncommon:
                    return PRECO_CARTA_UNCOMMON;
                case RaridadeEnum.Rare:
                    return PRECO_CARTA_RARE;
                case RaridadeEnum.Mythic:
                    return PRECO_CARTA_MYTHIC;
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
            return cores.Distinct().ToList();
        }
    }
}