using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace mysql_designer
{
    public partial class frmGenerator : Form
    {
        public Excel.Workbook Book { get; set; }

        public frmGenerator()
        {
            InitializeComponent();
        }

        private string ResourceString(string index)
        {
            try
            {
                return Properties.Resources.ResourceManager.GetString(index);
            }
            catch
            {
                return index;
            }
        }

        private void frmGenerator_Load(object sender, EventArgs e)
        {
            if(null != Book)
            {
                foreach(Excel.Worksheet sheet in Book.Sheets)
                {
                    cbSheets.Items.Add(sheet.Name);
                }
            }
        }

        private void frmGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void radAllSheets_CheckedChanged(object sender, EventArgs e)
        {
            cbSheets.SelectedIndex = -1;
            cbSheets.Enabled = false;
        }

        private void radCurrentSheet_CheckedChanged(object sender, EventArgs e)
        {
            if (null != Book)
            {
                Excel.Worksheet curSheet = Book.ActiveSheet;
                if (null != curSheet)
                {
                    cbSheets.SelectedIndex = cbSheets.FindString(curSheet.Name);
                }
            }
            cbSheets.Enabled = false;
        }

        private void radSpecifiedSheet_CheckedChanged(object sender, EventArgs e)
        {
            cbSheets.Enabled = true;
            if (cbSheets.SelectedIndex == -1)
            {
                cbSheets.SelectedIndex = 0;
            }
        }

        private string CreateTable(Excel.Worksheet sheet)
        {
            if (null == sheet)
            {
                return string.Empty;
            }

            string strCreate = "CREATE TABLE";
            string tblName = string.Empty;

            if (radTableNameFromSheetName.Checked)
            {
                tblName = sheet.Name;
            }
            else if (radTableNameFromCell.Checked)
            {
                try
                {
                    Excel.Range tblNameCell = sheet.Range[txtTableNameCellColumn.Text + txtTableNameCellRow.Text];
                    if (null != tblNameCell)
                    {
                        tblName = tblNameCell.Text;
                    }
                }
                catch(Exception ex)
                {
                    Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                    return string.Empty;
                }
            }

            string tblComment = string.Empty;
            if (radTableCommentFromText.Checked)
            {
                tblComment = txtTableComment.Text;
            }
            else if (radTableCommentFromCellText.Checked)
            {
                try
                {
                    Excel.Range tblCommentCell = sheet.Range[txtTableCommentColumn.Text + txtTableCommentRow.Text];
                    if (null != tblCommentCell)
                    {
                        tblComment = tblCommentCell.Text;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                    return string.Empty;
                }
            }

            string query = strCreate + " " + tblName + "(\n";
            uint fieldCount = 0;
            //Obtain fields
            List<string> primaryKeys=new List<string>();
            List<string> uniqueKeys=new List<string>();
            string fieldCommand = string.Empty;
            string fieldNotNull = string.Empty;
            int row = int.Parse(txtStartRow.Text);
            Excel.Range fieldNameCell = null;
            Excel.Range fieldTypeCell = null;
            Excel.Range fieldSizeCell = null;
            Excel.Range fieldAttributeCell = null;
            Excel.Range fieldNullableCell = null;
            Excel.Range fieldPrimaryCell = null;
            Excel.Range fieldUniqueCell = null;
            Excel.Range fieldAutoIncreCell = null;
            Excel.Range fieldDefaultValueCell = null;
            Excel.Range fieldRemarkCell = null;

            try
            {
                fieldNameCell = sheet.Range[txtFieldNameColumn.Text + row];
                fieldTypeCell = sheet.Range[txtFieldTypeColumn.Text + row];

                while( (null != fieldNameCell) && (null != fieldTypeCell ) && (null != fieldNameCell.Text) && ((string)fieldNameCell.Text).Length>0 )
                {
                    fieldCommand = "\t" + fieldNameCell.Text + " " + fieldTypeCell.Text;
                    //Field size
                    if (chbFieldSize.Checked)
                    {
                        try
                        {
                            fieldSizeCell = sheet.Range[txtFieldSizeColumn.Text + row];
                            if( (null != fieldSizeCell) && (((string)fieldSizeCell.Text).Length > 0) )
                            {
                                fieldCommand += "(" + fieldSizeCell.Text + ")";
                            }
                        }
                        catch(Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return string.Empty;
                        }
                    }

                    //Field's attribute
                    if (chbFieldAttribute.Checked)
                    {
                        try
                        {
                            fieldAttributeCell = sheet.Range[txtFieldAttributeColumn.Text + row];
                            if (null != fieldAttributeCell)
                            {
                                fieldCommand += " " + fieldAttributeCell.Text;
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return string.Empty;
                        }
                    }

                    //Nullable
                    fieldNotNull = " NOT NULL";
                    if (chbFieldNullable.Checked)
                    {
                        try
                        {
                            fieldNullableCell = sheet.Range[txtFieldNullableColumn.Text + row];
                            if (null != fieldNullableCell)
                            {
                                if(((string)fieldNullableCell.Text).Length > 0)
                                {
                                    fieldNotNull = string.Empty;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return string.Empty;
                        }
                    }
                    if (fieldNotNull.Length > 0)
                    {
                        fieldCommand += fieldNotNull;
                    }

                    //Primary
                    if (chbFieldPrimary.Checked)
                    {
                        try
                        {
                            fieldPrimaryCell = sheet.Range[txtFieldPrimaryColumn.Text + row];
                            if (null != fieldPrimaryCell)
                            {
                                if (((string)fieldPrimaryCell.Text).Length > 0)
                                {
                                    primaryKeys.Add(fieldNameCell.Text);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return string.Empty;
                        }
                    }

                    //Unique
                    if (chbFieldUnique.Checked)
                    {
                        try
                        {
                            fieldUniqueCell = sheet.Range[txtFieldUniqueColumn.Text + row];
                            if (null != fieldUniqueCell)
                            {
                                if (((string)fieldUniqueCell.Text).Length > 0)
                                {
                                    uniqueKeys.Add(fieldNameCell.Text);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return string.Empty;
                        }
                    }

                    //Field's remark
                    if (chbFieldRemark.Checked)
                    {
                        try
                        {
                            fieldRemarkCell = sheet.Range[txtFieldRemarkColumn.Text + row];
                            if (null != fieldRemarkCell)
                            {
                                fieldCommand += " COMMENT '" + fieldRemarkCell.Text + "'";
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return string.Empty;
                        }
                    }

                    if(fieldCount > 0)
                    {
                        query += ",\n";
                    }

                    query += fieldCommand;
                    fieldCount++;
                    row++;
                    fieldNameCell = sheet.Range[txtFieldNameColumn.Text + row];
                    fieldTypeCell = sheet.Range[txtFieldTypeColumn.Text + row];
                }
            }
            catch(Exception ex)
            {
                Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                return string.Empty;
            }


            query += "\n)";

            if (tblComment.Length > 0)
            {
                query += " COMMENT='" + tblComment + "'";
            }

            query += ";";

            if( (primaryKeys.Count > 0) || (uniqueKeys.Count > 0))
            {
                query += ("\nALTER TABLE " + tblName + "\n");
                ushort keyCount = 0;
                foreach(string fieldName in primaryKeys)
                {
                    if(keyCount > 0)
                    {
                        query += (",\n");
                    }

                    keyCount++;
                    query += ("\tADD PRIMARY KEY (" + fieldName + ")");
                }

                foreach(string fieldName in uniqueKeys)
                {
                    if (keyCount > 0)
                    {
                        query += (",\n");
                    }
                    keyCount++;

                    query += ("\tADD UNIQUE KEY UN_" + tblName + keyCount.ToString() + " (" + fieldName + ")");
                }

                query += ";";
            }

            return query;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Logger.Instance.Reset();

            if (radAllSheets.Checked)
            {
                foreach(Excel.Worksheet sheet in Book.Sheets)
                {
                    MessageBox.Show(CreateTable(sheet));
                }
            }
            else if (radCurrentSheet.Checked)
            {
                Excel.Worksheet curSheet = Book.ActiveSheet;
                MessageBox.Show(CreateTable(curSheet));
            }
            else
            {
                int selectedSheetIndex = cbSheets.SelectedIndex;
                if (selectedSheetIndex == -1)
                {
                    MessageBox.Show(ResourceString(Constants.MSG_NO_SHEET_SPECIFIED), ResourceString(Constants.STR_WARNING), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSheets.Focus();
                    return;
                }
                string sheetName = cbSheets.Items[selectedSheetIndex].ToString();
                Excel.Worksheet  selectedSheet = Book.Sheets[sheetName];
                if (null == selectedSheet)
                {
                    MessageBox.Show(ResourceString(Constants.MSG_SHEET_CANNOT_FOUND), ResourceString(Constants.STR_WARNING), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSheets.Focus();
                    return;
                }

                MessageBox.Show(CreateTable(selectedSheet));
            }
        }

        private void cbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radTableNameFromSheetName_CheckedChanged(object sender, EventArgs e)
        {
            txtTableNameCellRow.Enabled = false;
            txtTableNameCellColumn.Enabled = false;
        }

        private void radTableNameFromCell_CheckedChanged(object sender, EventArgs e)
        {
            txtTableNameCellRow.Enabled = true;
            txtTableNameCellColumn.Enabled = true;
            txtTableNameCellRow.Focus();
        }
    }
}
