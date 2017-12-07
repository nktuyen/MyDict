namespace MyDict
{
    partial class frmSettings
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabSystemSetting = new System.Windows.Forms.TabPage();
            this.tabGUISetting = new System.Windows.Forms.TabPage();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDefaultDictionary = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpSynchronization = new System.Windows.Forms.GroupBox();
            this.radSyncAutomatic = new System.Windows.Forms.RadioButton();
            this.radSyncManual = new System.Windows.Forms.RadioButton();
            this.cbSyncAutomaticType = new System.Windows.Forms.ComboBox();
            this.nmudSyncAutomaticMinutes = new System.Windows.Forms.NumericUpDown();
            this.cbSyncAutomaticTimeUnit = new System.Windows.Forms.ComboBox();
            this.tabSettings.SuspendLayout();
            this.tabSystemSetting.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpSynchronization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSyncAutomaticMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSettings.Controls.Add(this.tabSystemSetting);
            this.tabSettings.Controls.Add(this.tabGUISetting);
            this.tabSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(448, 303);
            this.tabSettings.TabIndex = 0;
            // 
            // tabSystemSetting
            // 
            this.tabSystemSetting.Controls.Add(this.grpSynchronization);
            this.tabSystemSetting.Controls.Add(this.grpGeneral);
            this.tabSystemSetting.Location = new System.Drawing.Point(23, 4);
            this.tabSystemSetting.Name = "tabSystemSetting";
            this.tabSystemSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemSetting.Size = new System.Drawing.Size(421, 295);
            this.tabSystemSetting.TabIndex = 0;
            this.tabSystemSetting.Text = "System";
            this.tabSystemSetting.UseVisualStyleBackColor = true;
            // 
            // tabGUISetting
            // 
            this.tabGUISetting.Location = new System.Drawing.Point(23, 4);
            this.tabGUISetting.Name = "tabGUISetting";
            this.tabGUISetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabGUISetting.Size = new System.Drawing.Size(421, 322);
            this.tabGUISetting.TabIndex = 1;
            this.tabGUISetting.Text = "User Interface";
            this.tabGUISetting.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.cbDefaultDictionary);
            this.grpGeneral.Controls.Add(this.label1);
            this.grpGeneral.Location = new System.Drawing.Point(7, 6);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(409, 62);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Dictionary:";
            // 
            // cbDefaultDictionary
            // 
            this.cbDefaultDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefaultDictionary.FormattingEnabled = true;
            this.cbDefaultDictionary.Location = new System.Drawing.Point(143, 17);
            this.cbDefaultDictionary.Name = "cbDefaultDictionary";
            this.cbDefaultDictionary.Size = new System.Drawing.Size(260, 21);
            this.cbDefaultDictionary.Sorted = true;
            this.cbDefaultDictionary.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(373, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(292, 305);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(211, 305);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpSynchronization
            // 
            this.grpSynchronization.Controls.Add(this.cbSyncAutomaticTimeUnit);
            this.grpSynchronization.Controls.Add(this.nmudSyncAutomaticMinutes);
            this.grpSynchronization.Controls.Add(this.cbSyncAutomaticType);
            this.grpSynchronization.Controls.Add(this.radSyncManual);
            this.grpSynchronization.Controls.Add(this.radSyncAutomatic);
            this.grpSynchronization.Location = new System.Drawing.Point(7, 74);
            this.grpSynchronization.Name = "grpSynchronization";
            this.grpSynchronization.Size = new System.Drawing.Size(409, 90);
            this.grpSynchronization.TabIndex = 1;
            this.grpSynchronization.TabStop = false;
            this.grpSynchronization.Text = "Synchronization";
            // 
            // radSyncAutomatic
            // 
            this.radSyncAutomatic.AutoSize = true;
            this.radSyncAutomatic.Checked = true;
            this.radSyncAutomatic.Location = new System.Drawing.Point(24, 19);
            this.radSyncAutomatic.Name = "radSyncAutomatic";
            this.radSyncAutomatic.Size = new System.Drawing.Size(81, 17);
            this.radSyncAutomatic.TabIndex = 0;
            this.radSyncAutomatic.Text = "Automatic";
            this.radSyncAutomatic.UseVisualStyleBackColor = true;
            this.radSyncAutomatic.CheckedChanged += new System.EventHandler(this.radSyncAutomatic_CheckedChanged);
            // 
            // radSyncManual
            // 
            this.radSyncManual.AutoSize = true;
            this.radSyncManual.Location = new System.Drawing.Point(140, 19);
            this.radSyncManual.Name = "radSyncManual";
            this.radSyncManual.Size = new System.Drawing.Size(66, 17);
            this.radSyncManual.TabIndex = 1;
            this.radSyncManual.Text = "Manual";
            this.radSyncManual.UseVisualStyleBackColor = true;
            this.radSyncManual.CheckedChanged += new System.EventHandler(this.radSyncManual_CheckedChanged);
            // 
            // cbSyncAutomaticType
            // 
            this.cbSyncAutomaticType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyncAutomaticType.FormattingEnabled = true;
            this.cbSyncAutomaticType.Items.AddRange(new object[] {
            "At start time",
            "At end time",
            "Every"});
            this.cbSyncAutomaticType.Location = new System.Drawing.Point(24, 54);
            this.cbSyncAutomaticType.Name = "cbSyncAutomaticType";
            this.cbSyncAutomaticType.Size = new System.Drawing.Size(205, 21);
            this.cbSyncAutomaticType.TabIndex = 2;
            this.cbSyncAutomaticType.SelectedIndexChanged += new System.EventHandler(this.cbSyncAutomaticType_SelectedIndexChanged);
            // 
            // nmudSyncAutomaticMinutes
            // 
            this.nmudSyncAutomaticMinutes.Location = new System.Drawing.Point(235, 54);
            this.nmudSyncAutomaticMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmudSyncAutomaticMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudSyncAutomaticMinutes.Name = "nmudSyncAutomaticMinutes";
            this.nmudSyncAutomaticMinutes.Size = new System.Drawing.Size(64, 20);
            this.nmudSyncAutomaticMinutes.TabIndex = 3;
            this.nmudSyncAutomaticMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSyncAutomaticTimeUnit
            // 
            this.cbSyncAutomaticTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyncAutomaticTimeUnit.FormattingEnabled = true;
            this.cbSyncAutomaticTimeUnit.Items.AddRange(new object[] {
            "Second(s)",
            "Minute(s)",
            "Hour(s)"});
            this.cbSyncAutomaticTimeUnit.Location = new System.Drawing.Point(306, 53);
            this.cbSyncAutomaticTimeUnit.Name = "cbSyncAutomaticTimeUnit";
            this.cbSyncAutomaticTimeUnit.Size = new System.Drawing.Size(97, 21);
            this.cbSyncAutomaticTimeUnit.TabIndex = 4;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 330);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.tabSettings.ResumeLayout(false);
            this.tabSystemSetting.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpSynchronization.ResumeLayout(false);
            this.grpSynchronization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSyncAutomaticMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabSystemSetting;
        private System.Windows.Forms.TabPage tabGUISetting;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDefaultDictionary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpSynchronization;
        private System.Windows.Forms.RadioButton radSyncAutomatic;
        private System.Windows.Forms.RadioButton radSyncManual;
        private System.Windows.Forms.ComboBox cbSyncAutomaticType;
        private System.Windows.Forms.NumericUpDown nmudSyncAutomaticMinutes;
        private System.Windows.Forms.ComboBox cbSyncAutomaticTimeUnit;
    }
}