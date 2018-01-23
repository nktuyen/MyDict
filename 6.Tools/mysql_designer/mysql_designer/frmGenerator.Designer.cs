namespace mysql_designer
{
    partial class frmGenerator
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
            this.grbApplyTo = new System.Windows.Forms.GroupBox();
            this.radSpecifiedSheet = new System.Windows.Forms.RadioButton();
            this.radCurrentSheet = new System.Windows.Forms.RadioButton();
            this.radAllSheets = new System.Windows.Forms.RadioButton();
            this.grbSettings = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbSheets = new System.Windows.Forms.ComboBox();
            this.grbTableName = new System.Windows.Forms.GroupBox();
            this.radTableNameFromSheetName = new System.Windows.Forms.RadioButton();
            this.radTableNameFromCell = new System.Windows.Forms.RadioButton();
            this.txtTableNameCellRow = new System.Windows.Forms.TextBox();
            this.txtTableNameCellColumn = new System.Windows.Forms.TextBox();
            this.lblTableNameCellRow = new System.Windows.Forms.Label();
            this.lblTableNameCellColumn = new System.Windows.Forms.Label();
            this.grbTableComment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableCommentColumn = new System.Windows.Forms.TextBox();
            this.txtTableCommentRow = new System.Windows.Forms.TextBox();
            this.radTableCommentFromCellText = new System.Windows.Forms.RadioButton();
            this.radTableCommentFromText = new System.Windows.Forms.RadioButton();
            this.txtTableComment = new System.Windows.Forms.TextBox();
            this.grbFieldData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFieldNameColumn = new System.Windows.Forms.TextBox();
            this.txtFieldTypeColumn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbFieldSize = new System.Windows.Forms.CheckBox();
            this.txtFieldSizeColumn = new System.Windows.Forms.TextBox();
            this.txtFieldAttributeColumn = new System.Windows.Forms.TextBox();
            this.chbFieldAttribute = new System.Windows.Forms.CheckBox();
            this.txtFieldNullableColumn = new System.Windows.Forms.TextBox();
            this.chbFieldNullable = new System.Windows.Forms.CheckBox();
            this.txtFieldPrimaryColumn = new System.Windows.Forms.TextBox();
            this.txtFieldUniqueColumn = new System.Windows.Forms.TextBox();
            this.chbFieldUnique = new System.Windows.Forms.CheckBox();
            this.txtFieldAutoIncreColumn = new System.Windows.Forms.TextBox();
            this.txtFieldDefValueColumn = new System.Windows.Forms.TextBox();
            this.txtFieldRemarkColumn = new System.Windows.Forms.TextBox();
            this.chbFieldAutoIncre = new System.Windows.Forms.CheckBox();
            this.chbFieldDefaultValue = new System.Windows.Forms.CheckBox();
            this.chbFieldRemark = new System.Windows.Forms.CheckBox();
            this.chbFieldPrimary = new System.Windows.Forms.CheckBox();
            this.grbApplyTo.SuspendLayout();
            this.grbSettings.SuspendLayout();
            this.grbTableName.SuspendLayout();
            this.grbTableComment.SuspendLayout();
            this.grbFieldData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbApplyTo
            // 
            this.grbApplyTo.Controls.Add(this.cbSheets);
            this.grbApplyTo.Controls.Add(this.radSpecifiedSheet);
            this.grbApplyTo.Controls.Add(this.radCurrentSheet);
            this.grbApplyTo.Controls.Add(this.radAllSheets);
            this.grbApplyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApplyTo.Location = new System.Drawing.Point(12, 12);
            this.grbApplyTo.Name = "grbApplyTo";
            this.grbApplyTo.Size = new System.Drawing.Size(707, 43);
            this.grbApplyTo.TabIndex = 0;
            this.grbApplyTo.TabStop = false;
            this.grbApplyTo.Text = "Apply To";
            // 
            // radSpecifiedSheet
            // 
            this.radSpecifiedSheet.AutoSize = true;
            this.radSpecifiedSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpecifiedSheet.Location = new System.Drawing.Point(227, 20);
            this.radSpecifiedSheet.Name = "radSpecifiedSheet";
            this.radSpecifiedSheet.Size = new System.Drawing.Size(98, 17);
            this.radSpecifiedSheet.TabIndex = 0;
            this.radSpecifiedSheet.Text = "Specified sheet";
            this.radSpecifiedSheet.UseVisualStyleBackColor = true;
            this.radSpecifiedSheet.CheckedChanged += new System.EventHandler(this.radSpecifiedSheet_CheckedChanged);
            // 
            // radCurrentSheet
            // 
            this.radCurrentSheet.AutoSize = true;
            this.radCurrentSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCurrentSheet.Location = new System.Drawing.Point(118, 20);
            this.radCurrentSheet.Name = "radCurrentSheet";
            this.radCurrentSheet.Size = new System.Drawing.Size(88, 17);
            this.radCurrentSheet.TabIndex = 0;
            this.radCurrentSheet.Text = "Current sheet";
            this.radCurrentSheet.UseVisualStyleBackColor = true;
            this.radCurrentSheet.CheckedChanged += new System.EventHandler(this.radCurrentSheet_CheckedChanged);
            // 
            // radAllSheets
            // 
            this.radAllSheets.AutoSize = true;
            this.radAllSheets.Checked = true;
            this.radAllSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAllSheets.Location = new System.Drawing.Point(29, 20);
            this.radAllSheets.Name = "radAllSheets";
            this.radAllSheets.Size = new System.Drawing.Size(70, 17);
            this.radAllSheets.TabIndex = 0;
            this.radAllSheets.TabStop = true;
            this.radAllSheets.Text = "All sheets";
            this.radAllSheets.UseVisualStyleBackColor = true;
            this.radAllSheets.CheckedChanged += new System.EventHandler(this.radAllSheets_CheckedChanged);
            // 
            // grbSettings
            // 
            this.grbSettings.Controls.Add(this.grbTableComment);
            this.grbSettings.Controls.Add(this.grbTableName);
            this.grbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSettings.Location = new System.Drawing.Point(12, 71);
            this.grbSettings.Name = "grbSettings";
            this.grbSettings.Size = new System.Drawing.Size(707, 156);
            this.grbSettings.TabIndex = 1;
            this.grbSettings.TabStop = false;
            this.grbSettings.Text = "Table Settings";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(334, 415);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 25);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbSheets
            // 
            this.cbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSheets.FormattingEnabled = true;
            this.cbSheets.Location = new System.Drawing.Point(340, 18);
            this.cbSheets.Name = "cbSheets";
            this.cbSheets.Size = new System.Drawing.Size(209, 21);
            this.cbSheets.TabIndex = 1;
            // 
            // grbTableName
            // 
            this.grbTableName.Controls.Add(this.lblTableNameCellColumn);
            this.grbTableName.Controls.Add(this.lblTableNameCellRow);
            this.grbTableName.Controls.Add(this.txtTableNameCellColumn);
            this.grbTableName.Controls.Add(this.txtTableNameCellRow);
            this.grbTableName.Controls.Add(this.radTableNameFromCell);
            this.grbTableName.Controls.Add(this.radTableNameFromSheetName);
            this.grbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTableName.Location = new System.Drawing.Point(29, 29);
            this.grbTableName.Name = "grbTableName";
            this.grbTableName.Size = new System.Drawing.Size(662, 55);
            this.grbTableName.TabIndex = 0;
            this.grbTableName.TabStop = false;
            this.grbTableName.Text = "Table Name";
            // 
            // radTableNameFromSheetName
            // 
            this.radTableNameFromSheetName.AutoSize = true;
            this.radTableNameFromSheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTableNameFromSheetName.Location = new System.Drawing.Point(38, 31);
            this.radTableNameFromSheetName.Name = "radTableNameFromSheetName";
            this.radTableNameFromSheetName.Size = new System.Drawing.Size(115, 17);
            this.radTableNameFromSheetName.TabIndex = 0;
            this.radTableNameFromSheetName.Text = "From Sheet\'s name";
            this.radTableNameFromSheetName.UseVisualStyleBackColor = true;
            this.radTableNameFromSheetName.CheckedChanged += new System.EventHandler(this.radTableNameFromSheetName_CheckedChanged);
            // 
            // radTableNameFromCell
            // 
            this.radTableNameFromCell.AutoSize = true;
            this.radTableNameFromCell.Checked = true;
            this.radTableNameFromCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTableNameFromCell.Location = new System.Drawing.Point(221, 31);
            this.radTableNameFromCell.Name = "radTableNameFromCell";
            this.radTableNameFromCell.Size = new System.Drawing.Size(112, 17);
            this.radTableNameFromCell.TabIndex = 0;
            this.radTableNameFromCell.TabStop = true;
            this.radTableNameFromCell.Text = "From specified cell";
            this.radTableNameFromCell.UseVisualStyleBackColor = true;
            this.radTableNameFromCell.CheckedChanged += new System.EventHandler(this.radTableNameFromCell_CheckedChanged);
            // 
            // txtTableNameCellRow
            // 
            this.txtTableNameCellRow.Enabled = false;
            this.txtTableNameCellRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableNameCellRow.Location = new System.Drawing.Point(400, 29);
            this.txtTableNameCellRow.Name = "txtTableNameCellRow";
            this.txtTableNameCellRow.Size = new System.Drawing.Size(30, 20);
            this.txtTableNameCellRow.TabIndex = 1;
            this.txtTableNameCellRow.Text = "2";
            // 
            // txtTableNameCellColumn
            // 
            this.txtTableNameCellColumn.Enabled = false;
            this.txtTableNameCellColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableNameCellColumn.Location = new System.Drawing.Point(369, 29);
            this.txtTableNameCellColumn.Name = "txtTableNameCellColumn";
            this.txtTableNameCellColumn.Size = new System.Drawing.Size(30, 20);
            this.txtTableNameCellColumn.TabIndex = 2;
            this.txtTableNameCellColumn.Text = "C";
            // 
            // lblTableNameCellRow
            // 
            this.lblTableNameCellRow.AutoSize = true;
            this.lblTableNameCellRow.Location = new System.Drawing.Point(401, 12);
            this.lblTableNameCellRow.Name = "lblTableNameCellRow";
            this.lblTableNameCellRow.Size = new System.Drawing.Size(29, 13);
            this.lblTableNameCellRow.TabIndex = 2;
            this.lblTableNameCellRow.Text = "Row";
            // 
            // lblTableNameCellColumn
            // 
            this.lblTableNameCellColumn.AutoSize = true;
            this.lblTableNameCellColumn.Location = new System.Drawing.Point(373, 12);
            this.lblTableNameCellColumn.Name = "lblTableNameCellColumn";
            this.lblTableNameCellColumn.Size = new System.Drawing.Size(22, 13);
            this.lblTableNameCellColumn.TabIndex = 3;
            this.lblTableNameCellColumn.Text = "Col";
            // 
            // grbTableComment
            // 
            this.grbTableComment.Controls.Add(this.txtTableComment);
            this.grbTableComment.Controls.Add(this.label1);
            this.grbTableComment.Controls.Add(this.label2);
            this.grbTableComment.Controls.Add(this.txtTableCommentColumn);
            this.grbTableComment.Controls.Add(this.txtTableCommentRow);
            this.grbTableComment.Controls.Add(this.radTableCommentFromCellText);
            this.grbTableComment.Controls.Add(this.radTableCommentFromText);
            this.grbTableComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTableComment.Location = new System.Drawing.Point(29, 90);
            this.grbTableComment.Name = "grbTableComment";
            this.grbTableComment.Size = new System.Drawing.Size(662, 55);
            this.grbTableComment.TabIndex = 1;
            this.grbTableComment.TabStop = false;
            this.grbTableComment.Text = "Table Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Col";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Row";
            // 
            // txtTableCommentColumn
            // 
            this.txtTableCommentColumn.Enabled = false;
            this.txtTableCommentColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableCommentColumn.Location = new System.Drawing.Point(369, 30);
            this.txtTableCommentColumn.Name = "txtTableCommentColumn";
            this.txtTableCommentColumn.Size = new System.Drawing.Size(30, 20);
            this.txtTableCommentColumn.TabIndex = 2;
            this.txtTableCommentColumn.Text = "C";
            // 
            // txtTableCommentRow
            // 
            this.txtTableCommentRow.Enabled = false;
            this.txtTableCommentRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableCommentRow.Location = new System.Drawing.Point(400, 30);
            this.txtTableCommentRow.Name = "txtTableCommentRow";
            this.txtTableCommentRow.Size = new System.Drawing.Size(30, 20);
            this.txtTableCommentRow.TabIndex = 1;
            this.txtTableCommentRow.Text = "3";
            // 
            // radTableCommentFromCellText
            // 
            this.radTableCommentFromCellText.AutoSize = true;
            this.radTableCommentFromCellText.Checked = true;
            this.radTableCommentFromCellText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTableCommentFromCellText.Location = new System.Drawing.Point(221, 32);
            this.radTableCommentFromCellText.Name = "radTableCommentFromCellText";
            this.radTableCommentFromCellText.Size = new System.Drawing.Size(112, 17);
            this.radTableCommentFromCellText.TabIndex = 0;
            this.radTableCommentFromCellText.TabStop = true;
            this.radTableCommentFromCellText.Text = "From specified cell";
            this.radTableCommentFromCellText.UseVisualStyleBackColor = true;
            // 
            // radTableCommentFromText
            // 
            this.radTableCommentFromText.AutoSize = true;
            this.radTableCommentFromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTableCommentFromText.Location = new System.Drawing.Point(38, 32);
            this.radTableCommentFromText.Name = "radTableCommentFromText";
            this.radTableCommentFromText.Size = new System.Drawing.Size(46, 17);
            this.radTableCommentFromText.TabIndex = 0;
            this.radTableCommentFromText.Text = "Text";
            this.radTableCommentFromText.UseVisualStyleBackColor = true;
            // 
            // txtTableComment
            // 
            this.txtTableComment.Location = new System.Drawing.Point(86, 30);
            this.txtTableComment.Name = "txtTableComment";
            this.txtTableComment.Size = new System.Drawing.Size(110, 20);
            this.txtTableComment.TabIndex = 4;
            // 
            // grbFieldData
            // 
            this.grbFieldData.Controls.Add(this.chbFieldUnique);
            this.grbFieldData.Controls.Add(this.chbFieldPrimary);
            this.grbFieldData.Controls.Add(this.chbFieldNullable);
            this.grbFieldData.Controls.Add(this.chbFieldAttribute);
            this.grbFieldData.Controls.Add(this.chbFieldRemark);
            this.grbFieldData.Controls.Add(this.chbFieldDefaultValue);
            this.grbFieldData.Controls.Add(this.chbFieldAutoIncre);
            this.grbFieldData.Controls.Add(this.chbFieldSize);
            this.grbFieldData.Controls.Add(this.txtFieldUniqueColumn);
            this.grbFieldData.Controls.Add(this.txtFieldPrimaryColumn);
            this.grbFieldData.Controls.Add(this.label5);
            this.grbFieldData.Controls.Add(this.txtFieldNullableColumn);
            this.grbFieldData.Controls.Add(this.label4);
            this.grbFieldData.Controls.Add(this.txtFieldAttributeColumn);
            this.grbFieldData.Controls.Add(this.txtFieldSizeColumn);
            this.grbFieldData.Controls.Add(this.txtFieldRemarkColumn);
            this.grbFieldData.Controls.Add(this.txtFieldDefValueColumn);
            this.grbFieldData.Controls.Add(this.txtFieldAutoIncreColumn);
            this.grbFieldData.Controls.Add(this.txtFieldTypeColumn);
            this.grbFieldData.Controls.Add(this.txtFieldNameColumn);
            this.grbFieldData.Controls.Add(this.txtStartRow);
            this.grbFieldData.Controls.Add(this.label3);
            this.grbFieldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFieldData.Location = new System.Drawing.Point(12, 235);
            this.grbFieldData.Name = "grbFieldData";
            this.grbFieldData.Size = new System.Drawing.Size(707, 174);
            this.grbFieldData.TabIndex = 3;
            this.grbFieldData.TabStop = false;
            this.grbFieldData.Text = "Field Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start row";
            // 
            // txtStartRow
            // 
            this.txtStartRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartRow.Location = new System.Drawing.Point(34, 35);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(33, 20);
            this.txtStartRow.TabIndex = 1;
            this.txtStartRow.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name column";
            // 
            // txtFieldNameColumn
            // 
            this.txtFieldNameColumn.Enabled = false;
            this.txtFieldNameColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldNameColumn.Location = new System.Drawing.Point(34, 83);
            this.txtFieldNameColumn.Name = "txtFieldNameColumn";
            this.txtFieldNameColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldNameColumn.TabIndex = 4;
            this.txtFieldNameColumn.Text = "B";
            // 
            // txtFieldTypeColumn
            // 
            this.txtFieldTypeColumn.Enabled = false;
            this.txtFieldTypeColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldTypeColumn.Location = new System.Drawing.Point(112, 83);
            this.txtFieldTypeColumn.Name = "txtFieldTypeColumn";
            this.txtFieldTypeColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldTypeColumn.TabIndex = 4;
            this.txtFieldTypeColumn.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type column";
            // 
            // chbFieldSize
            // 
            this.chbFieldSize.AutoSize = true;
            this.chbFieldSize.Checked = true;
            this.chbFieldSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldSize.Location = new System.Drawing.Point(191, 64);
            this.chbFieldSize.Name = "chbFieldSize";
            this.chbFieldSize.Size = new System.Drawing.Size(83, 17);
            this.chbFieldSize.TabIndex = 6;
            this.chbFieldSize.Text = "Size column";
            this.chbFieldSize.UseVisualStyleBackColor = true;
            // 
            // txtFieldSizeColumn
            // 
            this.txtFieldSizeColumn.Enabled = false;
            this.txtFieldSizeColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldSizeColumn.Location = new System.Drawing.Point(191, 83);
            this.txtFieldSizeColumn.Name = "txtFieldSizeColumn";
            this.txtFieldSizeColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldSizeColumn.TabIndex = 4;
            this.txtFieldSizeColumn.Text = "D";
            // 
            // txtFieldAttributeColumn
            // 
            this.txtFieldAttributeColumn.Enabled = false;
            this.txtFieldAttributeColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldAttributeColumn.Location = new System.Drawing.Point(276, 83);
            this.txtFieldAttributeColumn.Name = "txtFieldAttributeColumn";
            this.txtFieldAttributeColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldAttributeColumn.TabIndex = 4;
            this.txtFieldAttributeColumn.Text = "E";
            // 
            // chbFieldAttribute
            // 
            this.chbFieldAttribute.AutoSize = true;
            this.chbFieldAttribute.Checked = true;
            this.chbFieldAttribute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldAttribute.Location = new System.Drawing.Point(276, 64);
            this.chbFieldAttribute.Name = "chbFieldAttribute";
            this.chbFieldAttribute.Size = new System.Drawing.Size(102, 17);
            this.chbFieldAttribute.TabIndex = 6;
            this.chbFieldAttribute.Text = "Attribute column";
            this.chbFieldAttribute.UseVisualStyleBackColor = true;
            // 
            // txtFieldNullableColumn
            // 
            this.txtFieldNullableColumn.Enabled = false;
            this.txtFieldNullableColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldNullableColumn.Location = new System.Drawing.Point(384, 83);
            this.txtFieldNullableColumn.Name = "txtFieldNullableColumn";
            this.txtFieldNullableColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldNullableColumn.TabIndex = 4;
            this.txtFieldNullableColumn.Text = "F";
            // 
            // chbFieldNullable
            // 
            this.chbFieldNullable.AutoSize = true;
            this.chbFieldNullable.Checked = true;
            this.chbFieldNullable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldNullable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldNullable.Location = new System.Drawing.Point(384, 64);
            this.chbFieldNullable.Name = "chbFieldNullable";
            this.chbFieldNullable.Size = new System.Drawing.Size(101, 17);
            this.chbFieldNullable.TabIndex = 6;
            this.chbFieldNullable.Text = "Nullable column";
            this.chbFieldNullable.UseVisualStyleBackColor = true;
            // 
            // txtFieldPrimaryColumn
            // 
            this.txtFieldPrimaryColumn.Enabled = false;
            this.txtFieldPrimaryColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldPrimaryColumn.Location = new System.Drawing.Point(484, 83);
            this.txtFieldPrimaryColumn.Name = "txtFieldPrimaryColumn";
            this.txtFieldPrimaryColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldPrimaryColumn.TabIndex = 4;
            this.txtFieldPrimaryColumn.Text = "G";
            // 
            // txtFieldUniqueColumn
            // 
            this.txtFieldUniqueColumn.Enabled = false;
            this.txtFieldUniqueColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldUniqueColumn.Location = new System.Drawing.Point(594, 83);
            this.txtFieldUniqueColumn.Name = "txtFieldUniqueColumn";
            this.txtFieldUniqueColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldUniqueColumn.TabIndex = 4;
            this.txtFieldUniqueColumn.Text = "H";
            // 
            // chbFieldUnique
            // 
            this.chbFieldUnique.AutoSize = true;
            this.chbFieldUnique.Checked = true;
            this.chbFieldUnique.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldUnique.Location = new System.Drawing.Point(594, 64);
            this.chbFieldUnique.Name = "chbFieldUnique";
            this.chbFieldUnique.Size = new System.Drawing.Size(97, 17);
            this.chbFieldUnique.TabIndex = 6;
            this.chbFieldUnique.Text = "Unique column";
            this.chbFieldUnique.UseVisualStyleBackColor = true;
            // 
            // txtFieldAutoIncreColumn
            // 
            this.txtFieldAutoIncreColumn.Enabled = false;
            this.txtFieldAutoIncreColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldAutoIncreColumn.Location = new System.Drawing.Point(34, 140);
            this.txtFieldAutoIncreColumn.Name = "txtFieldAutoIncreColumn";
            this.txtFieldAutoIncreColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldAutoIncreColumn.TabIndex = 4;
            this.txtFieldAutoIncreColumn.Text = "I";
            // 
            // txtFieldDefValueColumn
            // 
            this.txtFieldDefValueColumn.Enabled = false;
            this.txtFieldDefValueColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldDefValueColumn.Location = new System.Drawing.Point(191, 140);
            this.txtFieldDefValueColumn.Name = "txtFieldDefValueColumn";
            this.txtFieldDefValueColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldDefValueColumn.TabIndex = 4;
            this.txtFieldDefValueColumn.Text = "J";
            // 
            // txtFieldRemarkColumn
            // 
            this.txtFieldRemarkColumn.Enabled = false;
            this.txtFieldRemarkColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldRemarkColumn.Location = new System.Drawing.Point(384, 140);
            this.txtFieldRemarkColumn.Name = "txtFieldRemarkColumn";
            this.txtFieldRemarkColumn.Size = new System.Drawing.Size(30, 20);
            this.txtFieldRemarkColumn.TabIndex = 4;
            this.txtFieldRemarkColumn.Text = "K";
            // 
            // chbFieldAutoIncre
            // 
            this.chbFieldAutoIncre.AutoSize = true;
            this.chbFieldAutoIncre.Checked = true;
            this.chbFieldAutoIncre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldAutoIncre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldAutoIncre.Location = new System.Drawing.Point(34, 121);
            this.chbFieldAutoIncre.Name = "chbFieldAutoIncre";
            this.chbFieldAutoIncre.Size = new System.Drawing.Size(134, 17);
            this.chbFieldAutoIncre.TabIndex = 6;
            this.chbFieldAutoIncre.Text = "Auto-increment column";
            this.chbFieldAutoIncre.UseVisualStyleBackColor = true;
            // 
            // chbFieldDefaultValue
            // 
            this.chbFieldDefaultValue.AutoSize = true;
            this.chbFieldDefaultValue.Checked = true;
            this.chbFieldDefaultValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldDefaultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldDefaultValue.Location = new System.Drawing.Point(191, 121);
            this.chbFieldDefaultValue.Name = "chbFieldDefaultValue";
            this.chbFieldDefaultValue.Size = new System.Drawing.Size(126, 17);
            this.chbFieldDefaultValue.TabIndex = 6;
            this.chbFieldDefaultValue.Text = "Default value column";
            this.chbFieldDefaultValue.UseVisualStyleBackColor = true;
            // 
            // chbFieldRemark
            // 
            this.chbFieldRemark.AutoSize = true;
            this.chbFieldRemark.Checked = true;
            this.chbFieldRemark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldRemark.Location = new System.Drawing.Point(384, 121);
            this.chbFieldRemark.Name = "chbFieldRemark";
            this.chbFieldRemark.Size = new System.Drawing.Size(100, 17);
            this.chbFieldRemark.TabIndex = 6;
            this.chbFieldRemark.Text = "Remark column";
            this.chbFieldRemark.UseVisualStyleBackColor = true;
            // 
            // chbFieldPrimary
            // 
            this.chbFieldPrimary.AutoSize = true;
            this.chbFieldPrimary.Checked = true;
            this.chbFieldPrimary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFieldPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFieldPrimary.Location = new System.Drawing.Point(484, 64);
            this.chbFieldPrimary.Name = "chbFieldPrimary";
            this.chbFieldPrimary.Size = new System.Drawing.Size(97, 17);
            this.chbFieldPrimary.TabIndex = 6;
            this.chbFieldPrimary.Text = "Primary column";
            this.chbFieldPrimary.UseVisualStyleBackColor = true;
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 452);
            this.Controls.Add(this.grbFieldData);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grbSettings);
            this.Controls.Add(this.grbApplyTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerator_FormClosing);
            this.Load += new System.EventHandler(this.frmGenerator_Load);
            this.grbApplyTo.ResumeLayout(false);
            this.grbApplyTo.PerformLayout();
            this.grbSettings.ResumeLayout(false);
            this.grbTableName.ResumeLayout(false);
            this.grbTableName.PerformLayout();
            this.grbTableComment.ResumeLayout(false);
            this.grbTableComment.PerformLayout();
            this.grbFieldData.ResumeLayout(false);
            this.grbFieldData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApplyTo;
        private System.Windows.Forms.RadioButton radAllSheets;
        private System.Windows.Forms.RadioButton radSpecifiedSheet;
        private System.Windows.Forms.RadioButton radCurrentSheet;
        private System.Windows.Forms.GroupBox grbSettings;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbSheets;
        private System.Windows.Forms.GroupBox grbTableName;
        private System.Windows.Forms.RadioButton radTableNameFromSheetName;
        private System.Windows.Forms.RadioButton radTableNameFromCell;
        private System.Windows.Forms.Label lblTableNameCellColumn;
        private System.Windows.Forms.Label lblTableNameCellRow;
        private System.Windows.Forms.TextBox txtTableNameCellColumn;
        private System.Windows.Forms.TextBox txtTableNameCellRow;
        private System.Windows.Forms.GroupBox grbTableComment;
        private System.Windows.Forms.TextBox txtTableComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableCommentColumn;
        private System.Windows.Forms.TextBox txtTableCommentRow;
        private System.Windows.Forms.RadioButton radTableCommentFromCellText;
        private System.Windows.Forms.RadioButton radTableCommentFromText;
        private System.Windows.Forms.GroupBox grbFieldData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbFieldSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFieldTypeColumn;
        private System.Windows.Forms.TextBox txtFieldNameColumn;
        private System.Windows.Forms.TextBox txtStartRow;
        private System.Windows.Forms.TextBox txtFieldSizeColumn;
        private System.Windows.Forms.CheckBox chbFieldAttribute;
        private System.Windows.Forms.TextBox txtFieldAttributeColumn;
        private System.Windows.Forms.CheckBox chbFieldNullable;
        private System.Windows.Forms.TextBox txtFieldNullableColumn;
        private System.Windows.Forms.TextBox txtFieldPrimaryColumn;
        private System.Windows.Forms.CheckBox chbFieldUnique;
        private System.Windows.Forms.TextBox txtFieldUniqueColumn;
        private System.Windows.Forms.TextBox txtFieldRemarkColumn;
        private System.Windows.Forms.TextBox txtFieldDefValueColumn;
        private System.Windows.Forms.TextBox txtFieldAutoIncreColumn;
        private System.Windows.Forms.CheckBox chbFieldRemark;
        private System.Windows.Forms.CheckBox chbFieldDefaultValue;
        private System.Windows.Forms.CheckBox chbFieldAutoIncre;
        private System.Windows.Forms.CheckBox chbFieldPrimary;
    }
}