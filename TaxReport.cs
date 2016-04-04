using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerExtensions
{
    public abstract class TaxReport : HtmlDocument
    {
        public abstract Guid UUID { get; }
        public abstract string Name { get; }
        public abstract TaxCode[] SupportedTaxCodes { get; }
        public abstract void GenerateFromTaxSummary(string businessName, DateTime from, DateTime to, bool isCashBasis, TaxTransaction[] taxTransactions);
    }
}
