using Cod3rsGrowth.Dominio.Modelos.Enums;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("Carta")]
    public class Carta
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        [Column("Nome")]
        public string NomeCarta { get; set; }
        [Column("CustoDeManaConvertido")]
        public int CustoDeManaConvertidoCarta { get; set; }
        [Column("TipoDeCarta")]
        public string TipoDeCarta {  get; set; }
        [Column("Raridade")]
        public RaridadeEnum RaridadeCarta { get; set; }
        [Column("Preco")]
        public decimal PrecoCarta { get; set; }
        [Column("Cor")]
        public string CorCarta { get; set; }
        [Column("Imagem")]
        public string? Imagem { get; set; }
    }
}