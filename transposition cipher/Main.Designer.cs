namespace transposition_cipher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTranspositionCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPrb = new System.Windows.Forms.ToolStripProgressBar();
            this.logDisplayRtb = new System.Windows.Forms.RichTextBox();
            this.statusContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpandBtn = new System.Windows.Forms.Button();
            this.cipherTextRtb = new System.Windows.Forms.RichTextBox();
            this.plainTextRtb = new System.Windows.Forms.RichTextBox();
            this.cipherTextLbl = new System.Windows.Forms.Label();
            this.plainTextLbl = new System.Windows.Forms.Label();
            this.encryptGb = new System.Windows.Forms.GroupBox();
            this.keyGen = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.paddingCb = new System.Windows.Forms.ComboBox();
            this.paddingLbl = new System.Windows.Forms.Label();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.cipherTypeLbl = new System.Windows.Forms.Label();
            this.showKeyChbx = new System.Windows.Forms.CheckBox();
            this.reenterKeyLbl = new System.Windows.Forms.Label();
            this.reenterTxb = new System.Windows.Forms.TextBox();
            this.enterKeyLbl = new System.Windows.Forms.Label();
            this.keyTxb = new System.Windows.Forms.TextBox();
            this.showHideLbl = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.decryptBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.statusContextMenuStrip.SuspendLayout();
            this.encryptGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(894, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Text = "&Open file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveFileToolStripMenuItem.Text = "&Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideDetailToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // hideDetailToolStripMenuItem
            // 
            this.hideDetailToolStripMenuItem.Name = "hideDetailToolStripMenuItem";
            this.hideDetailToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.hideDetailToolStripMenuItem.Text = "&Hide detail";
            this.hideDetailToolStripMenuItem.Click += new System.EventHandler(this.hideDetailToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutTranspositionCipherToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.viewHelpToolStripMenuItem.Text = "&View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // aboutTranspositionCipherToolStripMenuItem
            // 
            this.aboutTranspositionCipherToolStripMenuItem.Name = "aboutTranspositionCipherToolStripMenuItem";
            this.aboutTranspositionCipherToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aboutTranspositionCipherToolStripMenuItem.Text = "&About transposition cipher";
            this.aboutTranspositionCipherToolStripMenuItem.Click += new System.EventHandler(this.aboutTranspositionCipherToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptFileToolStripMenuItem,
            this.toolStripMenuItem4,
            this.copyToClipboardToolStripMenuItem,
            this.copyFromClipboardToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(185, 76);
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.decryptFileToolStripMenuItem.Text = "Decrypt";
            this.decryptFileToolStripMenuItem.Click += new System.EventHandler(this.decryptFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // copyFromClipboardToolStripMenuItem
            // 
            this.copyFromClipboardToolStripMenuItem.Name = "copyFromClipboardToolStripMenuItem";
            this.copyFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyFromClipboardToolStripMenuItem.Text = "Copy from clipboard";
            this.copyFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyFromClipboardToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl,
            this.toolStripPrb});
            this.statusStrip.Location = new System.Drawing.Point(0, 369);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(894, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLbl.Text = "ready";
            // 
            // toolStripPrb
            // 
            this.toolStripPrb.Name = "toolStripPrb";
            this.toolStripPrb.Size = new System.Drawing.Size(200, 16);
            // 
            // logDisplayRtb
            // 
            this.logDisplayRtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logDisplayRtb.ContextMenuStrip = this.statusContextMenuStrip;
            this.logDisplayRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logDisplayRtb.ForeColor = System.Drawing.Color.Lime;
            this.logDisplayRtb.Location = new System.Drawing.Point(12, 254);
            this.logDisplayRtb.Name = "logDisplayRtb";
            this.logDisplayRtb.ReadOnly = true;
            this.logDisplayRtb.Size = new System.Drawing.Size(460, 112);
            this.logDisplayRtb.TabIndex = 3;
            this.logDisplayRtb.Text = "";
            // 
            // statusContextMenuStrip
            // 
            this.statusContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveToFileToolStripMenuItem});
            this.statusContextMenuStrip.Name = "statusContextMenuStrip";
            this.statusContextMenuStrip.Size = new System.Drawing.Size(132, 54);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 6);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ExpandBtn.FlatAppearance.BorderSize = 0;
            this.ExpandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandBtn.Location = new System.Drawing.Point(879, 160);
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.Size = new System.Drawing.Size(15, 60);
            this.ExpandBtn.TabIndex = 4;
            this.ExpandBtn.Text = "<";
            this.ExpandBtn.UseVisualStyleBackColor = false;
            this.ExpandBtn.Click += new System.EventHandler(this.ExpandBtn_Click);
            // 
            // cipherTextRtb
            // 
            this.cipherTextRtb.ContextMenuStrip = this.contextMenuStrip;
            this.cipherTextRtb.Location = new System.Drawing.Point(512, 237);
            this.cipherTextRtb.Name = "cipherTextRtb";
            this.cipherTextRtb.ReadOnly = true;
            this.cipherTextRtb.Size = new System.Drawing.Size(356, 129);
            this.cipherTextRtb.TabIndex = 5;
            this.cipherTextRtb.Text = "";
            // 
            // plainTextRtb
            // 
            this.plainTextRtb.Location = new System.Drawing.Point(512, 49);
            this.plainTextRtb.Name = "plainTextRtb";
            this.plainTextRtb.Size = new System.Drawing.Size(356, 137);
            this.plainTextRtb.TabIndex = 6;
            this.plainTextRtb.Text = "";
            // 
            // cipherTextLbl
            // 
            this.cipherTextLbl.AutoSize = true;
            this.cipherTextLbl.Location = new System.Drawing.Point(512, 206);
            this.cipherTextLbl.Name = "cipherTextLbl";
            this.cipherTextLbl.Size = new System.Drawing.Size(57, 13);
            this.cipherTextLbl.TabIndex = 7;
            this.cipherTextLbl.Text = "Cipher text";
            // 
            // plainTextLbl
            // 
            this.plainTextLbl.AutoSize = true;
            this.plainTextLbl.Location = new System.Drawing.Point(512, 24);
            this.plainTextLbl.Name = "plainTextLbl";
            this.plainTextLbl.Size = new System.Drawing.Size(50, 13);
            this.plainTextLbl.TabIndex = 8;
            this.plainTextLbl.Text = "Plain text";
            // 
            // encryptGb
            // 
            this.encryptGb.Controls.Add(this.keyGen);
            this.encryptGb.Controls.Add(this.resetBtn);
            this.encryptGb.Controls.Add(this.encryptBtn);
            this.encryptGb.Controls.Add(this.paddingCb);
            this.encryptGb.Controls.Add(this.paddingLbl);
            this.encryptGb.Controls.Add(this.typeCb);
            this.encryptGb.Controls.Add(this.cipherTypeLbl);
            this.encryptGb.Controls.Add(this.showKeyChbx);
            this.encryptGb.Controls.Add(this.reenterKeyLbl);
            this.encryptGb.Controls.Add(this.reenterTxb);
            this.encryptGb.Controls.Add(this.enterKeyLbl);
            this.encryptGb.Controls.Add(this.keyTxb);
            this.encryptGb.Location = new System.Drawing.Point(12, 38);
            this.encryptGb.Name = "encryptGb";
            this.encryptGb.Size = new System.Drawing.Size(460, 198);
            this.encryptGb.TabIndex = 9;
            this.encryptGb.TabStop = false;
            this.encryptGb.Text = "Encryption";
            // 
            // keyGen
            // 
            this.keyGen.AutoSize = true;
            this.keyGen.ForeColor = System.Drawing.Color.Blue;
            this.keyGen.Location = new System.Drawing.Point(136, 116);
            this.keyGen.Name = "keyGen";
            this.keyGen.Size = new System.Drawing.Size(67, 13);
            this.keyGen.TabIndex = 13;
            this.keyGen.Text = "Random key";
            this.keyGen.Click += new System.EventHandler(this.keyGen_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(132, 158);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.encryptBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.encryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptBtn.Location = new System.Drawing.Point(30, 158);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 11;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // paddingCb
            // 
            this.paddingCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paddingCb.FormattingEnabled = true;
            this.paddingCb.Items.AddRange(new object[] {
            "Regular",
            "Irregular"});
            this.paddingCb.Location = new System.Drawing.Point(252, 89);
            this.paddingCb.Name = "paddingCb";
            this.paddingCb.Size = new System.Drawing.Size(189, 21);
            this.paddingCb.TabIndex = 10;
            // 
            // paddingLbl
            // 
            this.paddingLbl.AutoSize = true;
            this.paddingLbl.Location = new System.Drawing.Point(249, 72);
            this.paddingLbl.Name = "paddingLbl";
            this.paddingLbl.Size = new System.Drawing.Size(49, 13);
            this.paddingLbl.TabIndex = 9;
            this.paddingLbl.Text = "Padding:";
            // 
            // typeCb
            // 
            this.typeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Items.AddRange(new object[] {
            "Columnar",
            "Double",
            "Myszkowski"});
            this.typeCb.Location = new System.Drawing.Point(252, 43);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(189, 21);
            this.typeCb.TabIndex = 6;
            // 
            // cipherTypeLbl
            // 
            this.cipherTypeLbl.AutoSize = true;
            this.cipherTypeLbl.Location = new System.Drawing.Point(249, 27);
            this.cipherTypeLbl.Name = "cipherTypeLbl";
            this.cipherTypeLbl.Size = new System.Drawing.Size(128, 13);
            this.cipherTypeLbl.TabIndex = 5;
            this.cipherTypeLbl.Text = "Transpotision cipher type:";
            // 
            // showKeyChbx
            // 
            this.showKeyChbx.AutoSize = true;
            this.showKeyChbx.Location = new System.Drawing.Point(6, 112);
            this.showKeyChbx.Name = "showKeyChbx";
            this.showKeyChbx.Size = new System.Drawing.Size(73, 17);
            this.showKeyChbx.TabIndex = 4;
            this.showKeyChbx.Text = "Show key";
            this.showKeyChbx.UseVisualStyleBackColor = true;
            this.showKeyChbx.CheckedChanged += new System.EventHandler(this.showKeyChbx_CheckedChanged);
            // 
            // reenterKeyLbl
            // 
            this.reenterKeyLbl.AutoSize = true;
            this.reenterKeyLbl.Location = new System.Drawing.Point(27, 70);
            this.reenterKeyLbl.Name = "reenterKeyLbl";
            this.reenterKeyLbl.Size = new System.Drawing.Size(68, 13);
            this.reenterKeyLbl.TabIndex = 3;
            this.reenterKeyLbl.Text = "Reenter key:";
            // 
            // reenterTxb
            // 
            this.reenterTxb.Location = new System.Drawing.Point(6, 86);
            this.reenterTxb.Name = "reenterTxb";
            this.reenterTxb.Size = new System.Drawing.Size(201, 20);
            this.reenterTxb.TabIndex = 2;
            this.reenterTxb.UseSystemPasswordChar = true;
            // 
            // enterKeyLbl
            // 
            this.enterKeyLbl.AutoSize = true;
            this.enterKeyLbl.Location = new System.Drawing.Point(27, 27);
            this.enterKeyLbl.Name = "enterKeyLbl";
            this.enterKeyLbl.Size = new System.Drawing.Size(55, 13);
            this.enterKeyLbl.TabIndex = 1;
            this.enterKeyLbl.Text = "Enter key:";
            // 
            // keyTxb
            // 
            this.keyTxb.Location = new System.Drawing.Point(6, 43);
            this.keyTxb.Name = "keyTxb";
            this.keyTxb.Size = new System.Drawing.Size(201, 20);
            this.keyTxb.TabIndex = 0;
            this.keyTxb.UseSystemPasswordChar = true;
            // 
            // showHideLbl
            // 
            this.showHideLbl.AutoSize = true;
            this.showHideLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHideLbl.ForeColor = System.Drawing.Color.Blue;
            this.showHideLbl.Location = new System.Drawing.Point(27, 339);
            this.showHideLbl.Name = "showHideLbl";
            this.showHideLbl.Size = new System.Drawing.Size(90, 15);
            this.showHideLbl.TabIndex = 10;
            this.showHideLbl.Text = "Show Detail >>";
            this.showHideLbl.Visible = false;
            this.showHideLbl.Click += new System.EventHandler(this.showHideLbl_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.decryptBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.decryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptBtn.ForeColor = System.Drawing.Color.Black;
            this.decryptBtn.Location = new System.Drawing.Point(772, 200);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(96, 24);
            this.decryptBtn.TabIndex = 11;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 391);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.showHideLbl);
            this.Controls.Add(this.encryptGb);
            this.Controls.Add(this.plainTextLbl);
            this.Controls.Add(this.cipherTextLbl);
            this.Controls.Add(this.plainTextRtb);
            this.Controls.Add(this.cipherTextRtb);
            this.Controls.Add(this.ExpandBtn);
            this.Controls.Add(this.logDisplayRtb);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(910, 430);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transposition cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.statusContextMenuStrip.ResumeLayout(false);
            this.encryptGb.ResumeLayout(false);
            this.encryptGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTranspositionCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ToolStripProgressBar toolStripPrb;
        private System.Windows.Forms.RichTextBox logDisplayRtb;
        private System.Windows.Forms.ToolStripMenuItem hideDetailToolStripMenuItem;
        private System.Windows.Forms.Button ExpandBtn;
        private System.Windows.Forms.RichTextBox cipherTextRtb;
        private System.Windows.Forms.RichTextBox plainTextRtb;
        private System.Windows.Forms.Label cipherTextLbl;
        private System.Windows.Forms.Label plainTextLbl;
        private System.Windows.Forms.GroupBox encryptGb;
        private System.Windows.Forms.CheckBox showKeyChbx;
        private System.Windows.Forms.Label reenterKeyLbl;
        private System.Windows.Forms.TextBox reenterTxb;
        private System.Windows.Forms.Label enterKeyLbl;
        private System.Windows.Forms.TextBox keyTxb;
        private System.Windows.Forms.ComboBox typeCb;
        private System.Windows.Forms.Label cipherTypeLbl;
        private System.Windows.Forms.Label paddingLbl;
        private System.Windows.Forms.ComboBox paddingCb;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ContextMenuStrip statusContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFromClipboardToolStripMenuItem;
        private System.Windows.Forms.Label showHideLbl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label keyGen;
        private System.Windows.Forms.Button decryptBtn;
    }
}

