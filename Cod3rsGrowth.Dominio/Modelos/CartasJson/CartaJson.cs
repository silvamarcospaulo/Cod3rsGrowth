namespace Cod3rsGrowth.Dominio.Modelos.CartasJson
{
    public class CartaJson
    {
        public string? mana_cost { get; set; }

        public string? Name { get; set; }

        public double? Cmc { get; set; }

        public string? type_line { get; set; }

        public string? Rarity { get; set; }

        public Precos? Prices { get; set; }
    }
}
