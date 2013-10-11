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
    public partial class CreateValueSetDialog : Form
    {
        public CreateValueSetDialog()
        {
            InitializeComponent();
            this.dgwValues.KeyDown += new KeyEventHandler(dgwValues_KeyDown);
        }

        private void CreateValueSetDialog_Load(object sender, EventArgs e)
        {
            valuePresComboBox.DataSource = Option.GetOptions("ValuePres");
            RefreshValuePool();
        }

        private PxValueSet _valueSet;
        public PxValueSet  SelectedValueSet 
        {
            get
            {
                return _valueSet;
            }
            set
            {
                _valueSet = value;
                pxValueSetBindingSource.DataSource = _valueSet;
                dgwValues.DataSource = _valueSet.Values;
                List<Option> eliminationSource = Option.GetOptions("Elimination");

                if (!String.IsNullOrWhiteSpace(_valueSet.Valueset))
                {
                    eliminationSource.AddRange(VariableFacade.GetValuesListByValueset(_valueSet.Valueset.Replace("Copy_of_", "")));
                }
                eliminationComboBox.DataSource = eliminationSource;

            }
        }



        void dgwValues_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = dgwValues.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = dgwValues.CurrentCell.RowIndex;
                int col = dgwValues.CurrentCell.ColumnIndex;
                dgwValues.CancelEdit();
                foreach (string line in lines)
                {
                    string[] cells = line.Split('\t');
                    if (cells.Length == 3)
                    {
                        PxValue val = new PxValue() { ValueCode = cells[0], ValueText = cells[1], ValueTextEnglish = cells[2].Replace("\r", "") };
                        //_valueSet.Values.EndNew(0);
                        _valueSet.Values.CancelNew(0);
                        _valueSet.Values.Add(val);
                    }

                }

                //Add the pasted values as soruce for elimination 
                List<Option> eliminationSource = Option.GetOptions("Elimination");

                if (!String.IsNullOrWhiteSpace(_valueSet.Valueset))
                {
                    var eliminationOptions = (from v in _valueSet.Values
                                              select new Option()
                                              {
                                                  Code = v.ValueCode,
                                                  Text = v.ValueText
                                              }
                                                 ).ToList();
                    eliminationSource.AddRange(eliminationOptions);
                }
                eliminationComboBox.DataSource = eliminationSource;
            }

            
        }

        private void RefreshValuePool()
        { 
            valuePoolComboBox.DataSource = VariableFacade.GetValuePools();
            pxValueSetBindingSource.CurrencyManager.Refresh();
        }

        private void btnCreateValuePool_Click(object sender, EventArgs e)
        {
            CreateValuePoolDialog dlg = new CreateValuePoolDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshValuePool();
                valuePoolComboBox.SelectedValue = dlg.SelectedValuePool.ValuePool;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!_valueSet.Validate(ref message))
            {
                MessageBox.Show(message, "Create valueset", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (!VariableFacade.Save(_valueSet, ref message))
            {
                MessageBox.Show(message, "Create value pool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnAddValuesFromValuepool_Click(object sender, EventArgs e)
        {
            ChooseValues frmChooseValues = new ChooseValues();
            List<PxValue> valueList = VariableFacade.GetValuesByValuePool(_valueSet.ValuePool);

            foreach (var val in _valueSet.Values)
            {
                PxValue value = PxValueSet.GetValue(valueList, val.ValueCode);
                if (value != null)
                {
                    valueList.Remove(value);
                }
            }
            frmChooseValues.DataSource = valueList;
            if (frmChooseValues.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<PxValue> selectedValues = frmChooseValues.SelectedValues;
                foreach (var sv in selectedValues)
                {
                    _valueSet.Values.Add(sv);
                }
            }
            
        }
    }
}
