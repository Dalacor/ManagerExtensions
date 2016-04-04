using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagerExtensions.UnitedKingdom
{
    public sealed class VatReturn : TaxReport
    {
        public override Guid UUID
        {
            get
            {
                return new Guid("12e5e9fb-d8e8-4fce-aa33-8ba564117550");
            }
        }

        public override string Name
        {
            get
            {
                return "VAT Calculation Worksheet";
            }
        }

        public override TaxCode[] SupportedTaxCodes
        {
            get
            {
                return new[] {
                    TaxCodes.UnitedKingdom_VAT_00,
                    TaxCodes.UnitedKingdom_VAT_05,
                    TaxCodes.UnitedKingdom_VAT_05_ON_IMPORTS,
                    TaxCodes.UnitedKingdom_VAT_20,
                    TaxCodes.UnitedKingdom_VAT_20_ON_IMPORTS,
                    TaxCodes.UnitedKingdom_VAT_Exempt
                };
            }
        }

        public override void GenerateFromTaxSummary(string businessName, DateTime from, DateTime to, bool isCashBasis, TaxTransaction[] taxTransactions)
        {
            var G1 = taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_20).Sum(x => x.TaxCollected);
            G1 += taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_05).Sum(x => x.TaxCollected);
            var G2 = 0m;
            var G4 = taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_20).Sum(x => x.TaxPaid);
            G4 += taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_05).Sum(x => x.TaxPaid);
            G4 += taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_05_ON_IMPORTS).Sum(x => x.TaxAmount);
            G4 += taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_20_ON_IMPORTS).Sum(x => x.TaxAmount);
            var G6 = taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_20 || x.TaxCode == TaxCodes.UnitedKingdom_VAT_05 || x.TaxCode == TaxCodes.UnitedKingdom_VAT_00 || x.TaxCode == TaxCodes.UnitedKingdom_VAT_Exempt).Sum(x => x.NetSales);
            var G7 = taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_20 || x.TaxCode == TaxCodes.UnitedKingdom_VAT_05 || x.TaxCode == TaxCodes.UnitedKingdom_VAT_00 || x.TaxCode == TaxCodes.UnitedKingdom_VAT_Exempt).Sum(x => x.NetPurchases);
            G7 += taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_20_ON_IMPORTS).Sum(x => x.TaxAmount) * 5;
            G7 += taxTransactions.Where(x => x.TaxCode == TaxCodes.UnitedKingdom_VAT_05_ON_IMPORTS).Sum(x => x.TaxAmount) * 20;

            var G3 = G1 + G2;
            var G5 = G3 - G4;

            using (Style())
            {
                Write("table.taxReport th.section { background-color: #000; color: #fff; padding: 5px }");
                Write("table.taxReport td { padding: 5px; }");
                Write("table.taxReport td.amount div { min-width: 80px; padding: 3px; border: 1px solid #000; text-align: right; font-weight: bold; }");
                Write("table.taxReport td.gray div { font-weight: bold; text-align: center; background-color: #ccc; padding: 5px; }");
                Write("table.taxReport td.dollar-sign { text-align: right }");
            }

            using (Table(@class: "taxReport"))
            {
                using (Tr()) using (Th(colspan: 4, style: "font-weight: bold; font-size: 16px; text-align: center; padding-bottom: 10px")) Write(businessName);
                using (Tr()) using (Th(colspan: 4, style: "font-weight: bold; font-size: 24px; text-align: center; padding-bottom: 10px")) Write(Name);
                using (Tr()) using (Th(colspan: 4, style: "font-weight: bold; font-size: 16px; text-align: center; padding-bottom: 10px")) Write("From " + from.ToString("MMMM d, yyyy") + " until " + to.ToString("MMMM d, yyyy"));
                using (Tr()) using (Th(colspan: 4, style: "font-weight: bold; font-size: 16px; text-align: center; padding-bottom: 10px"))
                {
                    if (isCashBasis) Write("Cash basis");
                    if (!isCashBasis) Write("Acrual basis");
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 4, @class: "section")) Write("<b>VAT Calculations</b>");
                }
                using (Tr())
                {
                    using (Td()) Write("VAT due this period on sales and other outputs");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G1.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#1 on the VAT Return");
                }
                using (Tr())
                {
                    using (Td()) Write("VAT due in this period on acquisitions from other EC Member States");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G2.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#2 on the VAT Return");
                }
                using (Tr())
                {
                    using (Td()) Write("<b>Total VAT due (the sum of boxes 1 and 2)</b>");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G3.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#3 on the VAT Return");
                }
                using (Tr())
                {
                    using (Td()) Write("VAT reclaimed in this period on purchases and other inputs (including acquisitions from EC)");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G4.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#4 on the VAT Return");
                }
                using (Tr(@class: "line"))
                {
                    using (Td()) Write("<b>Net VAT to be paid to Customs (or reclaimed by you)</b>");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G5.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#5 on the VAT Return");
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 4, @class: "section")) Write("<b>Sales and Purchases Excluding VAT</b>");
                }
                using (Tr())
                {
                    using (Td()) Write("Total value of sales and all other outputs excluding VAT (including supplies to EC)");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G6.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#6 on the VAT Return");
                }
                using (Tr())
                {
                    using (Td()) Write("Total value of purchases and all other inputs excluding VAT (including acquisitions from EC)");
                    using (Td(@class: "dollar-sign")) Write("£");
                    using (Td(@class: "amount")) using (Div()) Write(G7.ToString("#,0"));
                    using (Td(@class: "gray")) using (Div()) Write("#7 on the VAT Return");
                }
            }
        }
    }
}
