using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Carta
    {
        public int IdCarta { get; set; }
        public string NomeCarta { get; set; }
        public double CustoDeManaConvertidoCarta { get; set; }
        public TipoDeCartaEnum TipoDeCarta {  get; set; }
        public RaridadeEnum RaridadeCarta { get; set; }
        public decimal PrecoCarta { get; set; }
        public List<CoresEnum> CorCarta { get; set; }
    }
}