using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PxDataLoader
{
    public partial class ChooseVariable : Form
    {
        public ChooseVariable()
        {
            InitializeComponent();
        }

        public Model.PxVariable SelectedVariable { get; set; }

        private void ChooseVariable_Load(object sender, EventArgs e)
        {
            List<Option> variables = VariableFacade.GetVariableList();

            foreach (var v in variables) 
            {
                lvVariables.Items.Add(v.Code).SubItems.Add(v.Text);
            }
            
        }

        private void lvVariables_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvVariables.SelectedIndices.Count == 1)
            {
                SelectedVariable = VariableFacade.GetVarible(lvVariables.SelectedItems[0].Text);
                pxVariableBindingSource.DataSource = SelectedVariable;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnSelectVariable_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            SelectedVariable = new Model.PxVariable() {Variable = "New variable"};
           // lvVariables.Items.Add(SelectedVariable.Variable);
            pxVariableBindingSource.DataSource = SelectedVariable;
            lvVariables.Enabled = false;

        }

    }
}
