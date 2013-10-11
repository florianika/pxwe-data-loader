using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PxDataLoader.Model;
using System.Xml.Linq;

namespace PxDataLoader
{
    public partial class CreateMainTable : Form
    {
        public string ImportFile { get; set; }

        public int FootnoteNo { get; set; }

        public CreateMainTable()
        {
            InitializeComponent();

            pressCategoryComboBox.DataSource = Option.GetOptions("PresCategory");
            specCharExistsComboBox.DataSource = Option.GetOptions("SpecCharExists");
            englishStatusComboBox.DataSource = Option.GetOptions("StatusEn");
            englishPublishedComboBox.DataSource = Option.GetOptions("YesNo");
            statAuthorityComboBox.DataSource = Option.GetOptions("StatAuthority");
            producerComboBox.DataSource = Option.GetOptions("StatAuthority");
            presCellsZeroComboBox.DataSource = Option.GetOptions("YesNo");
            aggregPossibleComboBox.DataSource = Option.GetOptions("YesNo");
            stockFAComboBox.DataSource = Option.GetOptions("StockFA");
            cFPricesComboBox.DataSource = Option.GetOptions("CFPrices");
            dayAdjComboBox.DataSource = Option.GetOptions("YesNo");
            seasAdjComboBox.DataSource = Option.GetOptions("YesNo");
            storeFormatComboBox.DataSource = Option.GetOptions("StoreFormat");
            variableTypeComboBox.DataSource = Option.GetOptions("VariableType");
            copyrightComboBox.DataSource = Option.GetOptions("Copyright");
            themeComboBox.DataSource = Option.GetThemeOptions();
            timeScaleIdComboBox.DataSource = Option.GetTimeScaleOptions();
            presMissingLineComboBox.DataSource = Option.GetPresMissingLineOptions();
            FootnoteNo = VariableFacade.GetFootnoteNextId();

            NewMainTable = new PxMainTable();
            //lbContents.DataSource = _table.Contents;
            //lbVariables.DataSource = _table.Variables;
        }
        public PxMainTable NewMainTable 
        {
            get
            {
                return _table;
            }

            set
            {
                _table = value;
                BindMainTableForm();
            }
        }

        private PxMainTable _table;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbContents.SelectedItem != null)
            {
                pxContentBindingSource.DataSource = lbContents.SelectedItem;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbVariables.SelectedItem != null)
            {
                pxVariableBindingSource.DataSource = lbVariables.SelectedItem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImportFile = ofd.FileName;
                txbExcelPath.Text = ImportFile;
                PxMainTable tbl = PxDataLoader.Import.TableBuilder.BuildTableFromFile(ImportFile, "Test");
                tbl.Theme = _table.Theme;
                NewMainTable = tbl;
                btnImport.Enabled = false;
            }

        }


        private void BindMainTableForm()
        {
            pxMainTableBindingSource.DataSource = _table;

            lbContents.DataSource = _table.Contents;

            lbVariables.DataSource = _table.Variables;
            SetControlMode();

        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            PxContent c = new PxContent();
            c.FootnoteValue = "N";
            c.FootnoteTime = "N";
            c.FootnoteVariable = "N";
            c.FootnoteContents = "N";
            c.Content = "New Content";
            _table.Contents.Add(c);
            _table.MarkAsDirty();
            lbContents.SelectedItem = c;
            pxContentBindingSource.DataSource = c;
        }

        private void btnRemoveContent_Click(object sender, EventArgs e)
        {
            if (lbContents.SelectedItem != null)
            {
                PxContent c = (PxContent)lbContents.SelectedItem;
                _table.Contents.Remove(c);
                if (!c.IsNew)
                {
                    _table.RemovedContents.Add(c);
                }
            }
        }

        private void btnContentUp_Click(object sender, EventArgs e)
        {
            if (lbContents.SelectedItem != null)
            {
                int oldIndex = lbContents.SelectedIndex;
                int newIndex = Math.Max(0, oldIndex  - 1);
                PxContent c = (PxContent)lbContents.SelectedItem;
                _table.Contents.RemoveAt(oldIndex);
                _table.Contents.Insert(newIndex, c);
                lbContents.SelectedIndex = newIndex;

            }
        }

        private void btnContentDown_Click(object sender, EventArgs e)
        {
            int oldIndex = lbContents.SelectedIndex;
            int newIndex = Math.Min(lbContents.Items.Count-1, oldIndex + 1);
            PxContent c = (PxContent)lbContents.SelectedItem;
            _table.Contents.RemoveAt(oldIndex);
            _table.Contents.Insert(newIndex, c);
            lbContents.SelectedIndex = newIndex;
        }


        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            ChooseVariable frmVariable = new ChooseVariable();
            if (frmVariable.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _table.Variables.Add(frmVariable.SelectedVariable);
                lbVariables.SelectedItem = frmVariable.SelectedVariable;
                pxVariableBindingSource.DataSource = frmVariable.SelectedVariable;
            }
            
        }

        public void SetTheme(string theme)
        {
         
                themeComboBox.SelectedValue = theme;
           
            
               
           
            
        }

        private void btnChooseValueset_Click(object sender, EventArgs e)
        {
            ChooseValuset frmValueset = new ChooseValuset();
            frmValueset.SelectedMainTable = _table;
            frmValueset.SelectedContent = (PxContent)lbContents.SelectedItem;
            frmValueset.SelectedVariable = (PxVariable)lbVariables.SelectedItem;
            frmValueset.selectedValueset = valueSetLabel1.Text;
            frmValueset.selectedValuePool = VariableFacade.GetValuepoolByValueSet(valueSetLabel1.Text);
            frmValueset.FootnoteNo = FootnoteNo;
            if (frmValueset.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FootnoteNo = frmValueset.FootnoteNo;
                ((PxVariable)pxVariableBindingSource.DataSource).ValueSet = frmValueset.selectedValueset;
                ((PxVariable)pxVariableBindingSource.DataSource).MarkAsDirty();
                _table.MarkAsDirty();

            }
        }

        private void storeFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storeFormatComboBox.SelectedValue!= null) {
                switch (storeFormatComboBox.SelectedValue.ToString())
                {
                    case "S":
                        storeNoCharNumericUpDown.Value = 2;
                        storeNoCharNumericUpDown.Enabled = false;
                        break;
                    case "I":
                        storeNoCharNumericUpDown.Value = 4;
                        storeNoCharNumericUpDown.Enabled = false;
                        break;
                    default:
                        storeNoCharNumericUpDown.Enabled = true;
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveMainTable())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void variableTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variableTypeComboBox.SelectedValue != null)
            {
                if (variableTypeComboBox.SelectedValue.ToString() == "T")
                {
                    ((PxVariable)pxVariableBindingSource.DataSource).ValueSet = "";
                    btnChooseValueset.Enabled = false;
                    variableTypeComboBox.SelectedValue = "T";

                }
                else
                {
                    btnChooseValueset.Enabled = true;
                }
            }
        }

        private void variableTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (pxVariableBindingSource.DataSource == null)
            {
                return;
            }
            PxVariable var = ((PxVariable)pxVariableBindingSource.DataSource);
            if (var.IsNew)
            {

                if (VariableFacade.VariableExisit(var.Variable))
                {
                    MessageBox.Show("Variable already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void btnRemoveVariable_Click(object sender, EventArgs e)
        {
            if (lbVariables.SelectedItem != null)
            {
                PxVariable v = (PxVariable)lbVariables.SelectedItem;
                _table.Variables.Remove(v);
                if (!v.IsNew)
                {
                    _table.RemovedVariables.Add(v);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        private void btnAddTimePeriods_Click(object sender, EventArgs e)
        {
            CreateTimePeriod frmCreateTimeperiod = new CreateTimePeriod();
            frmCreateTimeperiod.ImportFile = ImportFile;
            frmCreateTimeperiod.MainTable = _table;
            frmCreateTimeperiod.ShowDialog();
        }

        private void btnCreateDataTable_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (VariableFacade.CreateDataTable(_table, ref msg))
            {
                BindMainTableForm();
            }
            else
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            if (SaveMainTable())
            {
                BindMainTableForm();
                MessageBox.Show("All changes where applied!");
            }
        }

        public void SetEditMode()
        {
            tableIdTextBox.ReadOnly = true;
            btnImport.Enabled = false;
        }

        private void SetControlMode()
        {
            //Disables add?remove contents if timeperiods exisits
            if (_table.Contents.Count > 0)
            {
                btnAddTimePeriods.Enabled = true;
                if (_table.Contents[0].TimePeriods.Count > 0)
                {
                    btnAddContent.Enabled = false;
                    btnRemoveContent.Enabled = false;

                }
                else
                {
                    btnAddContent.Enabled = true;
                    btnRemoveContent.Enabled = true;

                }
            }
            else
            {
                btnAddTimePeriods.Enabled = false;
            }

            //Disables the creation of the datatable if it has already been created
            if (_table.TableStatus == "M" && _table.Contents.Count > 0 && _table.Variables.Count > 0)
            {
                btnCreateDataTable.Enabled = true;
                btnActivateTable.Enabled = false;
            }
            else
            {
                btnCreateDataTable.Enabled = false;
            }

            //Sets the controls in readonly mode if the tables status is other than expected
            if (_table.TableStatus != "M")
            {
                btnAddContent.Enabled = false;
                btnRemoveContent.Enabled = false;
                btnContentUp.Enabled = false;
                btnContentDown.Enabled = false;

                btnAddVariable.Enabled = false;
                btnRemoveVariable.Enabled = false;
                btnVariableUp.Enabled = false;
                btnVariableDown.Enabled = false;

                contentTextBox.ReadOnly = true;
                storeFormatComboBox.Enabled = false;

                variableTypeComboBox.Enabled = false;

                btnLoadData.Enabled = true;
            }

            if (_table.TableStatus == "A")
            {
                pressTextTextBox.ReadOnly = true;
                pressTextSTextBox.ReadOnly = true;
                contentVariableTextBox.ReadOnly = true;
                pressCategoryComboBox.Enabled = false;
                specCharExistsComboBox.Enabled = false;
                themeComboBox.Enabled = false;
                timeScaleIdComboBox.Enabled = false;
                tableTitleEnglishTextBox.ReadOnly = true;
                englishStatusComboBox.Enabled = false;
                englishPublishedComboBox.Enabled = false;
                contentVariableEnglishTextBox.ReadOnly = true;
                contentTextBox.ReadOnly = true;
                pressTextTextBox1.ReadOnly = true;
                pressTextEnglishTextBox.ReadOnly = true;
                pressTextSTextBox1.ReadOnly = true;
                pressTextEnglishSTextBox.ReadOnly = true;
                unitTextBox.ReadOnly = true;
                unitEnglishTextBox.ReadOnly = true;
                refPeriodTextBox.ReadOnly = true;
                refPeriodEnglishTextBox.ReadOnly = true;
                basePeriodTextBox.ReadOnly = true;
                basePeriodEnglishTextBox.ReadOnly = true;
                copyrightComboBox.Enabled = false;
                statAuthorityComboBox.Enabled = false;
                producerComboBox.Enabled = false;
                presDecimalsNumericUpDown.ReadOnly = true;
                presCellsZeroComboBox.Enabled = false;
                presMissingLineComboBox.Enabled = false;
                aggregPossibleComboBox.Enabled = false;
                stockFAComboBox.Enabled = false;
                cFPricesComboBox.Enabled = false;
                dayAdjComboBox.Enabled = false;
                seasAdjComboBox.Enabled = false;
                storeFormatComboBox.Enabled = false;
                storeNoCharNumericUpDown.ReadOnly = true;
                storeDecimalsNumericUpDown.ReadOnly = true;
                variableTypeComboBox.Enabled = false;
                btnChooseValueset.Enabled = false;
                btnActivateTable.Enabled = false;
            }

            if (_table.TableStatus == "O")
            {
                btnActivateTable.Enabled = true;
            }
           

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ImportFile))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InsertData(ofd.FileName);
                }
            }
            else
            {
                InsertData(ImportFile);
            }
        }

        private void InsertData(string fileName)
        {
            string msg = "";

            if (!VariableFacade.DataInsertInDb(_table, fileName, ref msg))
            {
                MessageBox.Show(msg);

            }
            else
            {
                btnActivateTable.Enabled = true;
            }
        }

        private void btnActivateTable_Click(object sender, EventArgs e)
        {
            string msg = "";
            _table.TableStatus = "A";
            if (!VariableFacade.Save(_table, ref msg))
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("The table was activated");
            }
        }

        private bool SaveMainTable()
        {
            string message = "";
            if (!_table.Validate(ref message))
            {
                MessageBox.Show(message, "Create Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (!VariableFacade.Save(_table, ref message))
            {
                MessageBox.Show(message, "Create Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAddMainTableFootnote_Click(object sender, EventArgs e)
        
        {
            FootnoteDialog frmFootnote = new FootnoteDialog();
            frmFootnote.Context = _table;
           
            if (_table.Footnotes.Count == 0)
            {
                PxMainTableFootnote f = (PxMainTableFootnote)CreateMainTableFootnote(frmFootnote.Context);
            }
           
            frmFootnote.SetDataSource((PxFootnote[])_table.Footnotes.ToArray());

            frmFootnote.AddFotnoteHandler = CreateMainTableFootnote;
            frmFootnote.RemoveFootnoteHandler = RemoveMainTableFootnote;
            frmFootnote.ShowDialog();
        }

     
        public PxFootnote CreateMainTableFootnote(PxObject context)
        {
            PxMainTableFootnote f = new PxMainTableFootnote();
            f.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            f.FootnoteText = "Shenim i ri";
            f.FootnoteTextEnglish = "New Footnote";
            f.MandOption = "O";
            f.ShowFootnote = "B";
            f.IsNew = true;

            _table.Footnotes.Add(f);
            _table.MarkAsDirty();
            return f;
        }


        public void RemoveMainTableFootnote(PxObject context, PxFootnote footnote)
        {
            _table.Footnotes.Remove((PxMainTableFootnote)footnote);
            if (!footnote.IsNew)
            {
                _table.RemovedFootnotes.Add((PxMainTableFootnote)footnote);
                _table.MarkAsDirty();
            }

        }

        private void btnAddContentFootnote_Click(object sender, EventArgs e)
        {
            PxContent pxContent = (PxContent)lbContents.SelectedItem;
            if (pxContent != null)
            {
                FootnoteDialog frmFootnote = new FootnoteDialog();
                frmFootnote.Context = pxContent;
                pxContent.FootnoteContents = "B";
                if (pxContent.Footnotes.Count == 0)
                {
                    PxContentFootnote contentFootnote = (PxContentFootnote)CreateContentFootnote(pxContent);
                }
                frmFootnote.SetDataSource((PxFootnote[])(pxContent).Footnotes.ToArray());

                frmFootnote.AddFotnoteHandler = CreateContentFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveContentFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a content first!");
            }
        }

        public PxFootnote CreateContentFootnote(PxObject context)
        {
            PxContentFootnote f = new PxContentFootnote();
            f.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            f.FootnoteText = "Shenim i ri";
            f.FootnoteTextEnglish = "New Footnote";
            f.MandOption = "O";
            f.ShowFootnote = "B";
            f.IsNew = true;
            ((PxContent)lbContents.SelectedItem).Footnotes.Add(f);
            ((PxContent)lbContents.SelectedItem).MarkAsDirty();
            _table.MarkAsDirty();
            return f;
        }


        public void RemoveContentFootnote(PxObject context, PxFootnote footnote)
        {
            ((PxContent)lbContents.SelectedItem).Footnotes.Remove((PxContentFootnote)footnote);
            if (!footnote.IsNew)
            {
                ((PxContent)lbContents.SelectedItem).RemovedFootnotes.Add((PxContentFootnote)footnote);
                ((PxContent)lbContents.SelectedItem).MarkAsDirty();
                _table.MarkAsDirty();
            }

        }

        private void llAddFootnoteInSelectedVariableForSelectedContent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PxContent pxContent = (PxContent)lbContents.SelectedItem;
            PxVariable variable = (PxVariable)lbVariables.SelectedItem;
           
            if (pxContent != null && variable != null)
            {
                var contentVariableFootnoteArray = (from vf in pxContent.ContentVariableFootnotes
                                                    where vf.Variable == variable
                                                    select vf).ToArray();
                FootnoteDialog frmFootnote = new FootnoteDialog();
                
                frmFootnote.Context = pxContent;
                pxContent.FootnoteVariable = "B";
                if (contentVariableFootnoteArray.Count() == 0)
                {
                    PxContentVariableFootnote contentVariableFootnote = (PxContentVariableFootnote)CreateContentVariableFootnote(pxContent);
                    contentVariableFootnoteArray = (from vf in pxContent.ContentVariableFootnotes
                                                    where vf.Variable == variable
                                                    select vf).ToArray();
                }
                frmFootnote.SetDataSource((PxFootnote[])contentVariableFootnoteArray);

                frmFootnote.AddFotnoteHandler = CreateContentVariableFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveContentVariableFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a content and a variable first!");
              
            }
         
        }

        public PxContentVariableFootnote CreateContentVariableFootnote(PxObject context)
        {
            PxContentVariableFootnote cvf = new PxContentVariableFootnote();
            cvf.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            cvf.FootnoteText = "Shenim i ri";
            cvf.FootnoteTextEnglish = "New Footnote";
            cvf.MandOption = "O";
            cvf.ShowFootnote = "B";
            cvf.IsNew = true;
            cvf.Variable = (PxVariable)lbVariables.SelectedItem;
            ((PxContent)lbContents.SelectedItem).ContentVariableFootnotes.Add(cvf);
            ((PxVariable)lbVariables.SelectedItem).MarkAsDirty();
            ((PxContent)lbContents.SelectedItem).MarkAsDirty();
            _table.MarkAsDirty();
            return cvf;
            
        }


        public void RemoveContentVariableFootnote(PxObject context, PxFootnote footnote)
        {

            ((PxContent)lbContents.SelectedItem).ContentVariableFootnotes.Remove((PxContentVariableFootnote)footnote);
            if (!footnote.IsNew)
            {
                ((PxContent)lbContents.SelectedItem).RemovedContentVariableFootnotes.Add((PxContentVariableFootnote)footnote);
                ((PxVariable)lbVariables.SelectedItem).MarkAsDirty();
                ((PxContent)lbContents.SelectedItem).MarkAsDirty();
                _table.MarkAsDirty();
            }

        }

        private void llAddFootnoteInSelectedVariable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PxVariable pxVariable = (PxVariable)lbVariables.SelectedItem;

            if (pxVariable != null)
            {
                var variableFootnoteArray = (from vf in pxVariable.VariableFootnotes
                                                    select vf).ToArray();
                FootnoteDialog frmFootnote = new FootnoteDialog();

                frmFootnote.Context = pxVariable;

                //TODO a better solution for Footnote
                pxVariable.Footnote = "B";

                if (variableFootnoteArray.Count() == 0)
                {
                    PxVariableFootnote variableFootnote = (PxVariableFootnote)CreateVariableFootnote(pxVariable);
                    variableFootnoteArray = (from vf in pxVariable.VariableFootnotes
                                             select vf).ToArray();
                }
                frmFootnote.SetDataSource((PxFootnote[])variableFootnoteArray);

                frmFootnote.AddFotnoteHandler = CreateVariableFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveVariableFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a content and a variable first!");

            }
        }


        public PxVariableFootnote CreateVariableFootnote(PxObject context)
        {
            PxVariableFootnote vf = new PxVariableFootnote();
            vf.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            vf.FootnoteText = "Shenim i ri";
            vf.FootnoteTextEnglish = "New Footnote";
            vf.MandOption = "O";
            vf.ShowFootnote = "B";
            vf.IsNew = true;
            ((PxVariable)lbVariables.SelectedItem).VariableFootnotes.Add(vf);
            ((PxVariable)lbVariables.SelectedItem).MarkAsDirty();
            _table.MarkAsDirty();
            return vf;

        }


        public void RemoveVariableFootnote(PxObject context, PxFootnote footnote)
        {

            ((PxVariable)lbVariables.SelectedItem).VariableFootnotes.Remove((PxVariableFootnote)footnote);
            if (!footnote.IsNew)
            {
                ((PxVariable)lbVariables.SelectedItem).RemovedVariableFootnotes.Add((PxVariableFootnote)footnote);
                ((PxVariable)lbVariables.SelectedItem).MarkAsDirty();
                _table.MarkAsDirty();
            }

        }






        //public PxFootnote CreateVariableFootnote(PxObject context)
        //{
            //PxVariableFootnote f = new PxVariableFootnote();
            //f.FootnoteText = "New footnote";
            //((PxVariable)context).Footnotes.Add(f);
            //return f;
        //}
    }


}
