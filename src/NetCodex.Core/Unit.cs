using System.Collections.Generic;
using NetCodex.Core.Abilities;

namespace NetCodex.Core
{
    public abstract class Unit : Card
    {
        public string UnitClass { get; }
        public int BaseAtk { get; }
        public int BaseHp { get; }
        protected IList<IAbility> BaseAbilities { get; }

        protected Unit(string name, int cost, Color color, Faction faction, string unitClass, int baseAtk, int baseHp)
            : base(name, CardType.Unit, cost, color, faction)
        {
            UnitClass = unitClass;
            BaseAtk = baseAtk;
            BaseHp = baseHp;
            BaseAbilities = new List<IAbility>();
        }
    }
}