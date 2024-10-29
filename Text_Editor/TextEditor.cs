using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

//ToDO: On page 18 ToolBar align Left is the next point

namespace Text_Editor
{
    public partial class TextEditor : Form
    {
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

        // Writing Options like Bold italic etc.

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
            Document.SelectionFont= new Font(currentFont, newFontStyle);
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

        // upper Case and lower Case Click Functions

        private void tb_UpperCase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.Text.ToUpper();
        }

        private void tb_LowerCase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToLower();
        }

        //Zoom clicks 

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

        // Font Size and Fonts

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
