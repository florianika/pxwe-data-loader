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
    public partial class ChooseValues : Form
    {

        public List<PxValue> SelectedValues
        {
            get
            {
                List<PxValue> selValues = new List<PxValue>();
                foreach (var row in dgwValues.SelectedRows)
                {
                    selValues.Add((PxValue)((System.Windows.Forms.DataGridViewRow)row).DataBoundItem);
                }
                return selValues;
            }
        }

        public List<PxValue> DataSource 
        { 
            get 
            { 
                return (List<PxValue>)dgwValues.DataSource; 
            }
            set 
            { 
                dgwValues.DataSource = value; 
            }
        }
        public ChooseValues()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }




    }
}
