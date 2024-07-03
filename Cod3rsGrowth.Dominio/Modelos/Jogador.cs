﻿using System;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Modelos
{
    [Table("Jogador")]
    public class Jogador
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        [Column("Nome")]
        public string NomeJogador { get; set; }
        [Column("Sobrenome")]
        public string SobrenomeJogador { get; set; }
        [Column("Cpf")]
        public string CpfJogador { get; set; }
        [Column("Usuario")]
        public string UsuarioJogador { get; set; }
        [Column("SenhaHash")]
        public string SenhaHashJogador { get; set; }
        [Column("Token")]
        public string TokenJogador { get; set; }
        [Column("Role")]
        public string Role { get; set; }
        [Column("DataDeCriacaoConta")]
        public DateTime DataDeCriacaoContaJogador { get; set; }
        [Column("DataDeNascimento")]
        public DateTime DataNascimentoJogador { get; set; }
        [Column("PrecoDasCartas")]
        public decimal PrecoDasCartasJogador { get; set; }
        [Column("QuantidadeDeBaralhos")]
        public int QuantidadeDeBaralhosJogador { get; set; }
        [Column("ContaAtiva")]
        public bool ContaAtivaJogador { get; set; }
        public List<Baralho>? BaralhosJogador { get; set; }
    }
}