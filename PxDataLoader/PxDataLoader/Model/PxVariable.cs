using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
   public class PxVariable : PxObject, INotifyPropertyChanged
    {
        #region "Public properties"



        public string Variable { get; set; }

        public string PresText { get; set; }

        public string VariableInfo { get; set; }

        public bool Exists { get { return !IsNew; }  }

        public short StoreColumnNo { get; set; }

        public PxMainTable MainTable { get; set; }

        #region "SubTableVariable"

        public string VariableType { get; set; }

       private string _valueset;
       
       public string ValueSet
        {
            get { return _valueset; }
            set
            {
                if (value != _valueset)
                {
                    _valueset = value;
                    NotifyPropertyChanged("ValueSet");
                }
            }
        }

        #endregion

        #region "English"

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

        #endregion

        #endregion


        private BindingList<PxVariableFootnote> _variableFootnotes;
        public BindingList<PxVariableFootnote> VariableFootnotes { get { return _variableFootnotes; } }

        private List<PxVariableFootnote> _removedVariableFootnotes;
        public List<PxVariableFootnote> RemovedVariableFootnotes { get { return _removedVariableFootnotes; } }

        public PxVariable()
        {
            IsNew = true;
            _variableFootnotes = new BindingList<PxVariableFootnote>();
            _removedVariableFootnotes = new List<PxVariableFootnote>();
        }

        #region "Validation"

        public override bool Validate(ref string message)
        {
            // Check mandantory fields

            if (String.IsNullOrWhiteSpace(Variable) ||
                String.IsNullOrWhiteSpace(PresText) ||
                String.IsNullOrWhiteSpace(VariableType) 
                )
            {
                message = String.Format("Please enter a valid option for fields marked with * for Variable {0} ", Variable);
                return false;
            }

            if (VariableType != "T" && String.IsNullOrWhiteSpace(ValueSet))
            {
                message = String.Format("Please enter a valid option for fields marked with * for Variable {0} ", Variable);
                return false;
            }


           

            return true;
        }
        #endregion

        #region "Entities creation"

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                PxMetaModel.Variable variable = new PxMetaModel.Variable();
                variable.Variable1 = Variable;
                variable.PresText = PresText;
                variable.VariableInfo = VariableInfo;
                variable.Footnote = Footnote;
                variable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                variable.LogDate = DateTime.Now;

                context.AddToVariables(variable);

                PxMetaModel.Variable_Eng variableEng = new PxMetaModel.Variable_Eng();
                variableEng.Variable1 = variable;
                variableEng.PresText = PresTextEnglish;
                variableEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                variableEng.LogDate = DateTime.Now;

                context.AddToVariable_Eng(variableEng);
            }

            PxMetaModel.SubTableVariable subTableVariable = new PxMetaModel.SubTableVariable();
            subTableVariable.MainTable = MainTable.TableId;
            subTableVariable.SubTable =  "1";
            subTableVariable.Variable = Variable;
            subTableVariable.ValueSet = String.IsNullOrWhiteSpace(ValueSet)?null:ValueSet;
            subTableVariable.VariableType = VariableType;
            subTableVariable.StoreColumnNo = StoreColumnNo;
            subTableVariable.UserID = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            subTableVariable.LogDate = DateTime.Now;

            context.AddToSubTableVariables(subTableVariable);

            foreach (var variableFootnote in VariableFootnotes)
            {
                variableFootnote.Variable = this;
                variableFootnote.Save(context);
            }
        }

        #endregion

        #region "Entities Update"

        public override void UpdateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (!IsNew)
            {
                PxMetaModel.Variable variable = (from v in context.Variables
                                                 where v.Variable1 == Variable
                                                 select v).First();
                variable.PresText = PresText;
                variable.VariableInfo = VariableInfo;
                variable.Footnote = Footnote == null ? "N" : Footnote;
                variable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                variable.LogDate = DateTime.Now;


                PxMetaModel.Variable_Eng variableEng = (from v in context.Variable_Eng
                                                        where v.Variable == Variable
                                                        select v).First();
                variableEng.PresText = PresTextEnglish;
                variableEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                variableEng.LogDate = DateTime.Now;
            }

            PxMetaModel.SubTableVariable subTableVariable = (from st in context.SubTableVariables
                                                             where st.MainTable == MainTable.TableId && st.SubTable == "1" && st.Variable == Variable
                                                             select st).FirstOrDefault();
            if (subTableVariable == null)
            {
                subTableVariable = new PxMetaModel.SubTableVariable();
                subTableVariable.MainTable = MainTable.TableId;
                subTableVariable.SubTable = "1";
                subTableVariable.Variable = Variable;
                context.AddToSubTableVariables(subTableVariable);
            }

            subTableVariable.ValueSet = String.IsNullOrWhiteSpace(ValueSet) ? null : ValueSet;
            subTableVariable.VariableType = VariableType;
            subTableVariable.StoreColumnNo = StoreColumnNo;
            subTableVariable.UserID = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            subTableVariable.LogDate = DateTime.Now;

            foreach (var variableFootnote in VariableFootnotes)
            {
                variableFootnote.Variable = this;
                variableFootnote.Save(context);
            }

            foreach (var removedVariableFootnote in RemovedVariableFootnotes)
            {
                removedVariableFootnote.DeleteEntities(context);
            }
        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            var var = (from v in context.SubTableVariables
                       where v.MainTable == MainTable.TableId && v.SubTable == "1" && v.Variable == Variable
                       select v).First();
            context.DeleteObject(var);
        }

        #endregion
    }
}
