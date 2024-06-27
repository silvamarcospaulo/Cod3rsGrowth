using LinqToDB.Mapping;
using System.Diagnostics;

namespace Cod3rsGrowth.Dominio.Modelos.CartasJson
{
    public class CartaJson
    {
        [PrimaryKey, Identity]
        public string Id { get; set; }

        [Column("OracleId")]
        public string? OracleId { get; set; }

        [Column("MtgoId")]
        public int? MtgoId { get; set; }

        [Column("MtgoFoilId")]
        public int? MtgoFoilId { get; set; }

        [Column("TcgplayerId")]
        public int? TcgplayerId { get; set; }

        [Column("CardmarketId")]
        public int? CardmarketId { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Lang")]
        public string? Lang { get; set; }

        [Column("ReleasedAt")]
        public string? ReleasedAt { get; set; }

        [Column("Uri")]
        public string? Uri { get; set; }

        [Column("ScryfallUri")]
        public string? ScryfallUri { get; set; }

        [Column("Layout")]
        public string? Layout { get; set; }

        [Column("HighresImage")]
        public bool? HighresImage { get; set; }

        [Column("ImageStatus")]
        public string? ImageStatus { get; set; }

        [Column("Png")]
        public string? Png { get; set; }

        [Column("ManaCost")]
        public int? ManaCost { get; set; }

        [Column("Cmc")]
        public double? Cmc { get; set; }

        [Column("TypeLine")]
        public string? TypeLine { get; set; }

        [Column("OracleText")]
        public string? OracleText { get; set; }

        [Column("Power")]
        public string? Power { get; set; }

        [Column("Toughness")]
        public string? Toughness { get; set; }

        [Column("Usd")]
        public string? Usd { get; set; }

        [Column("Rarity")]
        public string? Rarity { get; set; }

        public Precos? Prices { get; set; }
    }
}
