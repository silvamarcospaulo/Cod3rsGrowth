using System.Collections;

namespace Cod3rsGrowth.Dominio
{
    public class Jogador
    {
        public int idJogador { get; set; }
        public string nomeJogador { get; set; }
        public DateTime dataNascimentoJodador { get; set; }
        public decimal custoDasCartasJogador { get; set; }
        public int quantidadeDeBaralhosJogador { get; set; }
        public bool contaAtivaJogador { get; set; }
        public List<Baralho> baralhosJogador { get; set; }
    }
}