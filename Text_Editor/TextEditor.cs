using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

//ToDO: On page 18 ToolBar align Left is the next point

namespace Text_Editor
{
    public partial class TextEditor : Form
    {
        private int tableCount = 0;
        private int currentColumnCount = 0;

        public TextEditor()
        {
            InitializeComponent();
        }

        #region Editor and General

        private void TextEditor_Load(object sender, EventArgs e)
        {
            FontSize();
            InstalledFonts();
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            charCount.Text = "Characters in the current document: " + Document.TextLength.ToString();

            status_ZoomFactor.Text = Document.ZoomFactor.ToString();
        }

        private void Document_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        #endregion

        #region MainMenu

        // File

        private void file_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void file_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void file_Exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        // Edit

        private void edit_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void edit_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void edit_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void edit_SelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        // Tools

        private void tools_Customise_Click(object sender, EventArgs e)
        {
            customise();
        }

        #endregion

        #region Toolbar

        // Main function like Copy Paste New Document etc.
        private void tb_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tb_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tb_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        // Adding Image Click

        private void tb_AddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load the image from file, then copy the image to clipboard
                    Clipboard.SetImage(Image.FromFile(ofd.FileName));

                    // Paste the image into the RichTextBox
                    Document.Paste();
                }
            }
        }

        #region toolbar Text Options

        private void tb_Bold_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            Font currentFont = Document.SelectionFont;

            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;
            Document.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void tb_Italic_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            Font currentFont = Document.SelectionFont;

            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
            Document.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void tb_UnderLine_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            Font currentFont = Document.SelectionFont;

            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;
            Document.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void tb_Strike_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            Font currentFont = Document.SelectionFont;

            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Strikeout;
            Document.SelectionFont = new Font(currentFont, newFontStyle);
        }

        // Color change Click

        private void tb_TextColor_Click(object sender, EventArgs e)
        {
            if (Document.SelectionColor != Color.Black)
            {
                Document.SelectionColor = Color.Black;
            }
            else
            {
                Document.SelectionColor = tb_TextColor.ForeColor;
            }
        }

        private void tb_TextColor_DropDownOpening(object sender, EventArgs e)
        {
            colorChange();
        }

        #endregion

        #region tb_Aligning Text

        // Align Left, right and middle functions
        private void tb_AlignLeft_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tb_AlignCenter_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tb_AlignRight_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Right;
        }

        #endregion

        #region tb_Upper Text
        // upper Case and lower Case Click Functions

        private void tb_UpperCase_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            // Store the original selection start and length
            int selectionStart = Document.SelectionStart;
            int selectionLength = Document.SelectionLength;

            // Loop through the selected text
            for (int i = selectionStart; i < selectionStart + selectionLength; i++)
            {
                // Get the character at the current position
                char character = Document.Text[i];
                // Convert it to uppercase
                char upperChar = char.ToUpper(character);

                // Preserve the character formatting
                Document.Select(i, 1); // Select the character
                Document.SelectedText = upperChar.ToString(); // Replace it with uppercase character
            }

            // Restore original selection
            Document.Select(selectionStart, selectionLength);
        }

        private void tb_LowerCase_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            int selectionStart = Document.SelectionStart;
            int selectionLength = Document.SelectionLength;

            for (int i = selectionStart; i < selectionStart + selectionLength; i++)
            {
                char character = Document.Text[i];
                char lowerChar = char.ToLower(character);

                Document.Select(i, 1);
                Document.SelectedText = lowerChar.ToString();
            }

            Document.Select(selectionStart, selectionLength);
        }

        #endregion

        #region toolbar Zoom

        private void tb_ZoomIn_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 63)
            {
                return;
            }
            else
            {
                Document.ZoomFactor = Document.ZoomFactor + 1;
            }
        }

        private void tb_ZoomOut_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 1)
            {
                return;
            }
            else
            {
                Document.ZoomFactor = Document.ZoomFactor - 1;
            }
        }

        #endregion

        #region toolbar Fonts

        private void tb_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Font ComboFonts = null;

            try
            {
                ComboFonts = Document.SelectionFont;
                Document.SelectionFont = new System.Drawing.Font(tb_Font.Text, Document.SelectionFont.Size, Document.SelectionFont.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Document.SelectionFont = new Font(tb_FontSize.SelectedItem.ToString(), int.Parse(tb_FontSize.SelectedItem.ToString()), Document.SelectionFont.Style);
        }

        #endregion

        #region Table

        private void tb_AddTable_Click(object sender, EventArgs e)
        {
            AddTable();
        }

        private void tb_AddColumn_Click(object sender, EventArgs e)
        {
            AddColumnToLastTable();
        }

        private void tb_DeleteColumn_Click(object sender, EventArgs e)
        {
            DeleteColumnFromLastTable();
        }

        #endregion

        #endregion

        #region contextmenu

        private void rc_Undo_Click(Object sender, EventArgs e)
        {
            Undo();
        }

        private void rc_Redo_Click(Object sender, EventArgs e)
        {
            Redo();
        }

        private void rc_Cut_Click(Object sender, EventArgs e)
        {
            Cut();
        }

        private void rc_Copy_Click(Object sender, EventArgs e)
        {
            Copy();
        }

        private void rc_Paste_Click(Object sender, EventArgs e)
        {
            Paste();
        }

        #endregion

        #region Methods

        #region file

        void New()
        {
            Document.Clear();
        }

        void Open()
        {
            if (openWork.ShowDialog() == DialogResult.OK)
            {
                Document.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        void Save()
        {
            if (saveWork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Exit()
        {
            Application.Exit();
        }

        #endregion

        #region edit

        void Undo()
        {
            Document.Undo();
        }

        void Redo()
        {
            Document.Redo();
        }

        void Cut()
        {
            Document.Cut();
        }

        void Copy()
        {
            Document.Copy();
        }

        void Paste()
        {
            Document.Paste();
        }

        void SelectAll()
        {
            Document.SelectAll();
        }

        void ClearAll()
        {
            Document.Clear();
        }

        #endregion

        #region tools

        void customise()
        {
            ColorDialog myDialog = new ColorDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                mainMenu.BackColor = myDialog.Color;
                Status.BackColor = myDialog.Color;
                Tools.BackColor = myDialog.Color;
            }
        }

        void colorChange()
        {
            ColorDialog myDialog = new ColorDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                Document.SelectionColor = myDialog.Color;
                tb_TextColor.ForeColor = myDialog.Color;
            }
        }

        #endregion

        #region table

        void AddTable()
        {
            tableCount++;
            Document.AppendText($"Table {tableCount}:\n");

            // Add headers
            for (int i = 1; i <= currentColumnCount; i++)
            {
                Document.AppendText($"Column {i}\t");
            }
            Document.AppendText("\n");

            // Add a separator
            for (int i = 0; i < currentColumnCount; i++)
            {
                Document.AppendText("---------\t");
            }
            Document.AppendText("\n");

            // Add an empty row
            for (int i = 1; i <= currentColumnCount; i++)
            {
                Document.AppendText("\t"); // Empty cell
            }
            Document.AppendText("\n\n"); // Extra line for spacing
        }

        void AddColumnToLastTable()
        {
            if (tableCount > 0)
            {
                currentColumnCount++;
                // Update the last table's header
                Document.AppendText($"Column {currentColumnCount}\t");
                Document.AppendText("\n");

                // Add a new separator
                for (int i = 0; i < currentColumnCount; i++)
                {
                    Document.AppendText("---------\t");
                }
                Document.AppendText("\n");

                // Add an empty row
                for (int i = 1; i <= currentColumnCount; i++)
                {
                    Document.AppendText("\t"); // Empty cell
                }
                Document.AppendText("\n\n"); // Extra line for spacing
            }
            else
            {
                MessageBox.Show("No table exists to add a column.");
            }
        }

        void DeleteColumnFromLastTable()
        {
            if (tableCount > 0 && currentColumnCount > 0)
            {
                currentColumnCount--;

                // Update the last table's header
                Document.AppendText($"Column {currentColumnCount + 1} removed.\n");
                Document.AppendText("\n");

                // Add a new separator
                for (int i = 0; i < currentColumnCount; i++)
                {
                    Document.AppendText("---------\t");
                }
                Document.AppendText("\n");

                // Add an empty row
                for (int i = 1; i <= currentColumnCount; i++)
                {
                    Document.AppendText("\t"); // Empty cell
                }
                Document.AppendText("\n\n"); // Extra line for spacing
            }
            else
            {
                MessageBox.Show("No columns to delete in the last table.");
            }
        }

        #endregion

        #endregion

        // FontSize function for changing the size of the font

        void FontSize()
        {
            for (int fntSize = 10; fntSize <= 75; fntSize++)
            {
                tb_FontSize.Items.Add(fntSize.ToString());
            }
        }

        // Function to get the installed Fonts

        void InstalledFonts()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            for (int i = 0; i < fonts.Families.Length; i++)
            {
                tb_Font.Items.Add(fonts.Families[i].Name);
            }
        }
    }
}
