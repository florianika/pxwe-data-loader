namespace PxDataLoader
{
    partial class ChooseValuset
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
            System.Windows.Forms.Label presTextLabel;
            System.Windows.Forms.Label presTextEnglishLabel;
            System.Windows.Forms.Label valuePoolLabel;
            System.Windows.Forms.Label valuesetLabel;
            System.Windows.Forms.Label valuePresLabel;
            System.Windows.Forms.Label eliminationLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNewValuepool = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValuePools = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewValueSet = new System.Windows.Forms.Button();
            this.btnCopyValueSet = new System.Windows.Forms.Button();
            this.lbValuesets = new System.Windows.Forms.ListBox();
            this.llAddFootnoteContentValue = new System.Windows.Forms.LinkLabel();
            this.llAddFootnoteMainTValue = new System.Windows.Forms.LinkLabel();
            this.llAddValueFootnote = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwValues = new System.Windows.Forms.DataGridView();
            this.colValueCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Footnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValuePool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueTextEnglish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDirty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminationComboBox = new System.Windows.Forms.ComboBox();
            this.valuePresComboBox = new System.Windows.Forms.ComboBox();
            this.valuesetTextBox = new System.Windows.Forms.TextBox();
            this.valuePoolTextBox = new System.Windows.Forms.TextBox();
            this.presTextEnglishTextBox = new System.Windows.Forms.TextBox();
            this.presTextTextBox = new System.Windows.Forms.TextBox();
            this.pxValueSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            presTextLabel = new System.Windows.Forms.Label();
            presTextEnglishLabel = new System.Windows.Forms.Label();
            valuePoolLabel = new System.Windows.Forms.Label();
            valuesetLabel = new System.Windows.Forms.Label();
            valuePresLabel = new System.Windows.Forms.Label();
            eliminationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxValueSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // presTextLabel
            // 
            presTextLabel.AutoSize = true;
            presTextLabel.Location = new System.Drawing.Point(64, 36);
            presTextLabel.Name = "presTextLabel";
            presTextLabel.Size = new System.Drawing.Size(55, 13);
            presTextLabel.TabIndex = 0;
            presTextLabel.Text = "Pres Text:";
            // 
            // presTextEnglishLabel
            // 
            presTextEnglishLabel.AutoSize = true;
            presTextEnglishLabel.Location = new System.Drawing.Point(27, 62);
            presTextEnglishLabel.Name = "presTextEnglishLabel";
            presTextEnglishLabel.Size = new System.Drawing.Size(92, 13);
            presTextEnglishLabel.TabIndex = 2;
            presTextEnglishLabel.Text = "Pres Text English:";
            // 
            // valuePoolLabel
            // 
            valuePoolLabel.AutoSize = true;
            valuePoolLabel.Location = new System.Drawing.Point(58, 96);
            valuePoolLabel.Name = "valuePoolLabel";
            valuePoolLabel.Size = new System.Drawing.Size(61, 13);
            valuePoolLabel.TabIndex = 4;
            valuePoolLabel.Text = "Value Pool:";
            // 
            // valuesetLabel
            // 
            valuesetLabel.AutoSize = true;
            valuesetLabel.Location = new System.Drawing.Point(68, 10);
            valuesetLabel.Name = "valuesetLabel";
            valuesetLabel.Size = new System.Drawing.Size(51, 13);
            valuesetLabel.TabIndex = 6;
            valuesetLabel.Text = "Valueset:";
            // 
            // valuePresLabel
            // 
            valuePresLabel.AutoSize = true;
            valuePresLabel.Location = new System.Drawing.Point(58, 127);
            valuePresLabel.Name = "valuePresLabel";
            valuePresLabel.Size = new System.Drawing.Size(61, 13);
            valuePresLabel.TabIndex = 8;
            valuePresLabel.Text = "Value Pres:";
            // 
            // eliminationLabel
            // 
            eliminationLabel.AutoSize = true;
            eliminationLabel.Location = new System.Drawing.Point(59, 154);
            eliminationLabel.Name = "eliminationLabel";
            eliminationLabel.Size = new System.Drawing.Size(60, 13);
            eliminationLabel.TabIndex = 10;
            eliminationLabel.Text = "Elimination:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnNewValuepool);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lbValuePools);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(974, 439);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNewValuepool
            // 
            this.btnNewValuepool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewValuepool.Location = new System.Drawing.Point(13, 399);
            this.btnNewValuepool.Name = "btnNewValuepool";
            this.btnNewValuepool.Size = new System.Drawing.Size(75, 23);
            this.btnNewValuepool.TabIndex = 6;
            this.btnNewValuepool.Text = "New";
            this.btnNewValuepool.UseVisualStyleBackColor = true;
            this.btnNewValuepool.Click += new System.EventHandler(this.btnNewValuepool_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valuepools";
            // 
            // lbValuePools
            // 
            this.lbValuePools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValuePools.DisplayMember = "Code";
            this.lbValuePools.FormattingEnabled = true;
            this.lbValuePools.Location = new System.Drawing.Point(3, 42);
            this.lbValuePools.Name = "lbValuePools";
            this.lbValuePools.Size = new System.Drawing.Size(230, 342);
            this.lbValuePools.TabIndex = 0;
            this.lbValuePools.ValueMember = "Code";
            this.lbValuePools.SelectedIndexChanged += new System.EventHandler(this.lbValuePools_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.btnNewValueSet);
            this.splitContainer2.Panel1.Controls.Add(this.btnCopyValueSet);
            this.splitContainer2.Panel1.Controls.Add(this.lbValuesets);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.llAddFootnoteContentValue);
            this.splitContainer2.Panel2.Controls.Add(this.llAddFootnoteMainTValue);
            this.splitContainer2.Panel2.Controls.Add(this.llAddValueFootnote);
            this.splitContainer2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer2.Panel2.Controls.Add(this.btnOk);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.dgwValues);
            this.splitContainer2.Panel2.Controls.Add(eliminationLabel);
            this.splitContainer2.Panel2.Controls.Add(this.eliminationComboBox);
            this.splitContainer2.Panel2.Controls.Add(valuePresLabel);
            this.splitContainer2.Panel2.Controls.Add(this.valuePresComboBox);
            this.splitContainer2.Panel2.Controls.Add(valuesetLabel);
            this.splitContainer2.Panel2.Controls.Add(this.valuesetTextBox);
            this.splitContainer2.Panel2.Controls.Add(valuePoolLabel);
            this.splitContainer2.Panel2.Controls.Add(this.valuePoolTextBox);
            this.splitContainer2.Panel2.Controls.Add(presTextEnglishLabel);
            this.splitContainer2.Panel2.Controls.Add(this.presTextEnglishTextBox);
            this.splitContainer2.Panel2.Controls.Add(presTextLabel);
            this.splitContainer2.Panel2.Controls.Add(this.presTextTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(734, 439);
            this.splitContainer2.SplitterDistance = 233;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valuesets";
            // 
            // btnNewValueSet
            // 
            this.btnNewValueSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewValueSet.Location = new System.Drawing.Point(88, 399);
            this.btnNewValueSet.Name = "btnNewValueSet";
            this.btnNewValueSet.Size = new System.Drawing.Size(75, 23);
            this.btnNewValueSet.TabIndex = 3;
            this.btnNewValueSet.Text = "New";
            this.btnNewValueSet.UseVisualStyleBackColor = true;
            this.btnNewValueSet.Click += new System.EventHandler(this.btnNewValueSet_Click);
            // 
            // btnCopyValueSet
            // 
            this.btnCopyValueSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyValueSet.Location = new System.Drawing.Point(7, 399);
            this.btnCopyValueSet.Name = "btnCopyValueSet";
            this.btnCopyValueSet.Size = new System.Drawing.Size(75, 23);
            this.btnCopyValueSet.TabIndex = 2;
            this.btnCopyValueSet.Text = "Copy";
            this.btnCopyValueSet.UseVisualStyleBackColor = true;
            this.btnCopyValueSet.Click += new System.EventHandler(this.btnCopyValueSet_Click);
            // 
            // lbValuesets
            // 
            this.lbValuesets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValuesets.DisplayMember = "Valueset";
            this.lbValuesets.FormattingEnabled = true;
            this.lbValuesets.Location = new System.Drawing.Point(3, 42);
            this.lbValuesets.Name = "lbValuesets";
            this.lbValuesets.Size = new System.Drawing.Size(227, 342);
            this.lbValuesets.TabIndex = 1;
            this.lbValuesets.ValueMember = "Valueset";
            this.lbValuesets.SelectedIndexChanged += new System.EventHandler(this.lbValuesets_SelectedIndexChanged);
            // 
            // llAddFootnoteContentValue
            // 
            this.llAddFootnoteContentValue.AutoSize = true;
            this.llAddFootnoteContentValue.Location = new System.Drawing.Point(11, 404);
            this.llAddFootnoteContentValue.Name = "llAddFootnoteContentValue";
            this.llAddFootnoteContentValue.Size = new System.Drawing.Size(171, 13);
            this.llAddFootnoteContentValue.TabIndex = 18;
            this.llAddFootnoteContentValue.TabStop = true;
            this.llAddFootnoteContentValue.Text = "Add footnote in selected Content...";
            this.llAddFootnoteContentValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddFootnoteContentValue_LinkClicked);
            // 
            // llAddFootnoteMainTValue
            // 
            this.llAddFootnoteMainTValue.AutoSize = true;
            this.llAddFootnoteMainTValue.Location = new System.Drawing.Point(11, 386);
            this.llAddFootnoteMainTValue.Name = "llAddFootnoteMainTValue";
            this.llAddFootnoteMainTValue.Size = new System.Drawing.Size(163, 13);
            this.llAddFootnoteMainTValue.TabIndex = 17;
            this.llAddFootnoteMainTValue.TabStop = true;
            this.llAddFootnoteMainTValue.Text = "Add footnote in this Main Table...";
            this.llAddFootnoteMainTValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddFootnoteMainTValue_LinkClicked);
            // 
            // llAddValueFootnote
            // 
            this.llAddValueFootnote.AutoSize = true;
            this.llAddValueFootnote.Location = new System.Drawing.Point(11, 371);
            this.llAddValueFootnote.Name = "llAddValueFootnote";
            this.llAddValueFootnote.Size = new System.Drawing.Size(77, 13);
            this.llAddValueFootnote.TabIndex = 16;
            this.llAddValueFootnote.TabStop = true;
            this.llAddValueFootnote.Text = "Add footnote...";
            this.llAddValueFootnote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddValueFootnote_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(396, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(315, 399);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Values";
            // 
            // dgwValues
            // 
            this.dgwValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colValueCode,
            this.Footnote,
            this.colValuePool,
            this.colValueText,
            this.colValueTextEnglish,
            this.colIsNew,
            this.IsDirty});
            this.dgwValues.Location = new System.Drawing.Point(14, 185);
            this.dgwValues.Name = "dgwValues";
            this.dgwValues.ReadOnly = true;
            this.dgwValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwValues.Size = new System.Drawing.Size(471, 168);
            this.dgwValues.TabIndex = 12;
            this.dgwValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwValues_CellClick);
            // 
            // colValueCode
            // 
            this.colValueCode.DataPropertyName = "ValueCode";
            this.colValueCode.HeaderText = "Value code";
            this.colValueCode.Name = "colValueCode";
            this.colValueCode.ReadOnly = true;
            // 
            // Footnote
            // 
            this.Footnote.DataPropertyName = "Footnote";
            this.Footnote.HeaderText = "Footnote";
            this.Footnote.Name = "Footnote";
            this.Footnote.ReadOnly = true;
            this.Footnote.Visible = false;
            // 
            // colValuePool
            // 
            this.colValuePool.DataPropertyName = "ValuePool";
            this.colValuePool.HeaderText = "ValuePool";
            this.colValuePool.Name = "colValuePool";
            this.colValuePool.ReadOnly = true;
            this.colValuePool.Visible = false;
            // 
            // colValueText
            // 
            this.colValueText.DataPropertyName = "ValueText";
            this.colValueText.HeaderText = "Value Text";
            this.colValueText.Name = "colValueText";
            this.colValueText.ReadOnly = true;
            this.colValueText.Width = 150;
            // 
            // colValueTextEnglish
            // 
            this.colValueTextEnglish.DataPropertyName = "ValueTextEnglish";
            this.colValueTextEnglish.HeaderText = "Value Text English";
            this.colValueTextEnglish.Name = "colValueTextEnglish";
            this.colValueTextEnglish.ReadOnly = true;
            this.colValueTextEnglish.Width = 150;
            // 
            // colIsNew
            // 
            this.colIsNew.DataPropertyName = "IsNew";
            this.colIsNew.HeaderText = "Is New";
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.ReadOnly = true;
            this.colIsNew.Visible = false;
            // 
            // IsDirty
            // 
            this.IsDirty.DataPropertyName = "IsDirty";
            this.IsDirty.HeaderText = "Is Dirty";
            this.IsDirty.Name = "IsDirty";
            this.IsDirty.ReadOnly = true;
            this.IsDirty.Visible = false;
            // 
            // eliminationComboBox
            // 
            this.eliminationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxValueSetBindingSource, "Elimination", true));
            this.eliminationComboBox.DisplayMember = "Text";
            this.eliminationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eliminationComboBox.Enabled = false;
            this.eliminationComboBox.FormattingEnabled = true;
            this.eliminationComboBox.Location = new System.Drawing.Point(125, 151);
            this.eliminationComboBox.Name = "eliminationComboBox";
            this.eliminationComboBox.Size = new System.Drawing.Size(219, 21);
            this.eliminationComboBox.TabIndex = 11;
            this.eliminationComboBox.ValueMember = "Code";
            // 
            // valuePresComboBox
            // 
            this.valuePresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxValueSetBindingSource, "ValuePres", true));
            this.valuePresComboBox.DisplayMember = "Text";
            this.valuePresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valuePresComboBox.Enabled = false;
            this.valuePresComboBox.FormattingEnabled = true;
            this.valuePresComboBox.Location = new System.Drawing.Point(125, 124);
            this.valuePresComboBox.Name = "valuePresComboBox";
            this.valuePresComboBox.Size = new System.Drawing.Size(219, 21);
            this.valuePresComboBox.TabIndex = 9;
            this.valuePresComboBox.ValueMember = "Code";
            // 
            // valuesetTextBox
            // 
            this.valuesetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "Valueset", true));
            this.valuesetTextBox.Location = new System.Drawing.Point(125, 7);
            this.valuesetTextBox.Name = "valuesetTextBox";
            this.valuesetTextBox.ReadOnly = true;
            this.valuesetTextBox.Size = new System.Drawing.Size(219, 20);
            this.valuesetTextBox.TabIndex = 7;
            // 
            // valuePoolTextBox
            // 
            this.valuePoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "ValuePool", true));
            this.valuePoolTextBox.Location = new System.Drawing.Point(125, 93);
            this.valuePoolTextBox.Name = "valuePoolTextBox";
            this.valuePoolTextBox.ReadOnly = true;
            this.valuePoolTextBox.Size = new System.Drawing.Size(219, 20);
            this.valuePoolTextBox.TabIndex = 5;
            // 
            // presTextEnglishTextBox
            // 
            this.presTextEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "PresTextEnglish", true));
            this.presTextEnglishTextBox.Location = new System.Drawing.Point(125, 59);
            this.presTextEnglishTextBox.Name = "presTextEnglishTextBox";
            this.presTextEnglishTextBox.ReadOnly = true;
            this.presTextEnglishTextBox.Size = new System.Drawing.Size(219, 20);
            this.presTextEnglishTextBox.TabIndex = 3;
            // 
            // presTextTextBox
            // 
            this.presTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "PresText", true));
            this.presTextTextBox.Location = new System.Drawing.Point(125, 33);
            this.presTextTextBox.Name = "presTextTextBox";
            this.presTextTextBox.ReadOnly = true;
            this.presTextTextBox.Size = new System.Drawing.Size(219, 20);
            this.presTextTextBox.TabIndex = 1;
            // 
            // pxValueSetBindingSource
            // 
            this.pxValueSetBindingSource.DataSource = typeof(PxDataLoader.Model.PxValueSet);
            // 
            // ChooseValuset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 439);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseValuset";
            this.Text = "ChooseValuset";
            this.Load += new System.EventHandler(this.ChooseValuset_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxValueSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbValuePools;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lbValuesets;
        private System.Windows.Forms.ComboBox eliminationComboBox;
        private System.Windows.Forms.BindingSource pxValueSetBindingSource;
        private System.Windows.Forms.ComboBox valuePresComboBox;
        private System.Windows.Forms.TextBox valuesetTextBox;
        private System.Windows.Forms.TextBox valuePoolTextBox;
        private System.Windows.Forms.TextBox presTextEnglishTextBox;
        private System.Windows.Forms.TextBox presTextTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwValues;
        private System.Windows.Forms.Button btnNewValueSet;
        private System.Windows.Forms.Button btnCopyValueSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNewValuepool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llAddFootnoteMainTValue;
        private System.Windows.Forms.LinkLabel llAddValueFootnote;
        private System.Windows.Forms.LinkLabel llAddFootnoteContentValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Footnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValuePool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueTextEnglish;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDirty;
    }
}