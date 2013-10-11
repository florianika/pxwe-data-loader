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
    public partial class CreateValuePoolDialog : Form
    {
        public CreateValuePoolDialog()
        {
            InitializeComponent();
        }

        public PxValuePool SelectedValuePool { get; set; }
        
        private void CreateValuePoolDialog_Load(object sender, EventArgs e)
        {
            SelectedValuePool = new PxValuePool();
            pxValuePoolBindingSource.DataSource = SelectedValuePool;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!SelectedValuePool.Validate(ref message))
            {
                MessageBox.Show(message, "Create value pool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (!VariableFacade.Save(SelectedValuePool, ref message))
            {
                MessageBox.Show(message, "Create value pool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
