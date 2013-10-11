namespace PxDataLoader
{
    partial class CreateValueSetDialog
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
            System.Windows.Forms.Label valuesetLabel;
            System.Windows.Forms.Label presTextLabel;
            System.Windows.Forms.Label presTextEnglishLabel;
            System.Windows.Forms.Label valuePoolLabel;
            System.Windows.Forms.Label valuePresLabel;
            System.Windows.Forms.Label eliminationLabel;
            this.valuesetTextBox = new System.Windows.Forms.TextBox();
            this.presTextTextBox = new System.Windows.Forms.TextBox();
            this.presTextEnglishTextBox = new System.Windows.Forms.TextBox();
            this.valuePoolComboBox = new System.Windows.Forms.ComboBox();
            this.valuePresComboBox = new System.Windows.Forms.ComboBox();
            this.eliminationComboBox = new System.Windows.Forms.ComboBox();
            this.dgwValues = new System.Windows.Forms.DataGridView();
            this.colValueCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValuePool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueTextEnglish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDirty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Footnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateValuePool = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddValuesFromValuepool = new System.Windows.Forms.Button();
            this.pxValueSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            valuesetLabel = new System.Windows.Forms.Label();
            presTextLabel = new System.Windows.Forms.Label();
            presTextEnglishLabel = new System.Windows.Forms.Label();
            valuePoolLabel = new System.Windows.Forms.Label();
            valuePresLabel = new System.Windows.Forms.Label();
            eliminationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxValueSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valuesetLabel
            // 
            valuesetLabel.AutoSize = true;
            valuesetLabel.Location = new System.Drawing.Point(44, 29);
            valuesetLabel.Name = "valuesetLabel";
            valuesetLabel.Size = new System.Drawing.Size(51, 13);
            valuesetLabel.TabIndex = 1;
            valuesetLabel.Text = "Valueset:";
            // 
            // presTextLabel
            // 
            presTextLabel.AutoSize = true;
            presTextLabel.Location = new System.Drawing.Point(40, 55);
            presTextLabel.Name = "presTextLabel";
            presTextLabel.Size = new System.Drawing.Size(55, 13);
            presTextLabel.TabIndex = 2;
            presTextLabel.Text = "Pres Text:";
            // 
            // presTextEnglishLabel
            // 
            presTextEnglishLabel.AutoSize = true;
            presTextEnglishLabel.Location = new System.Drawing.Point(3, 81);
            presTextEnglishLabel.Name = "presTextEnglishLabel";
            presTextEnglishLabel.Size = new System.Drawing.Size(92, 13);
            presTextEnglishLabel.TabIndex = 4;
            presTextEnglishLabel.Text = "Pres Text English:";
            // 
            // valuePoolLabel
            // 
            valuePoolLabel.AutoSize = true;
            valuePoolLabel.Location = new System.Drawing.Point(352, 28);
            valuePoolLabel.Name = "valuePoolLabel";
            valuePoolLabel.Size = new System.Drawing.Size(61, 13);
            valuePoolLabel.TabIndex = 6;
            valuePoolLabel.Text = "Value Pool:";
            // 
            // valuePresLabel
            // 
            valuePresLabel.AutoSize = true;
            valuePresLabel.Location = new System.Drawing.Point(352, 55);
            valuePresLabel.Name = "valuePresLabel";
            valuePresLabel.Size = new System.Drawing.Size(61, 13);
            valuePresLabel.TabIndex = 8;
            valuePresLabel.Text = "Value Pres:";
            // 
            // eliminationLabel
            // 
            eliminationLabel.AutoSize = true;
            eliminationLabel.Location = new System.Drawing.Point(353, 82);
            eliminationLabel.Name = "eliminationLabel";
            eliminationLabel.Size = new System.Drawing.Size(60, 13);
            eliminationLabel.TabIndex = 10;
            eliminationLabel.Text = "Elimination:";
            // 
            // valuesetTextBox
            // 
            this.valuesetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "Valueset", true));
            this.valuesetTextBox.Location = new System.Drawing.Point(101, 26);
            this.valuesetTextBox.Name = "valuesetTextBox";
            this.valuesetTextBox.Size = new System.Drawing.Size(235, 20);
            this.valuesetTextBox.TabIndex = 2;
            // 
            // presTextTextBox
            // 
            this.presTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "PresText", true));
            this.presTextTextBox.Location = new System.Drawing.Point(101, 52);
            this.presTextTextBox.Name = "presTextTextBox";
            this.presTextTextBox.Size = new System.Drawing.Size(235, 20);
            this.presTextTextBox.TabIndex = 3;
            // 
            // presTextEnglishTextBox
            // 
            this.presTextEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValueSetBindingSource, "PresTextEnglish", true));
            this.presTextEnglishTextBox.Location = new System.Drawing.Point(101, 78);
            this.presTextEnglishTextBox.Name = "presTextEnglishTextBox";
            this.presTextEnglishTextBox.Size = new System.Drawing.Size(235, 20);
            this.presTextEnglishTextBox.TabIndex = 5;
            // 
            // valuePoolComboBox
            // 
            this.valuePoolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxValueSetBindingSource, "ValuePool", true));
            this.valuePoolComboBox.DisplayMember = "Code";
            this.valuePoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valuePoolComboBox.FormattingEnabled = true;
            this.valuePoolComboBox.Location = new System.Drawing.Point(419, 25);
            this.valuePoolComboBox.Name = "valuePoolComboBox";
            this.valuePoolComboBox.Size = new System.Drawing.Size(235, 21);
            this.valuePoolComboBox.TabIndex = 7;
            this.valuePoolComboBox.ValueMember = "Code";
            // 
            // valuePresComboBox
            // 
            this.valuePresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxValueSetBindingSource, "ValuePres", true));
            this.valuePresComboBox.DisplayMember = "Text";
            this.valuePresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valuePresComboBox.FormattingEnabled = true;
            this.valuePresComboBox.Location = new System.Drawing.Point(419, 52);
            this.valuePresComboBox.Name = "valuePresComboBox";
            this.valuePresComboBox.Size = new System.Drawing.Size(235, 21);
            this.valuePresComboBox.TabIndex = 9;
            this.valuePresComboBox.ValueMember = "Code";
            // 
            // eliminationComboBox
            // 
            this.eliminationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pxValueSetBindingSource, "Elimination", true));
            this.eliminationComboBox.DisplayMember = "Text";
            this.eliminationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eliminationComboBox.FormattingEnabled = true;
            this.eliminationComboBox.Location = new System.Drawing.Point(419, 79);
            this.eliminationComboBox.Name = "eliminationComboBox";
            this.eliminationComboBox.Size = new System.Drawing.Size(235, 21);
            this.eliminationComboBox.TabIndex = 11;
            this.eliminationComboBox.ValueMember = "Code";
            // 
            // dgwValues
            // 
            this.dgwValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colValueCode,
            this.colValuePool,
            this.colValueText,
            this.colValueTextEnglish,
            this.colIsNew,
            this.IsDirty,
            this.Footnote});
            this.dgwValues.Location = new System.Drawing.Point(12, 130);
            this.dgwValues.Name = "dgwValues";
            this.dgwValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwValues.Size = new System.Drawing.Size(714, 257);
            this.dgwValues.TabIndex = 13;
            // 
            // colValueCode
            // 
            this.colValueCode.DataPropertyName = "ValueCode";
            this.colValueCode.HeaderText = "Value code";
            this.colValueCode.Name = "colValueCode";
            // 
            // colValuePool
            // 
            this.colValuePool.DataPropertyName = "ValuePool";
            this.colValuePool.HeaderText = "ValuePool";
            this.colValuePool.Name = "colValuePool";
            this.colValuePool.Visible = false;
            // 
            // colValueText
            // 
            this.colValueText.DataPropertyName = "ValueText";
            this.colValueText.HeaderText = "Value Text";
            this.colValueText.Name = "colValueText";
            this.colValueText.Width = 200;
            // 
            // colValueTextEnglish
            // 
            this.colValueTextEnglish.DataPropertyName = "ValueTextEnglish";
            this.colValueTextEnglish.HeaderText = "Value Text English";
            this.colValueTextEnglish.Name = "colValueTextEnglish";
            this.colValueTextEnglish.Width = 200;
            // 
            // colIsNew
            // 
            this.colIsNew.DataPropertyName = "IsNew";
            this.colIsNew.HeaderText = "Is New";
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.Visible = false;
            // 
            // IsDirty
            // 
            this.IsDirty.DataPropertyName = "IsDirty";
            this.IsDirty.HeaderText = "IsDirty";
            this.IsDirty.Name = "IsDirty";
            this.IsDirty.Visible = false;
            // 
            // Footnote
            // 
            this.Footnote.DataPropertyName = "Footnote";
            this.Footnote.HeaderText = "Footnote";
            this.Footnote.Name = "Footnote";
            this.Footnote.Visible = false;
            // 
            // btnCreateValuePool
            // 
            this.btnCreateValuePool.Location = new System.Drawing.Point(660, 25);
            this.btnCreateValuePool.Name = "btnCreateValuePool";
            this.btnCreateValuePool.Size = new System.Drawing.Size(75, 23);
            this.btnCreateValuePool.TabIndex = 14;
            this.btnCreateValuePool.Text = "New";
            this.btnCreateValuePool.UseVisualStyleBackColor = true;
            this.btnCreateValuePool.Click += new System.EventHandler(this.btnCreateValuePool_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(570, 393);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(651, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddValuesFromValuepool
            // 
            this.btnAddValuesFromValuepool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddValuesFromValuepool.Location = new System.Drawing.Point(12, 393);
            this.btnAddValuesFromValuepool.Name = "btnAddValuesFromValuepool";
            this.btnAddValuesFromValuepool.Size = new System.Drawing.Size(185, 23);
            this.btnAddValuesFromValuepool.TabIndex = 17;
            this.btnAddValuesFromValuepool.Text = "Add Values From Valuepool";
            this.btnAddValuesFromValuepool.UseVisualStyleBackColor = true;
            this.btnAddValuesFromValuepool.Click += new System.EventHandler(this.btnAddValuesFromValuepool_Click);
            // 
            // pxValueSetBindingSource
            // 
            this.pxValueSetBindingSource.DataSource = typeof(PxDataLoader.Model.PxValueSet);
            // 
            // CreateValueSetDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 428);
            this.Controls.Add(this.btnAddValuesFromValuepool);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCreateValuePool);
            this.Controls.Add(this.dgwValues);
            this.Controls.Add(eliminationLabel);
            this.Controls.Add(this.eliminationComboBox);
            this.Controls.Add(valuePresLabel);
            this.Controls.Add(this.valuePresComboBox);
            this.Controls.Add(valuePoolLabel);
            this.Controls.Add(this.valuePoolComboBox);
            this.Controls.Add(presTextEnglishLabel);
            this.Controls.Add(this.presTextEnglishTextBox);
            this.Controls.Add(presTextLabel);
            this.Controls.Add(this.presTextTextBox);
            this.Controls.Add(valuesetLabel);
            this.Controls.Add(this.valuesetTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateValueSetDialog";
            this.Text = "CreateValueSetDialog";
            this.Load += new System.EventHandler(this.CreateValueSetDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxValueSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pxValueSetBindingSource;
        private System.Windows.Forms.TextBox valuesetTextBox;
        private System.Windows.Forms.TextBox presTextTextBox;
        private System.Windows.Forms.TextBox presTextEnglishTextBox;
        private System.Windows.Forms.ComboBox valuePoolComboBox;
        private System.Windows.Forms.ComboBox valuePresComboBox;
        private System.Windows.Forms.ComboBox eliminationComboBox;
        private System.Windows.Forms.DataGridView dgwValues;
        private System.Windows.Forms.Button btnCreateValuePool;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddValuesFromValuepool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValuePool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueTextEnglish;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDirty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Footnote;
    }
}