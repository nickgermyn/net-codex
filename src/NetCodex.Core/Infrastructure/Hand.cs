using System.Collections.Generic;

namespace NetCodex.Core.Infrastructure
{
    public class Hand : List<Card>
    {
        public int Discard(IDiscardPile discard)
        {
            var count = this.Count;
            discard.Add(this);
            this.Clear();
            return count;
        }
    }
}