using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Carta
    {
        public int IdCarta { get; set; }
        public string NomeCarta { get; set; }
        public int CustoDeManaConvertidoCarta { get; set; }
        public TipoDeCartaEnum TipoDeCarta {  get; set; }
        public RaridadeEnum RaridadeCarta { get; set; }
        public decimal PrecoCarta { get; set; }
        public List<CoresEnum> CorCarta { get; set; }
    }
}