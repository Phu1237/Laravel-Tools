namespace Laravel_Tools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bottomStrip = new System.Windows.Forms.StatusStrip();
            this.labelAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelComposer2 = new System.Windows.Forms.Label();
            this.labelComposer1 = new System.Windows.Forms.Label();
            this.labelPHP2 = new System.Windows.Forms.Label();
            this.labelPHP = new System.Windows.Forms.Label();
            this.labelVersion2 = new System.Windows.Forms.Label();
            this.labelVersion1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.labelResultStatus2 = new System.Windows.Forms.Label();
            this.labelResultStatus1 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCommand = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxAdditionalCMD = new System.Windows.Forms.TextBox();
            this.labelAdditionalCMD = new System.Windows.Forms.Label();
            this.bottomStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomStrip
            // 
            this.bottomStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAuthor});
            this.bottomStrip.Location = new System.Drawing.Point(0, 557);
            this.bottomStrip.Name = "bottomStrip";
            this.bottomStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.bottomStrip.Size = new System.Drawing.Size(1119, 26);
            this.bottomStrip.SizingGrip = false;
            this.bottomStrip.TabIndex = 2;
            this.bottomStrip.Text = "bottomStrip";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(65, 20);
            this.labelAuthor.Text = "Phu1237";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1119, 30);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.labelPath);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPath);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBrowser);
            this.splitContainer1.Panel1.Controls.Add(this.line);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.labelAdditionalCMD);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAdditionalCMD);
            this.splitContainer1.Panel2.Controls.Add(this.labelResultStatus2);
            this.splitContainer1.Panel2.Controls.Add(this.labelResultStatus1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonExecute);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxResult);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.labelCommand);
            this.splitContainer1.Size = new System.Drawing.Size(1119, 527);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelComposer2);
            this.panel1.Controls.Add(this.labelComposer1);
            this.panel1.Controls.Add(this.labelPHP2);
            this.panel1.Controls.Add(this.labelPHP);
            this.panel1.Controls.Add(this.labelVersion2);
            this.panel1.Controls.Add(this.labelVersion1);
            this.panel1.Controls.Add(this.labelName2);
            this.panel1.Controls.Add(this.labelName1);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Location = new System.Drawing.Point(13, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 424);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 100);
            this.label2.TabIndex = 11;
            this.label2.Text = "After choose the laravel project folder, wait for the software to handle some inf" +
    "ormation.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Laravel_Tools.Properties.Resources.laravel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelComposer2
            // 
            this.labelComposer2.Location = new System.Drawing.Point(111, 135);
            this.labelComposer2.Name = "labelComposer2";
            this.labelComposer2.Size = new System.Drawing.Size(232, 30);
            this.labelComposer2.TabIndex = 8;
            this.labelComposer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelComposer1
            // 
            this.labelComposer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelComposer1.Location = new System.Drawing.Point(3, 135);
            this.labelComposer1.Name = "labelComposer1";
            this.labelComposer1.Size = new System.Drawing.Size(102, 30);
            this.labelComposer1.TabIndex = 7;
            this.labelComposer1.Text = "Composer:";
            this.labelComposer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPHP2
            // 
            this.labelPHP2.Location = new System.Drawing.Point(111, 102);
            this.labelPHP2.Name = "labelPHP2";
            this.labelPHP2.Size = new System.Drawing.Size(232, 30);
            this.labelPHP2.TabIndex = 6;
            this.labelPHP2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPHP
            // 
            this.labelPHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelPHP.Location = new System.Drawing.Point(3, 102);
            this.labelPHP.Name = "labelPHP";
            this.labelPHP.Size = new System.Drawing.Size(102, 30);
            this.labelPHP.TabIndex = 5;
            this.labelPHP.Text = "PHP:";
            this.labelPHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion2
            // 
            this.labelVersion2.Location = new System.Drawing.Point(111, 69);
            this.labelVersion2.Name = "labelVersion2";
            this.labelVersion2.Size = new System.Drawing.Size(232, 30);
            this.labelVersion2.TabIndex = 4;
            this.labelVersion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion1
            // 
            this.labelVersion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelVersion1.Location = new System.Drawing.Point(3, 69);
            this.labelVersion1.Name = "labelVersion1";
            this.labelVersion1.Size = new System.Drawing.Size(102, 30);
            this.labelVersion1.TabIndex = 3;
            this.labelVersion1.Text = "Version:";
            this.labelVersion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName2
            // 
            this.labelName2.Location = new System.Drawing.Point(111, 36);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(232, 30);
            this.labelName2.TabIndex = 2;
            this.labelName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName1
            // 
            this.labelName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelName1.Location = new System.Drawing.Point(3, 36);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(102, 30);
            this.labelName1.TabIndex = 1;
            this.labelName1.Text = "Name:";
            this.labelName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(3, 1);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(340, 32);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Info";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPath
            // 
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelPath.Location = new System.Drawing.Point(8, 21);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(64, 30);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "Path";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(78, 23);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(193, 26);
            this.textBoxPath.TabIndex = 2;
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowser.Location = new System.Drawing.Point(277, 23);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(93, 26);
            this.buttonBrowser.TabIndex = 1;
            this.buttonBrowser.Text = "Browser";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.ButtonBrowser_Click);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.Location = new System.Drawing.Point(0, 72);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(373, 2);
            this.line.TabIndex = 0;
            // 
            // labelResultStatus2
            // 
            this.labelResultStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultStatus2.Location = new System.Drawing.Point(82, 267);
            this.labelResultStatus2.Name = "labelResultStatus2";
            this.labelResultStatus2.Size = new System.Drawing.Size(216, 30);
            this.labelResultStatus2.TabIndex = 10;
            this.labelResultStatus2.Text = "Stopped!";
            this.labelResultStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResultStatus1
            // 
            this.labelResultStatus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResultStatus1.Location = new System.Drawing.Point(14, 267);
            this.labelResultStatus1.Name = "labelResultStatus1";
            this.labelResultStatus1.Size = new System.Drawing.Size(62, 30);
            this.labelResultStatus1.TabIndex = 9;
            this.labelResultStatus1.Text = "Status:";
            this.labelResultStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecute.Location = new System.Drawing.Point(14, 231);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(97, 31);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.Black;
            this.textBoxResult.ForeColor = System.Drawing.Color.White;
            this.textBoxResult.Location = new System.Drawing.Point(14, 299);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(716, 224);
            this.textBoxResult.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listName,
            this.listDescription,
            this.listCommand});
            this.dataGridView1.Location = new System.Drawing.Point(14, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // listName
            // 
            this.listName.HeaderText = "Name";
            this.listName.MinimumWidth = 6;
            this.listName.Name = "listName";
            this.listName.ReadOnly = true;
            // 
            // listDescription
            // 
            this.listDescription.HeaderText = "Description";
            this.listDescription.MinimumWidth = 6;
            this.listDescription.Name = "listDescription";
            this.listDescription.ReadOnly = true;
            // 
            // listCommand
            // 
            this.listCommand.HeaderText = "Command";
            this.listCommand.MinimumWidth = 6;
            this.listCommand.Name = "listCommand";
            this.listCommand.ReadOnly = true;
            // 
            // labelCommand
            // 
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelCommand.Location = new System.Drawing.Point(14, 21);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(716, 30);
            this.labelCommand.TabIndex = 5;
            this.labelCommand.Text = "Command";
            this.labelCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1007, 559);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 5;
            // 
            // textBoxAdditionalCMD
            // 
            this.textBoxAdditionalCMD.Location = new System.Drawing.Point(509, 233);
            this.textBoxAdditionalCMD.Name = "textBoxAdditionalCMD";
            this.textBoxAdditionalCMD.Size = new System.Drawing.Size(221, 26);
            this.textBoxAdditionalCMD.TabIndex = 11;
            this.textBoxAdditionalCMD.Text = "--help";
            // 
            // labelAdditionalCMD
            // 
            this.labelAdditionalCMD.AutoSize = true;
            this.labelAdditionalCMD.Location = new System.Drawing.Point(381, 236);
            this.labelAdditionalCMD.Name = "labelAdditionalCMD";
            this.labelAdditionalCMD.Size = new System.Drawing.Size(122, 20);
            this.labelAdditionalCMD.TabIndex = 12;
            this.labelAdditionalCMD.Text = "Additonal CMD";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1119, 583);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.bottomStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laravel Tools - By Phu1237";
            this.bottomStrip.ResumeLayout(false);
            this.bottomStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bottomStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelAuthor;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelComposer2;
        private System.Windows.Forms.Label labelComposer1;
        private System.Windows.Forms.Label labelPHP2;
        private System.Windows.Forms.Label labelPHP;
        private System.Windows.Forms.Label labelVersion2;
        private System.Windows.Forms.Label labelVersion1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelResultStatus2;
        private System.Windows.Forms.Label labelResultStatus1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn listName;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn listCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdditionalCMD;
        private System.Windows.Forms.Label labelAdditionalCMD;
    }
}

