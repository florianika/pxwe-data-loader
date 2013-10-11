namespace PxDataLoader
{
    partial class ChooseValues
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
            this.dgwValues = new System.Windows.Forms.DataGridView();
            this.colValueCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValuePool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValueTextEnglish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwValues)).BeginInit();
            this.SuspendLayout();
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
            this.colIsNew});
            this.dgwValues.Location = new System.Drawing.Point(12, 30);
            this.dgwValues.Name = "dgwValues";
            this.dgwValues.ReadOnly = true;
            this.dgwValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwValues.Size = new System.Drawing.Size(632, 222);
            this.dgwValues.TabIndex = 14;
            // 
            // colValueCode
            // 
            this.colValueCode.DataPropertyName = "ValueCode";
            this.colValueCode.HeaderText = "Value code";
            this.colValueCode.Name = "colValueCode";
            this.colValueCode.ReadOnly = true;
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
            this.colValueText.Width = 200;
            // 
            // colValueTextEnglish
            // 
            this.colValueTextEnglish.DataPropertyName = "ValueTextEnglish";
            this.colValueTextEnglish.HeaderText = "Value Text English";
            this.colValueTextEnglish.Name = "colValueTextEnglish";
            this.colValueTextEnglish.ReadOnly = true;
            this.colValueTextEnglish.Width = 200;
            // 
            // colIsNew
            // 
            this.colIsNew.DataPropertyName = "IsNew";
            this.colIsNew.HeaderText = "Is New";
            this.colIsNew.Name = "colIsNew";
            this.colIsNew.ReadOnly = true;
            this.colIsNew.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(488, 258);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(569, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChooseValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgwValues);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseValues";
            this.Text = "ChooseValues";
            ((System.ComponentModel.ISupportInitialize)(this.dgwValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwValues;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValuePool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValueTextEnglish;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNew;
    }
}