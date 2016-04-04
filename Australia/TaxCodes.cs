using System;

namespace ManagerExtensions.Australia
{
    public static class TaxCodes
    {
        public static readonly TaxCode GST_10 = new TaxCode(new Guid("8cf9d117-3142-4d9c-82ee-b57a0e22c809"), Country.Australia, "GST 10%", 10m, taxInvoice: true);
        public static readonly TaxCode GST_FREE = new TaxCode(new Guid("14f63584-be71-40ca-9028-1a60e2e2cc90"), Country.Australia, "GST Free", 0.00m);
        public static readonly TaxCode GST_FREE_EXPORT = new TaxCode(new Guid("10d8f9dc-db1e-4c87-9480-a696f59aeddf"), Country.Australia, "GST Free Exports", 0.00m);
        public static readonly TaxCode INPUT_TAXED = new TaxCode(new Guid("f218a321-f83d-4d06-8d02-b52f595cc4fe"), Country.Australia, "Input Taxed", 0.00m);
        public static readonly TaxCode Deferred_GST_10 = new TaxCode(new Guid("73952f89-6139-4fd0-a937-165b8ed66ba8"), Country.Australia, "GST 10% (Deferred)", 10m);
        public static readonly TaxCode GST_10_ON_IMPORTS = new TaxCode(new Guid("9fe15ead-2138-4f4b-b3f5-398857d08503"), Country.Australia, "GST on Imports", decimal.MaxValue);
    }
}
