﻿namespace SuperPutty
{
    partial class dlgFindPutty
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgFindPutty));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBrowsePutty = new System.Windows.Forms.Button();
            this.buttonBrowsePscp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPuttyLocation = new System.Windows.Forms.TextBox();
            this.textBoxPscpLocation = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxSettingsFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBrowseLayoutsFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLayouts = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkRestoreWindow = new System.Windows.Forms.CheckBox();
            this.checkConstrainPuttyDocking = new System.Windows.Forms.CheckBox();
            this.checkSingleInstanceMode = new System.Windows.Forms.CheckBox();
            this.checkExitConfirmation = new System.Windows.Forms.CheckBox();
            this.checkExpandTree = new System.Windows.Forms.CheckBox();
            this.checkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.textBoxMinttyLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowseMintty = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTabText = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTabSwitching = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.checkSessionsTreeShowLines = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageGUI = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxActivatorType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.tabPageShortcuts = new System.Windows.Forms.TabPage();
            this.dataGridViewShortcuts = new System.Windows.Forms.DataGridView();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colClear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortcutStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyboardShortcutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageGUI.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAdvanced.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabPageShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShortcuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardShortcutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(464, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonBrowsePutty
            // 
            this.buttonBrowsePutty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowsePutty.Location = new System.Drawing.Point(541, 106);
            this.buttonBrowsePutty.Name = "buttonBrowsePutty";
            this.buttonBrowsePutty.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePutty.TabIndex = 1;
            this.buttonBrowsePutty.Text = "Browse";
            this.buttonBrowsePutty.UseVisualStyleBackColor = true;
            this.buttonBrowsePutty.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonBrowsePscp
            // 
            this.buttonBrowsePscp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowsePscp.Location = new System.Drawing.Point(541, 135);
            this.buttonBrowsePscp.Name = "buttonBrowsePscp";
            this.buttonBrowsePscp.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePscp.TabIndex = 3;
            this.buttonBrowsePscp.Text = "Browse";
            this.buttonBrowsePscp.UseVisualStyleBackColor = true;
            this.buttonBrowsePscp.Click += new System.EventHandler(this.buttonBrowsePscp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "putty.exe Location (Required)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "pscp.exe Location";
            // 
            // textBoxPuttyLocation
            // 
            this.textBoxPuttyLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPuttyLocation.Location = new System.Drawing.Point(172, 108);
            this.textBoxPuttyLocation.Name = "textBoxPuttyLocation";
            this.textBoxPuttyLocation.Size = new System.Drawing.Size(363, 20);
            this.textBoxPuttyLocation.TabIndex = 0;
            // 
            // textBoxPscpLocation
            // 
            this.textBoxPscpLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPscpLocation.Location = new System.Drawing.Point(172, 137);
            this.textBoxPscpLocation.Name = "textBoxPscpLocation";
            this.textBoxPscpLocation.Size = new System.Drawing.Size(363, 20);
            this.textBoxPscpLocation.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(609, 93);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBoxSettingsFolder
            // 
            this.textBoxSettingsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsFolder.Location = new System.Drawing.Point(172, 188);
            this.textBoxSettingsFolder.Name = "textBoxSettingsFolder";
            this.textBoxSettingsFolder.Size = new System.Drawing.Size(363, 20);
            this.textBoxSettingsFolder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Settings Folder (Required)";
            this.toolTip.SetToolTip(this.label3, "Where sessions and layout config files are stored");
            // 
            // buttonBrowseLayoutsFolder
            // 
            this.buttonBrowseLayoutsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseLayoutsFolder.Location = new System.Drawing.Point(541, 185);
            this.buttonBrowseLayoutsFolder.Name = "buttonBrowseLayoutsFolder";
            this.buttonBrowseLayoutsFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseLayoutsFolder.TabIndex = 5;
            this.buttonBrowseLayoutsFolder.Text = "Browse";
            this.buttonBrowseLayoutsFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseLayoutsFolder.Click += new System.EventHandler(this.buttonBrowseLayoutsFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Default Layout";
            this.toolTip.SetToolTip(this.label4, "Determines which set of sessions, if any, to restore at startup");
            // 
            // comboBoxLayouts
            // 
            this.comboBoxLayouts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLayouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLayouts.FormattingEnabled = true;
            this.comboBoxLayouts.Location = new System.Drawing.Point(172, 215);
            this.comboBoxLayouts.Name = "comboBoxLayouts";
            this.comboBoxLayouts.Size = new System.Drawing.Size(363, 21);
            this.comboBoxLayouts.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(555, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Other:";
            // 
            // checkRestoreWindow
            // 
            this.checkRestoreWindow.AutoSize = true;
            this.checkRestoreWindow.Location = new System.Drawing.Point(15, 43);
            this.checkRestoreWindow.Name = "checkRestoreWindow";
            this.checkRestoreWindow.Size = new System.Drawing.Size(193, 17);
            this.checkRestoreWindow.TabIndex = 26;
            this.checkRestoreWindow.Text = "Restore Window Size and Location";
            this.toolTip.SetToolTip(this.checkRestoreWindow, "Save windows size and location on close and restore on start up");
            this.checkRestoreWindow.UseVisualStyleBackColor = true;
            // 
            // checkConstrainPuttyDocking
            // 
            this.checkConstrainPuttyDocking.AutoSize = true;
            this.checkConstrainPuttyDocking.Location = new System.Drawing.Point(76, 80);
            this.checkConstrainPuttyDocking.Name = "checkConstrainPuttyDocking";
            this.checkConstrainPuttyDocking.Size = new System.Drawing.Size(193, 17);
            this.checkConstrainPuttyDocking.TabIndex = 25;
            this.checkConstrainPuttyDocking.Text = "Restrict Content to Document Tabs";
            this.toolTip.SetToolTip(this.checkConstrainPuttyDocking, "Prevent sessions from being docked in tool windows (edges)");
            this.checkConstrainPuttyDocking.UseVisualStyleBackColor = true;
            // 
            // checkSingleInstanceMode
            // 
            this.checkSingleInstanceMode.AutoSize = true;
            this.checkSingleInstanceMode.Location = new System.Drawing.Point(15, 20);
            this.checkSingleInstanceMode.Name = "checkSingleInstanceMode";
            this.checkSingleInstanceMode.Size = new System.Drawing.Size(254, 17);
            this.checkSingleInstanceMode.TabIndex = 24;
            this.checkSingleInstanceMode.Text = "Only allow single instance of SuperPuTTY to run";
            this.toolTip.SetToolTip(this.checkSingleInstanceMode, "If checked, new sessions launched from the command line are opened in an existing" +
        " instance");
            this.checkSingleInstanceMode.UseVisualStyleBackColor = true;
            // 
            // checkExitConfirmation
            // 
            this.checkExitConfirmation.AutoSize = true;
            this.checkExitConfirmation.Location = new System.Drawing.Point(15, 66);
            this.checkExitConfirmation.Name = "checkExitConfirmation";
            this.checkExitConfirmation.Size = new System.Drawing.Size(104, 17);
            this.checkExitConfirmation.TabIndex = 27;
            this.checkExitConfirmation.Text = "Exit Confirmation";
            this.toolTip.SetToolTip(this.checkExitConfirmation, "Ask for confirmation before closing SuperPutty");
            this.checkExitConfirmation.UseVisualStyleBackColor = true;
            // 
            // checkExpandTree
            // 
            this.checkExpandTree.AutoSize = true;
            this.checkExpandTree.Location = new System.Drawing.Point(76, 47);
            this.checkExpandTree.Name = "checkExpandTree";
            this.checkExpandTree.Size = new System.Drawing.Size(117, 17);
            this.checkExpandTree.TabIndex = 29;
            this.checkExpandTree.Text = "Expand on Start up";
            this.toolTip.SetToolTip(this.checkExpandTree, "Expand the session tree at startup to full extent");
            this.checkExpandTree.UseVisualStyleBackColor = true;
            // 
            // checkMinimizeToTray
            // 
            this.checkMinimizeToTray.AutoSize = true;
            this.checkMinimizeToTray.Location = new System.Drawing.Point(15, 19);
            this.checkMinimizeToTray.Name = "checkMinimizeToTray";
            this.checkMinimizeToTray.Size = new System.Drawing.Size(106, 17);
            this.checkMinimizeToTray.TabIndex = 30;
            this.checkMinimizeToTray.Text = "Minimize To Tray";
            this.checkMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // textBoxMinttyLocation
            // 
            this.textBoxMinttyLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinttyLocation.Location = new System.Drawing.Point(172, 162);
            this.textBoxMinttyLocation.Name = "textBoxMinttyLocation";
            this.textBoxMinttyLocation.Size = new System.Drawing.Size(363, 20);
            this.textBoxMinttyLocation.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "mintty.exe Location";
            this.toolTip.SetToolTip(this.label7, "Alternative to putty-cyg for local access");
            // 
            // btnBrowseMintty
            // 
            this.btnBrowseMintty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMintty.Location = new System.Drawing.Point(541, 160);
            this.btnBrowseMintty.Name = "btnBrowseMintty";
            this.btnBrowseMintty.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseMintty.TabIndex = 32;
            this.btnBrowseMintty.Text = "Browse";
            this.btnBrowseMintty.UseVisualStyleBackColor = true;
            this.btnBrowseMintty.Click += new System.EventHandler(this.btnBrowseMintty_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tab Text:";
            this.toolTip.SetToolTip(this.label8, "Determines how tabs are named and if they respond to the shell\'s title changing");
            // 
            // comboBoxTabText
            // 
            this.comboBoxTabText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTabText.FormattingEnabled = true;
            this.comboBoxTabText.Location = new System.Drawing.Point(76, 19);
            this.comboBoxTabText.Name = "comboBoxTabText";
            this.comboBoxTabText.Size = new System.Drawing.Size(207, 21);
            this.comboBoxTabText.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Switching:";
            this.toolTip.SetToolTip(this.label9, "Determines the order sessions tabs are cycled through");
            // 
            // comboBoxTabSwitching
            // 
            this.comboBoxTabSwitching.DisplayMember = "Description";
            this.comboBoxTabSwitching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTabSwitching.FormattingEnabled = true;
            this.comboBoxTabSwitching.Location = new System.Drawing.Point(76, 46);
            this.comboBoxTabSwitching.Name = "comboBoxTabSwitching";
            this.comboBoxTabSwitching.Size = new System.Drawing.Size(207, 21);
            this.comboBoxTabSwitching.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Font:";
            this.toolTip.SetToolTip(this.label10, "Determines how tabs are named and if they respond to the shell\'s title changing");
            // 
            // checkSessionsTreeShowLines
            // 
            this.checkSessionsTreeShowLines.AutoSize = true;
            this.checkSessionsTreeShowLines.Location = new System.Drawing.Point(76, 70);
            this.checkSessionsTreeShowLines.Name = "checkSessionsTreeShowLines";
            this.checkSessionsTreeShowLines.Size = new System.Drawing.Size(81, 17);
            this.checkSessionsTreeShowLines.TabIndex = 36;
            this.checkSessionsTreeShowLines.Text = "Show Lines";
            this.toolTip.SetToolTip(this.checkSessionsTreeShowLines, "Show lines in tree");
            this.checkSessionsTreeShowLines.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Activator:";
            this.toolTip.SetToolTip(this.label6, "Method for activating SuperPutty when clicking on a putty session.");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageGUI);
            this.tabControl.Controls.Add(this.tabPageShortcuts);
            this.tabControl.Controls.Add(this.tabPageAdvanced);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(630, 273);
            this.tabControl.TabIndex = 38;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.label4);
            this.tabPageGeneral.Controls.Add(this.buttonBrowsePutty);
            this.tabPageGeneral.Controls.Add(this.buttonBrowsePscp);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.textBoxMinttyLocation);
            this.tabPageGeneral.Controls.Add(this.textBoxPuttyLocation);
            this.tabPageGeneral.Controls.Add(this.label7);
            this.tabPageGeneral.Controls.Add(this.textBoxPscpLocation);
            this.tabPageGeneral.Controls.Add(this.btnBrowseMintty);
            this.tabPageGeneral.Controls.Add(this.richTextBox1);
            this.tabPageGeneral.Controls.Add(this.label3);
            this.tabPageGeneral.Controls.Add(this.textBoxSettingsFolder);
            this.tabPageGeneral.Controls.Add(this.buttonBrowseLayoutsFolder);
            this.tabPageGeneral.Controls.Add(this.comboBoxLayouts);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(622, 247);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPageGUI
            // 
            this.tabPageGUI.Controls.Add(this.groupBox3);
            this.tabPageGUI.Controls.Add(this.groupBox2);
            this.tabPageGUI.Controls.Add(this.groupBox1);
            this.tabPageGUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageGUI.Name = "tabPageGUI";
            this.tabPageGUI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGUI.Size = new System.Drawing.Size(622, 247);
            this.tabPageGUI.TabIndex = 1;
            this.tabPageGUI.Text = "GUI";
            this.tabPageGUI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkMinimizeToTray);
            this.groupBox3.Location = new System.Drawing.Point(358, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 242);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkConstrainPuttyDocking);
            this.groupBox2.Controls.Add(this.comboBoxTabText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxTabSwitching);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(3, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 137);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabs and Docking";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.checkSessionsTreeShowLines);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkExpandTree);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 99);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session Tree";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(76, 11);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(207, 23);
            this.btnFont.TabIndex = 39;
            this.btnFont.Text = "Choose Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Options:";
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Controls.Add(this.groupBox5);
            this.tabPageAdvanced.Controls.Add(this.groupBox4);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Size = new System.Drawing.Size(622, 247);
            this.tabPageAdvanced.TabIndex = 2;
            this.tabPageAdvanced.Text = "Advanced";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.comboBoxActivatorType);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(3, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(616, 142);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Focus";
            // 
            // comboBoxActivatorType
            // 
            this.comboBoxActivatorType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxActivatorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivatorType.FormattingEnabled = true;
            this.comboBoxActivatorType.Location = new System.Drawing.Point(79, 17);
            this.comboBoxActivatorType.Name = "comboBoxActivatorType";
            this.comboBoxActivatorType.Size = new System.Drawing.Size(531, 21);
            this.comboBoxActivatorType.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkSingleInstanceMode);
            this.groupBox4.Controls.Add(this.checkExitConfirmation);
            this.groupBox4.Controls.Add(this.checkRestoreWindow);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 92);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Application Behavior";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonCancel);
            this.panelBottom.Controls.Add(this.buttonOk);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 278);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(630, 27);
            this.panelBottom.TabIndex = 39;
            // 
            // tabPageShortcuts
            // 
            this.tabPageShortcuts.Controls.Add(this.dataGridViewShortcuts);
            this.tabPageShortcuts.Location = new System.Drawing.Point(4, 22);
            this.tabPageShortcuts.Name = "tabPageShortcuts";
            this.tabPageShortcuts.Size = new System.Drawing.Size(622, 247);
            this.tabPageShortcuts.TabIndex = 3;
            this.tabPageShortcuts.Text = "Shortcuts";
            this.tabPageShortcuts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShortcuts
            // 
            this.dataGridViewShortcuts.AllowUserToAddRows = false;
            this.dataGridViewShortcuts.AllowUserToDeleteRows = false;
            this.dataGridViewShortcuts.AutoGenerateColumns = false;
            this.dataGridViewShortcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShortcuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.keyDataGridViewTextBoxColumn,
            this.modifiersDataGridViewTextBoxColumn,
            this.shortcutStringDataGridViewTextBoxColumn,
            this.colEdit,
            this.colClear});
            this.dataGridViewShortcuts.DataSource = this.keyboardShortcutBindingSource;
            this.dataGridViewShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShortcuts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShortcuts.Name = "dataGridViewShortcuts";
            this.dataGridViewShortcuts.ReadOnly = true;
            this.dataGridViewShortcuts.Size = new System.Drawing.Size(622, 247);
            this.dataGridViewShortcuts.TabIndex = 0;
            this.dataGridViewShortcuts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShortcuts_CellClick);
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 50;
            // 
            // colClear
            // 
            this.colClear.HeaderText = "";
            this.colClear.Name = "colClear";
            this.colClear.ReadOnly = true;
            this.colClear.Text = "Clear";
            this.colClear.UseColumnTextForButtonValue = true;
            this.colClear.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiersDataGridViewTextBoxColumn
            // 
            this.modifiersDataGridViewTextBoxColumn.DataPropertyName = "Modifiers";
            this.modifiersDataGridViewTextBoxColumn.HeaderText = "Modifiers";
            this.modifiersDataGridViewTextBoxColumn.Name = "modifiersDataGridViewTextBoxColumn";
            this.modifiersDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiersDataGridViewTextBoxColumn.Visible = false;
            // 
            // shortcutStringDataGridViewTextBoxColumn
            // 
            this.shortcutStringDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shortcutStringDataGridViewTextBoxColumn.DataPropertyName = "ShortcutString";
            this.shortcutStringDataGridViewTextBoxColumn.HeaderText = "Shortcut";
            this.shortcutStringDataGridViewTextBoxColumn.Name = "shortcutStringDataGridViewTextBoxColumn";
            this.shortcutStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyboardShortcutBindingSource
            // 
            this.keyboardShortcutBindingSource.DataSource = typeof(SuperPutty.Data.KeyboardShortcut);
            // 
            // dlgFindPutty
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(640, 310);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgFindPutty";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuperPuTTY Options";
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageGUI.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageAdvanced.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tabPageShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShortcuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardShortcutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBrowsePutty;
        private System.Windows.Forms.Button buttonBrowsePscp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPuttyLocation;
        private System.Windows.Forms.TextBox textBoxPscpLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxSettingsFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowseLayoutsFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLayouts;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkRestoreWindow;
        private System.Windows.Forms.CheckBox checkConstrainPuttyDocking;
        private System.Windows.Forms.CheckBox checkSingleInstanceMode;
        private System.Windows.Forms.CheckBox checkExitConfirmation;
        private System.Windows.Forms.CheckBox checkExpandTree;
        private System.Windows.Forms.CheckBox checkMinimizeToTray;
        private System.Windows.Forms.TextBox textBoxMinttyLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowseMintty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTabText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTabSwitching;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageGUI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkSessionsTreeShowLines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxActivatorType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageShortcuts;
        private System.Windows.Forms.DataGridView dataGridViewShortcuts;
        private System.Windows.Forms.BindingSource keyboardShortcutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortcutStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colClear;
    }
}