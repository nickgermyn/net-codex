using NetCodex.Core;

namespace NetCodex.Cards.Neutral
{
    public class Wither : Spell
    {
        public Wither() :
            base(nameof(Wither), 2, Color.Neutral, Faction.None, SpellType.Minor, SpellClasses.Debuff)
        {
            // Effect - put a -1/-1 rune on a unit or hero
        }

        public override bool IsTargetted => true;
    }
}