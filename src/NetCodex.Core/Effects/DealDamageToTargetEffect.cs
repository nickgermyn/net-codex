namespace NetCodex.Core.Effects
{
    public class DealDamageToTargetEffect : IEffect
    {
        public ITargetFilter Filter { get; }

        public DealDamageToTargetEffect(int amount)
        {

        }

        public DealDamageToTargetEffect(int amount, ITargetFilter filter)
            : this(amount)
        {
            Filter = filter;
        }
    }
}