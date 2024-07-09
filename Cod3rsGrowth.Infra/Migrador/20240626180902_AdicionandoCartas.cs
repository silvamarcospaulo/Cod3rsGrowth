using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using Cod3rsGrowth.Dominio.Modelos.Enums;
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

            string diretorioRaiz = Path.Combine(diretorioLocal, @"..\..\..\..\Cod3rsGrowth.Infra\Migrador\ApiScryfall");

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
                    Raridade = ConversorRaridadeEnum(card?.Rarity ?? string.Empty),
                    Preco = Convert.ToDecimal(card?.Prices?.Usd ?? caractereNulo),
                    Cor = card?.mana_cost ?? custoDeManaNulo,
                    Imagem = card?.Image_uris?.png ?? string.Empty
                });
            }
        }

        public override void Down()
        {
            Delete.FromTable("Carta");
        }

        private int ConversorRaridadeEnum(string raridade)
        {
            const int valorInvalido = 4;
            switch (raridade)
            {
                case "common": return Convert.ToInt32(RaridadeEnum.Common);
                case "uncommon": return Convert.ToInt32(RaridadeEnum.Uncommon);
                case "rare": return Convert.ToInt32(RaridadeEnum.Rare);
                case "mythic": return Convert.ToInt32(RaridadeEnum.Mythic);
                default: return valorInvalido;
            };
        }

        private string ConversorCor(string mana_cost)
        {
            var cores = new List<string>();
            var coresDoMagic = new Dictionary<char, string>
            {
                { 'U', "Azul" },
                { 'W', "Branco" },
                { 'B', "Preto" },
                { 'G', "Verde" },
                { 'R', "Vermelho" },
            };
            string incolor = "Incolor";

            foreach (var cor in coresDoMagic)
            {
                if (mana_cost.Contains(cor.Key)) cores.Add(cor.Value);
            }

            return corDaCarta.Count > 0 ? string.Join(", ", colors) : "Incolor";
        }
    }
}