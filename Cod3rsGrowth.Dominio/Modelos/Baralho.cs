﻿using System;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("Baralho")]
    public class Baralho
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column("IdJogador")]
        public int IdJogador { get; set; }

        [Column("Nome")]
        public string NomeBaralho { get; set; }

        [Column("DataDeCriacao")]
        public DateTime DataDeCriacaoBaralho { get; set; }

        [Column("FormatoDeJogo")]
        public FormatoDeJogoEnum FormatoDeJogoBaralho { get; set; }

        [Column("QuantidadeDeCartas")]
        public int QuantidadeDeCartasNoBaralho { get; set; }

        [Column("Preco")]
        public decimal PrecoDoBaralho { get; set; }

        [Column("CustoDeManaConvertido")]
        public int CustoDeManaConvertidoDoBaralho { get; set; }

        [Column("Cor")]
        public string? CorBaralho { get; set; }

        public List<CopiaDeCartasNoBaralho> CartasDoBaralho { get; set; }
    }
}