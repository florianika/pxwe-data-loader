using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxObject
    {
        #region "Property changed event stuff"
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion

        public bool IsNew { get; set; }

        public bool IsDirty { get; set; }

        public virtual bool Validate(ref string message)
        {
            return true;
        }

        public virtual void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        { 
        
        }

        public virtual void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        { 
        
        }

        public virtual void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {

        }


        
        public void Save(PxMetaModel.PcAxisMetabaseEntities context)
        {
            //TODO check if isdirty works
            if (IsDirty)
            {
                if (IsNew)
                {
                    CreateEntities(context);
                }
                else
                {
                    UpdateEntities(context);
                }
            }
        }

        public virtual void MarkAsOld()
        {
            IsNew = false;
        }

        public virtual void MarkAsDirty()
        {
            IsDirty = true;
        }
    }
}
