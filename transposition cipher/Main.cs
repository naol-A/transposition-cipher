using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace transposition_cipher
{
    public partial class Main : Form
    {
        private string saveFileName = "";
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void log(string text)
        {
            logDisplayRtb.Text += text+"\n";
        }
        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            Size sz = new Size();
            Point lc = new Point();
            if (MinimumSize.Width == 510)
            {
                ExpandBtn.Text = "<";
                sz.Width = 910;
                sz.Height = 430;
                lc.X = 879;
                lc.Y = 160;
                ExpandBtn.Location = lc;
                MinimumSize = sz;
                plainTextLbl.Visible =
                    cipherTextLbl.Visible =
                    plainTextRtb.Visible =
                    cipherTextRtb.Visible = 
                    decryptBtn.Visible = true;
            }
            else
            {
                ExpandBtn.Text = ">";
                sz.Width = 510;
                sz.Height = 430;
                lc.X = 479;
                lc.Y = 160;
                ExpandBtn.Location = lc;
                MaximumSize = sz;
                plainTextLbl.Visible =
                    cipherTextLbl.Visible =
                    plainTextRtb.Visible =
                    cipherTextRtb.Visible =
                    decryptBtn.Visible = false;
            }
        }

        private void aboutTranspositionCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void showKeyChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (showKeyChbx.Checked == true)
            {
                reenterKeyLbl.Visible = reenterTxb.Visible = false;
                keyTxb.UseSystemPasswordChar = false;
            }
            else
            {
                reenterKeyLbl.Visible = reenterTxb.Visible = true;
                keyTxb.UseSystemPasswordChar = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            log("---Transposition cipher---");
            log("version 1.0");
            toolTip.SetToolTip(typeCb, "variation of transposition cipher used to encrypt");
            toolTip.SetToolTip(paddingCb, "how empty spaces are handled");
            paddingCb.SelectedIndex = 0;
            typeCb.SelectedIndex = 0;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logDisplayRtb.Text = string.Empty;
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text file(*.txt)|*.txt|log file(*.log)|*.log";
            sf.ShowDialog();
            filename = sf.FileName;
            if (filename != string.Empty)
            {
                StreamWriter wf = new StreamWriter(filename);
                wf.Write(logDisplayRtb.Text);
                wf.Close();
            }
        }

        private void hideDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logDisplayRtb.Visible == true)
            {
                logDisplayRtb.Visible = false;
                hideDetailToolStripMenuItem.Text = "Show detail";
                showHideLbl.Visible = true;
            }
            else
            {
                logDisplayRtb.Visible = true;
                hideDetailToolStripMenuItem.Text = "Hide detail";
                showHideLbl.Visible = false;
            }
        }

        private void showHideLbl_Click(object sender, EventArgs e)
        {
            hideDetailToolStripMenuItem_Click(sender,e);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hp = new Help();
            hp.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "All file(*.*)|*.*|Text file(*.txt)|*.txt|Transpostion cipher file(*.Tcf)|*.tcf";
            of.ShowDialog();
            filename = of.FileName;
            if (filename != "")
            {
                StreamReader rf = new StreamReader(filename);
                if (of.FilterIndex == 3||of.FileName.EndsWith(".tcf"))
                {
                    log("cipher text file \"" + of.FileName + "\" opened");
                    cipherTextRtb.Text = rf.ReadToEnd();
                }
                else
                {
                    log("plain text file \"" + of.FileName + "\" opened");
                    plainTextRtb.Text = rf.ReadToEnd();
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            logDisplayRtb.Text = "";
            log("---Transposition cipher---");
            log("version 1.0");
            plainTextRtb.Text = "";
            cipherTextRtb.Text = "";
            keyTxb.Text = reenterTxb.Text = "";
            showKeyChbx.Checked = false;
            typeCb.SelectedIndex = 0;
            paddingCb.SelectedIndex = 0;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("are you sure you want to exit","notice",MessageBoxButtons.YesNo)==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if(((!showKeyChbx.Checked &&
                (keyTxb.Text != "" &&
                reenterTxb.Text!="")&&
                (keyTxb.Text==reenterTxb.Text)) ||
                (showKeyChbx.Checked && keyTxb.Text!="")) &&
                plainTextRtb.Text != "")
            {   
                if (typeCb.SelectedIndex == 0)
                {
                    cipherTextRtb.Text = Columnar.Encrypt(plainTextRtb.Text,
                        keyTxb.Text,
                        paddingCb.SelectedIndex == 0 ? true : false);
                    logDisplayRtb.Text += "Cipher type: columnar cipher \n";
                    logDisplayRtb.Text += "padding: "+ (paddingCb.SelectedIndex == 0 ? true : false)+"\n";
                }
                else if (typeCb.SelectedIndex == 1)
                {
                    cipherTextRtb.Text = DoubleTransposition.Encrypt(plainTextRtb.Text,
                        keyTxb.Text,
                        paddingCb.SelectedIndex == 0 ? true : false);
                    logDisplayRtb.Text += "Cipher type: double cipher \n";
                    logDisplayRtb.Text += "padding: " + (paddingCb.SelectedIndex == 0 ? true : false) + "\n";
                }
                else if (typeCb.SelectedIndex == 2)
                {
                    cipherTextRtb.Text = Myszkowski.Encrypt(plainTextRtb.Text,
                        keyTxb.Text,
                        paddingCb.SelectedIndex == 0 ? true : false);
                    logDisplayRtb.Text += "Cipher type: myszowski cipher \n";
                    logDisplayRtb.Text += "padding: " + (paddingCb.SelectedIndex == 0 ? true : false) + "\n";
                }
            }
            else if((!showKeyChbx.Checked &&
                (keyTxb.Text == "" ||
                reenterTxb.Text == ""))&&
                plainTextRtb.Text != "")
            {
                if (keyTxb.Text == "")
                {
                    toolTip.Show("enter a key first", this,
                        keyTxb.Location.X, keyTxb.Location.Y, 2000);
                }
                else
                {
                    toolTip.Show("reenter the key first", this, 
                        reenterTxb.Location.X, reenterTxb.Location.Y, 2000);
                }
            }
            else if (((!showKeyChbx.Checked &&
                (keyTxb.Text != "" &&
                reenterTxb.Text != "") &&
                (keyTxb.Text == reenterTxb.Text))||
                (showKeyChbx.Checked && keyTxb.Text!="")) &&
                plainTextRtb.Text == "")
            {
                toolTip.Show("no plain text to encrpt!\n provide a text",this,
                    plainTextRtb.Location.X, plainTextRtb.Location.Y, 2000);
            }
            else if((!showKeyChbx.Checked &&
                (keyTxb.Text != "" &&
                reenterTxb.Text != "") &&
                (keyTxb.Text != reenterTxb.Text)))
            {
                toolTip.Show("reentered key not the same\n check your key", this, 
                    reenterTxb.Location.X, reenterTxb.Location.Y, 2000);
            }
            else if (showKeyChbx.Checked && keyTxb.Text == "")
            {
                toolTip.Show("enter a key first", this,
                        keyTxb.Location.X, keyTxb.Location.Y, 2000);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Decryption dcr = new Decryption();
            if (cipherTextRtb.Text != "")
            {
                dcr.cipher = cipherTextRtb.Text;
                dcr.ShowDialog();
                plainTextRtb.Text = dcr.plain;
            }
            else
            {
                toolTip.Show("no text to decrypt. load from file",this,
                    decryptBtn.Location.X,decryptBtn.Location.Y,2000);
            }
        }

        private void keyGen_Click(object sender, EventArgs e)
        {
            showKeyChbx.Checked = true;
            Random rand = new Random();
            keyTxb.Text = "";

            for (int i=rand.Next(3,8); i>0; i--)
            {
                keyTxb.Text += (char)rand.Next(65,90);
            }
            reenterTxb.Text = keyTxb.Text;
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Transposition cipher file(*.tcf)|*.tcf|All files(*.*)|*.*";
            sf.ShowDialog();
            saveFileName = sf.FileName;
            if (saveFileName != "" && cipherTextRtb.Text != "" && plainTextRtb.Text != "")
            {
                StreamWriter svf = new StreamWriter(saveFileName);
                if (saveFileName.EndsWith(".tcf"))
                {
                    svf.Write(cipherTextRtb.Text);
                    logDisplayRtb.Text += "cipher text saved to file "+saveFileName;
                }
                else
                {
                    svf.Write(plainTextRtb.Text);
                    logDisplayRtb.Text += "plain text saved to file " + saveFileName;
                }
                svf.Close();
            }
            else
            {
                if (cipherTextRtb.Text == "")
                {
                    toolTip.Show("no cipher text is not found", this,
                        cipherTextRtb.Location.X, cipherTextRtb.Location.Y, 3000);
                }
                else if (plainTextRtb.Text == "")
                {
                    toolTip.Show("no plain text is not found", this,
                        plainTextRtb.Location.X, plainTextRtb.Location.Y, 3000);
                }
            }
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decryptBtn_Click(sender,e);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cipherTextRtb.Text != "")
            {
                Clipboard.SetText(cipherTextRtb.Text);
            }
            else
            {
                toolTip.Show("no text to copy", this, 
                    cipherTextRtb.Location.X,cipherTextRtb.Location.Y,3000);
            }
        }

        private void copyFromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                cipherTextRtb.Text = Clipboard.GetText();
            }
        }
    }
}
