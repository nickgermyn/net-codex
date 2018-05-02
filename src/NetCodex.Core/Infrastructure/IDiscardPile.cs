using System.Collections.Generic;

namespace NetCodex.Core.Infrastructure
{
    public interface IDiscardPile
    {
        void Clear();
        void Add(Card card);
        void Add(IEnumerable<Card> cards);
        IEnumerable<Card> Cards { get; }
    }
}