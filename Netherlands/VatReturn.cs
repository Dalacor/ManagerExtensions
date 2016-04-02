using System;
using System.Linq;

namespace ManagerExtensions.Netherlands
{
    public sealed class VatReturn : TaxReport
    {
        public override string Name
        {
            get
            {
                return "VAT Calculation Worksheet";
            }
        }

        public override Guid[] SupportedTaxCodes
        {
            get
            {
                return new[] {
                    TaxCodes.Netherlands_BTW_06,
                    TaxCodes.Netherlands_BTW_21
                };
            }
        }

        public override void GenerateFromTaxSummary(string businessName, DateTime from, DateTime to, bool isCashBasis, TaxTransaction[] taxTransactions)
        {
            var btw = taxTransactions.Where(x => x.TaxCode == TaxCodes.Netherlands_BTW_06 || x.TaxCode == TaxCodes.Netherlands_BTW_21).ToArray();
            var btw21 = taxTransactions.Where(x => x.TaxCode == TaxCodes.Netherlands_BTW_21).ToArray();
            var btw06 = taxTransactions.Where(x => x.TaxCode == TaxCodes.Netherlands_BTW_06).ToArray();

            var btw21_tax_paid = btw21.Where(x => x.IsPurchase).Sum(x => x.TaxAmount);
            var btw21_tax_collected = btw21.Where(x => !x.IsPurchase).Sum(x => x.TaxAmount);
            var btw06_tax_paid = btw06.Where(x => x.IsPurchase).Sum(x => x.TaxAmount);
            var btw06_tax_collected = btw06.Where(x => !x.IsPurchase).Sum(x => x.TaxAmount);

            using (Style())
            {
                Write("table.report th.section { background-color: #000; color: #fff; }");
                Write("table.report td { padding-top: 5px; padding-bottom: 5px; }");
                Write("table.report td.amount { text-align: right; font-weight: bold; }");
                Write("table.report td.dollar-sign { text-align: left }");
            }

            using (Table(@class: "report"))
            {
                using (Tr())
                {
                    using (Th(@class: "header", colspan: 5))
                    {
                        using (H3(style: "font-weight: bold")) Write(businessName);
                        using (H1(style: "font-weight: bold")) Write("VAT Calculation Worksheet");
                        using (H3(style: "font-weight: bold")) Write("From " + from.ToString("MMMM d, yyyy") + " until " + to.ToString("MMMM d, yyyy"));
                        using (H3(style: "font-weight: bold"))
                        {
                            if (!isCashBasis) Write("Acrual basis");
                            if (isCashBasis) Write("Cash basis");
                        }
                    }
                }
                using (Tr())
                {
                    using (Td()) { }
                    using (Td(colspan: 2, style: "vertical-align: bottom; text-align: right; font-weight: bold")) Write("Bedrag waarover<br />omzetbelasting<br />wordt berekend");
                    using (Td(colspan: 2, style: "vertical-align: bottom; text-align: right; font-weight: bold; padding-left: 20px")) Write("Omzetbelasting");
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 5, @class: "section")) Write("<b>1 Prestaties binnenland</b>");
                }
                using (Tr())
                {
                    using (Td()) Write("1a Leveringen/diensten belast met hoog tarief"); // 1a and 1b Supplies/services taxed at the high or low rate
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) Write(btw21.Where(x => !x.IsPurchase).Sum(x => x.NetAmount+x.TaxAmount).ToString("0,0"));
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) Write(btw21.Where(x => !x.IsPurchase).Sum(x => x.TaxAmount).ToString("0,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("1b Leveringen/diensten belast met laag tarief"); // 1a and 1b Supplies/services taxed at the high or low rate
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) Write(btw06.Where(x => !x.IsPurchase).Sum(x => x.NetAmount + x.TaxAmount).ToString("0,0"));
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) Write(btw06.Where(x => !x.IsPurchase).Sum(x => x.TaxAmount).ToString("0,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("1c Leveringen/diensten belast met overige tarieven, behalve 0%");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr())
                {
                    using (Td()) Write("1d Privégebruik");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr())
                {
                    using (Td()) Write("1e Leveringen/diensten belast met 0% of niet bij u belast");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 5, @class: "section")) Write("<b>2 Verleggingsregelingen binnenland</b>");
                }
                using (Tr())
                {
                    using (Td()) Write("2a Leveringen/diensten waarbij de heffing van omzetbelasting naar u is verlegd");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 5, @class: "section")) Write("<b>3 Prestaties naar of in het buitenland</b>");
                }
                using (Tr())
                {
                    using (Td()) Write("3a Leveringen naar landen buiten de EU (uitvoer)");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr())
                {
                    using (Td()) Write("3b Leveringen naar of diensten in landen binnen de EU");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr())
                {
                    using (Td()) Write("3c Installatie/afstandsverkopen binnen de EU");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 5, @class: "section")) Write("<b>4 Prestaties vanuit het buitenland aan u verricht</b>");
                }
                using (Tr())
                {
                    using (Td()) Write("4a Leveringen/diensten uit landen buiten de EU");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr())
                {
                    using (Td()) Write("4b Leveringen/diensten uit landen binnen de EU");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 5, @class: "section")) Write("<b>5 Voorbelasting en kleineondernemersregeling</b>");
                }
                using (Tr())
                {
                    using (Td(colspan: 3)) Write("5a Omzetbelasting (rubrieken 1 t/m 4");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                using (Tr())
                {
                    using (Td(colspan: 3)) Write("5b Voorbelasting");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) Write(btw.Where(x => x.IsPurchase).Sum(x => x.TaxAmount).ToString("0,0"));
                }
                using (Tr())
                {
                    using (Td(colspan: 3)) Write("5c Subtotaal (rubriek 5a min 5b)");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) Write(btw.Where(x => x.IsPurchase).Sum(x => x.TaxAmount).ToString("0,0"));
                }
                using (Tr())
                {
                    using (Td(colspan: 3)) Write("5d Vermindering volgens de kleineondernemersregeling");
                    using (Td(@class: "dollar-sign")) Write("€");
                    using (Td(@class: "amount")) { }
                }
                //Totaal te betalen of terug te vragen
                var total = btw21.Sum(x => x.TaxAmount)+btw06.Sum(x => x.TaxAmount);
                if (total >= 0m)
                {
                    using (Tr())
                    {
                        using (Td(colspan: 3)) Write("Totaal te betalen");
                        using (Td(@class: "dollar-sign")) Write("€");
                        using (Td(@class: "amount")) Write(total.ToString("0,0"));
                    }
                }
                else
                {
                    using (Tr())
                    {
                        using (Td(colspan: 3)) Write("Totaal te terug te vragen");
                        using (Td(@class: "dollar-sign")) Write("€");
                        using (Td(@class: "amount")) Write((total * -1).ToString("0,0"));
                    }
                }
            }
        }
    }
}
