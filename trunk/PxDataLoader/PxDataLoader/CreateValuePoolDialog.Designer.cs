namespace PxDataLoader
{
    partial class CreateValuePoolDialog
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
            System.Windows.Forms.Label valuePoolLabel;
            System.Windows.Forms.Label presTextLabel;
            System.Windows.Forms.Label presTextEnglishLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label valuePoolAliasLabel;
            this.valuePoolTextBox = new System.Windows.Forms.TextBox();
            this.presTextTextBox = new System.Windows.Forms.TextBox();
            this.presTextEnglishTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.valuePoolAliasTextBox = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pxValuePoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            valuePoolLabel = new System.Windows.Forms.Label();
            presTextLabel = new System.Windows.Forms.Label();
            presTextEnglishLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            valuePoolAliasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pxValuePoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valuePoolLabel
            // 
            valuePoolLabel.AutoSize = true;
            valuePoolLabel.Location = new System.Drawing.Point(63, 24);
            valuePoolLabel.Name = "valuePoolLabel";
            valuePoolLabel.Size = new System.Drawing.Size(61, 13);
            valuePoolLabel.TabIndex = 1;
            valuePoolLabel.Text = "Value Pool:";
            // 
            // valuePoolTextBox
            // 
            this.valuePoolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.valuePoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValuePoolBindingSource, "ValuePool", true));
            this.valuePoolTextBox.Location = new System.Drawing.Point(130, 21);
            this.valuePoolTextBox.Name = "valuePoolTextBox";
            this.valuePoolTextBox.Size = new System.Drawing.Size(264, 20);
            this.valuePoolTextBox.TabIndex = 2;
            // 
            // presTextLabel
            // 
            presTextLabel.AutoSize = true;
            presTextLabel.Location = new System.Drawing.Point(69, 75);
            presTextLabel.Name = "presTextLabel";
            presTextLabel.Size = new System.Drawing.Size(55, 13);
            presTextLabel.TabIndex = 2;
            presTextLabel.Text = "Pres Text:";
            // 
            // presTextTextBox
            // 
            this.presTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.presTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValuePoolBindingSource, "PresText", true));
            this.presTextTextBox.Location = new System.Drawing.Point(130, 72);
            this.presTextTextBox.Name = "presTextTextBox";
            this.presTextTextBox.Size = new System.Drawing.Size(264, 20);
            this.presTextTextBox.TabIndex = 3;
            // 
            // presTextEnglishLabel
            // 
            presTextEnglishLabel.AutoSize = true;
            presTextEnglishLabel.Location = new System.Drawing.Point(32, 101);
            presTextEnglishLabel.Name = "presTextEnglishLabel";
            presTextEnglishLabel.Size = new System.Drawing.Size(92, 13);
            presTextEnglishLabel.TabIndex = 4;
            presTextEnglishLabel.Text = "Pres Text English:";
            // 
            // presTextEnglishTextBox
            // 
            this.presTextEnglishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.presTextEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValuePoolBindingSource, "PresTextEnglish", true));
            this.presTextEnglishTextBox.Location = new System.Drawing.Point(130, 98);
            this.presTextEnglishTextBox.Name = "presTextEnglishTextBox";
            this.presTextEnglishTextBox.Size = new System.Drawing.Size(264, 20);
            this.presTextEnglishTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(61, 127);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValuePoolBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(130, 124);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(264, 20);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // valuePoolAliasLabel
            // 
            valuePoolAliasLabel.AutoSize = true;
            valuePoolAliasLabel.Location = new System.Drawing.Point(38, 50);
            valuePoolAliasLabel.Name = "valuePoolAliasLabel";
            valuePoolAliasLabel.Size = new System.Drawing.Size(86, 13);
            valuePoolAliasLabel.TabIndex = 8;
            valuePoolAliasLabel.Text = "Value Pool Alias:";
            // 
            // valuePoolAliasTextBox
            // 
            this.valuePoolAliasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.valuePoolAliasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxValuePoolBindingSource, "ValuePoolAlias", true));
            this.valuePoolAliasTextBox.Location = new System.Drawing.Point(130, 47);
            this.valuePoolAliasTextBox.Name = "valuePoolAliasTextBox";
            this.valuePoolAliasTextBox.Size = new System.Drawing.Size(264, 20);
            this.valuePoolAliasTextBox.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(240, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(321, 162);
            this.btnCancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pxValuePoolBindingSource
            // 
            this.pxValuePoolBindingSource.DataSource = typeof(PxDataLoader.Model.PxValuePool);
            // 
            // CreateValuePoolDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(valuePoolAliasLabel);
            this.Controls.Add(this.valuePoolAliasTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(presTextEnglishLabel);
            this.Controls.Add(this.presTextEnglishTextBox);
            this.Controls.Add(presTextLabel);
            this.Controls.Add(this.presTextTextBox);
            this.Controls.Add(valuePoolLabel);
            this.Controls.Add(this.valuePoolTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 231);
            this.Name = "CreateValuePoolDialog";
            this.Text = "Create  new value pool";
            this.Load += new System.EventHandler(this.CreateValuePoolDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxValuePoolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pxValuePoolBindingSource;
        private System.Windows.Forms.TextBox valuePoolTextBox;
        private System.Windows.Forms.TextBox presTextTextBox;
        private System.Windows.Forms.TextBox presTextEnglishTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox valuePoolAliasTextBox;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}