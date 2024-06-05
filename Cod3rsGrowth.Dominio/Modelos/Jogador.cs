using System;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Jogador
    {
        public string IdJogador { get; set; }
        public string? NomeJogador { get; set; }
        public DateTime DataNascimentoJodador { get; set; }
        public decimal CustoDasCartasJogador { get; set; }
        public int QuantidadeDeBaralhosJogador { get; set; }
        public bool ContaAtivaJogador { get; set; }
        public List<Baralho>? BaralhosJogador { get; set; }
    }
}