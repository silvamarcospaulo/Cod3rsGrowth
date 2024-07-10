using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Filtros
{
    public class CartaFiltro
    {
        public string? NomeCarta { get; set; }
        public int? CustoDeManaConvertidoCarta { get; set; }
        public string? TipoDeCarta { get; set; }
        public RaridadeEnum? RaridadeCarta { get; set; }
        public decimal? PrecoCartaMinimo { get; set; }
        public decimal? PrecoCartaMaximo { get; set; }
        public string? CorCarta { get; set; }
    }
}