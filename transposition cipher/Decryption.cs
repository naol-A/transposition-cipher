using System;
using System.Windows.Forms;

namespace transposition_cipher
{
    public partial class Decryption : Form
    {
        public string cipher = "";
        public string plain = "";
        public Decryption()
        {
            InitializeComponent();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            switch (typeCb.SelectedIndex)
            {
                case 0:
                    if (keyTxb.Text != "")
                    {
                        plain = Columnar.Decrypt(cipher, keyTxb.Text);
                    }
                    break;
                case 1:
                    if (keyTxb.Text != "")
                    {
                        plain = DoubleTransposition.Decrypt(cipher, keyTxb.Text);
                    }
                    break;
                case 2:
                    if (keyTxb.Text != "")
                    {
                        plain = Myszkowski.Decrypt(cipher, keyTxb.Text);
                    }
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void Decryption_Load(object sender, EventArgs e)
        {
            typeCb.SelectedIndex = 0;
        }

        private void showKeyLnk_Click(object sender, EventArgs e)
        {
            if(showKeyLnk.Text == "show key")
            {
                showKeyLnk.Text = "hide key";
                keyTxb.UseSystemPasswordChar = false;
            }
            else
            {
                showKeyLnk.Text = "show key";
                keyTxb.UseSystemPasswordChar = true;
            }
        }
    }
}
