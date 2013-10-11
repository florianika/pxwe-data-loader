using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxTime : PxObject, INotifyPropertyChanged
    {

        #region "Public properties"


        private string _timePeriod;
        public string TimePeriod 
        {
            get 
            { 
                return _timePeriod; }
            set 
            {
                if (value != _timePeriod)
                {
                    _timePeriod = value;
                    IsDirty = true;
                    NotifyPropertyChanged("TimePeriod");
                }
            }
        }

        public PxContent Content { get; set; }

        #endregion

        private BindingList<PxTimeFootnote> _timeFootnotes;
        public BindingList<PxTimeFootnote> TimeFootnotes { get { return _timeFootnotes; } }

        private List<PxTimeFootnote> _removedTimeFootnotes;
        public List<PxTimeFootnote> RemovedTimeFootnotes { get { return _removedTimeFootnotes; } }

        public PxTime()
        {
            IsNew = false;
            _timeFootnotes = new BindingList<PxTimeFootnote>();
            _removedTimeFootnotes = new List<PxTimeFootnote>();
        }

        #region "Entities creation"

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                PxMetaModel.ContentsTime contentsTime = new PxMetaModel.ContentsTime();
                contentsTime.TimePeriod = TimePeriod;
                contentsTime.Contents = Content.Content;
                contentsTime.MainTable = Content.MainTable.TableId;
                contentsTime.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                contentsTime.LogDate = DateTime.Now;

                context.AddToContentsTimes(contentsTime);

                foreach (var timeFootnote in TimeFootnotes)
                {
                    timeFootnote.ContentTime = this;
                    timeFootnote.Save(context);
                }
            }
        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);
            foreach (PxTimeFootnote timeFootnote in _timeFootnotes)
            {
                timeFootnote.DeleteEntities(context);
            }
            var contTime = (from ct in context.ContentsTimes
                            where ct.Contents == Content.Content && ct.MainTable == Content.MainTable.TableId && ct.TimePeriod == TimePeriod
                            select ct).First();
            context.DeleteObject(contTime);
        }
        //TODO Update Entities

        #endregion

    }
}
