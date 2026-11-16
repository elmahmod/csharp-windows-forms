
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Menus
{
    public partial class frmMiniNotepad : Form
    {
        public frmMiniNotepad()
        {
            InitializeComponent();
            UpdateTitle();
            UpdateCharCount();
        }

        string currentFilePath = "";

        // Methods

        void ChangeTextFont(Font newFont)
        {
            rtbEditor.SelectionFont = newFont;
        }

        void SaveDocuments()
        {
            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rtbEditor.Text);

                currentFilePath = saveFileDialog1.FileName;

                UpdateTitle();
            }
        }

        void SaveCurrentDocument()
        {
            if (string.IsNullOrWhiteSpace(currentFilePath))
            {
                SaveDocuments();
            }
            else
            {
                File.WriteAllText(currentFilePath, rtbEditor.Text);
            }
        }

        void UpdateTitle()
        {
            if (string.IsNullOrWhiteSpace(currentFilePath))
                this.Text = "Untitled - Mini Notepad";
            else
                this.Text = Path.GetFileName(currentFilePath) + " - Mini Notepad";
        }
        void UpdateCharCount()
        {
            if (rtbEditor.SelectionLength > 0)
            {
                lblCharCount.Text =
                    $"{rtbEditor.SelectionLength} of {rtbEditor.Text.Length} Characters";
            }
            else
            {
                lblCharCount.Text = $"{rtbEditor.Text.Length} Characters";
            }
        }

        // File Menu

        private void mnuNew_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            currentFilePath = "";
            UpdateTitle();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog1.FileName);

                rtbEditor.Text = content;
                currentFilePath = openFileDialog1.FileName;

                UpdateTitle();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveCurrentDocument();
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveDocuments();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to save before closing?",
                "Mini Notepad",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                SaveCurrentDocument();
            }

            this.Close();
        }

        // Edit Menu

        private void mnuCut_Click(object sender, EventArgs e)
        {
            rtbEditor.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            rtbEditor.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            rtbEditor.Paste();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }

        // Format Menu

        private void mnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = rtbEditor.SelectionFont ?? rtbEditor.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ChangeTextFont(fontDialog1.Font);
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            ChangeTextFont(fontDialog1.Font);
        }

        private void mnuTextColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = rtbEditor.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SelectionColor = colorDialog1.Color;
            }
        }

        // View Menu

        private void mnuWrap_Click(object sender, EventArgs e)
        {
            rtbEditor.WordWrap = mnuWrap.Checked;
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            UpdateCharCount();
        }

        private void rtbEditor_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCharCount();
        }
    }
}
