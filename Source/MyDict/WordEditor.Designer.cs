namespace MyDict
{
    partial class WordEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblVocabulary = new System.Windows.Forms.Label();
            this.txtVocabulary = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.lblPhonetic = new System.Windows.Forms.Label();
            this.txtPhonetic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddDesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(534, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(486, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(390, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(47, 24);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(438, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblVocabulary
            // 
            this.lblVocabulary.AutoSize = true;
            this.lblVocabulary.Location = new System.Drawing.Point(3, 49);
            this.lblVocabulary.Name = "lblVocabulary";
            this.lblVocabulary.Size = new System.Drawing.Size(63, 13);
            this.lblVocabulary.TabIndex = 4;
            this.lblVocabulary.Text = "Vocabulary:";
            // 
            // txtVocabulary
            // 
            this.txtVocabulary.Location = new System.Drawing.Point(72, 45);
            this.txtVocabulary.MaxLength = 255;
            this.txtVocabulary.Name = "txtVocabulary";
            this.txtVocabulary.Size = new System.Drawing.Size(508, 20);
            this.txtVocabulary.TabIndex = 5;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(6, 80);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Class:";
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(72, 76);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(440, 21);
            this.cbClasses.Sorted = true;
            this.cbClasses.TabIndex = 7;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(518, 75);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(62, 23);
            this.btnNewClass.TabIndex = 8;
            this.btnNewClass.Text = "Add";
            this.btnNewClass.UseVisualStyleBackColor = true;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // lblPhonetic
            // 
            this.lblPhonetic.AutoSize = true;
            this.lblPhonetic.Location = new System.Drawing.Point(5, 117);
            this.lblPhonetic.Name = "lblPhonetic";
            this.lblPhonetic.Size = new System.Drawing.Size(52, 13);
            this.lblPhonetic.TabIndex = 9;
            this.lblPhonetic.Text = "Phonetic:";
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Location = new System.Drawing.Point(72, 113);
            this.txtPhonetic.MaxLength = 255;
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.Size = new System.Drawing.Size(508, 20);
            this.txtPhonetic.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(72, 142);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 20);
            this.txtDescription.TabIndex = 12;
            // 
            // btnAddDesc
            // 
            this.btnAddDesc.Location = new System.Drawing.Point(518, 141);
            this.btnAddDesc.Name = "btnAddDesc";
            this.btnAddDesc.Size = new System.Drawing.Size(62, 23);
            this.btnAddDesc.TabIndex = 13;
            this.btnAddDesc.Text = "Add";
            this.btnAddDesc.UseVisualStyleBackColor = true;
            this.btnAddDesc.Click += new System.EventHandler(this.btnAddDesc_Click);
            // 
            // WordEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddDesc);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhonetic);
            this.Controls.Add(this.lblPhonetic);
            this.Controls.Add(this.btnNewClass);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtVocabulary);
            this.Controls.Add(this.lblVocabulary);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "WordEditor";
            this.Size = new System.Drawing.Size(583, 375);
            this.VisibleChanged += new System.EventHandler(this.WordEditor_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordEditor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblVocabulary;
        private System.Windows.Forms.TextBox txtVocabulary;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Label lblPhonetic;
        private System.Windows.Forms.TextBox txtPhonetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddDesc;
    }
}
