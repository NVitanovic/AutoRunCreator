namespace AutoRunEditor
{
    partial class frmMain
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
            this.tbParameters = new System.Windows.Forms.TextBox();
            this.tbWorkingDirectory = new System.Windows.Forms.MaskedTextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.cbVisibilityMode = new System.Windows.Forms.ComboBox();
            this.tbFile = new System.Windows.Forms.MaskedTextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblParameters = new System.Windows.Forms.Label();
            this.lblWorkingDirectory = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblVisibilityMode = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbParameters
            // 
            this.tbParameters.Location = new System.Drawing.Point(143, 96);
            this.tbParameters.Name = "tbParameters";
            this.tbParameters.Size = new System.Drawing.Size(285, 26);
            this.tbParameters.TabIndex = 3;
            // 
            // tbWorkingDirectory
            // 
            this.tbWorkingDirectory.Location = new System.Drawing.Point(143, 128);
            this.tbWorkingDirectory.Name = "tbWorkingDirectory";
            this.tbWorkingDirectory.Size = new System.Drawing.Size(285, 26);
            this.tbWorkingDirectory.TabIndex = 4;
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "edit",
            "explore",
            "find",
            "open",
            "print"});
            this.cbOperation.Location = new System.Drawing.Point(143, 30);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(285, 28);
            this.cbOperation.TabIndex = 1;
            this.cbOperation.Text = "open";
            // 
            // cbVisibilityMode
            // 
            this.cbVisibilityMode.FormattingEnabled = true;
            this.cbVisibilityMode.Items.AddRange(new object[] {
            "SW_HIDE",
            "SW_SHOWNORMAL",
            "SW_SHOWMINIMIZED",
            "SW_SHOWMAXIMIZED",
            "SW_SHOWNOACTIVATE",
            "SW_SHOW",
            "SW_MINIMIZE",
            "SW_SHOWMINNOACTIVE",
            "SW_SHOWNA",
            "SW_RESTORE",
            "SW_SHOWDEFAULT"});
            this.cbVisibilityMode.Location = new System.Drawing.Point(143, 160);
            this.cbVisibilityMode.Name = "cbVisibilityMode";
            this.cbVisibilityMode.Size = new System.Drawing.Size(285, 28);
            this.cbVisibilityMode.TabIndex = 5;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(143, 64);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(285, 26);
            this.tbFile.TabIndex = 2;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(6, 33);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(79, 20);
            this.lblOperation.TabIndex = 5;
            this.lblOperation.Text = "Operation";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(6, 67);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(34, 20);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "File";
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(6, 99);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(91, 20);
            this.lblParameters.TabIndex = 7;
            this.lblParameters.Text = "Parameters";
            // 
            // lblWorkingDirectory
            // 
            this.lblWorkingDirectory.AutoSize = true;
            this.lblWorkingDirectory.Location = new System.Drawing.Point(6, 131);
            this.lblWorkingDirectory.Name = "lblWorkingDirectory";
            this.lblWorkingDirectory.Size = new System.Drawing.Size(131, 20);
            this.lblWorkingDirectory.TabIndex = 8;
            this.lblWorkingDirectory.Text = "Working directory";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AutoRunEditor.Properties.Resources.AUTORUNCreator;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(440, 100);
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon.Location = new System.Drawing.Point(143, 194);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIcon.TabIndex = 10;
            this.pbIcon.TabStop = false;
            // 
            // lblVisibilityMode
            // 
            this.lblVisibilityMode.AutoSize = true;
            this.lblVisibilityMode.Location = new System.Drawing.Point(6, 163);
            this.lblVisibilityMode.Name = "lblVisibilityMode";
            this.lblVisibilityMode.Size = new System.Drawing.Size(108, 20);
            this.lblVisibilityMode.TabIndex = 11;
            this.lblVisibilityMode.Text = "Visibility mode";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(6, 194);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(40, 20);
            this.lblIcon.TabIndex = 12;
            this.lblIcon.Text = "Icon";
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.Location = new System.Drawing.Point(213, 230);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(52, 28);
            this.btnSelectIcon.TabIndex = 6;
            this.btnSelectIcon.Text = "...";
            this.btnSelectIcon.UseVisualStyleBackColor = true;
            this.btnSelectIcon.Click += new System.EventHandler(this.btnSelectIcon_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnClear);
            this.gbSettings.Controls.Add(this.lblOperation);
            this.gbSettings.Controls.Add(this.btnSelectIcon);
            this.gbSettings.Controls.Add(this.tbParameters);
            this.gbSettings.Controls.Add(this.lblIcon);
            this.gbSettings.Controls.Add(this.tbWorkingDirectory);
            this.gbSettings.Controls.Add(this.lblVisibilityMode);
            this.gbSettings.Controls.Add(this.cbOperation);
            this.gbSettings.Controls.Add(this.pbIcon);
            this.gbSettings.Controls.Add(this.cbVisibilityMode);
            this.gbSettings.Controls.Add(this.tbFile);
            this.gbSettings.Controls.Add(this.lblWorkingDirectory);
            this.gbSettings.Controls.Add(this.lblFile);
            this.gbSettings.Controls.Add(this.lblParameters);
            this.gbSettings.Location = new System.Drawing.Point(12, 118);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(440, 276);
            this.gbSettings.TabIndex = 14;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 398);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 37);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(213, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 447);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "AutoRun Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbParameters;
        private System.Windows.Forms.MaskedTextBox tbWorkingDirectory;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.ComboBox cbVisibilityMode;
        private System.Windows.Forms.MaskedTextBox tbFile;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.Label lblWorkingDirectory;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblVisibilityMode;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnSelectIcon;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnClear;
    }
}

