using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using FluentMigrator;
using FluentMigrator.SqlServer;
using Newtonsoft.Json;
using System.Runtime.ConstrainedExecution;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240626180902)]
    public class _20240626180902_AdicionandoCartas : Migration
    {
        public override void Up()
        {
            const int valorNulo = 0;
            const string caractereNulo = "0";
            const string diretorioCartasJson = "..\\cartas20240624211029.json";
            string json = File.ReadAllText(diretorioCartasJson);
            List<CartaJson> cartas = JsonConvert.DeserializeObject<List<CartaJson>>(json);

            foreach (var card in cartas)
            {
                Insert.IntoTable("Carta").Row(new
                {
                    Nome = card.Name,
                    CustoDeManaConvertido = card?.Cmc ?? valorNulo,
                    TipoDeCarta = card?.TypeLine ?? string.Empty,
                    Raridade = card?.Rarity ?? string.Empty,
                    Preco = Convert.ToDecimal(card?.Prices?.Usd ?? caractereNulo)
                });
            };
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}