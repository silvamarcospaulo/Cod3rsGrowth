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
        public int idBaralho { get; set; }
        public int idJogador { get; set; }
        public string nomeBaralho { get; set; }
        public FormatoDeJogoEnum formatoDeJogoBaralho { get; set; }
        public Hashtable cartasNoBaralho { get; set; }
        public int quantidadeDeCartasNoBaralho { get; set; }
        public decimal custoDoBaralho { get; set; }
        public List<CoresEnum> corBaralho { get; set; }
    }
}