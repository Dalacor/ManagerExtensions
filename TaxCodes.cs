using System;

namespace ManagerExtensions
{
    public static class TaxCodes
    {
        public static readonly Guid Australia_GST_10 = new Guid("8cf9d117-3142-4d9c-82ee-b57a0e22c809");
        public static readonly Guid Australia_GST_FREE_EXPORT = new Guid("10d8f9dc-db1e-4c87-9480-a696f59aeddf");
        public static readonly Guid Australia_GST_FREE = new Guid("14f63584-be71-40ca-9028-1a60e2e2cc90");
        public static readonly Guid Australia_INPUT_TAXED = new Guid("f218a321-f83d-4d06-8d02-b52f595cc4fe");
        public static readonly Guid Australia_Deferred_GST_10 = new Guid("73952f89-6139-4fd0-a937-165b8ed66ba8");
        public static readonly Guid Australia_GST_10_ON_IMPORTS = new Guid("9fe15ead-2138-4f4b-b3f5-398857d08503");
        public static readonly Guid UnitedKingdom_VAT_20 = new Guid("b926c2d8-09e4-496c-9a2c-818c8aaa36ed");
        public static readonly Guid UnitedKingdom_VAT_05 = new Guid("56769971-405e-47bd-bd13-d64de0eae752");
        public static readonly Guid UnitedKingdom_VAT_00 = new Guid("6959fb01-3a48-486a-9bec-a0681a662f03");
        public static readonly Guid UnitedKingdom_VAT_Exempt = new Guid("42a5002c-5c8f-4def-8672-4e6f3fc09654");
        public static readonly Guid UnitedKingdom_VAT_05_ON_IMPORTS = new Guid("4ca35740-f9b7-4dc6-bc88-08bdc8715994");
        public static readonly Guid UnitedKingdom_VAT_20_ON_IMPORTS = new Guid("11e650b0-ec87-4e45-9049-10a83ea4bed6");
        public static readonly Guid NewZealand_GST_15 = new Guid("ee8cacde-58da-48ec-8aa9-aa6acba9c32f");
        public static readonly Guid NewZealand_GST_15_ON_IMPORTS = new Guid("d865c9b1-17b9-488b-b29b-b15c0b3c3246");
        public static readonly Guid SouthAfrica_VAT_14 = new Guid("08d40919-b4cb-4668-8969-b51a63da203e");
        public static readonly Guid Namibia_VAT_15 = new Guid("1608cdc4-67e5-437f-bab9-ab98d7b4b784");
        public static readonly Guid Namibia_VAT_00 = new Guid("d330352b-11f1-44b3-88cb-26f9cfc5fadc");
        public static readonly Guid Namibia_VAT_Exempt = new Guid("f4381505-35b0-4a7c-add6-3cfb6b7a8e0e");
        public static readonly Guid Philippines_VAT_12_Goods = new Guid("e111d796-d67c-454b-9b4b-aa12d5f788ef");
        public static readonly Guid Philippines_VAT_12_Services = new Guid("a2ed1aaa-be8f-403f-b113-0e94e31f815f");
        public static readonly Guid Philippines_VAT_00 = new Guid("835b3f27-3a6d-4d43-a79c-2016321ca388");
        public static readonly Guid Philippines_VAT_Exempt = new Guid("942779a5-e3b5-4b19-8f84-1aa5e8056744");
        public static readonly Guid India_ServiceTax_12_36 = new Guid("71813c71-7833-4911-9cbe-3d961486344d");
        public static readonly Guid India_ServiceTax_14 = new Guid("75bd30b9-4727-40c9-bc70-d7d71b40f374");
        public static readonly Guid India_ServiceTax_14_5 = new Guid("a7afc831-aebd-4a1e-bd07-eb14a4b5f311");
        public static readonly Guid India_CST_04 = new Guid("20888f96-8ef3-4023-9c54-3f6e41cf14f0");
        public static readonly Guid India_CST_Exempt = new Guid("cdca06f2-9732-45a2-88a2-3dfeb2da3fc0");
        public static readonly Guid Norway_VAT_25 = new Guid("01324570-474b-48bc-b893-d8fdc08a0a0f");
        public static readonly Guid Norway_VAT_14 = new Guid("5a71058a-c8d0-46a5-81a4-3cee4320aae0");
        public static readonly Guid Norway_VAT_15 = new Guid("283c571f-55dd-4b10-aac8-d7686e593286");
        public static readonly Guid Norway_VAT_08 = new Guid("023bf9ff-ad08-48d2-9913-db2f9f4dec4b");
        public static readonly Guid Norway_VAT_00 = new Guid("454d3e9e-805e-4c42-a79e-17ca98bc397c");
        public static readonly Guid Belgium_VAT_21 = new Guid("104ed048-88f0-4f9b-9b06-df4f8d5735d1");
        public static readonly Guid Belgium_VAT_06 = new Guid("5f1191d4-149a-4ec8-bd18-88190c48669c");
        public static readonly Guid Belgium_VAT_00 = new Guid("a882ae8c-c278-4f7a-b6b5-c9ec4d76d69d");
        public static readonly Guid Malaysia_GST_06 = new Guid("88b8763f-630a-439a-82a3-4cdac956a699");
        public static readonly Guid Malaysia_GST_10 = new Guid("ca7c4639-c2af-4298-a32d-ddae7e138752");
        public static readonly Guid Netherlands_BTW_21 = new Guid("33855cc4-964b-44d1-be27-cf268b0ad77d");
        public static readonly Guid Netherlands_BTW_06 = new Guid("ad40e782-1f1c-486a-91a4-266e7001c8b3");

        public sealed class InBuiltTaxCode
        {
            internal InBuiltTaxCode(Guid key, Country country, string code, decimal rate, string description = null, bool taxInvoice = false)
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

        public static InBuiltTaxCode[] MasterTaxCodes = new InBuiltTaxCode[]
        {
            new InBuiltTaxCode(Netherlands_BTW_21, Country.Netherlands, "BTW 21%", 21m),
            new InBuiltTaxCode(Netherlands_BTW_06, Country.Netherlands, "BTW 6%", 6m),
            new InBuiltTaxCode(new Guid("93cdbadc-4a15-41ff-bf68-4ed927915680"), Country.Netherlands, "BTW 21% EU", 21m),
            new InBuiltTaxCode(new Guid("3a57686a-7ce6-43e7-aa2a-dc5e98ad931b"), Country.Netherlands, "BTW 21% non-EU", 21m),
            new InBuiltTaxCode(new Guid("1f681bc9-93fd-4e09-815f-2f1c6bc5044b"), Country.Netherlands, "BTW 6% EU", 6m),
            new InBuiltTaxCode(new Guid("bddb4876-fd25-49bf-ac71-5365878268ef"), Country.Netherlands, "BTW 6% non-EU", 6m),
            new InBuiltTaxCode(new Guid("c6b298fa-f994-47ac-b6c0-3299fbac8306"), Country.Netherlands, "BTW 0% vrijgesteld", 0m),
            new InBuiltTaxCode(new Guid("ad18e082-df57-44f9-8fd0-ab3c5275d230"), Country.Netherlands, "BTW 0% verlegd", 0m),
            new InBuiltTaxCode(new Guid("d0eca2ec-e9da-40de-9be6-e2e9fb34269a"), Country.Netherlands, "BTW 0% EU", 0m),
            new InBuiltTaxCode(new Guid("75eaae26-98a4-4e1a-9d75-91bf2b7e7b11"), Country.Netherlands, "BTW 0% non-EU", 0m),

            new InBuiltTaxCode(Norway_VAT_25, Country.Norway, "VAT 25%", 25m),
            new InBuiltTaxCode(Norway_VAT_15, Country.Norway, "VAT 15%", 15m),
            new InBuiltTaxCode(Norway_VAT_14, Country.Norway, "VAT 14%", 14m),
            new InBuiltTaxCode(Norway_VAT_08, Country.Norway, "VAT 8%", 8m),
            new InBuiltTaxCode(Norway_VAT_00, Country.Norway, "VAT 0%", 0m),

            new InBuiltTaxCode(Belgium_VAT_21, Country.Belgium, "VAT 21%", 21m),
            new InBuiltTaxCode(Belgium_VAT_06, Country.Belgium, "VAT 6%", 6m),
            new InBuiltTaxCode(Belgium_VAT_00, Country.Belgium, "VAT 0%", 0m),

            new InBuiltTaxCode(UnitedKingdom_VAT_20, Country.UnitedKingdom, "VAT 20%", 20m),
            new InBuiltTaxCode(UnitedKingdom_VAT_05, Country.UnitedKingdom, "VAT 5%", 5m),
            new InBuiltTaxCode(UnitedKingdom_VAT_00, Country.UnitedKingdom, "VAT 0%", 0m),
            new InBuiltTaxCode(UnitedKingdom_VAT_Exempt, Country.UnitedKingdom, "VAT Exempt", 0m),
            new InBuiltTaxCode(UnitedKingdom_VAT_05_ON_IMPORTS, Country.UnitedKingdom, "VAT 5% on Imports", decimal.MaxValue),
            new InBuiltTaxCode(UnitedKingdom_VAT_20_ON_IMPORTS, Country.UnitedKingdom, "VAT 20% on Imports", decimal.MaxValue),

            new InBuiltTaxCode(NewZealand_GST_15, Country.NewZealand, "GST 15%", 15m, taxInvoice: true),
            new InBuiltTaxCode(NewZealand_GST_15_ON_IMPORTS, Country.NewZealand, "GST 15% on Imports", decimal.MaxValue),

            new InBuiltTaxCode(India_ServiceTax_12_36, Country.India, "Service Tax 12.36%", 12.36m),
            new InBuiltTaxCode(India_ServiceTax_14, Country.India, "Service Tax 14%", 14m),
            new InBuiltTaxCode(India_ServiceTax_14_5, Country.India, "Service Tax 14.5%", 14.5m),
            new InBuiltTaxCode(India_CST_04, Country.India, "CST 4%", 4m, taxInvoice: true),
            new InBuiltTaxCode(India_CST_Exempt, Country.India, "CST Exempt", 0m, taxInvoice: true),
            new InBuiltTaxCode(new Guid("492ed057-ff77-410e-a045-9d269e4603c9"), Country.India, "VAT 14.5%", 15.5m, "Karnataka", taxInvoice: true),
            new InBuiltTaxCode(new Guid("c79ebcef-2ee5-4c64-9078-ca73b49aa5f5"), Country.India, "VAT 5.5%", 15.5m, "Karnataka", taxInvoice: true),

            new InBuiltTaxCode(Australia_GST_10, Country.Australia, "GST 10%", 10m, taxInvoice: true),
            new InBuiltTaxCode(Australia_GST_FREE, Country.Australia, "GST Free", 0.00m),
            new InBuiltTaxCode(Australia_GST_FREE_EXPORT, Country.Australia, "GST Free Exports", 0.00m),
            new InBuiltTaxCode(Australia_INPUT_TAXED, Country.Australia, "Input Taxed", 0.00m),
            new InBuiltTaxCode(Australia_Deferred_GST_10, Country.Australia, "GST 10% (Deferred)", 10m),
            new InBuiltTaxCode(Australia_GST_10_ON_IMPORTS, Country.Australia, "GST on Imports", decimal.MaxValue),

            new InBuiltTaxCode(Philippines_VAT_12_Goods, Country.Philippines, "VAT 12% (Goods)", 12m),
            new InBuiltTaxCode(Philippines_VAT_12_Services, Country.Philippines, "VAT 12% (Services)", 12m),
            new InBuiltTaxCode(Philippines_VAT_00, Country.Philippines, "VAT 0%", 0m),
            new InBuiltTaxCode(Philippines_VAT_Exempt, Country.Philippines, "VAT Exempt", 0m),

            new InBuiltTaxCode(SouthAfrica_VAT_14, Country.SouthAfrica, "VAT 14%", 14m, taxInvoice: true),

            new InBuiltTaxCode(Malaysia_GST_06, Country.Malaysia, "GST 6%", 6m, taxInvoice: true),
            new InBuiltTaxCode(Malaysia_GST_10, Country.Malaysia, "GST 10%", 10m, taxInvoice: true),


            // EU

            new InBuiltTaxCode(new Guid("fd2bd370-78f5-4721-8ea4-aff4e9a402f5"), Country.Austria, "UST / MWST 20%", 20m),
            new InBuiltTaxCode(new Guid("bde0106a-e075-4df4-b8e6-8e2f31417e6f"), Country.Austria, "UST / MWST 10%", 10m),

            new InBuiltTaxCode(new Guid("19da2a05-4995-4a45-b460-8331df5218c5"), Country.Bulgaria, "ДДС 20%", 20m),
            new InBuiltTaxCode(new Guid("7441fd6c-90ff-44e5-b762-95326eb452f3"), Country.Bulgaria, "ДДС 9%", 9m),

            new InBuiltTaxCode(new Guid("a2b881af-911c-457f-82e3-44637a23a43f"), Country.Cyprus, "ΦΠΑ 19%", 19m),
            new InBuiltTaxCode(new Guid("4575e8fc-c324-48b2-86f9-0c5cc02ff800"), Country.Cyprus, "ΦΠΑ 18%", 18m),
            new InBuiltTaxCode(new Guid("be3cde62-5ba1-4eb1-ae73-1c82c07a0321"), Country.Cyprus, "ΦΠΑ 8%", 8m),
            new InBuiltTaxCode(new Guid("a3131461-f6fa-4548-ad5c-e810739b5127"), Country.Cyprus, "ΦΠΑ 5%", 5m),

            new InBuiltTaxCode(new Guid("f484f372-a1b8-4d2f-81c2-eebe662e11f4"), Country.CzechRepublic, "DPH 21%", 21m),
            new InBuiltTaxCode(new Guid("25919a92-2c62-435d-9f67-251d887346b3"), Country.CzechRepublic, "DPH 15%", 15m),

            new InBuiltTaxCode(new Guid("467aba82-4efd-4099-9063-624416c1da0b"), Country.Denmark, "moms 25%", 25m),
            new InBuiltTaxCode(new Guid("85abd674-62ad-4aed-bcd9-612214f764b5"), Country.Denmark, "moms 0%", 0m),

            new InBuiltTaxCode(new Guid("064e90b7-a389-469d-b9a2-2489f88d8a1f"), Country.Estonia, "KM 20%", 20m),
            new InBuiltTaxCode(new Guid("55d521dc-5c48-44f8-a1d5-d086e7dc3921"), Country.Estonia, "KM 9%", 9m),

            new InBuiltTaxCode(new Guid("d5373473-14e1-4a6c-b006-26d2c966f280"), Country.Finland, "ALV 24%", 24m),
            new InBuiltTaxCode(new Guid("d8271e69-e5f5-4c4b-8cbc-0ec59cc70119"), Country.Finland, "ALV 14%", 14m),
            new InBuiltTaxCode(new Guid("99601f9c-2d10-4957-b0f1-2f291fc44c54"), Country.Finland, "ALV 10%", 10m),

            new InBuiltTaxCode(new Guid("eca17133-3106-4d3b-80ed-34277c7908f8"), Country.France, "TVA 19,6%", 19.6m),
            new InBuiltTaxCode(new Guid("f0e9930c-1c6f-42f1-a3be-1f4c4ca92757"), Country.France, "TVA 7,00%", 7m),
            new InBuiltTaxCode(new Guid("fddbbda4-4afe-47e4-ba5e-c7e273030f19"), Country.France, "TVA 5,5%", 5.5m),
            new InBuiltTaxCode(new Guid("aa9e98ed-123f-42de-9224-14e5f999080b"), Country.France, "TVA 2,1%", 2.1m),

            new InBuiltTaxCode(new Guid("13fe02d9-c454-42d2-beb5-53d79d28784b"), Country.Germany, "MwSt. 19%", 19m),
            new InBuiltTaxCode(new Guid("0283b674-28e5-473b-a23f-ca7610608681"), Country.Germany, "MwSt. 7%", 7m),

            new InBuiltTaxCode(new Guid("73021733-ad27-4abb-993d-f0c739b660cc"), Country.Greece, "ΦΠΑ 23%", 23m),
            new InBuiltTaxCode(new Guid("cd290a5d-7904-43f3-ad8d-e049ca8a53ab"), Country.Greece, "ΦΠΑ 13%", 13m),
            new InBuiltTaxCode(new Guid("0429eb9c-bc44-43fc-8fac-80c62b60b416"), Country.Greece, "ΦΠΑ 6,5%", 6.5m),

            new InBuiltTaxCode(new Guid("3641edbe-c260-45f9-8409-33499cfe4c6f"), Country.Hungary, "ÁFA 27%", 27m),
            new InBuiltTaxCode(new Guid("9980049b-5382-4435-9bda-daab936fbf8c"), Country.Hungary, "ÁFA 18%", 18m),
            new InBuiltTaxCode(new Guid("da780b45-5557-48aa-815e-a767d9bb7140"), Country.Hungary, "ÁFA 5%", 5m),

            new InBuiltTaxCode(new Guid("36b562cc-479d-4b22-b189-78a1335b6992"), Country.Ireland, "VAT 23%", 23m),
            new InBuiltTaxCode(new Guid("5240d8ac-2e36-49d0-b9e7-42ecf68ad852"), Country.Ireland, "VAT 13,5%", 13.5m),
            new InBuiltTaxCode(new Guid("c9b2aa11-9880-4646-9dfc-45a47e507869"), Country.Ireland, "VAT 9%", 9m),
            new InBuiltTaxCode(new Guid("02564e13-d354-4ae0-8dbd-2d8a991b20f7"), Country.Ireland, "VAT 4,8%", 4.8m),

            new InBuiltTaxCode(new Guid("8a5ac333-9091-4c01-b5a2-1857fd884d92"), Country.Italy, "IVA 22%", 22m),
            new InBuiltTaxCode(new Guid("a7432e33-f01a-4a27-bd14-17f5598906e2"), Country.Italy, "IVA 10%", 10m),
            new InBuiltTaxCode(new Guid("53fbea2f-1116-4073-b820-d86941cee745"), Country.Italy, "IVA 4%", 4m),

            new InBuiltTaxCode(new Guid("b4e44174-d253-4060-9d49-f0e85b7486c1"), Country.Latvia, "PVN 21%", 21m),
            new InBuiltTaxCode(new Guid("0088c83d-31d8-400e-8e5d-d5b5dca6e4f4"), Country.Latvia, "PVN 12%", 12m),

            new InBuiltTaxCode(new Guid("4339f5cd-81b5-42ac-a79f-685323279e2b"), Country.Lithuania, "PVM 21%", 21m),
            new InBuiltTaxCode(new Guid("c6073012-fd45-4488-83e9-ce48db55fe0c"), Country.Lithuania, "PVM 9%", 9m),
            new InBuiltTaxCode(new Guid("dc966c1c-db30-4d38-aa77-ea04a6aa51e0"), Country.Lithuania, "PVM 5%", 5m),

            new InBuiltTaxCode(new Guid("6efaea7b-f043-4439-9a41-25bdcd92fff9"), Country.Luxembourg, "TVA 17%", 17m),
            new InBuiltTaxCode(new Guid("2eeacd0b-6849-4639-ae32-82015898fd3d"), Country.Luxembourg, "TVA 15%", 15m),
            new InBuiltTaxCode(new Guid("78f57f60-be88-4636-a569-f13db68d1503"), Country.Luxembourg, "TVA 12%", 12m),
            new InBuiltTaxCode(new Guid("e9cc20b0-aa86-44b0-a08d-1c1946527619"), Country.Luxembourg, "TVA 6%", 6m),
            new InBuiltTaxCode(new Guid("3a331b97-4314-4856-9d29-a4eaf7f2cdbb"), Country.Luxembourg, "TVA 3%", 3m),

            new InBuiltTaxCode(new Guid("89fe7748-9c1b-40eb-8b49-742d964f36c1"), Country.Malta, "VAT 18%", 18m),
            new InBuiltTaxCode(new Guid("cf151a23-f724-40da-a59f-5364940e3d62"), Country.Malta, "VAT 7%", 7m),
            new InBuiltTaxCode(new Guid("f99a3d3b-2e9d-4d1d-86d1-0308dee2cd37"), Country.Malta, "VAT 5%", 5m),

            new InBuiltTaxCode(new Guid("164d2efe-7a41-4e94-a1fa-b105fab01259"), Country.Poland, "PTU 23%", 23m),
            new InBuiltTaxCode(new Guid("b5ed7b88-77a9-4f07-93bf-94ed5ea6e3c2"), Country.Poland, "PTU 8%", 8m),
            new InBuiltTaxCode(new Guid("28c2facd-ec2c-4199-8183-83b73f9e2f6e"), Country.Poland, "PTU 5%", 5m),

            new InBuiltTaxCode(new Guid("d82058f9-3de3-49f2-a8bb-7ce02cb2d927"), Country.Portugal, "IVA 23%", 23m),
            new InBuiltTaxCode(new Guid("aa3a7647-a97a-43e1-a8ef-cf3ea1e578a6"), Country.Portugal, "IVA 13%", 13m),
            new InBuiltTaxCode(new Guid("4be32655-60bc-4c41-b1c6-d6c40ebf0157"), Country.Portugal, "IVA 10%", 10m),
            new InBuiltTaxCode(new Guid("047b2506-4497-4b72-8dc9-803e9a9c0e1f"), Country.Portugal, "IVA 6%", 6m),
            
            new InBuiltTaxCode(new Guid("73852216-a834-42e5-b8d6-b149c730a76b"), Country.Romania, "TVA 24%", 24m),
            new InBuiltTaxCode(new Guid("603f8ff3-2710-41e6-99d0-4b0bc52653ee"), Country.Romania, "TVA 9%", 9m),
            new InBuiltTaxCode(new Guid("ae209f82-dd4b-4163-a7c5-19d686f93f31"), Country.Romania, "TVA 5%", 5m),

            new InBuiltTaxCode(new Guid("29ea4858-a1cb-44ae-bcad-68f70a3dfecb"), Country.Slovakia, "DPH 20%", 20m),
            new InBuiltTaxCode(new Guid("bb9c10fd-44d3-4d60-8f93-374d026d6d26"), Country.Slovakia, "DPH 10%", 10m),

            new InBuiltTaxCode(new Guid("4418affd-c9c0-4984-b69d-a43250257e73"), Country.Slovenia, "DDV 22%", 22m),
            new InBuiltTaxCode(new Guid("684e513e-84ea-4c8f-a133-cf3c81b05097"), Country.Slovenia, "DDV 9,5%", 9.5m),

            new InBuiltTaxCode(new Guid("4824abee-2cfc-4d09-a651-7c8ddf86aa28"), Country.Spain, "IVA 21%", 21m),
            new InBuiltTaxCode(new Guid("c79fb615-6d74-45fc-854c-637aa76b6b31"), Country.Spain, "IVA 10%", 10m),
            new InBuiltTaxCode(new Guid("457e64c4-1425-41ef-ab18-b03c930afa9e"), Country.Spain, "IVA 4%", 4m),

            new InBuiltTaxCode(new Guid("a30110ee-4bd5-4de5-8865-8f53b42c69ce"), Country.Sweden, "Moms 25%", 25m),
            new InBuiltTaxCode(new Guid("48b07e00-41f5-4955-b70f-9a213e7109db"), Country.Sweden, "Moms 12%", 12m),
            new InBuiltTaxCode(new Guid("e3b7e497-03d4-4618-a393-d0f2b5769b11"), Country.Sweden, "Moms 6%", 6m),

            // Non-EU

            new InBuiltTaxCode(new Guid("d55d6df6-4f8f-4965-b3ae-2497a4da4cb7"), Country.Albania, "TVSH 20%", 20m),
            new InBuiltTaxCode(new Guid("41734dd9-fada-40c0-9152-934124f1b440"), Country.Albania, "TVSH 10%", 10m),

            new InBuiltTaxCode(new Guid("63121da2-bcc5-4b35-bf4a-65f59a91e3cd"), Country.Andorra, "IVA 4,5%", 4.5m),
            new InBuiltTaxCode(new Guid("bd6fc43d-850e-4c52-9e53-ca4f7fc137be"), Country.Andorra, "IVA 1%", 1m),

            new InBuiltTaxCode(new Guid("8a4a8ab1-a3c9-45e0-ad90-91a22cdacdbe"), Country.Azerbaijan, "ƏDV 18%", 18m),
            new InBuiltTaxCode(new Guid("914a5295-8105-425a-82c0-4a26e396e824"), Country.Azerbaijan, "ƏDV 10,5%", 10.5m),

            new InBuiltTaxCode(new Guid("b7dc3000-54b4-40e0-9dae-d137727bd554"), Country.Argentina, "IVA 21%", 21m),
            new InBuiltTaxCode(new Guid("cd4e7426-a1f0-47b3-a634-84ec753a64e4"), Country.Argentina, "IVA 10,5%", 10.5m),

            new InBuiltTaxCode(new Guid("5286cacb-8380-45f4-93ba-4cc6805f3aad"), Country.Armenia, "AAH 20%", 20m),

            new InBuiltTaxCode(new Guid("7e5f1e76-cc56-4e35-9775-cbb9b1c672b8"), Country.Bahamas, "VAT 7.5%", 7.5m),

            new InBuiltTaxCode(new Guid("759e0332-e43f-4162-aa92-958d9251902b"), Country.Belarus, "ПДВ 18%", 18m),
            new InBuiltTaxCode(new Guid("52717a51-2915-4f3b-bfb6-13c2f9c3a26d"), Country.Belarus, "ПДВ 10%", 10m),
            new InBuiltTaxCode(new Guid("a908a457-403e-4d25-ab10-a03dd2c87ca6"), Country.Belarus, "ПДВ 0,5%", 0.5m),

            new InBuiltTaxCode(new Guid("93d9e7c1-4936-4bc8-abbd-5223ebe65a8a"), Country.Barbados, "VAT 17.5%", 17.5m),

            new InBuiltTaxCode(new Guid("915ad279-974c-41e0-9fb8-e2d656112913"), Country.BosniaAndHerzegovina, "PDV 17%", 17m),

            new InBuiltTaxCode(new Guid("82aec7ed-b838-4269-916d-26f66935f014"), Country.Bolivia, "IVA 13%", 13m),

            new InBuiltTaxCode(new Guid("f90939b1-d762-4c0c-8735-851524435f0c"), Country.Chile, "IVA 19%", 19m),

            new InBuiltTaxCode(new Guid("d38c6ead-9572-4af0-82ca-7d251da4630e"), Country.Colombia, "IVA 16%", 16m),

            new InBuiltTaxCode(new Guid("94167f29-0dcf-486a-b321-b97a575775d2"), Country.China, "增值税 17%", 17m),
            new InBuiltTaxCode(new Guid("6747ec02-88a2-4029-a98f-1838b6f2958a"), Country.China, "增值税 13%", 13m),
            new InBuiltTaxCode(new Guid("3d3ef7da-c30c-4c51-8b18-2709033a1935"), Country.China, "增值税 6%", 6m),
            new InBuiltTaxCode(new Guid("f89a7327-300a-4270-8c66-7791b45722e3"), Country.China, "增值税 3%", 3m),

            new InBuiltTaxCode(new Guid("148624e1-8591-464f-b758-dcb27e729fd0"), Country.Croatia, "PDV 25%", 25m),
            new InBuiltTaxCode(new Guid("9010d642-a852-461a-b747-9f52bdc7553a"), Country.Croatia, "PDV 10%", 10m),
            new InBuiltTaxCode(new Guid("84f55b3d-0332-4c2e-8dce-176a68a30fdb"), Country.Croatia, "PDV 5%", 5m),

            new InBuiltTaxCode(new Guid("332337b2-6c58-4c65-abbb-7d3418140671"), Country.DominicanRepublic, "ITBIS 16%", 16m),
            new InBuiltTaxCode(new Guid("5cfa2e50-116e-40fc-afc4-e2f138a50989"), Country.DominicanRepublic, "ITBIS 12%", 12m),

            new InBuiltTaxCode(new Guid("27b7fe62-c071-49e1-8b98-424caa074d19"), Country.Ecuador, "IVA 12%", 12m),

            new InBuiltTaxCode(new Guid("ffe956b9-5b57-4bf1-ace5-ea128ddd11d7"), Country.Egypt, "VAT 15%", 15m),
            new InBuiltTaxCode(new Guid("7bd02c9d-ad0f-48f9-bade-4334f4bf9802"), Country.Egypt, "VAT 10%", 10m),

            new InBuiltTaxCode(new Guid("2622398e-7a12-4f10-83b8-0b7489ec9c80"), Country.ElSalvador, "IVA 13%", 13m),

            new InBuiltTaxCode(new Guid("bfcdc9de-1371-4472-8454-f64c576c8251"), Country.Ethiopia, "VAT 15%", 15m),

            new InBuiltTaxCode(new Guid("d23a7ba9-0ec3-44ac-8642-8a0bd68f053e"), Country.Fiji, "VAT 15%", 15m),

            new InBuiltTaxCode(new Guid("6cb67642-b5ab-4521-9957-970d4f8479c7"), Country.FaroeIslands, "MVG 25%", 25m),

            new InBuiltTaxCode(new Guid("9ee7cab8-c5cf-4a02-9e95-945b2bbd7c2c"), Country.Georgia, "DGhG 18%", 18m),

            new InBuiltTaxCode(new Guid("49f7db2b-8c5b-4b49-abe3-83aacddf6aaa"), Country.Guatemala, "IVA 12%", 12m),

            new InBuiltTaxCode(new Guid("6ef63df1-a5ba-4724-9136-a8cc35ba32a4"), Country.Ghana, "VAT 17.5%", 17.5m),

            new InBuiltTaxCode(new Guid("f4e9329c-82e0-43df-964e-0637b0679249"), Country.Guyana, "VAT 16%", 16m),

            new InBuiltTaxCode(new Guid("bae034a7-f5aa-4ce2-beec-98766d750715"), Country.Iran, "VAT 4%", 4m),

            new InBuiltTaxCode(new Guid("e06f77bd-bc54-446d-9731-4f976eb2d654"), Country.Iceland, "VSK 25,5%", 25.5m),
            new InBuiltTaxCode(new Guid("95114a03-a261-4f26-95c8-263f64a5c936"), Country.Iceland, "VSK 7%", 7m),

            new InBuiltTaxCode(new Guid("a1d415be-5c85-4406-8c57-1c1d4897a3ff"), Country.Indonesia, "PPN 10%", 10m),
            new InBuiltTaxCode(new Guid("ef44bd59-0447-4ea6-b982-d1cc60c2d00b"), Country.Indonesia, "PPN 5%", 5m),

            new InBuiltTaxCode(new Guid("7df559f5-a93f-4c50-8109-1b6462cc65f6"), Country.Israel, "Ma'am 16%", 16m),

            new InBuiltTaxCode(new Guid("5e89e806-4a3f-4575-8231-5aca6613cf10"), Country.Japan, "消費税 5%", 5m),

            new InBuiltTaxCode(new Guid("8cdc90b9-8b27-4434-ac36-061b917ef817"), Country.SouthKorea, "VAT 10%", 10m),

            new InBuiltTaxCode(new Guid("32fb9a57-94c0-40d4-b6ba-1d7d617abed2"), Country.Jersey, "GST 5%", 5m),

            new InBuiltTaxCode(new Guid("bde7fe22-1a6b-4515-b752-2a42e7473675"), Country.Jordan, "GST 16%", 16m),

            new InBuiltTaxCode(new Guid("733aa976-cbad-43d1-8925-127c6ddc7238"), Country.Kazakhstan, "VAT 12%", 12m),

            new InBuiltTaxCode(new Guid("a56af078-837c-4be1-b30c-55bf60775077"), Country.Lebanon, "TVA 10%", 10m),

            new InBuiltTaxCode(new Guid("f632f0d2-bbf5-42cc-a6b2-f1b181744aba"), Country.Liechtenstein, "MWST 8%", 8m),
            new InBuiltTaxCode(new Guid("beb8b874-8b09-4b1f-b2ae-a06348f524f6"), Country.Liechtenstein, "MWST 3,8%", 3.8m),
            new InBuiltTaxCode(new Guid("bf57622c-4e96-4dff-9a76-4ae2da9f0a69"), Country.Liechtenstein, "MWST 2,5%", 2.5m),

            new InBuiltTaxCode(new Guid("74e7a2c9-f7b4-4fe5-8e09-e98ff8e78ccb"), Country.Morocco, "GST 20%", 20m),

            new InBuiltTaxCode(new Guid("2af86b44-2f19-4b14-a062-56019601a33c"), Country.Moldova, "TVA 20%", 20m),
            new InBuiltTaxCode(new Guid("2ed5e354-9506-4cdc-ae6a-b5267f0a5ee2"), Country.Moldova, "TVA 8%", 8m),
            new InBuiltTaxCode(new Guid("c4664091-13d2-4fda-a747-189c758deb4e"), Country.Moldova, "TVA 5%", 5m),

            new InBuiltTaxCode(new Guid("8ff2da5b-ab1e-41cb-b03d-d7e95739067a"), Country.Rwanda, "VAT 18%", 18m),

            new InBuiltTaxCode(new Guid("d7eba1a0-d27c-465c-94ca-38e7b480266a"), Country.RepublicOfMacedonia, "ДДВ 18%", 18m),
            new InBuiltTaxCode(new Guid("8fad8a0f-f932-454e-b90b-7b48b6a02e1a"), Country.RepublicOfMacedonia, "ДДВ 5%", 5m),

            new InBuiltTaxCode(new Guid("a8644b0c-ae64-44c2-85b8-0784fee918a8"), Country.Maldives, "GST 6%", 6m),
            new InBuiltTaxCode(new Guid("44344f70-2f2a-4772-9861-b3a0e3f95d30"), Country.Maldives, "GST 0%", 0m),
            new InBuiltTaxCode(new Guid("848bf6d3-24fc-4789-8875-438660f45095"), Country.Maldives, "GST Exempt", 0m),

            new InBuiltTaxCode(new Guid("b865000f-7f77-407b-8f42-d860c651c548"), Country.Mexico, "IVA 16%", 16m),
            new InBuiltTaxCode(new Guid("82237185-e522-43a2-bdd6-59314a55160f"), Country.Mexico, "IVA 11%", 11m),

            new InBuiltTaxCode(new Guid("8df095fc-e63f-4e1a-ba19-a05eccfeeb73"), Country.Monaco, "TVA 19,6%", 19.6m),
            new InBuiltTaxCode(new Guid("6923f9cb-357b-40cd-bc75-d0661bf3b68c"), Country.Monaco, "TVA 5,6%", 5.6m),

            new InBuiltTaxCode(new Guid("1b691d0b-ab97-4bdb-9c2c-5bb2ea3197c0"), Country.Montenegro, "PDV 17%", 17m),

            new InBuiltTaxCode(new Guid("6c0da2ec-054c-4245-95d8-771e5384594a"), Country.Mauritius, "VAT 15%", 15m),

            new InBuiltTaxCode(Namibia_VAT_15, Country.Namibia, "VAT 15%", 15m, taxInvoice: true),
            new InBuiltTaxCode(Namibia_VAT_00, Country.Namibia, "VAT 0%", 0m, taxInvoice: true),
            new InBuiltTaxCode(Namibia_VAT_Exempt, Country.Namibia, "VAT Exempt", 0m, taxInvoice: true),

            new InBuiltTaxCode(new Guid("c94aa840-0694-4423-a4f7-d354666e139e"), Country.Nepal, "VAT 13%", 13m),
            
            new InBuiltTaxCode(new Guid("09f61013-fd43-4a48-9a70-3c8f6604e2ad"), Country.StateOfPalestine, "VAT 14.5%", 14.5m),

            new InBuiltTaxCode(new Guid("3fe156dd-2f8d-43dd-9067-40303f9e1795"), Country.Pakistan, "GST 16%", 16m),
            new InBuiltTaxCode(new Guid("790363ad-d41d-44e5-87b7-7a7134a44adf"), Country.Pakistan, "GST 1%", 1m),

            new InBuiltTaxCode(new Guid("3a502522-fa27-4f5b-b5fa-7024c0a8effc"), Country.Panama, "ITBMS 7%", 7m),

            new InBuiltTaxCode(new Guid("8392ae3a-b7ed-47f6-9b39-c45edd70c871"), Country.Paraguay, "IVA 10%", 10m),
            new InBuiltTaxCode(new Guid("f514b37f-df97-49c3-ab64-c67a884b5c33"), Country.Paraguay, "IVA 5%", 5m),

            new InBuiltTaxCode(new Guid("6afe7d93-b568-4d5c-bd53-564af2333446"), Country.RussianFederation, "НДС 18%", 18m),
            new InBuiltTaxCode(new Guid("cd70b7fc-8fba-4676-9d71-0a0e91bc02d1"), Country.RussianFederation, "НДС 10%", 10m),

            new InBuiltTaxCode(new Guid("491bb853-b30f-4fa8-83eb-8ea4c4c51a73"), Country.SaintKittsAndNevis, "VAT", 17m),

            new InBuiltTaxCode(new Guid("37432f45-4b4c-4a10-a8dc-d67686796eb9"), Country.Serbia, "ПДВ 20%", 20m),
            new InBuiltTaxCode(new Guid("1add5234-60be-4dc9-9d1a-aff709b885c1"), Country.Serbia, "ПДВ 8%", 8m),

            new InBuiltTaxCode(new Guid("e7b4abde-8bdc-409c-addb-5f74295f5b59"), Country.Singapore, "GST 7%", 7m),

            new InBuiltTaxCode(new Guid("19c66489-8c41-430c-a431-5a71d32191cc"), Country.SriLanka, "VAT 12%", 12m),

            new InBuiltTaxCode(new Guid("15359935-1449-43f4-8dc0-26c4010e51d3"), Country.Switzerland, "MWST 8%", 8m),
            new InBuiltTaxCode(new Guid("fa67c7d5-9a7b-4071-b13b-3b9e26fe8097"), Country.Switzerland, "MWST 3,8%", 3.8m),
            new InBuiltTaxCode(new Guid("a39564bf-cf89-41a1-bf66-fc8f223189c4"), Country.Switzerland, "MWST 2,5%", 2.5m),

            new InBuiltTaxCode(new Guid("976502bf-87c3-4470-ba3d-5b4c65f6d4d1"), Country.Taiwan, "增值稅 5%", 5m),

            new InBuiltTaxCode(new Guid("12fb6952-1604-4d27-be00-b273cc077ca6"), Country.Thailand, "VAT 7%", 7m),

            new InBuiltTaxCode(new Guid("9fc33bc5-9349-4e03-8130-fb44ce62b745"), Country.Turkey, "KDV 18%", 18m),
            new InBuiltTaxCode(new Guid("c33ab8fa-2f9c-4934-b737-225e03cade18"), Country.Turkey, "KDV 8%", 8m),

            new InBuiltTaxCode(new Guid("48b92558-bf91-4157-8e98-584298a1cceb"), Country.Uganda, "VAT 18%", 18m, taxInvoice: true),

            new InBuiltTaxCode(new Guid("5f1d5dfa-51f4-4b9f-aaa0-bd7b3db3de34"), Country.Ukraine, "ПДВ 20%", 20m),

            new InBuiltTaxCode(new Guid("53d4e1fb-0b6a-4285-a9b7-94719de5d9d1"), Country.Uruguay, "IVA 22%", 22m),
            new InBuiltTaxCode(new Guid("be3c5489-c109-4968-a2be-22b729d8220d"), Country.Uruguay, "IVA 10%", 10m),

            new InBuiltTaxCode(new Guid("cbda5e85-03fc-4fda-9994-2d746845e024"), Country.Uzbekistan, "НДС 20%", 20m),

            new InBuiltTaxCode(new Guid("5060b7bc-5585-46d1-96c7-37b559038c86"), Country.Vietnam, "GTGT 10%", 10m),
            new InBuiltTaxCode(new Guid("2a707816-caa1-44b7-86c0-ce5865b01c96"), Country.Vietnam, "GTGT 5%", 5m),

            new InBuiltTaxCode(new Guid("6d179f04-b6c6-483e-92c9-3f86be7892b4"), Country.Venezuela, "IVA 12%", 12m),
            new InBuiltTaxCode(new Guid("a1d6f757-8d9b-4675-b73c-a6f821f0f1ec"), Country.Venezuela, "IVA 11%", 11m),

            new InBuiltTaxCode(new Guid("20222d69-1588-4ddc-9fe9-207d0c84c347"), Country.Zimbabwe, "VAT 15%", 15m),
        };
    }
}