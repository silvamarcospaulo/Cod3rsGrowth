using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Filtros
{
    public class CartaFiltro
    {
        public string? NomeCarta { get; set; }
        public int? CustoDeManaConvertidoCarta { get; set; }
        public List<string>? TipoDeCarta { get; set; }
        public List<RaridadeEnum>? RaridadeCarta { get; set; }
        public decimal? PrecoCartaMinimo { get; set; }
        public decimal? PrecoCartaMaximo { get; set; }
        public List<string>? CorCarta { get; set; }
    }
}