using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PxDataLoader.Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PxDataLoader
{
    class VariableFacade
    {
        public static List<Option> GetVariableList()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var varList = from v in context.Variables
                          select new Option() { Code = v.Variable1, Text = v.PresText };
            return varList.ToList();
        }

        public static Model.PxVariable GetVarible(string varId)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var varList = from v in context.Variables
                          where v.Variable1 == varId
                          select new Model.PxVariable() { Variable = v.Variable1, PresText = v.PresText, VariableInfo = v.VariableInfo, PresTextEnglish = v.Variable_Eng.PresText, IsNew = false };
            if (varList.Count() > 0)
            {
                return varList.First();
            }
            return null;
        }

        public static List<Option> GetValuePools()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var poolList = from v in context.ValuePools
                           select new Option() { Code = v.ValuePool1, Text = v.PresText };
            return poolList.ToList();
        }

        public static string GetValuepoolByValueSet(string valueset)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
            var valuePool = (from vp in context.ValueSets
                             where vp.ValueSet1 == valueset
                             select vp.ValuePool).ToList();

            if (valuePool.Count != 0)
            {
                return valuePool.First();
            }
            return null;
        }

        public static List<Option> GetValuesetsByValuePool(string valuePool)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var poolList = from v in context.ValueSets
                           where v.ValuePool == valuePool
                           select new Option() { Code = v.ValueSet1, Text = v.PresText };
            return poolList.ToList();
        }

        public static List<PxValueSet> GetValuesetsByValuePoolPxValueset(string valuePool)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var valuesetslList = (from v in context.ValueSets
                           where v.ValuePool == valuePool
                           select new PxValueSet() { 
                               Valueset = v.ValueSet1, 
                               PresText = v.PresText, 
                               ValuePool = v.ValuePool, 
                               Elimination = v.Elimination, 
                               PresTextEnglish=v.ValueSet_Eng.PresText, 
                               ValuePres=v.ValuePres, 
                               IsNew = false, 
                               IsDirty = false }).ToList();
            return valuesetslList;
        }

        public static Model.PxValueSet GetValueSet(string valueSet)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var varList = from v in context.ValueSets
                          where v.ValueSet1 == valueSet
                          select new Model.PxValueSet() { Valueset = v.ValueSet1, PresText = v.PresText, Elimination = v.Elimination, ValuePool = v.ValuePool, ValuePres = v.ValuePres, PresTextEnglish = v.ValueSet_Eng.PresText };
            if (varList.Count() != 0)
            {
                return varList.First();
            }
            return null;
        }

        public static List<Option> GetValuesListByValueset(string valueSet)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var valueList = from v in context.VSValues
                            where v.ValueSet == valueSet
                            select new Option() { Code = v.ValueCode, Text = v.Value.ValueTextL };
            return valueList.ToList();
        }

        public static List<Model.PxValue> GetValuesByValueset(string valueSet)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var valueList = (from v in context.VSValues
                            where v.ValueSet == valueSet
                            select new Model.PxValue() { ValueCode = v.ValueCode, ValuePool = v.ValuePool, ValueText = v.Value.ValueTextL, ValueTextEnglish = v.Value.Value_Eng.ValuetextL, IsNew = false, IsDirty = false }).ToList();
            foreach (var value in valueList)
            {
                var footnoteValues = (from fv in context.FootnoteValues
                                     where fv.ValuePool == value.ValuePool && fv.ValueCode == value.ValueCode
                                     select new Model.PxValueFootnote()
                                     {
                                         FootnoteNo = (int)fv.FootnoteNo,
                                         FootnoteText = fv.Footnote.FootnoteText,
                                         FootnoteTextEnglish = fv.Footnote.Footnote_Eng.FootnoteText,
                                         FootnoteType = fv.Footnote.FootnoteType,
                                         MandOption = fv.Footnote.MandOpt,
                                         ShowFootnote = fv.Footnote.ShowFootnote,
                                         IsDirty = false,
                                         IsNew = false
                                     }).ToList();
                foreach (var f in footnoteValues)
                {
                    value.ValueFootnotes.Add(f);
                }
              
            }
            return valueList
                ;

        }

        //public static bool CreateEntities(PxObject obj, ref string message)
        //{
        //    try
        //    {
        //        PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
        //        obj.CreateEntities(context);
        //        context.SaveChanges();
        //        obj.MarkAsOld();
        //    }
        //    catch (Exception ex)
        //    {
        //        //TODO chage the exception type to EF Exception and look for an inner exception.
        //        message = ex.Message;
        //        return false;
        //    }
        //    return true;
        //}

        public static List<Model.PxValue> GetValuesByValuePool(string valuepool)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var valueList = from v in context.Values
                            where v.ValuePool == valuepool
                            select new Model.PxValue() { ValueCode = v.ValueCode, ValueText = v.ValueTextL, ValueTextEnglish = v.Value_Eng.ValuetextL, IsNew = false };
            return valueList.ToList();
        }


        public static bool VariableExisit(string variableName)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var valueList = from v in context.Variables
                            where v.Variable1 == variableName
                            select new { ValueCode = v.Variable1 };
            return valueList.ToList().Count == 1;
        }


        public static PxMenuSelection GetMenuStart()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var mythemes = new PxMenuSelection() { Menu = "Start", PresText = "Start", LevelNo = "0", Description = "Start", Presentation = "A", PresTextS = "Start", SortCode = "A" };
            return mythemes;
        }

        public static void LoadChildren(PxMenuSelection parent)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var mythemes = (from theme in context.MenuSelections
                            where theme.Menu == parent.Menu
                            orderby theme.SortCode
                            select new PxMenuSelection()
                            {
                                Menu = theme.Selection,
                                PresText = theme.PresText,
                                LevelNo = theme.LevelNo,
                                Description = theme.Description,
                                Presentation = theme.Presentation,
                                PresTextS = theme.PresTextS,
                                SortCode = theme.SortCode,
                                PresTextEnglish = theme.MenuSelection_Eng.PresText,
                                PresTextSEnglish = theme.MenuSelection_Eng.PresTextS,
                                DescriptionEnglish = theme.MenuSelection_Eng.Description,
                                PresentationEnglish = theme.MenuSelection_Eng.Presentation,
                                SortCodeEnglish = theme.MenuSelection_Eng.SortCode
                            });
            foreach (var item in mythemes)
            {
                item.Parent = parent;
                parent.Childrens.Add(item);
            }

        }

        public static bool UpdateMenuSelection(PxMenuSelection selection)
        {
            try
            {
                PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

                var selectedMenu = from sm in context.MenuSelections
                                   where sm.Menu == selection.Parent.Menu && sm.Selection == selection.Menu
                                   select sm;
                PxMetaModel.MenuSelection ms = selectedMenu.First();
                ms.PresText = selection.PresText;
                ms.PresTextS = selection.PresTextS;
                ms.Presentation = selection.Presentation;
                ms.Description = selection.Description;
                ms.SortCode = selection.SortCode;
                ms.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                ms.LogDate = DateTime.Now;

                var selectedMenuEng = from sm in context.MenuSelection_Eng
                                      where sm.Menu == selection.Parent.Menu && sm.Selection == selection.Menu
                                      select sm;
                PxMetaModel.MenuSelection_Eng msEng = selectedMenuEng.First();
                msEng.PresText = selection.PresTextEnglish;
                msEng.PresTextS = selection.PresTextSEnglish;
                msEng.Presentation = selection.PresentationEnglish;
                msEng.Description = selection.DescriptionEnglish;
                msEng.SortCode = selection.SortCodeEnglish;
                msEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                msEng.LogDate = DateTime.Now;
                context.SaveChanges();
                selection.MarkAsOld();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


        public static PxMainTable GetMainTableById(string mainTable)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            var table = (from tbl in context.MainTables
                         where tbl.MainTable1 == mainTable
                         select new PxMainTable()
                         {
                             TableId = tbl.MainTable1,
                             ContentVariable = tbl.ContentsVariable,
                             PresText = tbl.PresText,
                             PressTextS = tbl.PresTextS,
                             PresCategory = tbl.PresCategory,
                             SpecCharExists = tbl.SpecCharExists,
                             ProductId = tbl.ProductId,
                             TableStatus = tbl.TableStatus,
                             Theme = tbl.SubjectCode,
                             TimeScaleId = tbl.TimeScale,
                             ContentVariableEnglish = tbl.MainTable_Eng.ContentsVariable,
                             TableTitleEnglish = tbl.MainTable_Eng.PresText,
                             EnglishPublished = tbl.MainTable_Eng.Published,
                             EnglishStatus = tbl.MainTable_Eng.Status,
                             IsNew = false,
                             IsDirty = false
                         }).FirstOrDefault();
            if (table != null)
            {

                var contents = (from cont in context.Contents
                                where cont.MainTable == mainTable
                                select new PxContent()
                                {
                                    Content = cont.Contents,
                                    AggregPossible = cont.AggregPossible,
                                    BasePeriod = cont.BasePeriod,
                                    CFPrices = cont.CFPrices,
                                    Copyright = cont.Copyright,
                                    DayAdj = cont.DayAdj,
                                    PresCellsZero = cont.PresCellsZero,
                                    PresDecimals = cont.PresDecimals,
                                    PresMissingLine = cont.PresMissingLine,
                                    PressTextS = cont.PresTextS,
                                    PresText = cont.PresText,
                                    Producer = cont.Producer,
                                    RefPeriod = cont.RefPeriod,
                                    SeasAdj = cont.SeasAdj,
                                    StatAuthority = cont.StatAuthority,
                                    StockFA = cont.StockFA,
                                    StoreColumnNo = cont.StoreColumnNo,
                                    StoreDecimals = cont.StoreDecimals,
                                    StoreFormat = cont.StoreFormat,
                                    StoreNoChar = cont.StoreNoChar,
                                    Unit = cont.Unit,
                                    IsNew = false,
                                    IsDirty = false,
                                    PressTextEnglish = cont.Contents_Eng.PresText,
                                    PressTextEnglishS = cont.Contents_Eng.PresTextS,
                                    UnitEnglish = cont.Contents_Eng.Unit,
                                    RefPeriodEnglish = cont.Contents_Eng.RefPeriod,
                                    BasePeriodEnglish = cont.Contents_Eng.BasePeriod
                                }).ToList();

                foreach (var content in contents)
                {
                    content.MainTable = table;
                    table.Contents.Add(content);
                    var timePeriods = (from tp in context.ContentsTimes
                                       where tp.Contents == content.Content && tp.MainTable == mainTable
                                       select new PxTime() { TimePeriod = tp.TimePeriod, IsNew = false, IsDirty = false }).ToList();
                    foreach (var timePeriod in timePeriods)
                    {
                        timePeriod.Content = content;
                        timePeriod.IsNew = false;
                        timePeriod.IsDirty = false;
                        content.TimePeriods.Add(timePeriod);
                    }
                    var contentFootnotes = (from f in context.FootnoteContents
                                            where f.MainTable == mainTable && f.Contents == content.Content
                                            select new PxContentFootnote()
                                            {

                                                FootnoteNo = (int)f.FootnoteNo,
                                                FootnoteType = f.Footnote.FootnoteType,
                                                ShowFootnote = f.Footnote.ShowFootnote,
                                                MandOption = f.Footnote.MandOpt,
                                                FootnoteText = f.Footnote.FootnoteText,
                                                FootnoteTextEnglish = f.Footnote.Footnote_Eng.FootnoteText,
                                                IsNew = false,
                                                IsDirty = false
                                            }).ToList();

                    foreach (var contentFootnote in contentFootnotes)
                    {
                        contentFootnote.MainTable = table;
                        contentFootnote.Content = content;
                        content.IsNew = false;
                        content.IsDirty = false;
                        content.Footnotes.Add(contentFootnote);
                    }
                }


                var variables = (from vb in context.SubTableVariables
                                 where vb.MainTable == mainTable && vb.SubTable == "1"
                                 orderby vb.StoreColumnNo
                                 select new PxVariable()
                                 {
                                     PresText = vb.Variable1.PresText,
                                     PresTextEnglish = vb.Variable1.Variable_Eng.PresText,
                                     VariableInfo = vb.Variable1.VariableInfo,
                                     ValueSet = vb.ValueSet,
                                     VariableType = vb.VariableType,
                                     StoreColumnNo = vb.StoreColumnNo,
                                     Variable = vb.Variable,
                                     IsNew = false,
                                     IsDirty = false
                                 }).ToList();

                foreach (var variable in variables)
                {
                    variable.MainTable = table;
                    table.Variables.Add(variable);
                    var variableFootnotes = (from vf in context.FootnoteVariables
                                             where vf.Variable == variable.Variable
                                             select new PxVariableFootnote()
                                             {

                                                 FootnoteNo = (int)vf.FootnoteNo,
                                                 FootnoteType = vf.Footnote.FootnoteType,
                                                 ShowFootnote = vf.Footnote.ShowFootnote,
                                                 MandOption = vf.Footnote.MandOpt,
                                                 FootnoteText = vf.Footnote.FootnoteText,
                                                 FootnoteTextEnglish = vf.Footnote.Footnote_Eng.FootnoteText,
                                                 IsNew = false,
                                                 IsDirty = false

                                             }).ToList();

                    foreach (var variableFootnote in variableFootnotes)
                    {
                        variableFootnote.Variable = variable;
                        variableFootnote.IsDirty = false;
                        variableFootnote.IsNew = false;
                        variable.VariableFootnotes.Add(variableFootnote);
                    }
                }

                foreach (var content in contents)
                {
                    foreach (var variable in variables)
                    {

                        var contentVariableFootnotes = (from cvf in context.FootnoteContVbls
                                                        where cvf.MainTable == mainTable && cvf.Contents == content.Content && cvf.Variable == variable.Variable
                                                        select new PxContentVariableFootnote()
                                                        {
                                                            FootnoteNo = (int)cvf.FootnoteNo,
                                                            FootnoteType = cvf.Footnote.FootnoteType,
                                                            ShowFootnote = cvf.Footnote.ShowFootnote,
                                                            MandOption = cvf.Footnote.MandOpt,
                                                            FootnoteText = cvf.Footnote.FootnoteText,
                                                            FootnoteTextEnglish = cvf.Footnote.Footnote_Eng.FootnoteText,
                                                            IsNew = false,
                                                            IsDirty = false
                                                        }).ToList();

                        foreach (var contentVariableFootnote in contentVariableFootnotes)
                        {
                            contentVariableFootnote.MainTable = table;
                            contentVariableFootnote.Content = content;
                            contentVariableFootnote.Variable = variable;
                            contentVariableFootnote.IsDirty = false;
                            contentVariableFootnote.IsNew = false;
                            content.ContentVariableFootnotes.Add(contentVariableFootnote);
                        }

                        var valuesOfVariable = GetValuesByValueset(variable.ValueSet);
                        foreach (var value in valuesOfVariable)
                        {
                            var contentValueFootnotes = (from cvf in context.FootnoteContValues
                                                         where cvf.MainTable == mainTable && cvf.Contents == content.Content && cvf.Variable == variable.Variable && cvf.ValuePool == value.ValuePool && cvf.ValueCode == value.ValueCode
                                                         select new PxContentValueFootnote()
                                                         {
                                                             FootnoteNo = (int)cvf.FootnoteNo,
                                                             FootnoteType = cvf.Footnote.FootnoteType,
                                                             ShowFootnote = cvf.Footnote.ShowFootnote,
                                                             MandOption = cvf.Footnote.MandOpt,
                                                             FootnoteText = cvf.Footnote.FootnoteText,
                                                             FootnoteTextEnglish = cvf.Footnote.Footnote_Eng.FootnoteText,
                                                             IsNew = false,
                                                             IsDirty = false
                                                         }).ToList();


                            foreach (var contentValueFootnote in contentValueFootnotes)
                            {
                                contentValueFootnote.MainTable = table;
                                contentValueFootnote.Content = content;
                                contentValueFootnote.Variable = variable;
                                contentValueFootnote.Value = value;
                                contentValueFootnote.IsDirty = false;
                                contentValueFootnote.IsNew = false;
                                content.ContentValueFootnotes.Add(contentValueFootnote);
                            }

                        }

                    }
                    foreach (var variable in variables)
                    {

                        var valuesOfVariable = GetValuesByValueset(variable.ValueSet);
                        foreach (var value in valuesOfVariable)
                        {
                            var mainTableValueFootnotes = (from mtf in context.FootnoteMaintValues
                                                           where mtf.MainTable == mainTable && mtf.Variable == variable.Variable && mtf.ValuePool == value.ValuePool && mtf.ValueCode == value.ValueCode
                                                           select new PxMainTableValueFootnote()
                                                           {
                                                               FootnoteNo = (int)mtf.FootnoteNo,
                                                               FootnoteType = mtf.Footnote.FootnoteType,
                                                               ShowFootnote = mtf.Footnote.ShowFootnote,
                                                               MandOption = mtf.Footnote.MandOpt,
                                                               FootnoteText = mtf.Footnote.FootnoteText,
                                                               FootnoteTextEnglish = mtf.Footnote.Footnote_Eng.FootnoteText,
                                                               IsNew = false,
                                                               IsDirty = false
                                                           }).ToList();

                            foreach (var maintableValueFootnote in mainTableValueFootnotes)
                            {
                                maintableValueFootnote.MainTable = table;
                                maintableValueFootnote.Variable = variable;
                                maintableValueFootnote.Value = value;
                                maintableValueFootnote.IsDirty = false;
                                maintableValueFootnote.IsNew = false;
                                table.MainTableValueFootnotes.Add(maintableValueFootnote);
                            }
                        }
                    }

                }

                var footnotes = (from f in context.FootnoteMainTables
                                 where f.MainTable == mainTable
                                 select new PxMainTableFootnote()
                                 {
                                     FootnoteNo = (int)f.FootnoteNo,
                                     FootnoteType = f.Footnote.FootnoteType,
                                     ShowFootnote = f.Footnote.ShowFootnote,
                                     MandOption = f.Footnote.MandOpt,
                                     FootnoteText = f.Footnote.FootnoteText,
                                     FootnoteTextEnglish = f.Footnote.Footnote_Eng.FootnoteText,
                                     IsNew = false,
                                     IsDirty = false

                                 }).ToList();

                foreach (var footnote in footnotes)
                {
                    footnote.MainTable = table;
                    footnote.IsNew = false;
                    footnote.IsDirty = false;
                    table.Footnotes.Add(footnote);
                }


                return table;
            }
            else
            {
                return null;
            }
        }



        public static bool AddContentsTime(PxMainTable mainTable)
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

            foreach (var content in mainTable.Contents)
            {
                foreach (var timePeriod in content.TimePeriods)
                {
                    timePeriod.CreateEntities(context);
                }

            }

            if (mainTable.TableStatus != "M")
            {
                mainTable.TableStatus = "U";
                mainTable.Save(context);
            }

            try
            {
                context.SaveChanges();

                foreach (var content in mainTable.Contents)
                {
                    foreach (var timePeriod in content.TimePeriods)
                    {
                        timePeriod.MarkAsOld();
                    }

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public static bool CreateDataTable(PxMainTable table, ref string msg)
        {


            try
            {
                //Create the table
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PcAxisDatabase"].ConnectionString);
                
                
                SqlCommand sc = new System.Data.SqlClient.SqlCommand(CreateDataTableCreateCommand(table), conn);
                conn.Open();
                sc.ExecuteNonQuery();
                conn.Close();

                //Update TableStatus to E in database
                table.TableStatus = "E";

                PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
                var tbl = (from mt in context.MainTables
                           where mt.MainTable1 == table.TableId
                           select mt).First();

                tbl.TableStatus = "E";

                context.SaveChanges();

            }
            catch (SqlException ex)
            {
                if (ex.InnerException != null)
                {
                    msg = ex.InnerException.Message;
                }
                else
                {
                    msg = ex.Message;
                }
                return false;

            }


            return true;
        }

        private static string CreateDataTableCreateCommand(PxMainTable table)
        {
            string createCommand = "CREATE TABLE " + table.TableId + "1" + "  (";
            foreach (var i in table.Variables)
            {
                createCommand += i.Variable + " varchar(255), ";

            }
            //createCommand = createCommand.Substring(0, createCommand.Length - 2); //remove the last comma
            string formatType = "";

            foreach (var c in table.Contents)
            {
                switch (c.StoreFormat)
                {
                    case "C":
                        formatType = "varchar(255)";
                        break;
                    case "I":
                        formatType = "int";
                        break;
                    case "S":
                        formatType = "int";
                        break;
                    case "N":
                        formatType = "float";
                        break;
                    default:
                        formatType = "varchar(255)";
                        break;
                }//TODO find columntype from storeformat
                createCommand += c.Content + " " + formatType + ", ";
            }
            createCommand = createCommand.Substring(0, createCommand.Length - 2); //remove the last comma
            createCommand += ")";

            return createCommand;
        }

        public static bool DeleteDataTable(string mainTable, ref string msg) 
        {
             try
            {
                SqlConnection connAxis = new SqlConnection(ConfigurationManager.ConnectionStrings["PcAxisDatabase"].ConnectionString);
 
                String dropString = "IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[" + mainTable + "1" + "]') AND type in (N'U')) DROP TABLE [dbo].[" + mainTable + "1" + "]";

                SqlCommand cmdDrop = new SqlCommand(dropString, connAxis);
                connAxis.Open();
                cmdDrop.ExecuteNonQuery();
                connAxis.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null)
                {
                    msg = ex.Message;
                }
                else 
                {
                    msg = ex.InnerException.Message;
                }

                return false;
            }
        }

        public static bool Save(PxObject obj, ref string message)
        {
            try
            {
                PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
                obj.Save(context);
                context.SaveChanges();
                obj.MarkAsOld();
            }
            catch (Exception ex)
            {
                //TODO chage the exception type to EF Exception and look for an inner exception.
                if (string.IsNullOrEmpty(ex.InnerException.Message)) 
                {
                    message = ex.Message;
                }
                else 
                {
                    message = ex.InnerException.Message;
                }
                return false;
            }
            return true;

        }

        public static bool Delete(PxObject obj, ref string message)
        {
            try
            {
                if (obj == null) return true;
                PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();

                obj.DeleteEntities(context);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                //TODO chage the exception type to EF Exception and look for an inner exception.
                if (ex.InnerException == null)
                {
                    message = ex.Message;
                }
                else
                {
                    message = ex.InnerException.Message;
                }
                return false;
            }
            return true;

        }

        public static int GetFootnoteNextId()
        {
            PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
            int maxID = 0;
            if ((from f in context.Footnotes
                 select f.FootnoteNo).Count() != 0)
            {
                maxID = (int)(from f in context.Footnotes
                              select f.FootnoteNo).Max();
            }
             maxID++;
             return maxID;
        }

        public static bool DataInsertInDb(PxMainTable mt, string excelPath, ref string message)
        {

            if (System.IO.File.Exists(excelPath))
            {
                string qryExcel;
                //string qrySecondPart;
                //qrySecondPart = String.Format(" FROM OPENROWSET('Microsoft.Jet.OLEDB.4.0', 'Excel 8.0;Database={0};HDR=YES', 'SELECT * FROM [Data$]'", ExcelSource._path);
                qryExcel = "SELECT ";

                int countVariables;


                countVariables = mt.Variables.Count;


                qryExcel = GetExcelQueryForDataLoading(mt);

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PcAxisDatabase"].ConnectionString);
                try
                {
                    
                    DataTable dt = GetSheetDataForInsert(qryExcel, excelPath);
                    List<DataRow> drToRemove = new List<DataRow>();
                    
                    foreach (DataRow row in dt.Rows)
                    {
                        if (String.IsNullOrEmpty(row[0].ToString()) )
                        {
                            drToRemove.Add(row);
                        }
                    }

                    foreach (DataRow row in drToRemove)
                    {
                        dt.Rows.Remove(row);
                    }
                    SqlBulkCopy sbc = new SqlBulkCopy(conn);
                    sbc.DestinationTableName = mt.TableId + 1;
                    conn.Open();
                    sbc.WriteToServer(dt);
                    conn.Close();
                    PxMetaModel.PcAxisMetabaseEntities context = new PxMetaModel.PcAxisMetabaseEntities();
                    mt.TableStatus = "O";
                    Save(mt, ref message);
                    
                }
                catch (Exception ex)
                {

                    conn.Close();
                    message = ex.ToString();
                    return false;
                }
                return true;
            }
            return false;
        }

        public static DataTable GetSheetDataForInsert(string qryExcel, string path)
        {
            var conn = new System.Data.OleDb.OleDbConnection(
                String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';", path));
            DataSet ds = new DataSet();

            var adapter = new System.Data.OleDb.OleDbDataAdapter(
                qryExcel, conn);
            adapter.Fill(ds);

            return ds.Tables[0];
        }

        private static string GetExcelQueryForDataLoading(PxMainTable table)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT ");
            for (int i = 0; i < table.Variables.Count; i++)
            {
                sb.Append("Variable" + (i+1).ToString() + ", ");
            }

            for (int i = 0; i < table.Contents.Count; i++)
            {
                sb.Append("Content" + (i + 1).ToString());
                if (i != table.Contents.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append( " FROM [Data$]");
            return sb.ToString();
        }


        public static List<string> GetTimeValuesFormExcel(string excelFile)
        {
            List<string> list = new List<string>();
            for (int i = 1; i < 6; i++)
            {
                string q = String.Format("SELECT ValueText FROM [Variable{0}$]", i);
                DataTable dt = GetSheetDataForInsert(q, excelFile);

                if (dt.Rows.Count > 0)
                { 
                    string t = dt.Rows[0][0].ToString();
                    if (t.Length > 3)
                    {
                        int x;
                        if (int.TryParse(t.Substring(0,4), out x))
                        {
                            if (x > 1500)
                            {
                                foreach (DataRow row in dt.Rows)
                                {
                                    string time = row[0].ToString().Trim();
                                    if (!string.IsNullOrWhiteSpace(time))
                                    {
                                        list.Add(time);
                                    }
                                }
                                return list;
                            }
                        }
                    }
                }
            }
            return list;
            
        }
    }
}
