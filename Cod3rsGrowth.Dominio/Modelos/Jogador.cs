using Cod3rsGrowth.Dominio.Servicos;
using System.Collections;

namespace Cod3rsGrowth.Dominio.Modelos
{
    public class Jogador
    {
        public int IdJogador { get; set; }
        public string NomeJogador { get; set; }
        public DateTime DataNascimentoJodador { get; set; }
        public decimal CustoDasCartasJogador { get; set; }
        public int QuantidadeDeBaralhosJogador { get; set; }
        public bool ContaAtivaJogador { get; set; }
        public List<Baralho> BaralhosJogador { get; set; }
    }
}