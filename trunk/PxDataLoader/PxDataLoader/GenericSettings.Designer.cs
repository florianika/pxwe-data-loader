namespace PxDataLoader
{
    partial class GenericSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbMetabaseCn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbInstanceMb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPasswordMb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUsernameMb = new System.Windows.Forms.TextBox();
            this.chbIntsecMb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDatabaseMb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbServerMb = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDbSetCnString = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txbDatabaseCn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbInstanceDb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPasswordDb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUsernameDb = new System.Windows.Forms.TextBox();
            this.chbIntSecurityDb = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDatabaseDb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbServerDb = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txbMetabaseCn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txbInstanceMb);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txbPasswordMb);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txbUsernameMb);
            this.tabPage1.Controls.Add(this.chbIntsecMb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txbDatabaseMb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbServerMb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Metabase Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Connection String";
            // 
            // txbMetabaseCn
            // 
            this.txbMetabaseCn.Location = new System.Drawing.Point(317, 32);
            this.txbMetabaseCn.Multiline = true;
            this.txbMetabaseCn.Name = "txbMetabaseCn";
            this.txbMetabaseCn.Size = new System.Drawing.Size(279, 99);
            this.txbMetabaseCn.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Instance";
            // 
            // txbInstanceMb
            // 
            this.txbInstanceMb.Location = new System.Drawing.Point(94, 74);
            this.txbInstanceMb.Name = "txbInstanceMb";
            this.txbInstanceMb.Size = new System.Drawing.Size(164, 20);
            this.txbInstanceMb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txbPasswordMb
            // 
            this.txbPasswordMb.Location = new System.Drawing.Point(94, 235);
            this.txbPasswordMb.Name = "txbPasswordMb";
            this.txbPasswordMb.Size = new System.Drawing.Size(164, 20);
            this.txbPasswordMb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // txbUsernameMb
            // 
            this.txbUsernameMb.Location = new System.Drawing.Point(94, 196);
            this.txbUsernameMb.Name = "txbUsernameMb";
            this.txbUsernameMb.Size = new System.Drawing.Size(164, 20);
            this.txbUsernameMb.TabIndex = 5;
            // 
            // chbIntsecMb
            // 
            this.chbIntsecMb.AutoSize = true;
            this.chbIntsecMb.Location = new System.Drawing.Point(94, 161);
            this.chbIntsecMb.Name = "chbIntsecMb";
            this.chbIntsecMb.Size = new System.Drawing.Size(115, 17);
            this.chbIntsecMb.TabIndex = 4;
            this.chbIntsecMb.Text = "Integrated Security";
            this.chbIntsecMb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Databse";
            // 
            // txbDatabaseMb
            // 
            this.txbDatabaseMb.Location = new System.Drawing.Point(94, 117);
            this.txbDatabaseMb.Name = "txbDatabaseMb";
            this.txbDatabaseMb.Size = new System.Drawing.Size(164, 20);
            this.txbDatabaseMb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // txbServerMb
            // 
            this.txbServerMb.Location = new System.Drawing.Point(94, 32);
            this.txbServerMb.Name = "txbServerMb";
            this.txbServerMb.Size = new System.Drawing.Size(164, 20);
            this.txbServerMb.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDbSetCnString);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txbDatabaseCn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txbInstanceDb);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txbPasswordDb);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txbUsernameDb);
            this.tabPage2.Controls.Add(this.chbIntSecurityDb);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txbDatabaseDb);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txbServerDb);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDbSetCnString
            // 
            this.btnDbSetCnString.Location = new System.Drawing.Point(265, 160);
            this.btnDbSetCnString.Name = "btnDbSetCnString";
            this.btnDbSetCnString.Size = new System.Drawing.Size(42, 23);
            this.btnDbSetCnString.TabIndex = 24;
            this.btnDbSetCnString.Text = "->";
            this.btnDbSetCnString.UseVisualStyleBackColor = true;
            this.btnDbSetCnString.Click += new System.EventHandler(this.btnDbSetCnString_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Connection String";
            // 
            // txbDatabaseCn
            // 
            this.txbDatabaseCn.Location = new System.Drawing.Point(308, 31);
            this.txbDatabaseCn.Multiline = true;
            this.txbDatabaseCn.Name = "txbDatabaseCn";
            this.txbDatabaseCn.Size = new System.Drawing.Size(268, 99);
            this.txbDatabaseCn.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Instance";
            // 
            // txbInstanceDb
            // 
            this.txbInstanceDb.Location = new System.Drawing.Point(96, 73);
            this.txbInstanceDb.Name = "txbInstanceDb";
            this.txbInstanceDb.Size = new System.Drawing.Size(164, 20);
            this.txbInstanceDb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Password";
            // 
            // txbPasswordDb
            // 
            this.txbPasswordDb.Location = new System.Drawing.Point(96, 234);
            this.txbPasswordDb.Name = "txbPasswordDb";
            this.txbPasswordDb.Size = new System.Drawing.Size(164, 20);
            this.txbPasswordDb.TabIndex = 19;
            this.txbPasswordDb.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Username";
            // 
            // txbUsernameDb
            // 
            this.txbUsernameDb.Location = new System.Drawing.Point(96, 195);
            this.txbUsernameDb.Name = "txbUsernameDb";
            this.txbUsernameDb.Size = new System.Drawing.Size(164, 20);
            this.txbUsernameDb.TabIndex = 17;
            // 
            // chbIntSecurityDb
            // 
            this.chbIntSecurityDb.AutoSize = true;
            this.chbIntSecurityDb.Location = new System.Drawing.Point(96, 160);
            this.chbIntSecurityDb.Name = "chbIntSecurityDb";
            this.chbIntSecurityDb.Size = new System.Drawing.Size(115, 17);
            this.chbIntSecurityDb.TabIndex = 16;
            this.chbIntSecurityDb.Text = "Integrated Security";
            this.chbIntSecurityDb.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Databse";
            // 
            // txbDatabaseDb
            // 
            this.txbDatabaseDb.Location = new System.Drawing.Point(96, 116);
            this.txbDatabaseDb.Name = "txbDatabaseDb";
            this.txbDatabaseDb.Size = new System.Drawing.Size(164, 20);
            this.txbDatabaseDb.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Server";
            // 
            // txbServerDb
            // 
            this.txbServerDb.Location = new System.Drawing.Point(96, 31);
            this.txbServerDb.Name = "txbServerDb";
            this.txbServerDb.Size = new System.Drawing.Size(164, 20);
            this.txbServerDb.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(293, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GenericSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 361);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "GenericSettings";
            this.Text = "GenericSettings";
            this.Load += new System.EventHandler(this.GenericSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbServerMb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDatabaseMb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPasswordMb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUsernameMb;
        private System.Windows.Forms.CheckBox chbIntsecMb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbInstanceMb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbInstanceDb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPasswordDb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbUsernameDb;
        private System.Windows.Forms.CheckBox chbIntSecurityDb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDatabaseDb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbServerDb;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbMetabaseCn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbDatabaseCn;
        private System.Windows.Forms.Button btnDbSetCnString;
        private System.Windows.Forms.Button button1;
    }
}