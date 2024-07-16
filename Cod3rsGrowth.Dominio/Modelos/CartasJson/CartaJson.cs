namespace Cod3rsGrowth.Dominio.Modelos.CartasJson
{
    public class CartaJson
    {
        public string Id { get; set; }

        public string? OracleId { get; set; }

        public int? MtgoId { get; set; }

        public int? MtgoFoilId { get; set; }

        public int? TcgplayerId { get; set; }

        public string? mana_cost { get; set; }

        public int? CardmarketId { get; set; }

        public string? Name { get; set; }

        public string? Lang { get; set; }

        public string? ReleasedAt { get; set; }

        public string? Uri { get; set; }

        public string? ScryfallUri { get; set; }

        public string? Layout { get; set; }

        public bool? HighresImage { get; set; }


        public string? ImageStatus { get; set; }

        public double? Cmc { get; set; }

        public string? type_line { get; set; }

        public string? OracleText { get; set; }

        public string? Power { get; set; }

        public string? Toughness { get; set; }

        public string? Usd { get; set; }

        public string? Rarity { get; set; }
        public Image_uris Image_uris { get; set; }

        public Precos? Prices { get; set; }
    }
}
