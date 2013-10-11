using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PxDataLoader.Model;
using System.Data;

namespace PxDataLoader.Import
{
    class TableBuilder
    {
        public static PxMainTable BuildTableFromFile(string path, string tableId)
        { 
            PxMainTable tbl = new  PxMainTable();

            tbl.TableId = tableId;

            ExcelFileWrapper excel = new ExcelFileWrapper(path);

            BuildContents(excel.GetSheetData("Contents"), tbl);
            BuildVariables(excel.GetSheetData("Variables"), tbl);


            return tbl;
        }

        private static void BuildContents(DataTable contents, PxMainTable table)
        {
            var cont = from c in contents.AsEnumerable()
                                   where c.Field<string>("Id") != null
                                   select new PxContent 
                                   { Content = c.Field<string>("Id"), 
                                     PresText = c.Field<string>("Text"),
                                     PressTextS = c.Field<string>("Text"),
                                     Copyright = GetCopyright(c.Field<string>("CopyRight")),
                                     Unit = c.Field<string>("Unit"),
                                     RefPeriod = c.Field<string>("RefPeriod"),

                                     StockFA = c.Field<string>("StockFlowAverage") != "Other" ? c.Field<string>("StockFlowAverage")[0].ToString(): "X",
                                     BasePeriod = c.Field<string>("BasePeriod"),
                                     CFPrices = GetCFPrices(c.Field<string>("CurrentFixPrices")),
                                     DayAdj = GetYesNo(c.Field<string>("DayAdj")),
                                     SeasAdj = GetYesNo(c.Field<string>("SeasAdj")),
                                     StoreFormat = GetStoreFormat(c.Field<string>("StoreFormat")),
                                     StoreNoChar = c.IsNull("StoreNoChar") ? (short)0 : (short)c.Field<double>("StoreNoChar"),
                                     StoreDecimals = c.IsNull("StoreDecimals") ? (short)0 : (short)c.Field<double>("StoreDecimals"),
                                     FootnoteContents = "N",
                                     FootnoteVariable = "N",
                                     FootnoteTime = "N",
                                     FootnoteValue = "N",
                                     PressTextEnglish = c.Field<string>("EnglishText"),
                                     PressTextEnglishS = c.Field<string>("EnglishText"),
                                     UnitEnglish = c.Field<string>("EnglishUnit"),
                                     RefPeriodEnglish = c.Field<string>("EnglishRefPeriod"),
                                     BasePeriodEnglish = c.Field<string>("EnglishBasePeriod"),
                                     StatAuthority = "INSTAT",
                                     Producer = "INSTAT"
                                   };

                    foreach (var item in cont)
	                {
		                 table.Contents.Add(item);
	                }
        }


        private static void BuildVariables(DataTable variables, PxMainTable table)
        {
            var vari = from c in variables.AsEnumerable()
                            where c.Field<string>("Name") != null
                            select 
                            new PxVariable { 
                                Variable = c.Field<string>("Name"), 
                                PresText = c.Field<string>("PressText"),
                                PresTextEnglish = c.Field<string>("EnglishName"),
                                Footnote = "N",
                                VariableType = GetVariableType(c.Field<string>("Name"))
                            };

            foreach (var item in vari)
            {
                var variable = VariableFacade.GetVarible(item.Variable);
                if (variable != null)
                { 
                    if (String.Compare(variable.Variable, item.Variable, true) == 0 )
                    {
                        if (String.Compare(variable.PresText, item.PresText, true) == 0)
                        {
                            item.IsNew = false;
                        }
                        else
                        {
                            item.Variable = item.Variable + Guid.NewGuid().ToString();
                        }
                        
                    }
                }
                table.Variables.Add(item);
            }
        }

        #region "Conversion methods"

        private static string GetCopyright(string text)
        {
            switch (text)
            {
                case "Offical Statistic (No copyright)":
            return "1";
                case "Unofficial Statistic (No copyright)":
            return "2";
                case "Unofficial Statistic (Copyright)":
            return "3";
                default:
                    break;
            }
            return "1";
        }

        private static string GetStoreFormat(string text)
        {
            switch (text)
            {
                case "Character":
                    return "C";
                case "Integer":
                    return "I";
                case "Numeric":
                    return "N";
                default:
                    break;
            }
            return "N";
        }


        private static string GetYesNo(string text)
        {
            switch (text)
            {
                case "Yes":
                    return "Y";
                case "No":
                    return "N";
                default:
                    break;
            }
            return "";
        }

        private static string GetCFPrices(string text)
        {
            switch (text)
            {
                case "Current":
                    return "C";
                case "Fix":
                    return "F";
                default:
                    break;
            }
            return "";
        }


        private static string GetVariableType(string text)
        {
            if (string.Compare(text, "year", true) == 0 || string.Compare(text, "time", true) == 0 || string.Compare(text, "date", true) == 0)
            { return "T"; }

            return "V";
        }


        #endregion
    }
}
