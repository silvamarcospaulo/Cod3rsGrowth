using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio
{
    public class Deck
    {
        public int deckId { get; }
        public int playerId { get; }
        public string deckName { get; }
        public PlayFormats deckPlayFormat { get; set; }
        public int deckCardQuantity { get; }
        public decimal deckCost { get; }
        public List<Card> deckCards = new List<Card>();
    }
}
