using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxValue : PxObject, INotifyPropertyChanged
    {
        private string _valuCode;
        public string ValueCode 
        {
            get
            {
                return _valuCode;
            }
            set
            {
                if (value != _valuCode)
                {
                    IsDirty = true;
                    _valuCode = value;
                    NotifyPropertyChanged("ValueCode");
                }
            }
        }

        private string _valueText;
        public string ValueText
        {
            get
            {
                return _valueText;
            }
            set
            {
                if (value != _valueText)
                {
                    IsDirty = true;
                    _valueText = value;
                    NotifyPropertyChanged("ValueText");
                }
            }
        }

        private string _valueTextEnglish;
        public string ValueTextEnglish 
        {
            get
            {
                return _valueTextEnglish;
            }
            set
            {
                if (value != _valueTextEnglish)
                {
                    IsDirty = true;
                    _valueTextEnglish = value;
                    NotifyPropertyChanged("ValueTextEnglish");
                }
            }
        }

        private string _valuePool;
        public string ValuePool 
        {
            get
            {
                return _valuePool;
            }
            set
            {
                if (value != _valuePool)
                {
                    IsDirty = true;
                    _valuePool = value;
                    NotifyPropertyChanged("ValuePool");
                }
            }
        }

        private string _footnote;
        public string Footnote 
        {
            get
            {
                return _footnote;
            }
            set
            {
                if (value != _footnote)
                {
                    IsDirty = true;
                    _footnote = value;
                    NotifyPropertyChanged("Footnote");
                }
            }
        }

        private BindingList<PxValueFootnote> _valueFootnotes;
        public BindingList<PxValueFootnote> ValueFootnotes { get { return _valueFootnotes; } }

        private List<PxValueFootnote> _removedValueFootnotes;
        public List<PxValueFootnote> RemovedValueFootnotes { get { return _removedValueFootnotes; } }

        public PxValue()
        {
            IsNew = true;
            _valueFootnotes = new BindingList<PxValueFootnote>();
            _removedValueFootnotes = new List<PxValueFootnote>();
        }

        #region "Validation"

        public override bool Validate(ref string message)
        {
            if (String.IsNullOrWhiteSpace(ValueCode) ||
                String.IsNullOrWhiteSpace(ValueText))
                {
                    message = "Please enter a valid option for all input fields";
                    return false;
                }
            return true;
        }

        #endregion

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            PxMetaModel.Value value = new PxMetaModel.Value();
            value.ValuePool = ValuePool;
            value.ValueCode = ValueCode;
            value.ValueTextL = ValueText;
            value.Footnote = Footnote;
            value.SortCode = ValueCode;
            value.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            value.LogDate = DateTime.Now;

            context.AddToValues(value);

            PxMetaModel.Value_Eng valueEng = new PxMetaModel.Value_Eng();
            valueEng.Value = value;
            valueEng.ValuetextL = ValueTextEnglish;
            valueEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            valueEng.LogDate = DateTime.Now;
            valueEng.SortCode = ValueCode;
            context.AddToValue_Eng(valueEng);

            foreach(var valueFootnote in ValueFootnotes) 
            {
                valueFootnote.Value = this;
                valueFootnote.Save(context);
            }
            

        }
        //TODO update entities

        public override void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            PxMetaModel.Value value = (from v in context.Values
                             where v.ValuePool == ValuePool && v.ValueCode == ValueCode
                             select v).First();

            value.ValueTextL = ValueText;
            value.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            value.LogDate = DateTime.Now;

            PxMetaModel.Value_Eng value_eng = value.Value_Eng;

            value_eng.ValuetextL = ValueTextEnglish;
            value_eng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            value_eng.LogDate = DateTime.Now;

            foreach (var valueFootnote in ValueFootnotes)
            {
                valueFootnote.Value = this;
                valueFootnote.Save(context);
            }

            foreach (var removedValueFootnote in RemovedValueFootnotes)
            {
                removedValueFootnote.DeleteEntities(context);
            }
        }
    }
}
