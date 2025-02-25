namespace Text_Editor
{
    partial class TextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            mainMenu = new MenuStrip();
            mM_File = new ToolStripMenuItem();
            file_New = new ToolStripMenuItem();
            file_Open = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            file_Save = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            file_Exit = new ToolStripMenuItem();
            mM_Edit = new ToolStripMenuItem();
            edit_Undo = new ToolStripMenuItem();
            edit_Redo = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            edit_Cut = new ToolStripMenuItem();
            edit_Copy = new ToolStripMenuItem();
            edit_Paste = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            edit_SelectAll = new ToolStripMenuItem();
            mM_Tools = new ToolStripMenuItem();
            tools_Customisation = new ToolStripMenuItem();
            Tools = new ToolStrip();
            tb_New = new ToolStripButton();
            tb_Open = new ToolStripButton();
            tb_Save = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tb_Cut = new ToolStripButton();
            tb_Copy = new ToolStripButton();
            tb_Paste = new ToolStripButton();
            tb_AddImage = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            tb_Bold = new ToolStripButton();
            tb_Italic = new ToolStripButton();
            tb_UnderLine = new ToolStripButton();
            tb_Strike = new ToolStripButton();
            tb_TextColor = new ToolStripSplitButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tb_AlignLeft = new ToolStripButton();
            tb_AlignCenter = new ToolStripButton();
            tb_AlignRight = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            tb_UpperCase = new ToolStripButton();
            tb_LowerCase = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            tb_ZoomIn = new ToolStripButton();
            tb_ZoomOut = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            tb_Font = new ToolStripComboBox();
            tb_FontSize = new ToolStripComboBox();
            Status = new StatusStrip();
            charCount = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            status_ZoomFactor = new ToolStripStatusLabel();
            Document = new RichTextBox();
            rcMenu = new ContextMenuStrip(components);
            rc_Undo = new ToolStripMenuItem();
            rc_Redo = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            rc_Cut = new ToolStripMenuItem();
            rc_Copy = new ToolStripMenuItem();
            rc_Paste = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            openWork = new OpenFileDialog();
            saveWork = new SaveFileDialog();
            mainMenu.SuspendLayout();
            Tools.SuspendLayout();
            Status.SuspendLayout();
            rcMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { mM_File, mM_Edit, mM_Tools });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1209, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // mM_File
            // 
            mM_File.DropDownItems.AddRange(new ToolStripItem[] { file_New, file_Open, toolStripSeparator, file_Save, toolStripSeparator1, file_Exit });
            mM_File.Name = "mM_File";
            mM_File.Size = new Size(37, 20);
            mM_File.Text = "&File";
            // 
            // file_New
            // 
            file_New.Image = (Image)resources.GetObject("file_New.Image");
            file_New.ImageTransparentColor = Color.Magenta;
            file_New.Name = "file_New";
            file_New.ShortcutKeys = Keys.Control | Keys.N;
            file_New.Size = new Size(148, 22);
            file_New.Text = "&New";
            file_New.Click += file_New_Click;
            // 
            // file_Open
            // 
            file_Open.Image = (Image)resources.GetObject("file_Open.Image");
            file_Open.ImageTransparentColor = Color.Magenta;
            file_Open.Name = "file_Open";
            file_Open.ShortcutKeys = Keys.Control | Keys.O;
            file_Open.Size = new Size(148, 22);
            file_Open.Text = "&Open";
            file_Open.Click += file_Open_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(145, 6);
            // 
            // file_Save
            // 
            file_Save.Image = (Image)resources.GetObject("file_Save.Image");
            file_Save.ImageTransparentColor = Color.Magenta;
            file_Save.Name = "file_Save";
            file_Save.ShortcutKeys = Keys.Control | Keys.S;
            file_Save.Size = new Size(148, 22);
            file_Save.Text = "&Save";
            file_Save.Click += file_Save_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(145, 6);
            // 
            // file_Exit
            // 
            file_Exit.Name = "file_Exit";
            file_Exit.Size = new Size(148, 22);
            file_Exit.Text = "E&xit";
            file_Exit.Click += file_Exit_Click;
            // 
            // mM_Edit
            // 
            mM_Edit.DropDownItems.AddRange(new ToolStripItem[] { edit_Undo, edit_Redo, toolStripSeparator3, edit_Cut, edit_Copy, edit_Paste, toolStripSeparator4, edit_SelectAll });
            mM_Edit.Name = "mM_Edit";
            mM_Edit.Size = new Size(39, 20);
            mM_Edit.Text = "&Edit";
            // 
            // edit_Undo
            // 
            edit_Undo.Name = "edit_Undo";
            edit_Undo.ShortcutKeys = Keys.Control | Keys.Z;
            edit_Undo.Size = new Size(146, 22);
            edit_Undo.Text = "&Undo";
            edit_Undo.Click += edit_Undo_Click;
            // 
            // edit_Redo
            // 
            edit_Redo.Name = "edit_Redo";
            edit_Redo.ShortcutKeys = Keys.Control | Keys.Y;
            edit_Redo.Size = new Size(146, 22);
            edit_Redo.Text = "&Redo";
            edit_Redo.Click += edit_Redo_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(143, 6);
            // 
            // edit_Cut
            // 
            edit_Cut.Image = (Image)resources.GetObject("edit_Cut.Image");
            edit_Cut.ImageTransparentColor = Color.Magenta;
            edit_Cut.Name = "edit_Cut";
            edit_Cut.ShortcutKeys = Keys.Control | Keys.X;
            edit_Cut.Size = new Size(146, 22);
            edit_Cut.Text = "Cu&t";
            edit_Cut.Click += edit_Cut_Click;
            // 
            // edit_Copy
            // 
            edit_Copy.Image = (Image)resources.GetObject("edit_Copy.Image");
            edit_Copy.ImageTransparentColor = Color.Magenta;
            edit_Copy.Name = "edit_Copy";
            edit_Copy.ShortcutKeys = Keys.Control | Keys.C;
            edit_Copy.Size = new Size(146, 22);
            edit_Copy.Text = "&Copy";
            edit_Copy.Click += edit_Copy_Click;
            // 
            // edit_Paste
            // 
            edit_Paste.Image = (Image)resources.GetObject("edit_Paste.Image");
            edit_Paste.ImageTransparentColor = Color.Magenta;
            edit_Paste.Name = "edit_Paste";
            edit_Paste.ShortcutKeys = Keys.Control | Keys.V;
            edit_Paste.Size = new Size(146, 22);
            edit_Paste.Text = "&Paste";
            edit_Paste.Click += edit_Paste_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(143, 6);
            // 
            // edit_SelectAll
            // 
            edit_SelectAll.Name = "edit_SelectAll";
            edit_SelectAll.Size = new Size(146, 22);
            edit_SelectAll.Text = "Select &All";
            edit_SelectAll.Click += edit_SelectAll_Click;
            // 
            // mM_Tools
            // 
            mM_Tools.DropDownItems.AddRange(new ToolStripItem[] { tools_Customisation });
            mM_Tools.Name = "mM_Tools";
            mM_Tools.Size = new Size(47, 20);
            mM_Tools.Text = "&Tools";
            // 
            // tools_Customisation
            // 
            tools_Customisation.Name = "tools_Customisation";
            tools_Customisation.Size = new Size(130, 22);
            tools_Customisation.Text = "&Customize";
            tools_Customisation.Click += tools_Customise_Click;
            // 
            // Tools
            // 
            Tools.ImageScalingSize = new Size(20, 20);
            Tools.Items.AddRange(new ToolStripItem[] { tb_New, tb_Open, tb_Save, toolStripSeparator6, tb_Cut, tb_Copy, tb_Paste, tb_AddImage, toolStripSeparator7, tb_Bold, tb_Italic, tb_UnderLine, tb_Strike, tb_TextColor, toolStripSeparator2, tb_AlignLeft, tb_AlignCenter, tb_AlignRight, toolStripSeparator5, tb_UpperCase, tb_LowerCase, toolStripSeparator8, tb_ZoomIn, tb_ZoomOut, toolStripSeparator9, tb_Font, tb_FontSize });
            Tools.Location = new Point(0, 24);
            Tools.Name = "Tools";
            Tools.Size = new Size(1209, 27);
            Tools.TabIndex = 1;
            Tools.Text = "toolStrip1";
            // 
            // tb_New
            // 
            tb_New.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_New.Image = (Image)resources.GetObject("tb_New.Image");
            tb_New.ImageTransparentColor = Color.Magenta;
            tb_New.Name = "tb_New";
            tb_New.Size = new Size(24, 24);
            tb_New.Text = "&New";
            tb_New.Click += tb_New_Click;
            // 
            // tb_Open
            // 
            tb_Open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_Open.Image = (Image)resources.GetObject("tb_Open.Image");
            tb_Open.ImageTransparentColor = Color.Magenta;
            tb_Open.Name = "tb_Open";
            tb_Open.Size = new Size(24, 24);
            tb_Open.Text = "&Open";
            tb_Open.Click += tb_Open_Click;
            // 
            // tb_Save
            // 
            tb_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_Save.Image = (Image)resources.GetObject("tb_Save.Image");
            tb_Save.ImageTransparentColor = Color.Magenta;
            tb_Save.Name = "tb_Save";
            tb_Save.Size = new Size(24, 24);
            tb_Save.Text = "&Save";
            tb_Save.Click += tb_Save_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // tb_Cut
            // 
            tb_Cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_Cut.Image = (Image)resources.GetObject("tb_Cut.Image");
            tb_Cut.ImageTransparentColor = Color.Magenta;
            tb_Cut.Name = "tb_Cut";
            tb_Cut.Size = new Size(24, 24);
            tb_Cut.Text = "C&ut";
            tb_Cut.Click += tb_Cut_Click;
            // 
            // tb_Copy
            // 
            tb_Copy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_Copy.Image = (Image)resources.GetObject("tb_Copy.Image");
            tb_Copy.ImageTransparentColor = Color.Magenta;
            tb_Copy.Name = "tb_Copy";
            tb_Copy.Size = new Size(24, 24);
            tb_Copy.Text = "&Copy";
            tb_Copy.Click += tb_Copy_Click;
            // 
            // tb_Paste
            // 
            tb_Paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_Paste.Image = (Image)resources.GetObject("tb_Paste.Image");
            tb_Paste.ImageTransparentColor = Color.Magenta;
            tb_Paste.Name = "tb_Paste";
            tb_Paste.Size = new Size(24, 24);
            tb_Paste.Text = "&Paste";
            tb_Paste.Click += tb_Paste_Click;
            // 
            // tb_AddImage
            // 
            tb_AddImage.CheckOnClick = true;
            tb_AddImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tb_AddImage.Image = (Image)resources.GetObject("tb_AddImage.Image");
            tb_AddImage.ImageTransparentColor = Color.Magenta;
            tb_AddImage.Name = "tb_AddImage";
            tb_AddImage.Size = new Size(24, 24);
            tb_AddImage.Text = "Add Image";
            tb_AddImage.Click += tb_AddImage_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 27);
            // 
            // tb_Bold
            // 
            tb_Bold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_Bold.Image = (Image)resources.GetObject("tb_Bold.Image");
            tb_Bold.ImageTransparentColor = Color.Magenta;
            tb_Bold.Name = "tb_Bold";
            tb_Bold.Size = new Size(23, 24);
            tb_Bold.Text = "B";
            tb_Bold.Click += tb_Bold_Click;
            // 
            // tb_Italic
            // 
            tb_Italic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_Italic.Image = (Image)resources.GetObject("tb_Italic.Image");
            tb_Italic.ImageTransparentColor = Color.Magenta;
            tb_Italic.Name = "tb_Italic";
            tb_Italic.Size = new Size(23, 24);
            tb_Italic.Text = "/";
            tb_Italic.Click += tb_Italic_Click;
            // 
            // tb_UnderLine
            // 
            tb_UnderLine.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_UnderLine.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            tb_UnderLine.Image = (Image)resources.GetObject("tb_UnderLine.Image");
            tb_UnderLine.ImageTransparentColor = Color.Magenta;
            tb_UnderLine.Name = "tb_UnderLine";
            tb_UnderLine.Size = new Size(23, 24);
            tb_UnderLine.Text = "U";
            tb_UnderLine.Click += tb_UnderLine_Click;
            // 
            // tb_Strike
            // 
            tb_Strike.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_Strike.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            tb_Strike.Image = (Image)resources.GetObject("tb_Strike.Image");
            tb_Strike.ImageTransparentColor = Color.Magenta;
            tb_Strike.Name = "tb_Strike";
            tb_Strike.Size = new Size(23, 24);
            tb_Strike.Text = "S";
            tb_Strike.Click += tb_Strike_Click;
            // 
            // tb_TextColor
            // 
            tb_TextColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_TextColor.ForeColor = Color.Red;
            tb_TextColor.Image = (Image)resources.GetObject("tb_TextColor.Image");
            tb_TextColor.ImageTransparentColor = Color.Magenta;
            tb_TextColor.Name = "tb_TextColor";
            tb_TextColor.Size = new Size(44, 24);
            tb_TextColor.Text = "Abc";
            tb_TextColor.ToolTipText = "Text Color";
            tb_TextColor.ButtonClick += tb_TextColor_Click;
            tb_TextColor.DropDownOpening += tb_TextColor_DropDownOpening;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // tb_AlignLeft
            // 
            tb_AlignLeft.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_AlignLeft.Image = (Image)resources.GetObject("tb_AlignLeft.Image");
            tb_AlignLeft.ImageTransparentColor = Color.Magenta;
            tb_AlignLeft.Name = "tb_AlignLeft";
            tb_AlignLeft.Size = new Size(23, 24);
            tb_AlignLeft.Text = "L";
            tb_AlignLeft.Click += tb_AlignLeft_Click;
            // 
            // tb_AlignCenter
            // 
            tb_AlignCenter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_AlignCenter.Image = (Image)resources.GetObject("tb_AlignCenter.Image");
            tb_AlignCenter.ImageTransparentColor = Color.Magenta;
            tb_AlignCenter.Name = "tb_AlignCenter";
            tb_AlignCenter.Size = new Size(23, 24);
            tb_AlignCenter.Text = "C";
            tb_AlignCenter.Click += tb_AlignCenter_Click;
            // 
            // tb_AlignRight
            // 
            tb_AlignRight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_AlignRight.Image = (Image)resources.GetObject("tb_AlignRight.Image");
            tb_AlignRight.ImageTransparentColor = Color.Magenta;
            tb_AlignRight.Name = "tb_AlignRight";
            tb_AlignRight.Size = new Size(23, 24);
            tb_AlignRight.Text = "R";
            tb_AlignRight.Click += tb_AlignRight_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // tb_UpperCase
            // 
            tb_UpperCase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_UpperCase.Image = (Image)resources.GetObject("tb_UpperCase.Image");
            tb_UpperCase.ImageTransparentColor = Color.Magenta;
            tb_UpperCase.Name = "tb_UpperCase";
            tb_UpperCase.Size = new Size(23, 24);
            tb_UpperCase.Text = "A";
            tb_UpperCase.Click += tb_UpperCase_Click;
            // 
            // tb_LowerCase
            // 
            tb_LowerCase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_LowerCase.Image = (Image)resources.GetObject("tb_LowerCase.Image");
            tb_LowerCase.ImageTransparentColor = Color.Magenta;
            tb_LowerCase.Name = "tb_LowerCase";
            tb_LowerCase.Size = new Size(23, 24);
            tb_LowerCase.Text = "a";
            tb_LowerCase.Click += tb_LowerCase_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 27);
            // 
            // tb_ZoomIn
            // 
            tb_ZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_ZoomIn.Image = (Image)resources.GetObject("tb_ZoomIn.Image");
            tb_ZoomIn.ImageTransparentColor = Color.Magenta;
            tb_ZoomIn.Name = "tb_ZoomIn";
            tb_ZoomIn.Size = new Size(23, 24);
            tb_ZoomIn.Text = "+";
            tb_ZoomIn.Click += tb_ZoomIn_Click;
            // 
            // tb_ZoomOut
            // 
            tb_ZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tb_ZoomOut.Image = (Image)resources.GetObject("tb_ZoomOut.Image");
            tb_ZoomOut.ImageTransparentColor = Color.Magenta;
            tb_ZoomOut.Name = "tb_ZoomOut";
            tb_ZoomOut.Size = new Size(23, 24);
            tb_ZoomOut.Text = "-";
            tb_ZoomOut.Click += tb_ZoomOut_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 27);
            // 
            // tb_Font
            // 
            tb_Font.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_Font.FlatStyle = FlatStyle.Standard;
            tb_Font.Name = "tb_Font";
            tb_Font.Size = new Size(121, 27);
            tb_Font.SelectedIndexChanged += tb_Font_SelectedIndexChanged;
            // 
            // tb_FontSize
            // 
            tb_FontSize.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_FontSize.FlatStyle = FlatStyle.Standard;
            tb_FontSize.Name = "tb_FontSize";
            tb_FontSize.Size = new Size(121, 27);
            tb_FontSize.SelectedIndexChanged += tb_FontSize_SelectedIndexChanged;
            // 
            // Status
            // 
            Status.ImageScalingSize = new Size(20, 20);
            Status.Items.AddRange(new ToolStripItem[] { charCount, toolStripStatusLabel1, toolStripStatusLabel2, status_ZoomFactor });
            Status.Location = new Point(0, 511);
            Status.Name = "Status";
            Status.Size = new Size(1209, 22);
            Status.TabIndex = 2;
            Status.Text = "statusStrip1";
            // 
            // charCount
            // 
            charCount.AccessibleName = "";
            charCount.DisplayStyle = ToolStripItemDisplayStyle.Text;
            charCount.Name = "charCount";
            charCount.Size = new Size(63, 17);
            charCount.Text = "charCount";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.None;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1092, 17);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // status_ZoomFactor
            // 
            status_ZoomFactor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            status_ZoomFactor.Name = "status_ZoomFactor";
            status_ZoomFactor.Size = new Size(39, 17);
            status_ZoomFactor.Text = "Zoom";
            // 
            // Document
            // 
            Document.ContextMenuStrip = rcMenu;
            Document.Dock = DockStyle.Fill;
            Document.Location = new Point(0, 51);
            Document.Name = "Document";
            Document.ScrollBars = RichTextBoxScrollBars.Vertical;
            Document.Size = new Size(1209, 460);
            Document.TabIndex = 3;
            Document.Text = "";
            Document.LinkClicked += Document_LinkClicked;
            // 
            // rcMenu
            // 
            rcMenu.ImageScalingSize = new Size(20, 20);
            rcMenu.Items.AddRange(new ToolStripItem[] { rc_Undo, rc_Redo, toolStripSeparator10, rc_Cut, rc_Copy, rc_Paste });
            rcMenu.Name = "contextMenuStrip1";
            rcMenu.Size = new Size(104, 120);
            // 
            // rc_Undo
            // 
            rc_Undo.Name = "rc_Undo";
            rc_Undo.Size = new Size(103, 22);
            rc_Undo.Text = "Undo";
            rc_Undo.Click += rc_Undo_Click;
            // 
            // rc_Redo
            // 
            rc_Redo.Name = "rc_Redo";
            rc_Redo.Size = new Size(103, 22);
            rc_Redo.Text = "Redo";
            rc_Redo.Click += rc_Redo_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(100, 6);
            // 
            // rc_Cut
            // 
            rc_Cut.Name = "rc_Cut";
            rc_Cut.Size = new Size(103, 22);
            rc_Cut.Text = "Cut";
            rc_Cut.Click += rc_Cut_Click;
            // 
            // rc_Copy
            // 
            rc_Copy.Name = "rc_Copy";
            rc_Copy.Size = new Size(103, 22);
            rc_Copy.Text = "Copy";
            rc_Copy.Click += rc_Copy_Click;
            // 
            // rc_Paste
            // 
            rc_Paste.Name = "rc_Paste";
            rc_Paste.Size = new Size(103, 22);
            rc_Paste.Text = "Paste";
            rc_Paste.Click += rc_Paste_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += Timer_Tick_1;
            // 
            // openWork
            // 
            openWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            openWork.Title = "Open Work";
            // 
            // saveWork
            // 
            saveWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            saveWork.Title = "Save Work";
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1209, 533);
            Controls.Add(Document);
            Controls.Add(Status);
            Controls.Add(Tools);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            MaximumSize = new Size(1400, 800);
            MinimumSize = new Size(748, 471);
            Name = "TextEditor";
            Text = "TextEditor";
            Load += TextEditor_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            Tools.ResumeLayout(false);
            Tools.PerformLayout();
            Status.ResumeLayout(false);
            Status.PerformLayout();
            rcMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStrip Tools;
        private StatusStrip Status;
        private RichTextBox Document;
        private ToolStripMenuItem mM_File;
        private ToolStripMenuItem file_New;
        private ToolStripMenuItem file_Open;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem file_Save;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem file_Exit;
        private ToolStripMenuItem mM_Edit;
        private ToolStripMenuItem edit_Undo;
        private ToolStripMenuItem edit_Redo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem edit_Cut;
        private ToolStripMenuItem edit_Copy;
        private ToolStripMenuItem edit_Paste;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem edit_SelectAll;
        private ToolStripMenuItem mM_Tools;
        private ToolStripMenuItem tools_Customisation;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripButton tb_New;
        private ToolStripButton tb_Open;
        private ToolStripButton tb_Save;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tb_Cut;
        private ToolStripButton tb_Copy;
        private ToolStripButton tb_Paste;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripComboBox tb_Font;
        private ToolStripComboBox tb_FontSize;
        private ToolStripButton tb_Bold;
        private ToolStripButton tb_Italic;
        private ToolStripButton tb_UnderLine;
        private ToolStripButton tb_Strike;
        private ToolStripButton tb_AlignLeft;
        private ToolStripButton tb_AlignCenter;
        private ToolStripButton tb_AlignRight;
        private ToolStripButton tb_UpperCase;
        private ToolStripButton tb_LowerCase;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton tb_ZoomIn;
        private ToolStripButton tb_ZoomOut;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripStatusLabel charCount;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel status_ZoomFactor;
        private ContextMenuStrip rcMenu;
        private ToolStripMenuItem rc_Undo;
        private ToolStripMenuItem rc_Redo;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem rc_Cut;
        private ToolStripMenuItem rc_Copy;
        private ToolStripMenuItem rc_Paste;
        private System.Windows.Forms.Timer timer;
        private OpenFileDialog openWork;
        private SaveFileDialog saveWork;
        private ToolStripButton tb_AddImage;
        private ToolStripSplitButton tb_TextColor;
    }
}
