using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDict
{
    public partial class WordEditor : UserControl
    {
        private EditorModes _mode = EditorModes.None;
        public delegate void ModeChangedEventHandler(WordEditorModeChangeArgs Args);
        public event ModeChangedEventHandler ModeChanged;
        public event EventHandler OnAddVocabulary;
        public event EventHandler OnEdit;
        public event EventHandler OnSave;
        public event EventHandler OnClose;
        public event EventHandler OnAddClass;
        public event EventHandler OnAddDesc;


        public EditorModes Mode
        {
            get { return _mode; }
            set
            {
                if (_mode != value)
                {
                    EditorModes old = _mode;
                    _mode = value;
                    ModeChanged?.Invoke(new WordEditorModeChangeArgs(old, _mode));
                }
            }
        }
        public WordEditor()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OnAddVocabulary?.Invoke(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEdit?.Invoke(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke(sender, e);
        }

        private void WordEditor_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("KeyDown");
        }

        private void WordEditor_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                switch (Mode)
                {
                    case EditorModes.AddNew:
                        btnAddNew.Focus();
                        break;
                    case EditorModes.Edit:
                        btnEdit.Focus();
                        break;
                    default:
                        btnClose.Focus();
                        break;
                }
            }
        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            OnAddClass?.Invoke(sender, e);
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDesc_Click(object sender, EventArgs e)
        {
            OnAddDesc?.Invoke(sender, e);
        }
    }

    public enum EditorModes { None = 0, Edit, AddNew }

    public partial class WordEditorModeChangeArgs : EventArgs
    {
        private EditorModes _modeOld = EditorModes.None;
        private EditorModes _modeNew = EditorModes.None;

        public EditorModes OldMode
        {
            get { return _modeOld; }
        }
        public EditorModes NewMode
        {
            get { return _modeNew; }
        }
        public WordEditorModeChangeArgs(EditorModes oldMode, EditorModes newMode)
        {
            _modeOld = oldMode;
            _modeNew = newMode;
        }
    }
}
