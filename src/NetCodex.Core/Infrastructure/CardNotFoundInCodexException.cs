using System;

namespace NetCodex.Core.Infrastructure
{
    public class CardNotFoundInCodexException : Exception
    {
        public CardNotFoundInCodexException(string cardName)
            : base($"Card {cardName} not found in the codex")
        {
            
        }
    }
}