using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Carta
    {
        public int idCarta { get; set; }
        public string nomeCarta { get; set; }
        public double custoDeManaConvertidoCarta { get; set; }
        public RaridadeEnum raridadeCarta { get; set; }
        public decimal precoCarta { get; set; }
        public List<CoresEnum> corCarta { get; set; }
    }
}