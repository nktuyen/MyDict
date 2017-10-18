namespace MyDict
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
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lbVocabularies = new System.Windows.Forms.ListBox();
            this.wrdViewer = new MyDict.WordViewer();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter.Location = new System.Drawing.Point(3, 3);
            this.splitter.Margin = new System.Windows.Forms.Padding(0);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.BackColor = System.Drawing.Color.White;
            this.splitter.Panel1.Controls.Add(this.txtKeyword);
            this.splitter.Panel1.Controls.Add(this.lblKeyword);
            this.splitter.Panel1.Controls.Add(this.lblStatus);
            this.splitter.Panel1.Controls.Add(this.cbFilter);
            this.splitter.Panel1.Controls.Add(this.lblFilter);
            this.splitter.Panel1.Controls.Add(this.lbVocabularies);
            this.splitter.Panel1MinSize = 250;
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.BackColor = System.Drawing.Color.White;
            this.splitter.Panel2.Controls.Add(this.wrdViewer);
            this.splitter.Panel2MinSize = 146;
            this.splitter.Size = new System.Drawing.Size(580, 356);
            this.splitter.SplitterDistance = 250;
            this.splitter.SplitterWidth = 6;
            this.splitter.TabIndex = 7;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Location = new System.Drawing.Point(53, 29);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(194, 20);
            this.txtKeyword.TabIndex = 11;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(3, 33);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(51, 13);
            this.lblKeyword.TabIndex = 10;
            this.lblKeyword.Text = "Keyword:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(3, 335);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(244, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Total: 0";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(53, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(194, 21);
            this.cbFilter.TabIndex = 8;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(3, 7);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter:";
            // 
            // lbVocabularies
            // 
            this.lbVocabularies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVocabularies.FormattingEnabled = true;
            this.lbVocabularies.IntegralHeight = false;
            this.lbVocabularies.Location = new System.Drawing.Point(3, 53);
            this.lbVocabularies.Name = "lbVocabularies";
            this.lbVocabularies.Size = new System.Drawing.Size(244, 279);
            this.lbVocabularies.Sorted = true;
            this.lbVocabularies.TabIndex = 6;
            this.lbVocabularies.SelectedIndexChanged += new System.EventHandler(this.lbVocabularies_SelectedIndexChanged);
            // 
            // wrdViewer
            // 
            this.wrdViewer.AutoScroll = true;
            this.wrdViewer.BackColor = System.Drawing.Color.White;
            this.wrdViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrdViewer.Location = new System.Drawing.Point(0, 0);
            this.wrdViewer.Name = "wrdViewer";
            this.wrdViewer.Size = new System.Drawing.Size(322, 354);
            this.wrdViewer.TabIndex = 7;
            this.wrdViewer.OnRefreshClicked += new System.EventHandler(this.wrdViewer_OnRefreshClicked);
            this.wrdViewer.OnLoveClicked += new System.EventHandler(this.wrdViewer_OnLoveClicked);
            this.wrdViewer.OnPrintClicked += new System.EventHandler(this.wrdViewer_OnPrintClicked);
            this.wrdViewer.OnEditClicked += new System.EventHandler(this.wrdViewer_OnEditClicked);
            this.wrdViewer.OnPreferencesClicked += new System.EventHandler(this.wrdViewer_OnPreferencesClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.splitter);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel1.PerformLayout();
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ListBox lbVocabularies;
        private WordViewer wrdViewer;
    }
}

