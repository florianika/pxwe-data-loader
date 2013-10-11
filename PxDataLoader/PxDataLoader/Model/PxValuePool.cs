using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxValuePool : PxObject, INotifyPropertyChanged
    {

        #region "Public properties"

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

        private string _presText;
        public string PresText 
        {
            get
            {
                return _presText;
            }
            set
            {
                if (value != _presText)
                {
                    IsDirty = true;
                    _presText = value;
                    NotifyPropertyChanged("PresText");
                }
            }
        }

        private string _description;
        public string Description 
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    IsDirty = true;
                    _description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        #region "English properties"

        private string _valuePoolAlias;
        public string ValuePoolAlias
        {
            get
            {
                return _valuePoolAlias;
            }
            set
            {
                if (value != _valuePoolAlias)
                {
                    IsDirty = true;
                    _valuePoolAlias = value;
                    NotifyPropertyChanged("ValuePoolAlias");
                }
            }
        }

        private string _presTextEnglish;
        public string PresTextEnglish 
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
                    NotifyPropertyChanged("PresTextEnglish");
                }
            }
        }
        
        #endregion

        #endregion

        public PxValuePool()
        {
            IsNew = true;
        }

        #region "Validation"
        
        public override bool Validate(ref string message)
        {

            if (String.IsNullOrWhiteSpace(ValuePool) ||
                String.IsNullOrWhiteSpace(PresText) ||
                String.IsNullOrWhiteSpace(Description) ||
                String.IsNullOrWhiteSpace(ValuePoolAlias) ||
                String.IsNullOrWhiteSpace(PresTextEnglish))
            {
                message = "Please enter a valid option for all input fields";
                return false;
            }

            return true;
        }

        #endregion

        #region "Entities creation"

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            // Creates the ValuePool object
            context.ValuePools.AddObject(new PxMetaModel.ValuePool() 
                {ValuePool1 = ValuePool,
                 PresText = PresText,
                 Description = Description,
                 ValueTextExists = "L",
                 ValuePres = "T",
                 UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                 LogDate = DateTime.Now});

            //Creates the english value pool object
            context.ValuePool_Eng.AddObject(new PxMetaModel.ValuePool_Eng()
            {
                ValuePool = ValuePool,
                PresText = PresTextEnglish,
                ValuePoolEng = ValuePoolAlias, 
                UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                LogDate = DateTime.Now
            });

        #endregion

        }
    }
}
