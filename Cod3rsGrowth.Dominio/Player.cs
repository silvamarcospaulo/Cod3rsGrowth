namespace Cod3rsGrowth.Dominio
{
    public class Player
    {
        public int playerId {  get; set; }
        public DateTime playerBithday { get; set; }
        public string playerName { get; set; }
        public decimal allCardsCost { get; set; }
        public int deckCost { get; set; }
        public bool activeAccount { get; set; }
        public List<Deck> playerDecks = new List<Deck>();


    }
}