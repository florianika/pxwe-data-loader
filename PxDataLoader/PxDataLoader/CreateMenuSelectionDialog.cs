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
    public partial class CreateMenuSelectionDialog : Form
    {
        public PxDataLoader.Model.PxMenuSelection NewMenuSelection { get; set; }

        public CreateMenuSelectionDialog()
        {
            InitializeComponent();
            NewMenuSelection = new Model.PxMenuSelection();
        }

        private void CreateMenuSelectionDialog_Load(object sender, EventArgs e)
        {
            presentationComboBox.DataSource = Option.GetOptions("Presentation");
            presentationEnglishComboBox.DataSource = Option.GetOptions("Presentation");
            pxMenuSelectionBindingSource.DataSource = NewMenuSelection;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!NewMenuSelection.Validate(ref message))
            {
                MessageBox.Show(message, "Create Menu Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (!VariableFacade.Save(NewMenuSelection, ref message))
            {
                MessageBox.Show(message, "Create Menu Selection", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
