namespace transposition_cipher
{
    partial class Decryption
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
            this.keyLbl = new System.Windows.Forms.Label();
            this.keyTxb = new System.Windows.Forms.TextBox();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.showKeyLnk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Location = new System.Drawing.Point(30, 81);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(28, 13);
            this.keyLbl.TabIndex = 0;
            this.keyLbl.Text = "Key:";
            // 
            // keyTxb
            // 
            this.keyTxb.Location = new System.Drawing.Point(33, 97);
            this.keyTxb.Name = "keyTxb";
            this.keyTxb.Size = new System.Drawing.Size(269, 20);
            this.keyTxb.TabIndex = 1;
            this.keyTxb.UseSystemPasswordChar = true;
            // 
            // typeCb
            // 
            this.typeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Items.AddRange(new object[] {
            "Columnar",
            "Double",
            "Myszkowski"});
            this.typeCb.Location = new System.Drawing.Point(33, 46);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(219, 21);
            this.typeCb.TabIndex = 2;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(30, 30);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(128, 13);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Transposition cipher type:";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(122, 133);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(91, 32);
            this.decryptBtn.TabIndex = 4;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // showKeyLnk
            // 
            this.showKeyLnk.AutoSize = true;
            this.showKeyLnk.ForeColor = System.Drawing.Color.Blue;
            this.showKeyLnk.Location = new System.Drawing.Point(30, 120);
            this.showKeyLnk.Name = "showKeyLnk";
            this.showKeyLnk.Size = new System.Drawing.Size(52, 13);
            this.showKeyLnk.TabIndex = 5;
            this.showKeyLnk.Text = "show key";
            this.showKeyLnk.Click += new System.EventHandler(this.showKeyLnk_Click);
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.showKeyLnk);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.keyTxb);
            this.Controls.Add(this.keyLbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 240);
            this.Name = "Decryption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Decryption";
            this.Load += new System.EventHandler(this.Decryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyLbl;
        private System.Windows.Forms.TextBox keyTxb;
        private System.Windows.Forms.ComboBox typeCb;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label showKeyLnk;
    }
}