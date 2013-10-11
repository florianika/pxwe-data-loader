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
    public partial class FootnoteDialog : Form
    {
        public delegate PxFootnote AddFootnote(PxObject context);

        public delegate void RemoveFootnote(PxObject context, PxFootnote footnote);


        public AddFootnote AddFotnoteHandler { get; set; }

        public RemoveFootnote RemoveFootnoteHandler { get; set; }


        public PxObject Context { get; set; }

        public FootnoteDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FootnoteDialog_Load(object sender, EventArgs e)
        {
            mandOptionComboBox.DataSource = Option.GetOptions("MandOpt");
            showFootnoteComboBox.DataSource = Option.GetOptions("ShowFootnote");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private List<PxFootnote> _list;

        public void SetDataSource(PxFootnote[] footnotes)
        {
            _list = new List<PxFootnote>();
            _list.AddRange(footnotes);
            lbFootnote.DataSource = _list;
        }

        private void btnAddFootnote_Click(object sender, EventArgs e)
        {
            PxFootnote footnote = AddFotnoteHandler(Context);
            _list.Add(footnote);
            ((CurrencyManager)(lbFootnote.BindingContext[lbFootnote.DataSource])).Refresh();
            lbFootnote.SelectedItem = footnote;
            pxFootnoteBindingSource.DataSource = footnote;
        }

        private void btnRemoveFootnote_Click(object sender, EventArgs e)
        {

            if (lbFootnote.SelectedItem != null)
            {
                PxFootnote footnote;
                footnote = (PxFootnote)lbFootnote.SelectedItem;
                _list.Remove(footnote);
                RemoveFootnoteHandler(Context, footnote);
                ((CurrencyManager)(lbFootnote.BindingContext[lbFootnote.DataSource])).Refresh();
            }
        }

        private void lbFootnote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFootnote.SelectedItem != null)
            {
                pxFootnoteBindingSource.DataSource = lbFootnote.SelectedItem;
            }
        }

        private void footnoteTextTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox txb = (TextBox)sender;

            if (txb.Text.Length == 0)
            {
                e.Cancel = true;
            }
        }

    }
}
