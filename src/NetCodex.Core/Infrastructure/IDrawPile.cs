namespace NetCodex.Core.Infrastructure
{
    public interface IDrawPile
    {
        bool IsEmpty { get; }
        int Count { get; }
        Card Draw();
        void Recycle(IDiscardPile discardPile);
    }
}