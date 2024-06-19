using Cod3rsGrowth.Dominio.Modelos.Enums;
using System;
    using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio.Filtros
{
    public class CartaFiltro
    {
        public string? NomeCarta { get; set; }
        public int? CustoDeManaConvertidoCarta { get; set; }
        public TipoDeCartaEnum? TipoDeCarta { get; set; }
        public RaridadeEnum? RaridadeCarta { get; set; }
        public decimal? PrecoCartaMinimo { get; set; }
        public decimal? PrecoCartaMaximo { get; set; }
        public CoresEnum? CorCarta { get; set; }
    }
}