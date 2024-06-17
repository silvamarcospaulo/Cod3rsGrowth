using System;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Jogador
    {
        public int IdJogador { get; set; }
        public string NomeJogador { get; set; }
        public DateTime DataNascimentoJogador { get; set; }
        public decimal PrecoDasCartasJogador { get; set; }
        public int QuantidadeDeBaralhosJogador { get; set; }
        public bool ContaAtivaJogador { get; set; }
        public List<Baralho>? BaralhosJogador { get; set; }
    }
}