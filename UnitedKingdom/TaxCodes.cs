using System;

namespace ManagerExtensions.UnitedKingdom
{
    public static class TaxCodes
    {
        public static readonly TaxCode VAT_20 = new TaxCode(new Guid("b926c2d8-09e4-496c-9a2c-818c8aaa36ed"), Country.UnitedKingdom, "VAT 20%", 20m);
        public static readonly TaxCode VAT_05 = new TaxCode(new Guid("56769971-405e-47bd-bd13-d64de0eae752"), Country.UnitedKingdom, "VAT 5%", 5m);
        public static readonly TaxCode VAT_00 = new TaxCode(new Guid("6959fb01-3a48-486a-9bec-a0681a662f03"), Country.UnitedKingdom, "VAT 0%", 0m);
        public static readonly TaxCode VAT_Exempt = new TaxCode(new Guid("42a5002c-5c8f-4def-8672-4e6f3fc09654"), Country.UnitedKingdom, "VAT Exempt", 0m);
        public static readonly TaxCode VAT_05_ON_IMPORTS = new TaxCode(new Guid("4ca35740-f9b7-4dc6-bc88-08bdc8715994"), Country.UnitedKingdom, "VAT 5% on Imports", decimal.MaxValue);
        public static readonly TaxCode VAT_20_ON_IMPORTS = new TaxCode(new Guid("11e650b0-ec87-4e45-9049-10a83ea4bed6"), Country.UnitedKingdom, "VAT 20% on Imports", decimal.MaxValue);
    }
}
