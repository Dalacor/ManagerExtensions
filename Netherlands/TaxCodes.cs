using System;

namespace ManagerExtensions.Netherlands
{
    public static class TaxCodes
    {
        public static readonly TaxCode BTW_21 = new TaxCode(new Guid("33855cc4-964b-44d1-be27-cf268b0ad77d"), Country.Netherlands, "BTW 21%", 21m);
        public static readonly TaxCode BTW_06 = new TaxCode(new Guid("ad40e782-1f1c-486a-91a4-266e7001c8b3"), Country.Netherlands, "BTW 6%", 6m);
        public static readonly TaxCode BTW_21_EU = new TaxCode(new Guid("93cdbadc-4a15-41ff-bf68-4ed927915680"), Country.Netherlands, "BTW 21% EU", 21m);
        public static readonly TaxCode BTW_21_nonEU = new TaxCode(new Guid("3a57686a-7ce6-43e7-aa2a-dc5e98ad931b"), Country.Netherlands, "BTW 21% non-EU", 21m);
        public static readonly TaxCode BTW_06_EU = new TaxCode(new Guid("1f681bc9-93fd-4e09-815f-2f1c6bc5044b"), Country.Netherlands, "BTW 6% EU", 6m);
        public static readonly TaxCode BTW_06_nonEU = new TaxCode(new Guid("bddb4876-fd25-49bf-ac71-5365878268ef"), Country.Netherlands, "BTW 6% non-EU", 6m);
        public static readonly TaxCode BTW_0_EU = new TaxCode(new Guid("d0eca2ec-e9da-40de-9be6-e2e9fb34269a"), Country.Netherlands, "BTW 0% EU", 0m);
        public static readonly TaxCode BTW_0_nonEU = new TaxCode(new Guid("75eaae26-98a4-4e1a-9d75-91bf2b7e7b11"), Country.Netherlands, "BTW 0% non-EU", 0m);
        public static readonly TaxCode BTW_0_vrijgesteld = new TaxCode(new Guid("c6b298fa-f994-47ac-b6c0-3299fbac8306"), Country.Netherlands, "BTW 0% vrijgesteld", 0m);
        public static readonly TaxCode BTW_0_verlegd = new TaxCode(new Guid("ad18e082-df57-44f9-8fd0-ab3c5275d230"), Country.Netherlands, "BTW 0% verlegd", 0m);
    }
}
