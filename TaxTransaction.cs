using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerExtensions
{
    public sealed class TaxTransaction
    {
        public TaxCode TaxCode;

        public decimal NetPurchases { get; set; }
        public decimal TaxPaid { get; set; }
        public decimal NetSales { get; set; }
        public decimal TaxCollected { get; set; }

        public decimal Amount { get { return NetPurchases + (NetSales * -1); } }
        public decimal TaxAmount { get { return TaxPaid + (TaxCollected * -1); } }
        public decimal TotalAmount { get { return Amount + TaxAmount; } }

        public bool IsCapitalAccount;
    }
}
