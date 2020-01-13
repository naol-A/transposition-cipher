namespace transposition_cipher
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.titleLbl = new System.Windows.Forms.Label();
            this.aboutTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.descrLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.memberListLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.aboutTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titleLbl.Location = new System.Drawing.Point(76, 29);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(171, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Transposition cipher";
            // 
            // aboutTabControl
            // 
            this.aboutTabControl.Controls.Add(this.tabPage1);
            this.aboutTabControl.Controls.Add(this.tabPage2);
            this.aboutTabControl.Controls.Add(this.tabPage3);
            this.aboutTabControl.Location = new System.Drawing.Point(12, 79);
            this.aboutTabControl.Name = "aboutTabControl";
            this.aboutTabControl.SelectedIndex = 0;
            this.aboutTabControl.Size = new System.Drawing.Size(300, 170);
            this.aboutTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.descrLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // descrLbl
            // 
            this.descrLbl.AutoSize = true;
            this.descrLbl.Location = new System.Drawing.Point(7, 7);
            this.descrLbl.Name = "descrLbl";
            this.descrLbl.Size = new System.Drawing.Size(283, 117);
            this.descrLbl.TabIndex = 0;
            this.descrLbl.Text = resources.GetString("descrLbl.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.memberListLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group memebers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // memberListLbl
            // 
            this.memberListLbl.AutoSize = true;
            this.memberListLbl.Location = new System.Drawing.Point(7, 7);
            this.memberListLbl.Name = "memberListLbl";
            this.memberListLbl.Size = new System.Drawing.Size(248, 52);
            this.memberListLbl.TabIndex = 0;
            this.memberListLbl.Text = resources.GetString("memberListLbl.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 144);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "license";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(286, 138);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.aboutTabControl);
            this.Controls.Add(this.titleLbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 300);
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.aboutTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TabControl aboutTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label descrLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label memberListLbl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}