using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerExtensions
{
    public sealed class TaxCode
    {
        internal TaxCode(Guid key, Country country, string code, decimal rate, string description = null, bool taxInvoice = false)
        {
            Key = key;
            Country = country;
            Code = code;
            Rate = rate;
            Description = description;
            TaxInvoice = taxInvoice;
        }

        public Guid Key;
        public Country Country;
        public string Code;
        public decimal Rate;
        public string Description;
        public bool TaxInvoice;
    }
}
