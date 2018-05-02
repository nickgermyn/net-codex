using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCodex.Core.Infrastructure
{
    public class Codex
    {
        private readonly List<Card> _cards = new List<Card>();
        private readonly List<Card> _starterDeck = new List<Card>();

        public Codex()
        {
            
        }

        public IEnumerable<Card> Cards => _cards;

        public Card Take(string name)
        {
            var card = _cards.FirstOrDefault(c => c.Name == name);
            if (card == null)
            {
                throw new CardNotFoundInCodexException(name);
            }

            _cards.Remove(card);
            return card;
        }

        public IEnumerable<Card> GetStarter()
        {
            return _starterDeck;
        }
    }
}
