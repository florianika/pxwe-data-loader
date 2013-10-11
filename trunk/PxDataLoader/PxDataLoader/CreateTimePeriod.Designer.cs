namespace PxDataLoader
{
    partial class CreateTimePeriod
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
            this.lbTimePeriods = new System.Windows.Forms.ListBox();
            this.txbTimePeriod = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.llCreateFootonoteForSelectedTimePeriod = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbTimePeriods
            // 
            this.lbTimePeriods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimePeriods.DisplayMember = "TimePeriod";
            this.lbTimePeriods.FormattingEnabled = true;
            this.lbTimePeriods.Location = new System.Drawing.Point(33, 12);
            this.lbTimePeriods.Name = "lbTimePeriods";
            this.lbTimePeriods.Size = new System.Drawing.Size(329, 303);
            this.lbTimePeriods.TabIndex = 0;
            // 
            // txbTimePeriod
            // 
            this.txbTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTimePeriod.Location = new System.Drawing.Point(33, 321);
            this.txbTimePeriod.Name = "txbTimePeriod";
            this.txbTimePeriod.Size = new System.Drawing.Size(329, 20);
            this.txbTimePeriod.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(287, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(199, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(287, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(33, 347);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(163, 23);
            this.btnImportExcel.TabIndex = 5;
            this.btnImportExcel.Text = "Add from Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // llCreateFootonoteForSelectedTimePeriod
            // 
            this.llCreateFootonoteForSelectedTimePeriod.AutoSize = true;
            this.llCreateFootonoteForSelectedTimePeriod.Location = new System.Drawing.Point(30, 390);
            this.llCreateFootonoteForSelectedTimePeriod.Name = "llCreateFootonoteForSelectedTimePeriod";
            this.llCreateFootonoteForSelectedTimePeriod.Size = new System.Drawing.Size(208, 13);
            this.llCreateFootonoteForSelectedTimePeriod.TabIndex = 6;
            this.llCreateFootonoteForSelectedTimePeriod.TabStop = true;
            this.llCreateFootonoteForSelectedTimePeriod.Text = "Create footnote for Selected Time Period...";
            this.llCreateFootonoteForSelectedTimePeriod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreateFootonoteForSelectedTimePeriod_LinkClicked);
            // 
            // CreateTimePeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 453);
            this.Controls.Add(this.llCreateFootonoteForSelectedTimePeriod);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbTimePeriod);
            this.Controls.Add(this.lbTimePeriods);
            this.Name = "CreateTimePeriod";
            this.Text = "CreateTimePeriod";
            this.Load += new System.EventHandler(this.CreateTimePeriod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTimePeriods;
        private System.Windows.Forms.TextBox txbTimePeriod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.LinkLabel llCreateFootonoteForSelectedTimePeriod;
    }
}