using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxFootnote : PxObject, INotifyPropertyChanged
    {

        private int _footnoteNo;
        public int FootnoteNo 
        {
            get
            {
                return _footnoteNo;
            }
            set
            {
                if (value != _footnoteNo)
                {
                    IsDirty = true;
                    _footnoteNo = value;
                    NotifyPropertyChanged("FootnoteNo");
                }
            }
        }

        private string _footnoteType;
        public string FootnoteType 
        {
            get
            {
                return _footnoteType;
            }
            set
            {
                if (value != _footnoteType)
                {
                    IsDirty = true;
                    _footnoteType = value;
                    NotifyPropertyChanged("FootnoteType");
                }
            }
        }

        private string _showFootnote;
        public string ShowFootnote 
        {
            get
            {
                return _showFootnote;
            }
            set
            {
                if (value != _showFootnote)
                {
                    IsDirty = true;
                    _showFootnote = value;
                    NotifyPropertyChanged("ShowFootnote");
                }
            }
        }

        private string _mandOption;
        public string MandOption 
        {
            get
            {
                return _mandOption;
            }
            set
            {
                if (value != _mandOption)
                {
                    IsDirty = true;
                    _mandOption = value;
                    NotifyPropertyChanged("MandOption");
                }
            }
        }

        private string _footnoteText;
        public string FootnoteText 
        {
            get
            {
                return _footnoteText;
            }
            set
            {
                if (value != _footnoteText)
                {
                    IsDirty = true;
                    _footnoteText = value;
                    NotifyPropertyChanged("FootnoteText");
                }
            }
        }


        private string _footnoteTextEnglish;
        public string FootnoteTextEnglish 
        {
            get
            {
                return _footnoteTextEnglish;
            }
            set
            {
                if (value != _footnoteTextEnglish)
                {
                    IsDirty = true;
                    _footnoteTextEnglish = value;
                    NotifyPropertyChanged("FootnoteTextEnglish");
                }
            }
        }


        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                PxMetaModel.Footnote footnote = new PxMetaModel.Footnote();
                footnote.FootnoteNo = FootnoteNo;
                footnote.FootnoteType = FootnoteType;
                footnote.MandOpt = MandOption;
                footnote.FootnoteText = FootnoteText;
                footnote.ShowFootnote = ShowFootnote;
                footnote.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnote.LogDate = DateTime.Now;
                context.AddToFootnotes(footnote);

                PxMetaModel.Footnote_Eng footnoteEng = new PxMetaModel.Footnote_Eng();

                footnoteEng.Footnote = footnote;
                footnoteEng.FootnoteText = FootnoteTextEnglish;
                footnoteEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteEng.LogDate = DateTime.Now;
                context.AddToFootnote_Eng(footnoteEng);
            }
        }

        public override void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (!IsNew)
            {
                var footnote = (from f in context.Footnotes
                                where f.FootnoteNo == FootnoteNo
                                select f).First();
                footnote.MandOpt = MandOption;
                footnote.FootnoteText = FootnoteText;
                footnote.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnote.LogDate = DateTime.Now;

                var footnoteEng = (from f in context.Footnote_Eng
                                   where f.FootnoteNo == FootnoteNo
                                   select f).First();
                footnoteEng.FootnoteText = FootnoteTextEnglish;
                footnoteEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteEng.LogDate = DateTime.Now;
            }
        }

        public override bool Validate(ref string message)
        {
            if (String.IsNullOrWhiteSpace(ShowFootnote) ||
                String.IsNullOrWhiteSpace(FootnoteText) ||
                String.IsNullOrWhiteSpace(MandOption))
            {
                message = "Please enter a valid option for all input fields marked with * for Footnote";
                return false;
            }

            return true;
        }

        public PxFootnote()
        {
            IsNew = true;
        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            var fEng = (from c in context.Footnote_Eng 
                                where c.FootnoteNo == FootnoteNo 
                                select c).FirstOrDefault();
            if (fEng != null)
            {
                context.DeleteObject(fEng);
            }
            var f = (from c in context.Footnotes
                             where c.FootnoteNo == FootnoteNo 
                             select c).FirstOrDefault();
            if (f != null)
            {
                context.DeleteObject(f);
            }
        }

    }
}
