using NetCodex.Core;
using NetCodex.Core.Abilities;

namespace NetCodex.Cards.Neutral
{
    public class TimelyMesssenger : Unit
    {
        public TimelyMesssenger() : 
            base(nameof(TimelyMesssenger), 1, Core.Color.Neutral, Faction.None, UnitClasses.Mercenary, 1, 1)
        {
            BaseAbilities.Add(new HasteAbility());
        }
    }
}