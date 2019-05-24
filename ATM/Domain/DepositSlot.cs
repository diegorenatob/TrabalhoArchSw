using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class DepositSlot: IDepositSlot
    {
        public bool IsEnvelopeReceived { get { return true; } }
    }
}
