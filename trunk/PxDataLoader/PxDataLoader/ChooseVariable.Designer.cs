namespace PxDataLoader
{
    partial class ChooseVariable
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
            System.Windows.Forms.Label variableLabel;
            System.Windows.Forms.Label variableInfoLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvVariables = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPresText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectVariable = new System.Windows.Forms.Button();
            this.variableInfoTextBox = new System.Windows.Forms.TextBox();
            this.pxVariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variableTextBox = new System.Windows.Forms.TextBox();
            this.presTextEnglishTextBox = new System.Windows.Forms.TextBox();
            this.presTextTextBox = new System.Windows.Forms.TextBox();
            presTextLabel = new System.Windows.Forms.Label();
            presTextEnglishLabel = new System.Windows.Forms.Label();
            variableLabel = new System.Windows.Forms.Label();
            variableInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxVariableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // presTextLabel
            // 
            presTextLabel.AutoSize = true;
            presTextLabel.Location = new System.Drawing.Point(42, 67);
            presTextLabel.Name = "presTextLabel";
            presTextLabel.Size = new System.Drawing.Size(55, 13);
            presTextLabel.TabIndex = 0;
            presTextLabel.Text = "Pres Text:";
            // 
            // presTextEnglishLabel
            // 
            presTextEnglishLabel.AutoSize = true;
            presTextEnglishLabel.Location = new System.Drawing.Point(5, 139);
            presTextEnglishLabel.Name = "presTextEnglishLabel";
            presTextEnglishLabel.Size = new System.Drawing.Size(92, 13);
            presTextEnglishLabel.TabIndex = 2;
            presTextEnglishLabel.Text = "Pres Text English:";
            // 
            // variableLabel
            // 
            variableLabel.AutoSize = true;
            variableLabel.Location = new System.Drawing.Point(49, 30);
            variableLabel.Name = "variableLabel";
            variableLabel.Size = new System.Drawing.Size(48, 13);
            variableLabel.TabIndex = 4;
            variableLabel.Text = "Variable:";
            // 
            // variableInfoLabel
            // 
            variableInfoLabel.AutoSize = true;
            variableInfoLabel.Location = new System.Drawing.Point(28, 205);
            variableInfoLabel.Name = "variableInfoLabel";
            variableInfoLabel.Size = new System.Drawing.Size(69, 13);
            variableInfoLabel.TabIndex = 6;
            variableInfoLabel.Text = "Variable Info:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvVariables);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddVariable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(variableInfoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelectVariable);
            this.splitContainer1.Panel2.Controls.Add(this.variableInfoTextBox);
            this.splitContainer1.Panel2.Controls.Add(variableLabel);
            this.splitContainer1.Panel2.Controls.Add(this.variableTextBox);
            this.splitContainer1.Panel2.Controls.Add(presTextEnglishLabel);
            this.splitContainer1.Panel2.Controls.Add(this.presTextEnglishTextBox);
            this.splitContainer1.Panel2.Controls.Add(presTextLabel);
            this.splitContainer1.Panel2.Controls.Add(this.presTextTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(550, 462);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvVariables
            // 
            this.lvVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chPresText});
            this.lvVariables.FullRowSelect = true;
            this.lvVariables.Location = new System.Drawing.Point(0, 0);
            this.lvVariables.MultiSelect = false;
            this.lvVariables.Name = "lvVariables";
            this.lvVariables.Size = new System.Drawing.Size(253, 421);
            this.lvVariables.TabIndex = 0;
            this.lvVariables.UseCompatibleStateImageBehavior = false;
            this.lvVariables.View = System.Windows.Forms.View.Details;
            this.lvVariables.SelectedIndexChanged += new System.EventHandler(this.lvVariables_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chPresText
            // 
            this.chPresText.Text = "Press Text";
            this.chPresText.Width = 180;
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddVariable.Location = new System.Drawing.Point(12, 427);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(75, 23);
            this.btnAddVariable.TabIndex = 1;
            this.btnAddVariable.Text = "Add";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(206, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectVariable
            // 
            this.btnSelectVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectVariable.Location = new System.Drawing.Point(125, 427);
            this.btnSelectVariable.Name = "btnSelectVariable";
            this.btnSelectVariable.Size = new System.Drawing.Size(75, 23);
            this.btnSelectVariable.TabIndex = 2;
            this.btnSelectVariable.Text = "OK";
            this.btnSelectVariable.UseVisualStyleBackColor = true;
            this.btnSelectVariable.Click += new System.EventHandler(this.btnSelectVariable_Click);
            // 
            // variableInfoTextBox
            // 
            this.variableInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.variableInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxVariableBindingSource, "VariableInfo", true));
            this.variableInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.pxVariableBindingSource, "Exists", true));
            this.variableInfoTextBox.Location = new System.Drawing.Point(103, 202);
            this.variableInfoTextBox.Multiline = true;
            this.variableInfoTextBox.Name = "variableInfoTextBox";
            this.variableInfoTextBox.Size = new System.Drawing.Size(166, 71);
            this.variableInfoTextBox.TabIndex = 7;
            // 
            // pxVariableBindingSource
            // 
            this.pxVariableBindingSource.DataSource = typeof(PxDataLoader.Model.PxVariable);
            // 
            // variableTextBox
            // 
            this.variableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.variableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxVariableBindingSource, "Variable", true));
            this.variableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.pxVariableBindingSource, "Exists", true));
            this.variableTextBox.Location = new System.Drawing.Point(103, 27);
            this.variableTextBox.Name = "variableTextBox";
            this.variableTextBox.Size = new System.Drawing.Size(166, 20);
            this.variableTextBox.TabIndex = 5;
            // 
            // presTextEnglishTextBox
            // 
            this.presTextEnglishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.presTextEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxVariableBindingSource, "PresTextEnglish", true));
            this.presTextEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.pxVariableBindingSource, "Exists", true));
            this.presTextEnglishTextBox.Location = new System.Drawing.Point(103, 136);
            this.presTextEnglishTextBox.Multiline = true;
            this.presTextEnglishTextBox.Name = "presTextEnglishTextBox";
            this.presTextEnglishTextBox.Size = new System.Drawing.Size(166, 60);
            this.presTextEnglishTextBox.TabIndex = 3;
            // 
            // presTextTextBox
            // 
            this.presTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.presTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxVariableBindingSource, "PresText", true));
            this.presTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.pxVariableBindingSource, "Exists", true));
            this.presTextTextBox.Location = new System.Drawing.Point(103, 64);
            this.presTextTextBox.Multiline = true;
            this.presTextTextBox.Name = "presTextTextBox";
            this.presTextTextBox.Size = new System.Drawing.Size(166, 66);
            this.presTextTextBox.TabIndex = 1;
            // 
            // ChooseVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 462);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseVariable";
            this.Text = "ChooseVariable";
            this.Load += new System.EventHandler(this.ChooseVariable_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxVariableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvVariables;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chPresText;
        private System.Windows.Forms.TextBox variableInfoTextBox;
        private System.Windows.Forms.BindingSource pxVariableBindingSource;
        private System.Windows.Forms.TextBox variableTextBox;
        private System.Windows.Forms.TextBox presTextEnglishTextBox;
        private System.Windows.Forms.TextBox presTextTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectVariable;
        private System.Windows.Forms.Button btnAddVariable;
    }
}