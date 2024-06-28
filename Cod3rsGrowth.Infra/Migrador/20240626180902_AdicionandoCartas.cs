using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using FluentMigrator;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240626180902)]
    public class _20240626180902_AdicionandoCartas : Migration
    {
        public override void Up()
        {
            const int valorNulo = 0;
            const string caractereNulo = "0";
            const string custoDeManaNulo = "{0}";

            const string diretorioCartas202406242110291 = "C:\\Users\\Usuario\\Desktop\\Projetos\\Cod3rsGrowth\\Cod3rsGrowth.Infra\\Migrador\\Api Scryfall\\cartas202406242110291.json";
            string json202406242110291 = File.ReadAllText(diretorioCartas202406242110291);
            const string diretorioCartas202406242110292 = "C:\\Users\\Usuario\\Desktop\\Projetos\\Cod3rsGrowth\\Cod3rsGrowth.Infra\\Migrador\\Api Scryfall\\cartas202406242110292.json";
            string json202406242110292 = File.ReadAllText(diretorioCartas202406242110292);
            const string diretorioCartas202406242110293 = "C:\\Users\\Usuario\\Desktop\\Projetos\\Cod3rsGrowth\\Cod3rsGrowth.Infra\\Migrador\\Api Scryfall\\cartas202406242110293.json";
            string json202406242110293 = File.ReadAllText(diretorioCartas202406242110293);
            const string diretorioCartas202406242110294 = "C:\\Users\\Usuario\\Desktop\\Projetos\\Cod3rsGrowth\\Cod3rsGrowth.Infra\\Migrador\\Api Scryfall\\cartas202406242110294.json";
            string json202406242110294 = File.ReadAllText(diretorioCartas202406242110294);
            const string diretorioCartas202406242110295 = "C:\\Users\\Usuario\\Desktop\\Projetos\\Cod3rsGrowth\\Cod3rsGrowth.Infra\\Migrador\\Api Scryfall\\cartas202406242110295.json";
            string json202406242110295 = File.ReadAllText(diretorioCartas202406242110295);
            const string diretorioCartas202406242110296 = "C:\\Users\\Usuario\\Desktop\\Projetos\\Cod3rsGrowth\\Cod3rsGrowth.Infra\\Migrador\\Api Scryfall\\cartas202406242110296.json";
            string json202406242110296 = File.ReadAllText(diretorioCartas202406242110296);

            var cartas = new List<CartaJson>();

            cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json202406242110291));
            cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json202406242110292));
            cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json202406242110293));
            cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json202406242110294));
            cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json202406242110295));
            cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json202406242110296));

            foreach (var card in cartas)
            {
                Insert.IntoTable("Carta").Row(new
                {
                    Nome = card.Name,
                    CustoDeManaConvertido = card?.Cmc ?? valorNulo,
                    TipoDeCarta = card?.type_line ?? string.Empty,
                    Raridade = card?.Rarity ?? string.Empty,
                    Preco = Convert.ToDecimal(card?.Prices?.Usd ?? caractereNulo),
                    Cor = card.mana_cost ?? custoDeManaNulo
                });
            };
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}