using System;
using System.Collections.Generic;
using System.Text;
using NetCodex.Core.Infrastructure;

namespace NetCodex.Core
{
    public class Player
    {
        public PlayerProfile Profile { get; }
        public Codex Codex { get; }
        public IDrawPile DrawPile { get; }
        public IDiscardPile DiscardPile { get; }
        public Hand Hand { get; }

        public Player(PlayerProfile profile, Codex codex)
        {
            Profile = profile;
            Codex = codex;
            DrawPile = new Pile(codex.GetStarter());
            DiscardPile = new Pile();
            Hand = new Hand();
        }

        public void Draw(int cardCount)
        {
            var drawCounter = 0;
            while (drawCounter < cardCount)
            {
                DrawTop();
                drawCounter++;
            }
        }

        public void DrawTop()
        {
            if (DrawPile.IsEmpty)
            {
                // Recycle the discard pile
                DrawPile.Recycle(DiscardPile);
            }
            var card = DrawPile.Draw();
            Hand.Add(card);
        }

        public void DiscardHandAndDraw()
        {
            var discardCount = Hand.Discard(DiscardPile);
            var drawCount = Math.Min(7, discardCount + 2);
            Draw(drawCount);
        }
    }

    public class PlayerProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
