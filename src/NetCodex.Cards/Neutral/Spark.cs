using NetCodex.Core;
using NetCodex.Core.Effects;

namespace NetCodex.Cards.Neutral
{
    public class Spark : Spell
    {
        public Spark() : 
            base(nameof(Spark), 1, Color.Neutral, Faction.None, SpellType.Minor, SpellClasses.Burn)
        {
            // Effect - deal 1 damage to a patroller
            Effects.Add(new DealDamageToTargetEffect(1, new PatrollerOnlyFilter()));
        }

        public override bool IsTargetted => true;
    }
}