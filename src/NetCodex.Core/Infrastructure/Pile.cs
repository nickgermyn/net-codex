using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCodex.Core.Infrastructure
{
    public class Pile : IDrawPile, IDiscardPile
    {
        private readonly Queue<Card> _cards;

        public Pile()
        {
            _cards = new Queue<Card>();
        }
        public Pile(IEnumerable<Card> initialCards)
        {
            _cards = new Queue<Card>(initialCards);
        }

        public bool IsEmpty => _cards.Count == 0;
        public int Count => _cards.Count;
        public Card Draw()
        {
            return _cards.Dequeue();
        }

        public void Recycle(IDiscardPile discardPile)
        {
            if (!IsEmpty)
            {
                throw new InvalidOperationException("Cannot recycle pile if not empty");
            }
            Add(discardPile.Cards.Shuffle());
            discardPile.Clear();
        }

        public void Clear()
        {
            _cards.Clear();
        }

        public void Add(Card card)
        {
            _cards.Enqueue(card);
        }

        public void Add(IEnumerable<Card> cards)
        {
            foreach (var card in cards)
            {
                this.Add(card);
            }
        }

        public IEnumerable<Card> Cards => _cards.AsEnumerable();
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.Shuffle(new Random());
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (rng == null) throw new ArgumentNullException(nameof(rng));

            return source.ShuffleIterator(rng);
        }

        /// <summary>
        /// Shuffles the source using Fisher-Yates shuffle.
        /// <see cref="https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle#The_modern_algorithm"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="rng">The RNG.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        private static IEnumerable<T> ShuffleIterator<T>(
            this IEnumerable<T> source, Random rng)
        {
            var buffer = source.ToList();
            for (int i = 0; i < buffer.Count; i++)
            {
                int j = rng.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}