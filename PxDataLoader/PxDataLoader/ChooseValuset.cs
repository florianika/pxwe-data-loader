using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PxDataLoader.Model;

namespace PxDataLoader
{
    public partial class ChooseValuset : Form
    {
        private string _selectedValueset;
        public string selectedValueset
        {
            get
            {
                return _selectedValueset;//lbValuesets.SelectedValue.ToString();
            }

            set
            {
                    _selectedValueset = value;
               
            }
        }

        public PxMainTable SelectedMainTable { get; set; }

        public PxContent SelectedContent { get; set; }

        public PxVariable SelectedVariable { get; set; }

        public PxValue SelectedValue { get; set; }

        public string selectedValuePool { get; set; }

        public int FootnoteNo { get; set; }

        public ChooseValuset()
        {
            InitializeComponent();
        }

        private void ChooseValuset_Load(object sender, EventArgs e)
        {
            lbValuePools.DataSource = VariableFacade.GetValuePools();
            if (!String.IsNullOrEmpty(selectedValuePool) )
            {
                lbValuePools.SelectedValue = selectedValuePool;
            }
            if (!String.IsNullOrEmpty(selectedValueset))
            {
                lbValuesets.SelectedValue = selectedValueset;
            }
            valuePresComboBox.DataSource = Option.GetOptions("ValuePres");

            SelectedValue = (PxValue)dgwValues.SelectedRows[0].DataBoundItem;

        }

        private void lbValuePools_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbValuesets.DataSource = VariableFacade.GetValuesetsByValuePoolPxValueset(lbValuePools.SelectedValue.ToString());
            if (lbValuesets.SelectedValue != null)
            {
                btnOk.Enabled = true;

            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void lbValuesets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbValuesets.SelectedValue != null)
            {
                btnOk.Enabled = true;
                List<Option> eliminationSource = Option.GetOptions("Elimination");

                eliminationSource.AddRange(VariableFacade.GetValuesListByValueset(lbValuesets.SelectedValue.ToString()));
                eliminationComboBox.DataSource = eliminationSource;

                List<Model.PxValue> valuesOfSelectedValueset = VariableFacade.GetValuesByValueset(lbValuesets.SelectedValue.ToString());

                pxValueSetBindingSource.DataSource = VariableFacade.GetValueSet(lbValuesets.SelectedValue.ToString());
                dgwValues.DataSource = valuesOfSelectedValueset;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void btnNewValueSet_Click(object sender, EventArgs e)
        {
            CreateValueSetDialog dlg = new CreateValueSetDialog();
            dlg.SelectedValueSet = new Model.PxValueSet();
            dlg.ShowDialog();
        }

        private void btnCopyValueSet_Click(object sender, EventArgs e)
        {
            PxValueSet source = (PxValueSet)pxValueSetBindingSource.DataSource;
            PxValueSet copy = new PxValueSet() { 
                Valueset = "Copy_of_" + source.Valueset,
                Elimination = source.Elimination,
                PresText = source.PresText,
                PresTextEnglish = source.PresTextEnglish,
                ValuePool = source.ValuePool,
                ValuePres = source.ValuePres,
            };

            List<PxValue> values = (List<PxValue>)dgwValues.DataSource;

            foreach (var val in values)
            {
                copy.Values.Add(new PxValue() { ValueCode = val.ValueCode, ValueText = val.ValueText, ValueTextEnglish = val.ValueTextEnglish , Footnote = "N"});  
            }


            CreateValueSetDialog dlg = new CreateValueSetDialog();
            dlg.SelectedValueSet = copy;
            dlg.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveValueFootnotes();
            selectedValueset = lbValuesets.SelectedValue.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void SaveValueFootnotes()
        {
          
            foreach (var vs in (List<PxValueSet>)lbValuesets.DataSource)
            {
                if (vs.IsDirty)
                {
                    vs.ValuePool = lbValuePools.SelectedValue.ToString();
                    foreach (var v in ((List<PxValue>)dgwValues.DataSource))
                    {
                        vs.Values.Add(v);
                    }
                    string msg = "";
                    VariableFacade.Save(vs, ref msg);
                }
            }
        }

        private void btnNewValuepool_Click(object sender, EventArgs e)
        {
            CreateValuePoolDialog dlg = new CreateValuePoolDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbValuePools.DataSource = VariableFacade.GetValuePools();
                lbValuePools.SelectedValue = dlg.SelectedValuePool.ValuePool;
            }
        }

        private void llAddFootnoteContentValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PxContent pxContent = SelectedContent;
            PxVariable variable = SelectedVariable;
            PxValue value = SelectedValue;
          
            if (pxContent != null && variable != null && value != null)
            {

                var contentValueFootnoteArray = (from vf in pxContent.ContentValueFootnotes
                                                 where vf.Variable.Variable == variable.Variable && vf.Value.ValuePool == value.ValuePool && vf.Value.ValueCode == value.ValueCode
                                                 select vf).ToArray();

                FootnoteDialog frmFootnote = new FootnoteDialog();
                frmFootnote.Context = pxContent;
                pxContent.FootnoteValue = "B";
                if (contentValueFootnoteArray.Count() == 0)
                {
                    PxContentValueFootnote contentValueFootnote = (PxContentValueFootnote)CreateContentValueFootnote(pxContent);
                    contentValueFootnoteArray = (from vf in pxContent.ContentValueFootnotes
                                                 where vf.Variable == variable && vf.Value == value
                                                 select vf).ToArray();

                }
                frmFootnote.SetDataSource((PxFootnote[])contentValueFootnoteArray);

                frmFootnote.AddFotnoteHandler = CreateContentValueFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveContentValueFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a content, a variable and a value first!");
              
            }
        }


        public PxContentValueFootnote CreateContentValueFootnote(PxObject context)
        {
            PxContentValueFootnote cvf = new PxContentValueFootnote();
            cvf.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            cvf.FootnoteText = "Shenim i ri";
            cvf.FootnoteTextEnglish = "New Footnote";
            cvf.MandOption = "M";
            cvf.ShowFootnote = "B";
            cvf.IsNew = true;
            cvf.Variable = SelectedVariable;
            cvf.Value = SelectedValue;
            SelectedContent.ContentValueFootnotes.Add(cvf);
            SelectedContent.MarkAsDirty();
            SelectedMainTable.MarkAsDirty();
            return cvf;

        }


        public void RemoveContentValueFootnote(PxObject context, PxFootnote footnote)
        {

            SelectedContent.ContentValueFootnotes.Remove((PxContentValueFootnote)footnote);
            if (!footnote.IsNew)
            {
                SelectedContent.RemovedContentValueFootnotes.Add((PxContentValueFootnote)footnote);
            }

        }

        private void llAddFootnoteMainTValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PxMainTable pxMainTable = SelectedMainTable;
            PxVariable variable = SelectedVariable;
            PxValue value = SelectedValue;

            if ( variable != null && value != null)
            {

                var contentMainTableValueFootnoteArray = (from mtvf in pxMainTable.MainTableValueFootnotes
                                                 where mtvf.Variable.Variable == variable.Variable && mtvf.Value.ValuePool == value.ValuePool && mtvf.Value.ValueCode ==  value.ValueCode
                                                 select mtvf).ToArray();

                FootnoteDialog frmFootnote = new FootnoteDialog();
                frmFootnote.Context = pxMainTable;
                pxMainTable.MarkAsDirty();
                if (contentMainTableValueFootnoteArray.Count() == 0)
                {
                    PxMainTableValueFootnote mainTableValueFootnote = (PxMainTableValueFootnote)CreateMainTableValueFootnote(pxMainTable);
                    contentMainTableValueFootnoteArray = (from vf in pxMainTable.MainTableValueFootnotes
                                                 where vf.Variable == variable && vf.Value == value
                                                 select vf).ToArray();

                }
                frmFootnote.SetDataSource((PxFootnote[])contentMainTableValueFootnoteArray);

                frmFootnote.AddFotnoteHandler = CreateMainTableValueFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveMainTableValueFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a content, a variable and a value first!");

            }
        }



        public PxMainTableValueFootnote CreateMainTableValueFootnote(PxObject context)
        {
            PxMainTableValueFootnote mtvf = new PxMainTableValueFootnote();
            mtvf.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            mtvf.FootnoteText = "Shenim i ri";
            mtvf.FootnoteTextEnglish = "New Footnote";
            mtvf.MandOption = "O";
            mtvf.ShowFootnote = "B";
            mtvf.IsNew = true;
            mtvf.Variable = SelectedVariable;
            mtvf.Value = SelectedValue;
            SelectedMainTable.MainTableValueFootnotes.Add(mtvf);
            SelectedMainTable.MarkAsDirty();
            SelectedValue.MarkAsDirty();
            return mtvf;

        }


        public void RemoveMainTableValueFootnote(PxObject context, PxFootnote footnote)
        {

            SelectedMainTable.MainTableValueFootnotes.Remove((PxMainTableValueFootnote)footnote);
            if (!footnote.IsNew)
            {
                SelectedMainTable.RemovedMainTableValueFootnotes.Add((PxMainTableValueFootnote)footnote);
                ((PxValueSet)lbValuesets.SelectedItem).MarkAsDirty();
            }

        }

        private void llAddValueFootnote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        
        {
            

            if (SelectedValue != null)
            {

                var valueFootnoteArray = (from vf in SelectedValue.ValueFootnotes
                                                          select vf).ToArray();

                FootnoteDialog frmFootnote = new FootnoteDialog();
                frmFootnote.Context = SelectedValue;
                SelectedValue.Footnote = "B";
                if (valueFootnoteArray.Count() == 0)
                {
                    PxValueFootnote mainTableValueFootnote = (PxValueFootnote)CreateValueFootnote(SelectedValue);
                    valueFootnoteArray = (from vf in SelectedValue.ValueFootnotes
                                                 select vf).ToArray();

                }
                frmFootnote.SetDataSource((PxFootnote[])valueFootnoteArray);

                frmFootnote.AddFotnoteHandler = CreateValueFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveValueFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a content, a variable and a value first!");

            }
        }

        public PxValueFootnote CreateValueFootnote(PxObject context)
        {
            PxValueFootnote vf = new PxValueFootnote();
            vf.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            vf.FootnoteText = "Shenim i ri";
            vf.FootnoteTextEnglish = "New Footnote";
            vf.MandOption = "O";
            vf.ShowFootnote = "B";
            vf.IsNew = true;
            vf.Value = SelectedValue;
            SelectedValue.ValueFootnotes.Add(vf);
            SelectedValue.MarkAsDirty();
            ((PxValueSet)lbValuesets.SelectedItem).MarkAsDirty();
            return vf;

        }


        public void RemoveValueFootnote(PxObject context, PxFootnote footnote)
        {

            SelectedValue.ValueFootnotes.Remove((PxValueFootnote)footnote);
            if (!footnote.IsNew)
            {
                SelectedValue.RemovedValueFootnotes.Add((PxValueFootnote)footnote);
                SelectedValue.MarkAsDirty();
                SelectedMainTable.MarkAsDirty();
            }

        }

      

        private void dgwValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwValues.SelectedRows.Count == 1)
            {
                SelectedValue = (PxValue)dgwValues.SelectedRows[0].DataBoundItem;
            }
        }



    }
}
