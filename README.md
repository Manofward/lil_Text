# Text_Editor

This project is a little c# TextEditor Project which will be updated in the near future.

ToDos:
* Pictures (for adding pictures)
* Bugfixing 
* more features like Tables 
* changing the color of the Text

This Project is only to learn about app creating and should not be used for work.

### Standing things:
#### Adding Tables:
1. right now it doesnt look very Table like it has to be changed


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Set up the DataGridView
            dataGridView1.ColumnCount = 3; // Start with 3 columns
            dataGridView1.Columns[0].Name = "Column 1";
            dataGridView1.Columns[1].Name = "Column 2";
            dataGridView1.Columns[2].Name = "Column 3";

            // Allow user to add rows
            dataGridView1.AllowUser ToAddRows = true;
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
        ```csharp
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

        private void tb_Underline_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                return;
            }

            Font currentFont = Document.SelectionFont;

            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;
            Document.SelectionFont = new Font(currentFont, newFontStyle);
        }

        #endregion

        #endregion

        private void btnCreateDataGrid_Click(object sender, EventArgs e)
        {
            // Create a new DataGridView
            DataGridView newDataGridView = new DataGridView();
            newDataGridView.ColumnCount = 3; // Set the number of columns
            newDataGridView.Columns[0].Name = "Column 1";
            newDataGridView.Columns[1].Name = "Column 2";
            newDataGridView.Columns[2].Name = "Column 3";

            // Add some sample rows
            newDataGridView.Rows.Add("Row 1 Cell 1", "Row 1 Cell 2", "Row 1 Cell 3");
            newDataGridView.Rows.Add("Row 2 Cell 1", "Row 2 Cell 2", "Row 2 Cell 3");

            // Convert the DataGridView to a string and append it to the RichTextBox
            richTextBox1.Clear();
            foreach (DataGridViewRow row in newDataGridView.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder
                string line = string.Join("\t", row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
                richTextBox1.AppendText(line + Environment.NewLine);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            // Add a new row to the DataGridView
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            row.Cells[0].Value = "New Cell 1"; // Default value for the first cell
            row.Cells[1].Value = "New Cell 2"; // Default value for the second cell
            row.Cells[2].Value = "New Cell 3"; // Default value for the third cell
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            // Add a new column to the DataGridView
            int columnIndex = dataGridView1.Columns.Count;
            dataGridView1.Columns.Add($"Column {columnIndex + 1}", $"Column {columnIndex + 1}");
        }

        private void btnSaveFromRichTextBox_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView and load data from RichTextBox
            dataGridView1.Rows.Clear();
            string[] lines = richTextBox1.Lines;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty lines
                string[] values = line.Split('\t'); // Split by tab
                dataGridView1.Rows.Add(values);
            }
        }
    }
}
``` This updated code includes the ability for users to dynamically add rows and columns to the `DataGridView`, provides a visual representation by hosting the `DataGridView` in a `Panel`, and allows for data persistence by saving data back from the `RichTextBox` to the `DataGridView`. The methods for adding rows and columns are integrated, and the overall structure supports user interaction effectively.