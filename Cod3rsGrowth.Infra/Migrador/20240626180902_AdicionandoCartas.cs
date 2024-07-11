using Cod3rsGrowth.Dominio.Modelos.CartasJson;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using FluentMigrator;
using Microsoft.IdentityModel.Tokens;
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
                var diretorioArquivo = Path.Combine(diretorioRaiz, arquivo);
                var json = File.ReadAllText(diretorioArquivo);
                cartas.AddRange(JsonConvert.DeserializeObject<List<CartaJson>>(json));
            }

            foreach (var carta in cartas)
            {
                var coresDaCarta = ConversorCor(carta?.mana_cost ?? custoDeManaNulo);
                var raridadeCarta = ConversorRaridadeEnum(carta?.Rarity ?? string.Empty);

                Insert.IntoTable("Carta").Row(new
                {
                    Nome = carta.Name,
                    CustoDeManaConvertido = carta?.Cmc ?? valorNulo,
                    TipoDeCarta = carta?.type_line ?? string.Empty,
                    Raridade = raridadeCarta,
                    Preco = Convert.ToDecimal(carta?.Prices?.Usd ?? caractereNulo),
                    Cor = coresDaCarta,
                    Imagem = carta?.Image_uris?.png ?? string.Empty
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
            const string incolor = "Incolor";
            string coresDaCarta = null;

            var coresDoMagic = new Dictionary<char, string>
            {
                { 'U', "Azul" },
                { 'W', "Branco" },
                { 'B', "Preto" },
                { 'G', "Verde" },
                { 'R', "Vermelho" },
            };

            foreach (var cor in coresDoMagic)
            {
                if (mana_cost.Contains(cor.Key))
                {
                    if (coresDaCarta is null)
                    {
                        coresDaCarta = cor.Value;
                    }
                    else
                    {
                        coresDaCarta = coresDaCarta + $", {cor.Value}";
                    }
                }
            }

            if (coresDaCarta is null) return incolor;

            return coresDaCarta;
        }
    }
}