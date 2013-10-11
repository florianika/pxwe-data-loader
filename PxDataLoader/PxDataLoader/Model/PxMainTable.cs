using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxMainTable : PxObject, INotifyPropertyChanged
    {

        #region "Public properties"


        private string _tableStatus;

        public string TableStatus 
        {
            get
            {
                return _tableStatus;
            }
            set
            {
                if (value != _tableStatus)
                {
                    IsDirty = true;
                    _tableStatus = value;
                    NotifyPropertyChanged("TableStatus");
                }
            }
        }

        private string _presText;
        public string PresText
        {
            get { return _presText; }
            set
            {
                if (value != _presText)
                {
                    IsDirty = true;
                    _presText = value;
                    NotifyPropertyChanged("PressText");
                }
            }
        }

        private string _presTextS;
        public string PressTextS 
        {
            get
            {
                return _presTextS;
            }
            set
            {
                if (value != _presTextS)
                {
                    IsDirty = true;
                    _presTextS = value;
                    NotifyPropertyChanged("PressTextS");
                }
            }
        }

        private string _contentVariable;
        public string ContentVariable 
        {
            get
            {
                return _contentVariable;
            }
            set
            {
                if (value != _contentVariable)
                {
                    IsDirty = true;
                    _contentVariable = value;
                    NotifyPropertyChanged("ContentVariable");
                }
            }
        }

        private string _tableId;
        public string TableId 
        {
            get
            {
                return _tableId;
            }
            set
            {
                if (value != _tableId)
                {
                    IsDirty = true;
                    _tableId = value;
                    NotifyPropertyChanged("TableId");
                }
            }
        }


        private string _presCategry;
        public string PresCategory 
        {
            get
            {
                return _presCategry;
            }
            set
            {
                if (value != _presCategry)
                {
                    IsDirty = true;
                    _presCategry = value;
                    NotifyPropertyChanged("PresCategory");
                }
            }
        }


        private string _specCharExists;
        public string SpecCharExists 
        {
            get
            {
                return _specCharExists;
            }
            set
            {
                if (value != _specCharExists)
                {
                    IsDirty = true;
                    _specCharExists = value;
                    NotifyPropertyChanged("SpecCharExists");
                }
            }
        }

        //SubjectCode

        private string _theme;
        public string Theme 
        {
            get
            {
                return _theme;
            }
            set
            {
                if (value != _theme)
                {
                    IsDirty = true;
                    _theme = value;
                    NotifyPropertyChanged("Theme");
                }
            }
        }

        private string _productId;
        public string ProductId 
        {
            get
            {
                return _productId;
            }
            set
            {
                if (value != _productId)
                {
                    IsDirty = true;
                    _productId = value;
                    NotifyPropertyChanged("ProductId");
                }
            }

        }

        private string _timeScaleId;
        public string TimeScaleId 
        { 
            get
            {
                return _timeScaleId;
            }
            set
            {
                if (value != _timeScaleId)
                {
                    IsDirty = true;
                    _timeScaleId = value;
                    NotifyPropertyChanged("TimeScaleId");
                }
            }
        }


        #region "English"

        private string _englishStatus;
        public string EnglishStatus 
        {
            get
            {
                return _englishStatus;
            }
            set
            {
                if (value != _englishStatus)
                {
                    IsDirty = true;
                    _englishStatus = value;
                    NotifyPropertyChanged("EnglishStatus");
                }

            }
        }

        private string _englishPublished;
        public string EnglishPublished 
        {
            get
            {
                return _englishPublished;
            }
            set
            {
                if (value != _englishPublished)
                {
                    IsDirty = true;
                    _englishPublished = value;
                    NotifyPropertyChanged("EnglishPublished");
                }
            }
        }

        //PresText PresTextS

        private string _tableTitleEnglish;
        public string TableTitleEnglish 
        {
            get
            {
                return _tableTitleEnglish;
            }
            set
            {
                if (value != _tableTitleEnglish)
                {
                    IsDirty = true;
                    _tableTitleEnglish = value;
                    NotifyPropertyChanged("TableTitleEnglish");
                }
            }
        }

        private string _contentVariableEnglish;
        public string ContentVariableEnglish 
        {
            get
            {
                return _contentVariableEnglish;
            }
            set
            {
                if (value != _contentVariableEnglish)
                {
                    IsDirty = true;
                    _contentVariableEnglish = value;
                    NotifyPropertyChanged("ContentVariableEnglish");
                }
            }
        }

        #endregion

        BindingList<PxContent> _contents;
        public BindingList<PxContent> Contents { get { return _contents; } }

        BindingList<PxVariable> _variables;
        public BindingList<PxVariable> Variables { get { return _variables; } }

        private List<PxVariable> _removedVariables;
        public List<PxVariable> RemovedVariables { get { return _removedVariables; } }

        private List<PxContent> _removedContents;
        public List<PxContent> RemovedContents { get { return _removedContents; } }

        private BindingList<PxMainTableFootnote> _footnotes;
        public BindingList<PxMainTableFootnote> Footnotes { get { return _footnotes; } }

        private List<PxMainTableFootnote> _removedFootnotes;
        public List<PxMainTableFootnote> RemovedFootnotes { get { return _removedFootnotes; } }

        private BindingList<PxMainTableValueFootnote> _mainTableValueFootnotes;
        public BindingList<PxMainTableValueFootnote> MainTableValueFootnotes { get { return _mainTableValueFootnotes; } }

        private List<PxMainTableValueFootnote> _removedMainTableValueFootnotes;
        public List<PxMainTableValueFootnote> RemovedMainTableValueFootnotes { get { return _removedMainTableValueFootnotes; } }

        #endregion

        public PxMainTable()
        {
            _contents = new BindingList<PxContent>();
            _variables = new BindingList<PxVariable>();
            _removedVariables = new List<PxVariable>();
            _removedContents = new List<PxContent>();
            _footnotes = new BindingList<PxMainTableFootnote>();
            _removedFootnotes = new List<PxMainTableFootnote>();
            _mainTableValueFootnotes = new BindingList<PxMainTableValueFootnote>();
            _removedMainTableValueFootnotes = new List<PxMainTableValueFootnote>();
            TableStatus = "M";
            ProductId = Properties.Settings.Default.ProductId;
            IsNew = true;
        }

                #region "Validation"
        
        public override bool Validate(ref string message)
        {

            if (String.IsNullOrWhiteSpace(TableId) ||
                String.IsNullOrWhiteSpace(PresText) ||
                String.IsNullOrWhiteSpace(PresCategory) ||
                String.IsNullOrWhiteSpace(SpecCharExists) ||
                String.IsNullOrWhiteSpace(Theme) ||
                String.IsNullOrWhiteSpace(TimeScaleId))
            {
                message = "Please enter a valid option for all input fields marked with * for Main Table";
                return false;
            }

            foreach (var content in _contents)
            {
                if (!content.Validate(ref message))
                {
                    return false;
                }
            }

            foreach (var variable in _variables)
            {
                if (!variable.Validate(ref message))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region "Entities creation"

        public override void MarkAsOld()
        {
            base.MarkAsOld();
            foreach (var content in Contents)
            {
                content.MarkAsOld();
            }
            foreach (var variable in Variables)
            {
                variable.MarkAsOld();
            }
            _removedVariables.Clear();

            foreach (var f in Footnotes)
            {
                f.MarkAsOld();
            }
            _removedFootnotes.Clear();
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                PxMetaModel.MainTable mainTable = new PxMetaModel.MainTable();

                mainTable.MainTable1 = TableId;
                mainTable.PresText = PresText;
                mainTable.PresTextS = PressTextS;
                mainTable.TableStatus = TableStatus;
                mainTable.SpecCharExists = SpecCharExists;
                mainTable.ContentsVariable = ContentVariable;
                mainTable.TableId = TableId;
                mainTable.PresCategory = PresCategory;
                mainTable.ProductId = ProductId;
                mainTable.SubjectCode = Theme;
                mainTable.TimeScale = TimeScaleId;
                mainTable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                mainTable.LogDate = DateTime.Now;

                context.AddToMainTables(mainTable);

                PxMetaModel.MainTable_Eng mainTableEng = new PxMetaModel.MainTable_Eng();
                mainTableEng.MainTable1 = mainTable;
                mainTableEng.PresText = TableTitleEnglish;
                mainTableEng.PresTextS = TableTitleEnglish;
                mainTableEng.Status = EnglishStatus;
                mainTableEng.Published = EnglishPublished;
                mainTableEng.ContentsVariable = ContentVariableEnglish;
                mainTableEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                mainTableEng.LogDate = DateTime.Now;

                context.AddToMainTable_Eng(mainTableEng);

                short counter = 0;
                foreach (var content in _contents)
                {
                    counter++;
                    content.StoreColumnNo = counter;
                    content.MainTable = this;
                    content.Save(context);
                 
                }

                PxMetaModel.SubTable subTable = new PxMetaModel.SubTable();
                subTable.MainTable1 = mainTable;
                subTable.SubTable1 = "1";
                subTable.PresText = mainTable.PresText;
                subTable.CleanTable = "X";
                subTable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                subTable.LogDate = DateTime.Now;

                context.AddToSubTables(subTable);

                PxMetaModel.SubTable_Eng subTableEng = new PxMetaModel.SubTable_Eng();
                subTableEng.SubTable1 = subTable;
                subTableEng.PresText = mainTableEng.PresText;
                subTableEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                subTableEng.LogDate = DateTime.Now;

                counter = 0;
                foreach (var variable in _variables)
                {
                    counter++;
                    variable.StoreColumnNo = counter;
                    variable.MainTable = this;
                    variable.Save(context);
                }

                foreach (var footnote in Footnotes)
                {
                    footnote.MainTable = this;

                    footnote.Save(context);
                }

                foreach (var mainTableValueFootnote in MainTableValueFootnotes)
                {
                    mainTableValueFootnote.MainTable = this;
                    mainTableValueFootnote.Save(context);
                }



            }
        }
        #endregion

        #region "Update entities"
        public override void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (!IsNew)
            {
                var mainTable = (from mt in context.MainTables
                                 where mt.MainTable1 == TableId
                                 select mt).First();

                mainTable.PresText = PresText;
                mainTable.PresTextS = PressTextS;
                mainTable.TableStatus = TableStatus;
                mainTable.SpecCharExists = SpecCharExists;
                mainTable.ContentsVariable = ContentVariable;
                mainTable.PresCategory = PresCategory;
                mainTable.TimeScale = TimeScaleId;
                mainTable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                mainTable.LogDate = DateTime.Now;

                var mainTableEng = (from mte in context.MainTable_Eng
                                    where mte.MainTable == TableId
                                    select mte).First();
                mainTableEng.PresText = TableTitleEnglish;
                mainTableEng.PresTextS = TableTitleEnglish;
                mainTableEng.Status = EnglishStatus;
                mainTableEng.Published = EnglishPublished;
                mainTableEng.ContentsVariable = ContentVariableEnglish;
                mainTableEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                mainTableEng.LogDate = DateTime.Now;

            }

            short counter = 0;
            foreach (var content in _contents)
            {
                counter++;
                content.StoreColumnNo = counter;
                content.MainTable = this;
                content.Save(context);
            }

            counter = 0;
            foreach (var variable in _variables)
            {
                counter++;
                variable.StoreColumnNo = counter;
                variable.MainTable = this;
                variable.Save(context);

               
            }

            foreach (var f in Footnotes)
            {
                f.MainTable = this;
                f.Save(context);
            }

            foreach (var mainTableValueFootnote in MainTableValueFootnotes)
            {
                mainTableValueFootnote.MainTable = this;
                mainTableValueFootnote.Save(context);
            }
            foreach (var variable in _removedVariables)
            {
                variable.DeleteEntities(context);
            }


            foreach (var content in RemovedContents) 
            {
                content.DeleteEntities(context);
            }

            foreach (var footnote in RemovedFootnotes)
            {
                footnote.DeleteEntities(context);
            }
            
        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            if (!IsNew)
            {
                foreach (var content in _contents)
                {
                    content.DeleteEntities(context);
                }

                foreach (var variable in _variables)
                {
                    variable.DeleteEntities(context);
                }

                var subTable_Eng = (from st in context.SubTable_Eng
                                where st.MainTable == this.TableId && st.SubTable == "1"
                                select st).FirstOrDefault();
                if (subTable_Eng != null)
                {
                    context.DeleteObject(subTable_Eng);
                }

                var subTable = (from st in context.SubTables
                                where st.MainTable == this.TableId && st.SubTable1 == "1"
                                select st).FirstOrDefault();
                if (subTable != null)
                {
                    context.DeleteObject(subTable);
                }

                foreach (var f in Footnotes)
                {

                    f.DeleteEntities(context);
                }

                foreach (var mainTableValueFootnote in MainTableValueFootnotes)
                {
                    mainTableValueFootnote.DeleteEntities(context);
                }
                foreach (var variable in _removedVariables)
                {
                    variable.DeleteEntities(context);
                }


                foreach (var content in RemovedContents)
                {
                    content.DeleteEntities(context);
                }

                foreach (var footnote in RemovedFootnotes)
                {
                    footnote.DeleteEntities(context);
                }
                var mainTableEng = (from mte in context.MainTable_Eng
                                    where mte.MainTable == TableId
                                    select mte).FirstOrDefault();
                if (mainTableEng != null)
                {
                    context.DeleteObject(mainTableEng);
                }

                var mainTable = (from mt in context.MainTables
                                 where mt.MainTable1 == TableId
                                 select mt).FirstOrDefault();

                if (mainTable != null)
                {
                    context.DeleteObject(mainTable);
                }

             
            }

          
          
            
        }
        #endregion
    }
}
