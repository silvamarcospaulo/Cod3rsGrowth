using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Carta
    {
        public int idCarta { get; }
        public string nomeCarta { get; }
        public double custoDeManaConvertidoCarta { get; }
        public string raridadeCarta { get; }
        public decimal precoCarta { get; }
        public List<CoresEnum> corCarta { get; }
    }
}