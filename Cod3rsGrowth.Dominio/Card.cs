using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Dominio
{
    public class Card
    {
        public int cardId {  get; }
        public string cardName { get; }
        public string cardColor { get; }
        public string cardSet { get; }
        public string cardRarity { get; }
        public decimal cardCost { get; set; }
        private List<PlayFormats> cardPlayFormat = new List<PlayFormats>();

        public Card(int cardId, string cardName, string cardColor, string cardSet,
            string cardRarity, decimal cardCost, List<PlayFormats> playFormats)
        {
            this.cardId = cardId;
            this.cardName = cardName;
            this.cardColor = cardColor;
            this.cardSet = cardSet;
            this.cardRarity = cardRarity;
            this.cardCost = cardCost;
            this.cardPlayFormat = playFormats;
        }

    }
}
