namespace PxDataLoader
{
    partial class FootnoteDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label footnoteTextLabel;
            System.Windows.Forms.Label footnoteTextEnglishLabel;
            System.Windows.Forms.Label mandOptionLabel;
            System.Windows.Forms.Label showFootnoteLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.footnoteTextTextBox = new System.Windows.Forms.TextBox();
            this.footnoteTextEnglishTextBox = new System.Windows.Forms.TextBox();
            this.mandOptionComboBox = new System.Windows.Forms.ComboBox();
            this.showFootnoteComboBox = new System.Windows.Forms.ComboBox();
            this.lbFootnote = new System.Windows.Forms.ListBox();
            this.btnAddFootnote = new System.Windows.Forms.Button();
            this.btnRemoveFootnote = new System.Windows.Forms.Button();
            this.pxFootnoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            footnoteTextLabel = new System.Windows.Forms.Label();
            footnoteTextEnglishLabel = new System.Windows.Forms.Label();
            mandOptionLabel = new System.Windows.Forms.Label();
            showFootnoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pxFootnoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(388, 340);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // footnoteTextTextBox
            // 
            this.footnoteTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxFootnoteBindingSource, "FootnoteText", true));
            this.footnoteTextTextBox.Location = new System.Drawing.Point(354, 21);
            this.footnoteTextTextBox.Multiline = true;
            this.footnoteTextTextBox.Name = "footnoteTextTextBox";
            this.footnoteTextTextBox.Size = new System.Drawing.Size(190, 74);
            this.footnoteTextTextBox.TabIndex = 2;
            this.footnoteTextTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.footnoteTextTextBox_Validating);
            // 
            // footnoteTextLabel
            // 
            footnoteTextLabel.AutoSize = true;
            footnoteTextLabel.Location = new System.Drawing.Point(272, 24);
            footnoteTextLabel.Name = "footnoteTextLabel";
            footnoteTextLabel.Size = new System.Drawing.Size(76, 13);
            footnoteTextLabel.TabIndex = 1;
            footnoteTextLabel.Text = "Footnote Text:";
            // 
            // footnoteTextEnglishTextBox
            // 
            this.footnoteTextEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxFootnoteBindingSource, "FootnoteTextEnglish", true));
            this.footnoteTextEnglishTextBox.Location = new System.Drawing.Point(354, 110);
            this.footnoteTextEnglishTextBox.Multiline = true;
            this.footnoteTextEnglishTextBox.Name = "footnoteTextEnglishTextBox";
            this.footnoteTextEnglishTextBox.Size = new System.Drawing.Size(190, 72);
            this.footnoteTextEnglishTextBox.TabIndex = 3;
            this.footnoteTextEnglishTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.footnoteTextTextBox_Validating);
            // 
            // footnoteTextEnglishLabel
            // 
            footnoteTextEnglishLabel.AutoSize = true;
            footnoteTextEnglishLabel.Location = new System.Drawing.Point(235, 113);
            footnoteTextEnglishLabel.Name = "footnoteTextEnglishLabel";
            footnoteTextEnglishLabel.Size = new System.Drawing.Size(113, 13);
            footnoteTextEnglishLabel.TabIndex = 2;
            footnoteTextEnglishLabel.Text = "Footnote Text English:";
            // 
            // mandOptionComboBox
            // 
            this.mandOptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxFootnoteBindingSource, "MandOption", true));
            this.mandOptionComboBox.DisplayMember = "Text";
            this.mandOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mandOptionComboBox.FormattingEnabled = true;
            this.mandOptionComboBox.Location = new System.Drawing.Point(354, 188);
            this.mandOptionComboBox.Name = "mandOptionComboBox";
            this.mandOptionComboBox.Size = new System.Drawing.Size(190, 21);
            this.mandOptionComboBox.TabIndex = 5;
            this.mandOptionComboBox.ValueMember = "Code";
            // 
            // mandOptionLabel
            // 
            mandOptionLabel.AutoSize = true;
            mandOptionLabel.Location = new System.Drawing.Point(277, 191);
            mandOptionLabel.Name = "mandOptionLabel";
            mandOptionLabel.Size = new System.Drawing.Size(71, 13);
            mandOptionLabel.TabIndex = 4;
            mandOptionLabel.Text = "Mand Option:";
            // 
            // showFootnoteComboBox
            // 
            this.showFootnoteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxFootnoteBindingSource, "ShowFootnote", true));
            this.showFootnoteComboBox.DisplayMember = "Text";
            this.showFootnoteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showFootnoteComboBox.FormattingEnabled = true;
            this.showFootnoteComboBox.Location = new System.Drawing.Point(354, 215);
            this.showFootnoteComboBox.Name = "showFootnoteComboBox";
            this.showFootnoteComboBox.Size = new System.Drawing.Size(190, 21);
            this.showFootnoteComboBox.TabIndex = 7;
            this.showFootnoteComboBox.ValueMember = "Code";
            // 
            // showFootnoteLabel
            // 
            showFootnoteLabel.AutoSize = true;
            showFootnoteLabel.Location = new System.Drawing.Point(266, 218);
            showFootnoteLabel.Name = "showFootnoteLabel";
            showFootnoteLabel.Size = new System.Drawing.Size(82, 13);
            showFootnoteLabel.TabIndex = 6;
            showFootnoteLabel.Text = "Show Footnote:";
            // 
            // lbFootnote
            // 
            this.lbFootnote.DisplayMember = "FootnoteNo";
            this.lbFootnote.FormattingEnabled = true;
            this.lbFootnote.Location = new System.Drawing.Point(32, 12);
            this.lbFootnote.Name = "lbFootnote";
            this.lbFootnote.Size = new System.Drawing.Size(196, 316);
            this.lbFootnote.TabIndex = 10;
            this.lbFootnote.SelectedIndexChanged += new System.EventHandler(this.lbFootnote_SelectedIndexChanged);
            // 
            // btnAddFootnote
            // 
            this.btnAddFootnote.Location = new System.Drawing.Point(72, 340);
            this.btnAddFootnote.Name = "btnAddFootnote";
            this.btnAddFootnote.Size = new System.Drawing.Size(75, 23);
            this.btnAddFootnote.TabIndex = 11;
            this.btnAddFootnote.Text = "Add";
            this.btnAddFootnote.UseVisualStyleBackColor = true;
            this.btnAddFootnote.Click += new System.EventHandler(this.btnAddFootnote_Click);
            // 
            // btnRemoveFootnote
            // 
            this.btnRemoveFootnote.Location = new System.Drawing.Point(153, 340);
            this.btnRemoveFootnote.Name = "btnRemoveFootnote";
            this.btnRemoveFootnote.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFootnote.TabIndex = 12;
            this.btnRemoveFootnote.Text = "Remove";
            this.btnRemoveFootnote.UseVisualStyleBackColor = true;
            this.btnRemoveFootnote.Click += new System.EventHandler(this.btnRemoveFootnote_Click);
            // 
            // pxFootnoteBindingSource
            // 
            this.pxFootnoteBindingSource.DataSource = typeof(PxDataLoader.Model.PxFootnote);
            // 
            // FootnoteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 379);
            this.Controls.Add(this.btnRemoveFootnote);
            this.Controls.Add(this.btnAddFootnote);
            this.Controls.Add(this.lbFootnote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(showFootnoteLabel);
            this.Controls.Add(this.showFootnoteComboBox);
            this.Controls.Add(mandOptionLabel);
            this.Controls.Add(this.mandOptionComboBox);
            this.Controls.Add(footnoteTextEnglishLabel);
            this.Controls.Add(this.footnoteTextEnglishTextBox);
            this.Controls.Add(footnoteTextLabel);
            this.Controls.Add(this.footnoteTextTextBox);
            this.Name = "FootnoteDialog";
            this.Text = "FootnoteDialog";
            this.Load += new System.EventHandler(this.FootnoteDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxFootnoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pxFootnoteBindingSource;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox footnoteTextTextBox;
        private System.Windows.Forms.TextBox footnoteTextEnglishTextBox;
        private System.Windows.Forms.ComboBox mandOptionComboBox;
        private System.Windows.Forms.ComboBox showFootnoteComboBox;
        private System.Windows.Forms.ListBox lbFootnote;
        private System.Windows.Forms.Button btnAddFootnote;
        private System.Windows.Forms.Button btnRemoveFootnote;
    }
}