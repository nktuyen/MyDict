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
using MySql.Data.MySqlClient;

namespace mysql_designer
{
    public partial class frmGenerator : Form
    {
        public Excel.Workbook Book { get; set; }

        public frmGenerator()
        {
            InitializeComponent();
        }

        private void frmGenerator_Load(object sender, EventArgs e)
        {
            cbSheets.Items.Clear();
            lstExcludeSheets.Items.Clear();
            if(null != Book)
            {
                foreach(Excel.Worksheet sheet in Book.Sheets)
                {
                    cbSheets.Items.Add(sheet.Name);
                    lstExcludeSheets.Items.Add(sheet.Name);
                }
            }
            lstExcludeSheets.SelectedIndex = lstExcludeSheets.FindString("References");
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
            lstExcludeSheets.Enabled = true;
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
            lstExcludeSheets.Enabled = false;
            cbSheets.Enabled = false;
        }

        private void radSpecifiedSheet_CheckedChanged(object sender, EventArgs e)
        {
            cbSheets.Enabled = true;
            lstExcludeSheets.Enabled = false;
            if (cbSheets.SelectedIndex == -1)
            {
                cbSheets.SelectedIndex = 0;
            }
        }

        private string CreateTable(Excel.Worksheet sheet, ref Dictionary<string,string> tableNames)
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
                    return "******Create Table " + tblName + " error:" + ex.Message;
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
                    return "******Create Table " + tblName + " error:" + ex.Message;
                }
            }

            string query = strCreate + " " + tableNames[tblName] + "("+Environment.NewLine;
            uint fieldIndex = 0;
            //Obtain fields
            Dictionary<string, string> primaryKeys = new Dictionary<string, string>();
            Dictionary<string, ForeignKeyInfo> foreignKeys = new Dictionary<string, ForeignKeyInfo>();
            List<string> uniqueKeys=new List<string>();
            List<string> fieldNames = new List<string>();
            List<string> fieldTypes = new List<string>();
            string fieldCommand = string.Empty;
            string fieldNotNull = string.Empty;
            string fieldAutoIncrement = string.Empty;
            int row = int.Parse(txtStartRow.Text);
            int rowEnd = row;
            Excel.Range fieldNameCell = null;
            Excel.Range fieldTypeCell = null;
            Excel.Range fieldSizeCell = null;
            Excel.Range fieldAttributeCell = null;
            Excel.Range fieldNullableCell = null;
            Excel.Range fieldPrimaryCell = null;
            Excel.Range fieldUniqueCell = null;
            Excel.Range fieldAutoIncreCell = null;
            Excel.Range fieldDefaultValueCell = null;
            Excel.Range fieldForeignKeyValueCell = null;
            Excel.Range fieldForeignTableValueCell = null;
            Excel.Range fieldForeignSourceFieldValueCell = null;
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
                            return "******Create Table " + tblName + " error:" + ex.Message;
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
                            return "******Create Table " + tblName + " error:" + ex.Message;
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
                            return "******Create Table " + tblName + " error:" + ex.Message;
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
                                    primaryKeys.Add(fieldNameCell.Text, fieldNameCell.Text);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return "******Create Table " + tblName + " error:" + ex.Message;
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
                            return "******Create Table " + tblName + " error:" + ex.Message;
                        }
                    }

                    //AutoIncrement
                    fieldAutoIncrement = string.Empty;
                    if (chbFieldAutoIncre.Checked)
                    {
                        try
                        {
                            fieldAutoIncreCell = sheet.Range[txtFieldAutoIncreColumn.Text + row];
                            if (null != fieldAutoIncreCell)
                            {
                                if( ((string)fieldAutoIncreCell.Text).Length > 0){
                                    fieldAutoIncrement = " AUTO_INCREMENT";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return "******Create Table " + tblName + " error:" + ex.Message;
                        }
                    }
                    if ( (fieldAutoIncrement.Length > 0) && (!primaryKeys.ContainsKey(fieldNameCell.Text)) )  {
                        fieldCommand += fieldAutoIncrement;
                    }

                    //Default Value
                    if (chbFieldDefaultValue.Checked)
                    {
                        try
                        {
                            fieldDefaultValueCell = sheet.Range[txtFieldDefValueColumn.Text + row];
                            if (null != fieldDefaultValueCell)
                            {
                                if (((string)fieldDefaultValueCell.Text).Length > 0)
                                {
                                    fieldCommand += (" DEFAULT " + fieldDefaultValueCell.Text);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return "******Create Table " + tblName + " error:" + ex.Message;
                        }
                    }

                    //Foreign key
                    if (chbFieldForeignKey.Checked)
                    {
                        try
                        {
                            fieldForeignKeyValueCell  = sheet.Range[txtFieldForeignKeyCol.Text + row];
                            if (null != fieldForeignKeyValueCell)
                            {
                                if (((string)fieldForeignKeyValueCell.Text).Length > 0)
                                {
                                    ForeignKeyInfo foreignInfo = new ForeignKeyInfo(fieldNameCell.Text);
                                    try
                                    {
                                        fieldForeignTableValueCell = sheet.Range[txtFieldRefTableNameCol.Text + row];
                                        if(fieldForeignTableValueCell.Text != string.Empty)
                                        {
                                            foreignInfo.ForeignTable = tableNames[fieldForeignTableValueCell.Text];

                                            fieldForeignSourceFieldValueCell = sheet.Range[txtFieldRefSourceFieldCol.Text + row];
                                            if(null!= fieldForeignSourceFieldValueCell)
                                            {
                                                if (fieldForeignSourceFieldValueCell.Text != string.Empty)
                                                {
                                                    foreignInfo.ForeignFieldName = fieldForeignSourceFieldValueCell.Text;
                                                }
                                            }
                                            foreignKeys.Add(fieldNameCell.Text, foreignInfo);
                                        }
                                    }
                                    catch(Exception ex)
                                    {
                                        Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                                        return "******Create Table " + tblName + " error:" + ex.Message;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                            return "******Create Table " + tblName + " error:" + ex.Message;
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
                            return "******Create Table " + tblName + " error:" + ex.Message;
                        }
                    }

                    if(fieldIndex > 0)
                    {
                        query += ("," + Environment.NewLine);
                    }

                    fieldNames.Add(fieldNameCell.Text);
                    fieldTypes.Add(fieldTypeCell.Text);

                    query += fieldCommand;
                    fieldIndex++;
                    row++;
                    fieldNameCell = sheet.Range[txtFieldNameColumn.Text + row];
                    fieldTypeCell = sheet.Range[txtFieldTypeColumn.Text + row];
                }
            }
            catch(Exception ex)
            {
                Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                return "******Create Table " + tblName + " error:" + ex.Message;
            }

            rowEnd = row;

            if (foreignKeys.Count > 0)
            {
                string foreignCommand = string.Empty;
                uint foreignKeyCount = 0;
                foreach(ForeignKeyInfo info in foreignKeys.Values)
                {
                    if (info.ForeignFieldName == string.Empty)
                    {
                        foreignCommand = string.Format("\tFOREIGN KEY ({0}) REFERENCES {1}({2})", info.FieldName, info.ForeignTable, info.FieldName);
                    }
                    else
                    {
                        foreignCommand = string.Format("\tFOREIGN KEY ({0}) REFERENCES {1}({2})", info.FieldName, info.ForeignTable, info.ForeignFieldName);
                    }

                    query += ("," + Environment.NewLine);
                    query += foreignCommand;
                    foreignKeyCount++;
                }
                foreignKeys.Clear();
            }


            query += Environment.NewLine + ") DEFAULT CHARSET=utf8";

            if (tblComment.Length > 0)
            {
                tblComment= tblComment.Replace("%TableName%", tblName);
                tblComment = tblComment.Replace("%TableNameWithPrefix%", tableNames[tblName]);
                query += " COMMENT='" + tblComment + "'";
            }

            query += ";";

            if( (primaryKeys.Count > 0) || (uniqueKeys.Count > 0))
            {
                query += (Environment.NewLine + "ALTER TABLE " + tableNames[tblName] + Environment.NewLine);
                ushort keyCount = 0;
                foreach(string fieldName in primaryKeys.Values)
                {
                    if(keyCount > 0)
                    {
                        query += (","+Environment.NewLine);
                    }

                    keyCount++;
                    query += ("\tADD PRIMARY KEY (" + fieldName + ")");
                }

                foreach(string fieldName in uniqueKeys)
                {
                    if (keyCount > 0)
                    {
                        query += (","+Environment.NewLine);
                    }
                    keyCount++;

                    query += ("\tADD UNIQUE KEY UN_" + tableNames[tblName] + keyCount.ToString() + " (" + fieldName + ")");
                }

                query += ";";
            }

            if (chbDataColumn.Checked)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                List<string> dataTypes = new List<string>();
                int rowStart = int.Parse(txtStartRow.Text);
                Excel.Range dataCell = null;
                string strInsert = string.Empty;
                bool bFirst = false;
                dataCell = sheet.Range[txtDataColumn.Text + rowStart];
                int col = dataCell.Column;
                while (true)
                {
                    values.Clear();
                    dataTypes.Clear();
                    for (row=rowStart;row<rowEnd;row++)
                    {
                        dataCell = sheet.Cells[row, col];
                        if ((dataCell!=null) && (dataCell.Text != string.Empty))
                        {
                            values.Add(fieldNames[row - rowStart], dataCell.Text);
                            dataTypes.Add(fieldTypes[row-rowStart]);
                        }
                    }
                    if (values.Count <= 0)
                        break;

                    strInsert = string.Empty;
                    foreach (string field in values.Keys)
                    {
                        if (strInsert == string.Empty)
                        {
                            strInsert = "INSERT INTO " + tableNames[tblName] + "(" + field;
                        }
                        else
                        {
                            strInsert += ("," + field);
                        }
                    }

                    if (strInsert != string.Empty)
                    {
                        strInsert += ") VALUES(";
                        bFirst = true;
                        row = 0;
                        foreach (string val in values.Values)
                        {
                            if (bFirst)
                            {
                                if ((dataTypes[row] == Constants.MYSQL_DATE) ||
                                    (dataTypes[row] == Constants.MYSQL_DATETIME) ||
                                    (dataTypes[row] == Constants.MYSQL_TIME) ||
                                    (dataTypes[row] == Constants.MYSQL_VARCHAR) ||
                                    (dataTypes[row] == Constants.MYSQL_TEXT))
                                {
                                    strInsert += "'" + val + "'";
                                }
                                else
                                {
                                    strInsert += val;
                                }
                                bFirst = false;
                            }
                            else
                            {
                                if ((dataTypes[row] == Constants.MYSQL_DATE) ||
                                    (dataTypes[row] == Constants.MYSQL_DATETIME) ||
                                    (dataTypes[row] == Constants.MYSQL_TIME) ||
                                    (dataTypes[row] == Constants.MYSQL_VARCHAR) ||
                                    (dataTypes[row] == Constants.MYSQL_TEXT))
                                {
                                    strInsert += ("," + "'" + val + "'");
                                }
                                else
                                {
                                    strInsert += ("," + val);
                                }
                            }
                            row++;
                        }

                        strInsert += ");";
                    }

                    if(strInsert !=string.Empty)
                    {
                        query += Environment.NewLine + strInsert;
                    }

                    col++;
                }
            }

            return query;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Logger.Instance.Reset();
            frmScriptEditor frm = new frmScriptEditor();
            frm.Tables.Clear();
            Dictionary<string, string> tableNames = new Dictionary<string, string>();
            if (radAllSheets.Checked)
            {
                bool excluded = false;
                foreach(Excel.Worksheet sheet in Book.Sheets)
                {
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
                        catch (Exception ex)
                        {
                            Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                        }
                    }
                    tableNames.Add(tblName, (chbPrefixTableName.Checked ? txtPrefixTableName.Text : string.Empty) + tblName);
                }

                foreach (Excel.Worksheet sheet in Book.Sheets)
                {
                    excluded = false;
                    foreach(string item in lstExcludeSheets.SelectedItems)
                    {
                        if(string.Compare(item, sheet.Name, true) == 0)
                        {
                            excluded = true;
                            break;
                        }
                    }
                    if (!excluded)
                    {
                        frm.Script += CreateTable(sheet, ref tableNames) + Environment.NewLine;
                        frm.Tables.Add(sheet.Name);
                    }
                }
            }
            else if (radCurrentSheet.Checked)
            {
                Excel.Worksheet curSheet = Book.ActiveSheet;
                string tblName = string.Empty;

                if (radTableNameFromSheetName.Checked)
                {
                    tblName = curSheet.Name;
                }
                else if (radTableNameFromCell.Checked)
                {
                    try
                    {
                        Excel.Range tblNameCell = curSheet.Range[txtTableNameCellColumn.Text + txtTableNameCellRow.Text];
                        if (null != tblNameCell)
                        {
                            tblName = tblNameCell.Text;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                    }
                }
                tableNames.Add(tblName, (chbPrefixTableName.Checked ? txtPrefixTableName.Text : string.Empty) + tblName);

                frm.Script += CreateTable(curSheet, ref tableNames);
                frm.Tables.Add(curSheet.Name);
            }
            else
            {
                int selectedSheetIndex = cbSheets.SelectedIndex;
                if (selectedSheetIndex == -1)
                {
                    MessageBox.Show(Constants.GetResourceString(Constants.MSG_NO_SHEET_SPECIFIED), Constants.GetResourceString(Constants.STR_WARNING), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSheets.Focus();
                    return;
                }
                string sheetName = cbSheets.Items[selectedSheetIndex].ToString();
                Excel.Worksheet  selectedSheet = Book.Sheets[sheetName];
                if (null == selectedSheet)
                {
                    MessageBox.Show(Constants.GetResourceString(Constants.MSG_SHEET_CANNOT_FOUND), Constants.GetResourceString(Constants.STR_WARNING), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSheets.Focus();
                    return;
                }

                string tblName = string.Empty;

                if (radTableNameFromSheetName.Checked)
                {
                    tblName = selectedSheet.Name;
                }
                else if (radTableNameFromCell.Checked)
                {
                    try
                    {
                        Excel.Range tblNameCell = selectedSheet.Range[txtTableNameCellColumn.Text + txtTableNameCellRow.Text];
                        if (null != tblNameCell)
                        {
                            tblName = tblNameCell.Text;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Instance.Write(LogInfo.LogType.ERROR, ex.Message);
                    }
                }
                tableNames.Add(tblName, (chbPrefixTableName.Checked ? txtPrefixTableName.Text : string.Empty) + tblName);


                frm.Script += CreateTable(selectedSheet, ref tableNames);
                frm.Tables.Add(sheetName);
            }

            frm.ShowDialog();
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

        private void chbFieldSize_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldSizeColumn.Enabled = chbFieldSize.Checked;
        }

        private void chbFieldAttribute_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldAttributeColumn.Enabled = chbFieldAttribute.Checked;
        }

        private void chbFieldNullable_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldNullableColumn.Enabled = chbFieldNullable.Checked;
        }

        private void chbFieldPrimary_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldPrimaryColumn.Enabled = chbFieldPrimary.Checked;
        }

        private void chbFieldUnique_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldUniqueColumn.Enabled = chbFieldUnique.Checked;
        }

        private void chbFieldAutoIncre_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldAutoIncreColumn.Enabled = chbFieldAutoIncre.Checked;
        }

        private void chbFieldDefaultValue_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldDefValueColumn.Enabled = chbFieldDefaultValue.Checked;
        }

        private void chbFieldRemark_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldRemarkColumn.Enabled = chbFieldRemark.Checked;
        }

        private void chbFieldForeignKey_CheckedChanged(object sender, EventArgs e)
        {
            txtFieldRefTableNameCol.Enabled = txtFieldRefSourceFieldCol.Enabled = txtFieldForeignKeyCol.Enabled = chbFieldForeignKey.Checked;
        }

        private void chbDataCloumn_CheckedChanged(object sender, EventArgs e)
        {
            txtDataColumn.Enabled = chbDataColumn.Checked;
        }

        private void chbAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            chbFieldSize.Checked =
            chbFieldAttribute.Checked =
            chbFieldNullable.Checked =
            chbFieldPrimary.Checked =
            chbFieldUnique.Checked =
            chbFieldAutoIncre.Checked =
            chbFieldDefaultValue.Checked =
            chbFieldRemark.Checked =
            chbFieldForeignKey.Checked =
            chbDataColumn.Checked = 
            chbAllCheckbox.Checked;
        }

        private void chbPrefixTableName_CheckedChanged(object sender, EventArgs e)
        {
            txtPrefixTableName.Enabled = chbPrefixTableName.Checked;
        }

        private void radTableCommentFromText_CheckedChanged(object sender, EventArgs e)
        {
            cbbMacros.Enabled = btnInsertMacro.Enabled = radTableCommentFromText.Checked;
        }

        private void radTableCommentFromCellText_CheckedChanged(object sender, EventArgs e)
        {
            cbbMacros.Enabled = btnInsertMacro.Enabled = radTableCommentFromText.Checked;
        }

        private void btnInsertMacro_Click(object sender, EventArgs e)
        {
            int nSel = cbbMacros.SelectedIndex;
            if(nSel==-1)
            {
                MessageBox.Show(Constants.GetResourceString(Constants.MSG_PLEASE_CHOOSE_A_MACRO_TO_INSERT), Constants.GetResourceString(Constants.STR_APPNAME), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMacros.Focus();
                return;
            }

            string strMacro = cbbMacros.Items[nSel] as string;
            txtTableComment.Paste(strMacro);
        }

        private void txtTableComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            radTableCommentFromText.Checked = true;
        }
    }
}
