using Interfaces;

namespace Domain
{
    public class DepositSlot: IDepositSlot
    {
        public bool IsEnvelopeReceived { get { return true; } }
    }
}
