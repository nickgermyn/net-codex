using System;

namespace NetCodex.Core
{
    public abstract class Card
    {
        protected Card(string name, CardType cardType, int cost, Color color, Faction faction)
        {
            this.Name = name;
            this.CardType = cardType;
            this.Cost = cost;
            Color = color;
            Faction = faction;
        }
        public string Name { get; }
        public CardType CardType { get; }
        public int Cost { get; }
        public Color Color { get; }
        public Faction Faction { get; }
    }

    //public class CardState
    //{
    //    public Card Card { get; set; }
    //    public List<IRune> Runes { get; set; }
    //}
}
