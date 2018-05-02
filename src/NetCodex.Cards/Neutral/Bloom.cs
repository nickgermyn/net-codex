using NetCodex.Core;

namespace NetCodex.Cards.Neutral
{
    public class Bloom : Spell
    {
        public Bloom() :
            base(nameof(Bloom), 2, Color.Neutral, Faction.None, SpellType.Minor, SpellClasses.Buff)
        {
            // Effect - put a +1/+1 rune on a friendly unit or hero that doesn't have a +1/+1 rune
        }

        public override bool IsTargetted => true;
    }
}