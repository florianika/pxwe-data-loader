using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxContent : PxObject, INotifyPropertyChanged
    {

        #region "Public properties"

        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                if (value != _content)
                {
                    _content = value;
                    IsDirty = true;
                    NotifyPropertyChanged("Content");
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
                    _presText = value;
                    IsDirty = true;
                    NotifyPropertyChanged("PressText");
                }
            }
        }

        private string _presTestS;
        public string PressTextS
        {
            get
            {
                return _presTestS;
            }
            set
            {
                if (value != _presTestS)
                {
                    IsDirty = true;
                    _presTestS = value;
                    NotifyPropertyChanged("PressTextS");
                }
            }
        }

        private string _copyright;
        public string Copyright 
        {
            get
            {
                return _copyright;
            }
            set
            {
                if (value != _copyright)
                {
                    IsDirty = true;
                    _copyright = value;
                    NotifyPropertyChanged("Copyright");
                }
            }
        }

        private string _statAuthority;
        public string StatAuthority 
        {
            get
            {
                return _statAuthority;
            }

            set
            {
                if (value != _statAuthority)
                {
                    IsDirty = true;
                    _statAuthority = value;
                    NotifyPropertyChanged("StatAuthority");
                }
            }
        }


        private string _producer;
        public string Producer 
        {
            get
            {
                return _producer;
            }
            set
            {
                if (value != _producer)
                {
                    IsDirty = true;
                    _producer = value;
                    NotifyPropertyChanged("Producer");
                }
            }
        }

        private string _unit;
        public string Unit 
        {
            get
            {
                return _unit;
            }
            set
            {
                if (value != _unit)
                {
                    IsDirty = true;
                    _unit = value;
                    NotifyPropertyChanged("Unit");
                }
            }
        }

        private short _presDecimals;
        public short PresDecimals 
        {
            get
            {
                return _presDecimals;
            }
            set
            {
                if (value != _presDecimals)
                {
                    IsDirty = true;
                    _presDecimals = value;
                    NotifyPropertyChanged("PresDecimals");
                }
            }
        }

        private string _presCellZero;
        public string PresCellsZero 
        {
            get
            {
                return _presCellZero;
            }
            set
            {
                if (value != _presCellZero)
                {
                    IsDirty = true;
                    _presCellZero = value;
                    NotifyPropertyChanged("PresCellsZero");

                }
            }
        }

        private string _presMissingLine;
        public string PresMissingLine 
        {
            get
            {
                return _presMissingLine;
            }
            set
            {
                if (value != _presMissingLine)
                {
                    IsDirty = true;
                    _presMissingLine = value;
                    NotifyPropertyChanged("PresMissingLine");
                }
            }
        }


        private string _aggregPossible;
        public string AggregPossible 
        {
            get
            {
                return _aggregPossible;
            }
            set
            {
                if (value != _aggregPossible)
                {
                    IsDirty = true;
                    _aggregPossible = value;
                    NotifyPropertyChanged("AggregPossible");
                }
            }
        }

        private string _refPeriod;
        public string RefPeriod 
        {
            get
            {
                return _refPeriod;
            }
            set
            {
                if (value != _refPeriod)
                {
                    IsDirty = true;
                    _refPeriod = value;
                    NotifyPropertyChanged("RefPeriod");
                }
            }
        }

        private string _stockFA;
        public string StockFA 
        {
            get
            {
                return _stockFA;
            }
            set
            {
                if (value != _stockFA)
                {
                    IsDirty = true;
                    _stockFA = value;
                    NotifyPropertyChanged("StockFA");
                }
            }

        }


        private string _basePeriod;
        public string BasePeriod 
        {
            get
            {
                return _basePeriod;
            }
            set
            {
                if (value != _basePeriod)
                {
                    IsDirty = true;
                    _basePeriod = value;
                    NotifyPropertyChanged("BasePeriod");
                }
            }
        }

        private string _cFPrices;
        public string CFPrices 
        {
            get
            {
                return _cFPrices;
            }
            set
            {
                if (value != _cFPrices)
                {
                    IsDirty = true;
                    _cFPrices = value;
                    NotifyPropertyChanged("CFPrices");
                }
            }
        }

        private string _dayAdj;
        public string DayAdj 
        {
            get
            {
                return _dayAdj;
            }
            set
            {
                if (value != _dayAdj)
                {
                    IsDirty = true;
                    _dayAdj = value;
                    NotifyPropertyChanged("DayAdj");
                }
            }
        }

        private string _seasAdj;
        public string SeasAdj
        {
            get
            {
                return _seasAdj;
            }
            set
            {
                if (value != _seasAdj)
                {
                    IsDirty = true;
                    _seasAdj = value;
                    NotifyPropertyChanged("SeasAdj");
                }
            }
        }

        private short _storeColumnNo;
        public short StoreColumnNo 
        {
            get
            {
                return _storeColumnNo;
            }
            set
            {
                if (value != _storeColumnNo)
                {
                    IsDirty = true;
                    _storeColumnNo = value;
                    NotifyPropertyChanged("StoreColumnNo");
                }
            }
        }

        private string _storeFormat;
        public string StoreFormat 
        {
            get
            {
                return _storeFormat;
            }
            set
            {
                if (value != _storeFormat)
                {
                    IsDirty = true;
                    _storeFormat = value;
                    NotifyPropertyChanged("StoreFormat");
                }
            }
        }

        private short _storeNoChar;
        public short StoreNoChar 
        {
            get
            {
                return _storeNoChar;
            }
            set
            {
                if (value != _storeNoChar)
                {
                    IsDirty = true;
                    _storeNoChar = value;
                    NotifyPropertyChanged("StoreNoChar");
                }
            }
        }

        private short _storeDecimals;
        public short StoreDecimals 
        {
            get
            {
                return _storeDecimals;
            }
            set
            {
                if (value != _storeDecimals)
                {
                    IsDirty = true;
                    _storeDecimals = value;
                    NotifyPropertyChanged("StoreDecimals");
                }
            }
        }

        private PxMainTable _mainTable;
        public PxMainTable MainTable
        {
            get
            {
                return _mainTable;
            }
            set
            {
                if (value != _mainTable)
                {
                    IsDirty = true;
                    _mainTable = value;
                    NotifyPropertyChanged("MainTable");
                }
            }
        }

        private string _footnoteContents;
        public string FootnoteContents
        {
            get
            {
                return _footnoteContents;
            }
            set
            {
                if (value != _footnoteContents)
                {
                    IsDirty = true;
                    _footnoteContents = value;
                    NotifyPropertyChanged("FootnoteContents");
                }
            }
        }

        private string _footnoteTime;
        public string FootnoteTime 
        {
            get
            {
                return _footnoteTime;
            }
            set
            {
                if (value != _footnoteTime)
                {
                    IsDirty = true;
                    _footnoteTime = value;
                    NotifyPropertyChanged("FootnoteTime");
                }
            }
        }

        private string _footnoteValue;
        public string FootnoteValue 
        {
            get
            {
                return _footnoteValue;
            }
            set
            {
                if (value != _footnoteValue)
                {
                    IsDirty = true;
                    _footnoteValue = value;
                    NotifyPropertyChanged("FootnoteValue");
                }
            }
        }


        private string _footnoteVariable;
        public string FootnoteVariable 
        {
            get
            {
                return _footnoteVariable;
            }
            set
            {
                if (value != _footnoteVariable)
                {
                    IsDirty = true;
                    _footnoteVariable = value;
                    NotifyPropertyChanged("FootnoteVariable");
                }
            }
        }


        #region "English"

        private string _presTextEnglish;
        public string PressTextEnglish 
        {
            get
            {
                return _presTextEnglish;
            }
            set
            {
                if (value != _presTextEnglish)
                {
                    IsDirty = true;
                    _presTextEnglish = value;
                    NotifyPropertyChanged("PressTextEnglish");
                }
            }
        }

        private string _presTextEnglishS;
        public string PressTextEnglishS
        {
            get
            {
                return _presTextEnglishS;
            }
            set
            {
                if (value != _presTextEnglishS)
                {
                    IsDirty = true;
                    _presTextEnglishS = value;
                    NotifyPropertyChanged("PressTextEnglishS");
                }
            }
        }

        private string _unitEnglsih;
        public string UnitEnglish 
        {
            get
            {
                return _unitEnglsih;
            }
            set
            {
                if (value != _unitEnglsih)
                {
                    IsDirty = true;
                    _unitEnglsih = value;
                    NotifyPropertyChanged("UnitEnglish");
                }
            }
        }

        private string _refPeriodEnglish;
        public string RefPeriodEnglish 
        {
            get
            {
                return _refPeriodEnglish;
            }
            set
            {
                if (value != _refPeriodEnglish)
                {
                    IsDirty = true;
                    _refPeriodEnglish = value;
                    NotifyPropertyChanged("RefPeriodEnglish");
                }
            }
        }


        private string _basePeriodEnglish;
        public string BasePeriodEnglish 
        { 
            get
            {
                return _basePeriodEnglish;
            }
            set
            {
                if (value != _basePeriodEnglish)
                {
                    IsDirty = true;
                    _basePeriodEnglish = value;
                    NotifyPropertyChanged("BasePeriodEnglish");
                }

            }
        }

        #endregion




        BindingList<PxTime> _time;
        public BindingList<PxTime> TimePeriods { get { return _time; } }

        private BindingList<PxContentFootnote> _footnotes;
        public BindingList<PxContentFootnote> Footnotes { get { return _footnotes; } }

        private List<PxContentFootnote> _removedFootnotes;
        public List<PxContentFootnote> RemovedFootnotes { get { return _removedFootnotes; } }

        private BindingList<PxContentVariableFootnote> _contetnVariableFootnotes;
        public BindingList<PxContentVariableFootnote> ContentVariableFootnotes { get { return _contetnVariableFootnotes; } }

        private List<PxContentVariableFootnote> _removedContentVariableFootnotes;
        public List<PxContentVariableFootnote> RemovedContentVariableFootnotes { get { return _removedContentVariableFootnotes; } }

        private BindingList<PxContentValueFootnote> _contetnValueFootnotes;
        public BindingList<PxContentValueFootnote> ContentValueFootnotes { get { return _contetnValueFootnotes; } }

        private List<PxContentValueFootnote> _removedContentValueFootnotes;
        public List<PxContentValueFootnote> RemovedContentValueFootnotes { get { return _removedContentValueFootnotes; } }

        #endregion

        public PxContent()
        {
            _time = new BindingList<PxTime>();
            IsNew = true;
            _footnotes = new BindingList<PxContentFootnote>();
            _removedFootnotes = new List<PxContentFootnote>();
            _contetnVariableFootnotes = new BindingList<PxContentVariableFootnote>();
            _removedContentVariableFootnotes = new List<PxContentVariableFootnote>();
            _contetnValueFootnotes = new BindingList<PxContentValueFootnote>();
            _removedContentValueFootnotes = new List<PxContentValueFootnote>();
        }

        public override bool Validate(ref string message)
        {
            // Check mandantory fields
            if (String.IsNullOrWhiteSpace(Content) ||
                String.IsNullOrWhiteSpace(PresText) ||
                String.IsNullOrWhiteSpace(Copyright) ||
                String.IsNullOrWhiteSpace(StatAuthority) ||
                String.IsNullOrWhiteSpace(Producer) ||
                String.IsNullOrWhiteSpace(Unit) ||
                String.IsNullOrWhiteSpace(PresCellsZero) ||
                String.IsNullOrWhiteSpace(AggregPossible) ||
                String.IsNullOrWhiteSpace(StockFA) ||
                String.IsNullOrWhiteSpace(DayAdj) ||
                String.IsNullOrWhiteSpace(SeasAdj) ||
                String.IsNullOrWhiteSpace(StoreFormat))
            {
                message = String.Format("Please enter a valid option for all input fields marked with * for Content {0}", Content);
                return false;
            }

            if (StoreFormat == "N")
            {
                if (StoreNoChar < 2 || StoreNoChar > 17)
                {
                    message = String.Format("Store no of Characters for the content {0} must be in the range betwen 2 and 17", Content);
                    return false;
                }
            }
            if (StoreFormat == "C")
            {
                if (StoreNoChar < 1 || StoreNoChar > 30)
                {
                    message = String.Format("Store no of Characters for the content {0} must be in the range betwen 1 and 30", Content);
                    return false;
                }
            }

            
            return true;
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            PxMetaModel.Content content = new PxMetaModel.Content();
            content.Contents = Content;
            content.MainTable = MainTable.TableId;
            content.PresText = PresText;
            content.PresTextS = PressTextS;
            content.PresCode = MainTable.ProductId + StoreColumnNo;
            content.Copyright = Copyright;
            content.StatAuthority = StatAuthority;
            content.Producer = Producer;
            content.Unit = Unit;
            content.PresDecimals = PresDecimals;
            content.PresCellsZero = PresCellsZero;
            content.PresMissingLine = PresMissingLine;
            content.AggregPossible = AggregPossible;
            content.RefPeriod = RefPeriod;
            content.StockFA = StockFA;
            content.BasePeriod = BasePeriod;
           
            content.CFPrices = String.IsNullOrWhiteSpace(CFPrices) ? null : CFPrices;
            content.DayAdj = DayAdj;
            content.SeasAdj = SeasAdj;
            content.FootnoteContents = FootnoteContents;
            content.FootnoteVariable = FootnoteVariable;
            content.FootnoteValue = FootnoteValue;
            content.FootnoteTime = FootnoteTime;
            content.StoreColumnNo = StoreColumnNo;
            content.StoreFormat = StoreFormat;
            content.StoreNoChar = StoreNoChar;
            content.StoreDecimals = StoreDecimals;
            content.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            content.LogDate = DateTime.Now;
            context.AddToContents(content);

            PxMetaModel.Contents_Eng contentEng = new PxMetaModel.Contents_Eng();

            contentEng.Content = content;
            contentEng.PresText = PressTextEnglish;
            contentEng.PresTextS = PressTextEnglishS;
            contentEng.RefPeriod = RefPeriodEnglish;

            contentEng.BasePeriod = BasePeriodEnglish;
            contentEng.Unit = UnitEnglish;
            contentEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            contentEng.LogDate = DateTime.Now;

            context.AddToContents_Eng(contentEng);


            foreach (PxContentFootnote contentFootnote in Footnotes)
            {
                contentFootnote.MainTable = MainTable;

                contentFootnote.Content = this;

                contentFootnote.Save(context);
            }

            foreach (PxContentVariableFootnote contentVariableFootnote in ContentVariableFootnotes)
            {
                contentVariableFootnote.MainTable = MainTable;
                contentVariableFootnote.Content = this;
                contentVariableFootnote.Save(context);
            }

            foreach (PxContentValueFootnote contentValueFootnote in ContentValueFootnotes)
            {
                contentValueFootnote.MainTable = MainTable;
                contentValueFootnote.Content = this;
                contentValueFootnote.Save(context);
            }
        }


        public override void MarkAsOld()
        {
            base.MarkAsOld();

            foreach (var timePeriod in TimePeriods)
            {
                timePeriod.MarkAsOld();
            }
        }

        public override void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            PxMetaModel.Content content = (from c in context.Contents
                                           where c.MainTable == MainTable.TableId && c.Contents == Content
                                           select c).First();

            content.PresText = PresText;
            content.PresTextS = PressTextS;
            content.PresCode = MainTable.ProductId + StoreColumnNo;
            content.Copyright = Copyright;
            content.StatAuthority = StatAuthority;
            content.Producer = Producer;
            content.Unit = Unit;
            content.PresDecimals = PresDecimals;
            content.PresCellsZero = PresCellsZero;
            content.PresMissingLine = PresMissingLine;
            content.AggregPossible = AggregPossible;
            content.RefPeriod = RefPeriod;
            content.StockFA = StockFA;
            content.BasePeriod = BasePeriod;
            content.CFPrices = String.IsNullOrWhiteSpace(CFPrices) ? null : CFPrices;
            content.DayAdj = DayAdj;
            content.SeasAdj = SeasAdj;
            content.FootnoteContents = FootnoteContents == null ? "N" : FootnoteContents;
            content.FootnoteVariable = FootnoteVariable == null ? "N" : FootnoteVariable;
            content.FootnoteValue = FootnoteValue == null ? "N" : FootnoteValue;
            content.FootnoteTime = FootnoteTime == null ? "N" : FootnoteTime;
            content.StoreColumnNo = StoreColumnNo;
            content.StoreFormat = StoreFormat;
            content.StoreNoChar = StoreNoChar;
            content.StoreDecimals = StoreDecimals;
            content.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            content.LogDate = DateTime.Now;


            PxMetaModel.Contents_Eng contentEng = (from c in context.Contents_Eng
                                                   where c.MainTable == MainTable.TableId && c.Contents == Content
                                                   select c).First();

            contentEng.PresText = PressTextEnglish;
            contentEng.PresTextS = PressTextEnglishS;
            contentEng.RefPeriod = RefPeriodEnglish;
            contentEng.BasePeriod = BasePeriod;
            contentEng.Unit = UnitEnglish;
            contentEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            contentEng.LogDate = DateTime.Now;


            foreach (PxContentFootnote contentFootnote in Footnotes)
            {
                contentFootnote.MainTable = MainTable;

                contentFootnote.Content = this;

                contentFootnote.Save(context);
            }

            foreach (PxContentVariableFootnote contentVariableFootnote in ContentVariableFootnotes)
            {
                contentVariableFootnote.MainTable = MainTable;
                contentVariableFootnote.Content = this;
                contentVariableFootnote.Save(context);
            }

            foreach (PxContentValueFootnote contentValueFootnote in ContentValueFootnotes)
            {
                contentValueFootnote.MainTable = MainTable;
                contentValueFootnote.Content = this;
                contentValueFootnote.Save(context);
            }

            foreach (PxContentVariableFootnote contentVariableFootnote in RemovedContentVariableFootnotes)
            {
                contentVariableFootnote.DeleteEntities(context);
            }

            foreach (PxContentFootnote contentFootnote in RemovedFootnotes)
            {
                contentFootnote.DeleteEntities(context);
            }

            foreach (PxContentValueFootnote contentValueFootnote in RemovedContentValueFootnotes)
            {
                contentValueFootnote.DeleteEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            foreach  (PxTime time in _time)
            {
                time.DeleteEntities(context);
            }

            foreach (PxContentFootnote contentFootnote in Footnotes)
            {
               
                contentFootnote.DeleteEntities(context);
            }

            foreach (PxContentVariableFootnote contentVariableFootnote in ContentVariableFootnotes)
            {
               
                contentVariableFootnote.DeleteEntities(context);
            }

            foreach (PxContentValueFootnote contentValueFootnote in ContentValueFootnotes)
            {
                
                contentValueFootnote.DeleteEntities(context);
            }

            foreach (PxContentVariableFootnote contentVariableFootnote in RemovedContentVariableFootnotes)
            {
                contentVariableFootnote.DeleteEntities(context);
            }

            foreach (PxContentFootnote contentFootnote in RemovedFootnotes)
            {
                contentFootnote.DeleteEntities(context);
            }

            foreach (PxContentValueFootnote contentValueFootnote in RemovedContentValueFootnotes)
            {
                contentValueFootnote.DeleteEntities(context);
            }

            var contEngToDel = (from c in context.Contents_Eng
                                where c.Contents == Content && c.MainTable == MainTable.TableId
                                select c).FirstOrDefault();
            if (contEngToDel != null)
            {
                context.DeleteObject(contEngToDel);
            }

            var contToDel = (from c in context.Contents
                             where c.Contents == Content && c.MainTable == MainTable.TableId
                             select c).FirstOrDefault();
            if (contToDel != null)
            {
                context.DeleteObject(contToDel);
            }
                
        }
    }
}

