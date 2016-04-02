using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerExtensions
{
    public sealed class TaxTransaction
    {
        public Guid TaxCode;
        public decimal TaxAmount;
        public decimal NetAmount;

        public bool IsPurchase;
        public bool IsCapitalPurchase;
    }
}
