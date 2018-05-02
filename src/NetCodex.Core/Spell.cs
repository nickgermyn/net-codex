using System.Collections.Generic;
using NetCodex.Core.Effects;

namespace NetCodex.Core
{
    public abstract class Spell : Card
    {
        public SpellType SpellType { get; }
        public string SpellClass { get; }
        protected IList<IEffect> Effects { get; }

        protected Spell(string name, int cost, Color color, Faction faction, SpellType spellType, string spellClass = null) : 
            base(name, CardType.Magic, cost, color, faction)
        {
            SpellType = spellType;
            SpellClass = spellClass;
            Effects = new List<IEffect>();
        }

        public virtual bool IsTargetted => false;
    }
}