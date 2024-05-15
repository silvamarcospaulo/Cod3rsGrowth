using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio
{
    public class Baralho
    {
        public int idBaralho { get; }
        public int idJogador { get; }
        public string nomeBaralho { get; }
        public FormatoDeJogoEnum formatoDeJogoBaralho { get; set; }
        public Hashtable cartasNoBaralho;
        public int quantidadeDeCartasNoBaralho { get; }
        public decimal custoDoBaralho { get; }
        

    }
}
