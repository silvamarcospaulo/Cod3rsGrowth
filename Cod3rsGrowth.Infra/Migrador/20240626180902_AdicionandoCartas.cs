using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using FluentMigrator;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Cod3rsGrowth.Dominio.Migrador
{
    [Migration(20240626180902)]
    public class _20240626180902_AdicionandoCartas : Migration
    {
        private const int valorNulo = 0;
        private const string caractereNulo = "0";
        private const string custoDeManaNulo = "{0}";

        public override void Up()
        {
            var diretorioLocal = AppDomain.CurrentDomain.BaseDirectory;

            string diretorioRaiz = Path.Combine(diretorioLocal, @"..\..\..\..\Cod3rsGrowth.Infra\Migrador\Api Scryfall");

            var arquivosJson = new List<string>
            {
                "cartas202406242110291.json",
                "cartas202406242110292.json",
                "cartas202406242110293.json",
                "cartas202406242110294.json",
                "cartas202406242110295.json",
                "cartas202406242110296.json"
            };

            var cartas = new List<CartaJson>();

            foreach (var arquivo in arquivosJson)
            {
                string caminhoArquivo = Path.Combine(diretorioRaiz, arquivo);
                string json = File.ReadAllText(caminhoArquivo);
                cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json));
            }

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
            }
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}