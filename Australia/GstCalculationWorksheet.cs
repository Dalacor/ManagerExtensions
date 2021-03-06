﻿using System;
using System.Linq;

namespace ManagerExtensions.Australia
{
    public sealed class GstCalculationWorksheet : TaxReport
    {
        public override Guid UUID
        {
            get
            {
                return new Guid("11acbfe1-0d24-4161-b366-fe905f2bcfd9");
            }
        }

        public override string Name
        {
            get
            {
                return "GST Calculation Worksheet for BAS";
            }
        }

        public override TaxCode[] SupportedTaxCodes
        {
            get
            {
                return new [] {
                    TaxCodes.Deferred_GST_10,
                    TaxCodes.GST_10,
                    TaxCodes.GST_10_ON_IMPORTS,
                    TaxCodes.GST_FREE,
                    TaxCodes.GST_FREE_EXPORT,
                    TaxCodes.INPUT_TAXED
                };
            }
        }

        public override void GenerateFromTaxSummary(string businessName, DateTime from, DateTime to, bool isCashBasis, TaxTransaction[] taxTransactions)
        {
            var G2 = taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_FREE_EXPORT).Sum(x => x.NetSales);
            var G3 = taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_FREE).Sum(x => x.NetSales);
            var G4 = taxTransactions.Where(x => x.TaxCode == TaxCodes.INPUT_TAXED).Sum(x => x.NetSales);
            var G8 = taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_10).Sum(x => x.NetSales + x.TaxCollected);
            var G9 = taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_10).Sum(x => x.TaxCollected);

            var _7A = taxTransactions.Where(x => x.TaxCode == TaxCodes.Deferred_GST_10).Sum(x => x.TaxAmount);

            var G10 = taxTransactions.Where(x => x.IsCapitalAccount && (x.TaxCode == TaxCodes.GST_10 || x.TaxCode == TaxCodes.GST_FREE || x.TaxCode == TaxCodes.INPUT_TAXED)).Sum(x => x.NetPurchases + x.TaxPaid);
            G10 += taxTransactions.Where(x => x.IsCapitalAccount && (x.TaxCode == TaxCodes.Deferred_GST_10)).Sum(x => x.NetPurchases + x.TaxPaid);
            G10 += taxTransactions.Where(x => x.IsCapitalAccount && (x.TaxCode == TaxCodes.GST_10_ON_IMPORTS)).Sum(x => x.TaxPaid * 11m);

            var G11 = taxTransactions.Where(x => !x.IsCapitalAccount && (x.TaxCode == TaxCodes.GST_10 || x.TaxCode == TaxCodes.GST_FREE || x.TaxCode == TaxCodes.INPUT_TAXED)).Sum(x => x.NetPurchases + x.TaxPaid);
            G11 += taxTransactions.Where(x => !x.IsCapitalAccount && (x.TaxCode == TaxCodes.Deferred_GST_10)).Sum(x => x.NetPurchases + x.TaxPaid);
            G11 += taxTransactions.Where(x => !x.IsCapitalAccount && (x.TaxCode == TaxCodes.GST_10_ON_IMPORTS)).Sum(x => x.TaxPaid * 11m);

            var G13 = taxTransactions.Where(x => x.TaxCode == TaxCodes.INPUT_TAXED).Sum(x => x.NetPurchases);
            var G14 = taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_FREE).Sum(x => x.NetPurchases);

            var G20 = taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_10).Sum(x => x.TaxPaid);
            G20 += taxTransactions.Where(x => x.TaxCode == TaxCodes.GST_10_ON_IMPORTS).Sum(x => x.TaxAmount);
            G20 += _7A;

            var G5 = G2 + G3 + G4;
            var G1 = G5 + G8;
            var G6 = G8;
            var G7 = 0m;
            var G12 = G10 + G11;
            var G15 = 0m;
            var G16 = G13 + G14 + G15;
            var G17 = G12 - G16;
            var G18 = 0m;
            var G19 = G17;

            var _1A = G9;
            var _8A = _1A + _7A;
            var _1B = G20;
            var _8B = _1B;
            var _9 = _8B - _8A;

            G1 = decimal.Floor(G1);
            G2 = decimal.Floor(G2);
            G3 = decimal.Floor(G3);
            G4 = decimal.Floor(G4);
            G5 = decimal.Floor(G5);
            G6 = decimal.Floor(G6);
            G7 = decimal.Floor(G7);
            G8 = decimal.Floor(G8);
            G9 = decimal.Floor(G9);
            G10 = decimal.Floor(G10);
            G11 = decimal.Floor(G11);
            G12 = decimal.Floor(G12);
            G13 = decimal.Floor(G13);
            G14 = decimal.Floor(G14);
            G15 = decimal.Floor(G15);
            G16 = decimal.Floor(G16);
            G17 = decimal.Floor(G17);
            G18 = decimal.Floor(G18);
            G19 = decimal.Floor(G19);
            G20 = decimal.Floor(G20);

            _1A = decimal.Floor(_1A);
            _1B = decimal.Floor(_1B);
            _8A = decimal.Floor(_8A);
            _8B = decimal.Floor(_8B);
            _9 = decimal.Floor(_9);

            using (Style())
            {
                Write("table.taxReport th.section { background-color: #000; color: #fff; font-weight: bold; padding: 5px }");
                Write("table.taxReport td { padding: 5px; }");
                Write("table.taxReport td.amount div { min-width: 80px; padding: 3px; border: 1px solid #000; text-align: right; font-weight: bold; }");
                Write("table.taxReport td.gray div { font-weight: bold; text-align: center; background-color: #ccc; padding: 5px; }");
                Write("table.taxReport td.dollar-sign { text-align: right }");
            }

            using (Table(@class: "taxReport"))
            {
                using (Tr()) using (Th(colspan: 7, style: "font-weight: bold; font-size: 16px; text-align: center; padding-bottom: 10px")) Write(businessName);
                using (Tr()) using (Th(colspan: 7, style: "font-weight: bold; font-size: 24px; text-align: center; padding-bottom: 10px")) Write(Name);
                using (Tr()) using (Th(colspan: 7, style: "font-weight: bold; font-size: 16px; text-align: center; padding-bottom: 10px")) Write("From " + from.ToString("MMMM d, yyyy") + " until " + to.ToString("MMMM d, yyyy"));
                using (Tr()) using (Th(colspan: 7, style: "font-weight: bold; font-size: 16px; text-align: center; padding-bottom: 10px"))
                {
                    if (isCashBasis) Write("Cash basis");
                    if (!isCashBasis) Write("Acrual basis");
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 7, @class: "section")) Write("GST amounts you owe the Tax Office from sales");
                }
                using (Tr())
                {
                    using (Td()) Write("G1");
                    using (Td()) Write("Total sales (including any GST)");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G1.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G2");
                    using (Td()) Write("Export sales");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G2.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr())
                {
                    using (Td()) Write("G3");
                    using (Td()) Write("Other GST-free sales");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G3.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr())
                {
                    using (Td()) Write("G4");
                    using (Td()) Write("Input taxed sales");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G4.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Td()) Write("G5");
                    using (Td()) Write("G2 + G3 + G4");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G5.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G6");
                    using (Td()) Write("Total sales subject to GST (G1 minus G5)");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G6.ToString("#,0"));
                }
                using (Tr(@class: "line"))
                {
                    using (Td()) Write("G7");
                    using (Td()) Write("Adjustments");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G7.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G8");
                    using (Td()) Write("Total sales subject to GST after adjustments (G6 + G7)");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G8.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G9");
                    using (Td()) Write("GST on sales");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G9.ToString("#,0"));
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 8, @class: "section")) Write("GST amounts the Tax Office owes you from purchases");
                }
                using (Tr())
                {
                    using (Td()) Write("G10");
                    using (Td()) Write("Capital purchases (including any GST)");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G10.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr())
                {
                    using (Td()) Write("G11");
                    using (Td()) Write("Non-capital purchases (including any GST)");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G11.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Td()) Write("G12");
                    using (Td()) Write("G10 + G11");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G12.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G13");
                    using (Td()) Write("Purchases for making input taxed sales");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G13.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr())
                {
                    using (Td()) Write("G14");
                    using (Td()) Write("Purchases without GST in the price");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G14.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr())
                {
                    using (Td()) Write("G15");
                    using (Td()) Write("Purchases for private use or not income tax deductible");
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G15.ToString("#,0"));
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                }
                using (Tr(@class: "line"))
                {
                    using (Td()) Write("G16");
                    using (Td()) Write("G13 + G14 + G15");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G16.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G17");
                    using (Td()) Write("Total purchases subject to GST (G12 minus G16)");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G17.ToString("#,0"));
                }
                using (Tr(@class: "line"))
                {
                    using (Td()) Write("G18");
                    using (Td()) Write("Adjustments");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G18.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G19");
                    using (Td()) Write("Total purchases subject to GST after adjustments (G17 + G18)");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G19.ToString("#,0"));
                }
                using (Tr())
                {
                    using (Td()) Write("G20");
                    using (Td()) Write("GST on purchases");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(G20.ToString("#,0"));
                }
                using (Tr(@class: "line"))
                {
                    using (Th(colspan: 7, @class: "section")) Write("Summary");
                }
                using (Tr())
                {
                    using (Td()) Write("1A");
                    using (Td()) Write("GST on sales");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(_1A.ToString("#,0"));
                }
                if (taxTransactions.Any(x => x.TaxCode == TaxCodes.Deferred_GST_10))
                {
                    using (Tr())
                    {
                        using (Td()) Write("7A");
                        using (Td()) Write("Deferred GST");
                        using (Td()) { }
                        using (Td()) { }
                        using (Td()) { }
                        using (Td(@class: "dollar-sign")) Write("$");
                        using (Td(@class: "amount")) using (Div()) Write(_7A.ToString("#,0"));
                    }
                    using (Tr())
                    {
                        using (Td()) Write("8A");
                        using (Td()) Write("Total amount you owe the ATO (1A + 7A)");
                        using (Td()) { }
                        using (Td()) { }
                        using (Td()) { }
                        using (Td(@class: "dollar-sign")) Write("$");
                        using (Td(@class: "amount")) using (Div()) Write(_8A.ToString("#,0"));
                    }
                }
                using (Tr())
                {
                    using (Td()) Write("1B");
                    using (Td()) Write("GST on purchases");
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write(_1B.ToString("#,0"));
                }
                using (Tr())
                {
                    var total = _9;
                    using (Td()) Write("9");
                    using (Td())
                    {
                        if (total > 0) Write("Your refund");
                        else Write("Your payment");
                    }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td()) { }
                    using (Td(@class: "dollar-sign")) Write("$");
                    using (Td(@class: "amount")) using (Div()) Write((total < 0 ? (total * -1).ToString("#,0") : total.ToString("#,0")));
                }
            }
        }
    }
}