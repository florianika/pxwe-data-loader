using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PxDataLoader.Model
{
    public class PxMenuSelection : PxObject, INotifyPropertyChanged
    {
        private string _menu;
        public string Menu 
        {
            get
            {
                return _menu;
            }
            set
            {
                if (value != _menu)
                {
                    IsDirty = true;
                    _menu = value;
                    NotifyPropertyChanged("Menu");
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

        private string _presTextS;
        public string PresTextS 
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
                    NotifyPropertyChanged("PresTextS");
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

        private string _levelNo;
        public string LevelNo 
        {
            get
            {
                return _levelNo;
            }
            set
            {
                if (value != _levelNo)
                {
                    IsDirty = true;
                    _levelNo = value;
                    NotifyPropertyChanged("LevelNo");
                }
            }
        }

        private string _sortCode;
        public string SortCode 
        {
            get
            {
                return _sortCode;
            }
            set
            {
                if (value != _sortCode)
                {
                    IsDirty = true;
                    _sortCode = value;
                    NotifyPropertyChanged("SortCode");
                }
            }
        }

        private string _presentation;
        public string Presentation 
        {
            get
            {
                return _presentation;
            }
            set
            {
                if (value != _presentation)
                {
                    IsDirty = true;
                    _presentation = value;
                    NotifyPropertyChanged("Presentation");
                }
            }
        }

        private PxMenuSelection _parent;
        public PxMenuSelection Parent 
        {
            get
            {
                return _parent;
            }
            set
            {
                if (value != _parent)
                {
                    IsDirty = true;
                    _parent = value;
                    NotifyPropertyChanged("Parent");
                }
            }
        }

        public List<PxMenuSelection> Childrens 
        {
            get 
            {
                return _children;
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

        private string _presTextSEnglish;
        public string PresTextSEnglish 
        {
            get
            {
                return _presTextSEnglish;
            }
            set
            {
                if (value != _presTextSEnglish)
                {
                    IsDirty = true;
                    _presTextSEnglish = value;
                    NotifyPropertyChanged("PresTextSEnglish");
                }
            }
        }

        private string _descriptionEnglish;
        public string DescriptionEnglish 
        {
            get
            {
                return _descriptionEnglish;
            }
            set
            {
                if (value != _descriptionEnglish)
                {
                    IsDirty = true;
                    _descriptionEnglish = value;
                    NotifyPropertyChanged("DescriptionEnglish");
                }
            }
        }

        private string _sortCodeEnglish;
        public string SortCodeEnglish 
        {
            get
            {
                return _sortCodeEnglish;
            }
            set 
            {
                if (value != _sortCodeEnglish)
                {
                    IsDirty = true;
                    _sortCodeEnglish = value;
                    NotifyPropertyChanged("SortCodeEnglish");
                }
            }
        }

        private string _presentationEnglish;
        public string PresentationEnglish 
        {
            get
            {
                return _presentationEnglish;
            }
            set
            {
                if (value != _presentationEnglish)
                {
                    IsDirty = true;
                    _presentationEnglish = value;
                    NotifyPropertyChanged("PresentationEnglish");
                }
            }
        }

        private List<PxMenuSelection> _children = new List<PxMenuSelection>();

        public PxMenuSelection()
        {
            IsNew = true;
        }
        #region "Validation"

        public override bool Validate(ref string message)
        {

            if (String.IsNullOrWhiteSpace(Menu) ||
                String.IsNullOrWhiteSpace(PresText) ||
                String.IsNullOrWhiteSpace(Presentation))
            {
                message = "Please enter a valid option for all input fields marked with * for Menu Selection";
                return false;
            }

           
            return true;
        }

        #endregion

        #region "Entities creation"

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            PxMetaModel.MenuSelection menuSelection = new PxMetaModel.MenuSelection();

            menuSelection.Menu = Parent.Menu;
            menuSelection.Selection = Menu;
            menuSelection.PresText = PresText;
            menuSelection.PresTextS = PresTextS;
            menuSelection.Presentation = Presentation;
            menuSelection.LevelNo = LevelNo;
            menuSelection.Description = Description;
            menuSelection.SortCode = SortCode;
            menuSelection.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            menuSelection.LogDate = DateTime.Now;

            context.AddToMenuSelections(menuSelection);


            PxMetaModel.MenuSelection_Eng menuSelectionEng = new PxMetaModel.MenuSelection_Eng();

            menuSelectionEng.MenuSelection = menuSelection;
            menuSelectionEng.PresText = PresTextEnglish;
            menuSelectionEng.PresTextS = PresTextSEnglish;
            menuSelectionEng.Presentation = PresentationEnglish;
            menuSelectionEng.Description = DescriptionEnglish;
            menuSelectionEng.SortCode = SortCodeEnglish;
            menuSelectionEng.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            menuSelectionEng.LogDate = DateTime.Now;

            context.AddToMenuSelection_Eng(menuSelectionEng);

        }
        #endregion

        public string GetTheme(PxMenuSelection node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Parent != null)
            {
                    if (String.Compare(node.Parent.Menu, "START", true) == 0)
                    {
                        return node.Menu;
                    }
                    return GetTheme(node.Parent);
            }

            return null;
        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);
            var menuSel_Eng = (from mse in context.MenuSelection_Eng
                               where mse.Menu == Parent.Menu && mse.Selection == Menu
                               select mse).FirstOrDefault();
            if (menuSel_Eng != null)
            {
                context.DeleteObject(menuSel_Eng);
            }
            var menusel = (from ms in context.MenuSelections
                           where ms.Menu == Parent.Menu && ms.Selection == Menu
                               select ms).FirstOrDefault();
            if (menusel != null)
            {

                context.DeleteObject(menusel);
            }
        }

    }
}
