using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxValueSet : PxObject, INotifyPropertyChanged
    {

        #region "Properties"

        private string _valueSet;
        public string Valueset 
        {
            get
            {
                return _valueSet;
            }
            set
            {
                if (value != _valueSet)
                {
                    IsDirty = true;
                    _valueSet = value;
                    NotifyPropertyChanged("Valueset");
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

        private string _elimination;
        public string Elimination 
        {
            get
            {
                return _elimination;
            }
            set
            {
                if (value != _elimination)
                {
                    IsDirty = true;
                    _elimination = value;
                    NotifyPropertyChanged("Elimination");
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


        private string _valuePres;
        public string ValuePres 
        {
            get
            {
                return _valuePres;
            }
            set
            {
                if (value != _valuePres)
                {
                    IsDirty = true;
                    _valuePres = value;
                    NotifyPropertyChanged("ValuePres");
                }
            }
        }

        #region "English properties"

        private string _presTextEnglish;
        public string  PresTextEnglish 
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

        private BindingList<PxValue> _values;
        public BindingList<PxValue> Values { get { return _values; } }
        
        #endregion

        #region "Constructor(s)"

        public PxValueSet()
        {
            _values = new BindingList<PxValue>();
            IsNew = true;
        }

        #endregion

        #region "Validation"
        
        public override bool Validate(ref string message)
        {
            // Check mandantory fields
            if (String.IsNullOrWhiteSpace(Valueset) ||
                String.IsNullOrWhiteSpace(PresText) ||
                String.IsNullOrWhiteSpace(Elimination) ||
                String.IsNullOrWhiteSpace(ValuePool) ||
                String.IsNullOrWhiteSpace(ValuePres))
            {
                message = "Please enter a valid option for all input fields";
                return false;
            }

            //Check for duplicate values
            Dictionary<string, string> codes = new Dictionary<string, string>();

            List<Model.PxValue> poolValues = VariableFacade.GetValuesByValuePool(ValuePool);

            PxValue existingValue;

            foreach (var v in _values)
            {
                string code = v.ValueCode.ToUpper();
                if (codes.ContainsKey(code))
                {
                    message = "Duplicate code: " + v.ValueCode;
                    return false;
                }
                codes.Add(code, v.ValueCode);
                if (!v.Validate(ref message))
                {
                    return false;
                }

                existingValue = GetValue(poolValues, v.ValueCode);

                if (existingValue == null)
                {
                    v.IsNew = true;
                }
                else
                {
                    if (String.Compare(existingValue.ValueText, v.ValueText, true) == 0
                        && String.Compare(existingValue.ValueTextEnglish, v.ValueTextEnglish, true) == 0)
                    {
                        v.IsNew = false;
                    }
                    else
                    {
                        message = String.Format("The value you are adding {0}, {1} is already in the valuepool {2}, \n Either remove your value and add it from valuepool or define a new valuepool or a new code in this valuepool"
                            , v.ValueCode, v.ValueText, ValuePool);
                        return false;
                    }
                }
                
            }


            return true;
        }

        public static PxValue GetValue(List<PxValue> listOfValues, string valueCode)
        {
            foreach (var v in listOfValues)
            {
                if (String.Compare(v.ValueCode, valueCode, true) == 0)
                {
                    return v;
                }
            }
            return null;
        }

        #endregion

        #region "Entities creation"

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            //Create the valueset
            PxMetaModel.ValueSet vs = new PxMetaModel.ValueSet();
            vs.ValueSet1 = Valueset;
            vs.PresText = PresText;
            vs.Description = PresText;
            vs.Elimination = Elimination;
            vs.ValuePool = ValuePool;
            vs.ValuePres = ValuePres;
            vs.SortCodeExists = "Y";
            vs.Footnote = "S";
            vs.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            vs.LogDate = DateTime.Now;

            context.AddToValueSets(vs);

            PxMetaModel.ValueSet_Eng vsEng = new PxMetaModel.ValueSet_Eng();
            vsEng.ValueSet1 = vs;
            vsEng.PresText = PresTextEnglish;
            vsEng.Description = PresTextEnglish;
            vsEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            vsEng.LogDate = DateTime.Now;
            

            context.AddToValueSet_Eng(vsEng);

            int sortCode = 0;
            foreach (var v in Values)
            {
                sortCode++;
                if (v.IsNew)
                {
                    v.ValuePool = ValuePool;
                    v.Footnote = "N";
                    v.CreateEntities(context);
                }

                //Create vs value
                PxMetaModel.VSValue vsValue = new PxMetaModel.VSValue();
                vsValue.ValueSet1 = vs;
                vsValue.ValuePool = ValuePool;
                vsValue.ValueCode = v.ValueCode;
                int lengthOfCountValues = Values.Count.ToString().Length;
                string stringSortCode = "";
                for (int i = 0; i < lengthOfCountValues - sortCode.ToString().Length; i++)
                {
                    stringSortCode += "0";
                }
                stringSortCode += sortCode.ToString();
                vsValue.SortCode = stringSortCode;
                vsValue.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                vsValue.LogDate = DateTime.Now;

                context.AddToVSValues(vsValue);

                //Create vs value eng
                PxMetaModel.VSValue_Eng vsValueEng = new PxMetaModel.VSValue_Eng();
                vsValueEng.ValueSet1 = vs;
                vsValueEng.ValuePool = ValuePool;
                vsValueEng.ValueCode = v.ValueCode;
                vsValueEng.SortCode = sortCode.ToString();
                vsValueEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                vsValueEng.LogDate = DateTime.Now;

                context.AddToVSValue_Eng(vsValueEng);
            }

            
        }

        public override void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (!IsNew)
            {
                var valueset = (from vs in context.ValueSets
                                where vs.ValueSet1 == Valueset
                                select vs).First();
                valueset.PresText = PresText;
                valueset.Description = PresText;
                valueset.Elimination = Elimination;
                valueset.SortCodeExists = "Y";
                valueset.Footnote = "S";
                valueset.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                valueset.LogDate = DateTime.Now;

                var valueset_eng = (from vs_eng in context.ValueSet_Eng
                                    where vs_eng.ValueSet == Valueset
                                    select vs_eng).First();
                valueset_eng.PresText = PresTextEnglish;
                valueset_eng.Description = PresTextEnglish;
                valueset_eng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                valueset_eng.LogDate = DateTime.Now;

                foreach (var v in Values)
                {
                    if (!v.IsNew)
                    {
                        v.ValuePool = ValuePool;
                        v.Save(context);
                    }
                }
            }
        }

        #endregion

    }
}
