namespace TFive_Windows_Information
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.coordModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.magnifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabElement = new System.Windows.Forms.TabPage();
            this.dataElement = new System.Windows.Forms.DataGridView();
            this.ColPropertiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.dataMain = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.finder1 = new TFive.Library.Automation.Detection.Finder.Finder();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataElement)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysTopToolStripMenuItem,
            this.toolStripSeparator1,
            this.coordModeToolStripMenuItem,
            this.toolStripSeparator2,
            this.magnifyToolStripMenuItem,
            this.toolStripSeparator3,
            this.showColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // alwaysTopToolStripMenuItem
            // 
            this.alwaysTopToolStripMenuItem.Checked = true;
            this.alwaysTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysTopToolStripMenuItem.Name = "alwaysTopToolStripMenuItem";
            this.alwaysTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.alwaysTopToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.alwaysTopToolStripMenuItem.Text = "Always Top";
            this.alwaysTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysTopToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // coordModeToolStripMenuItem
            // 
            this.coordModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.coordModeToolStripMenuItem.Name = "coordModeToolStripMenuItem";
            this.coordModeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.coordModeToolStripMenuItem.Text = "Coord Mode";
            // 
            // screenToolStripMenuItem
            // 
            this.screenToolStripMenuItem.Name = "screenToolStripMenuItem";
            this.screenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.screenToolStripMenuItem.Text = "Screen";
            this.screenToolStripMenuItem.Click += new System.EventHandler(this.screenToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.windowToolStripMenuItem.Text = "Window";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // magnifyToolStripMenuItem
            // 
            this.magnifyToolStripMenuItem.Checked = true;
            this.magnifyToolStripMenuItem.CheckOnClick = true;
            this.magnifyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.magnifyToolStripMenuItem.Name = "magnifyToolStripMenuItem";
            this.magnifyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.magnifyToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.magnifyToolStripMenuItem.Text = "Magnify";
            this.magnifyToolStripMenuItem.CheckedChanged += new System.EventHandler(this.magnifyToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // showColorToolStripMenuItem
            // 
            this.showColorToolStripMenuItem.Checked = true;
            this.showColorToolStripMenuItem.CheckOnClick = true;
            this.showColorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showColorToolStripMenuItem.Name = "showColorToolStripMenuItem";
            this.showColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.showColorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.showColorToolStripMenuItem.Text = "Show Color";
            this.showColorToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showColorToolStripMenuItem_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(359, 487);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabElement);
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 166);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 311);
            this.tabControl1.TabIndex = 2;
            // 
            // tabElement
            // 
            this.tabElement.Controls.Add(this.dataElement);
            this.tabElement.Location = new System.Drawing.Point(4, 24);
            this.tabElement.Name = "tabElement";
            this.tabElement.Padding = new System.Windows.Forms.Padding(3);
            this.tabElement.Size = new System.Drawing.Size(331, 283);
            this.tabElement.TabIndex = 0;
            this.tabElement.Text = "Element Window";
            this.tabElement.UseVisualStyleBackColor = true;
            // 
            // dataElement
            // 
            this.dataElement.AllowUserToAddRows = false;
            this.dataElement.AllowUserToDeleteRows = false;
            this.dataElement.AllowUserToResizeColumns = false;
            this.dataElement.AllowUserToResizeRows = false;
            this.dataElement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataElement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataElement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dataElement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataElement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataElement.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataElement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPropertiy,
            this.ColValue});
            this.dataElement.ContextMenuStrip = this.contextMenuStrip1;
            this.dataElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataElement.Location = new System.Drawing.Point(3, 3);
            this.dataElement.MultiSelect = false;
            this.dataElement.Name = "dataElement";
            this.dataElement.ReadOnly = true;
            this.dataElement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataElement.RowHeadersVisible = false;
            this.dataElement.RowTemplate.Height = 25;
            this.dataElement.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataElement.Size = new System.Drawing.Size(325, 277);
            this.dataElement.TabIndex = 0;
            this.dataElement.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_MouseDoubleClick);
            this.dataElement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.data_MouseDown);
            // 
            // ColPropertiy
            // 
            this.ColPropertiy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColPropertiy.HeaderText = "Property";
            this.ColPropertiy.Name = "ColPropertiy";
            this.ColPropertiy.ReadOnly = true;
            this.ColPropertiy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPropertiy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPropertiy.Width = 80;
            // 
            // ColValue
            // 
            this.ColValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColValue.HeaderText = "Value";
            this.ColValue.Name = "ColValue";
            this.ColValue.ReadOnly = true;
            this.ColValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.dataMain);
            this.tabMain.Location = new System.Drawing.Point(4, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(331, 283);
            this.tabMain.TabIndex = 1;
            this.tabMain.Text = "Main Window";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // dataMain
            // 
            this.dataMain.AllowUserToAddRows = false;
            this.dataMain.AllowUserToDeleteRows = false;
            this.dataMain.AllowUserToResizeColumns = false;
            this.dataMain.AllowUserToResizeRows = false;
            this.dataMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dataMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataMain.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataMain.ContextMenuStrip = this.contextMenuStrip1;
            this.dataMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMain.Location = new System.Drawing.Point(3, 3);
            this.dataMain.MultiSelect = false;
            this.dataMain.Name = "dataMain";
            this.dataMain.ReadOnly = true;
            this.dataMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataMain.RowHeadersVisible = false;
            this.dataMain.RowTemplate.Height = 25;
            this.dataMain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMain.Size = new System.Drawing.Size(325, 277);
            this.dataMain.TabIndex = 1;
            this.dataMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_MouseDoubleClick);
            this.dataMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.data_MouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Property";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "(Double-click list entries to copy to clipboard)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelColor);
            this.groupBox2.Controls.Add(this.linkGithub);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 0, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(339, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finder Tools";
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColor.Location = new System.Drawing.Point(149, 16);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(148, 41);
            this.panelColor.TabIndex = 0;
            // 
            // linkGithub
            // 
            this.linkGithub.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkGithub.Location = new System.Drawing.Point(8, 16);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(141, 41);
            this.linkGithub.TabIndex = 0;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "https://github.com/T5ive";
            this.linkGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.finder1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(297, 16);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(39, 41);
            this.panel2.TabIndex = 0;
            // 
            // finder1
            // 
            this.finder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finder1.Location = new System.Drawing.Point(5, 5);
            this.finder1.Magnify = true;
            this.finder1.MaximumSize = new System.Drawing.Size(31, 28);
            this.finder1.MinimumSize = new System.Drawing.Size(31, 28);
            this.finder1.Name = "finder1";
            this.finder1.Size = new System.Drawing.Size(31, 28);
            this.finder1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Window Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClassName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Window Title: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(109, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(221, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // txtClassName
            // 
            this.txtClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassName.Location = new System.Drawing.Point(109, 32);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(221, 23);
            this.txtClassName.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(375, 550);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TFive - Windows Infomation";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabElement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataElement)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem alwaysTopToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem coordModeToolStripMenuItem;
        private ToolStripMenuItem screenToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem magnifyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem showColorToolStripMenuItem;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtClassName;
        private GroupBox groupBox2;
        private LinkLabel linkGithub;
        private TFive.Library.Automation.Detection.Finder.Finder finder1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabElement;
        private TabPage tabMain;
        private Label label3;
        private Panel panelColor;
        private DataGridView dataElement;
        private DataGridView dataMain;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColPropertiy;
        private DataGridViewTextBoxColumn ColValue;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}