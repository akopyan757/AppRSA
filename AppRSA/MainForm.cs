using AppRSA.RSA;
using System;
using System.IO;
using System.Windows.Forms;

namespace AppRSA
{
    public partial class MainForm : Form
    {

        RSAKeyInstance rsaGenerator = new RSAKeyInstance();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateKey_Click(object sender, EventArgs e)
        {
            if (textBoxCreateKeyName.Text.Length == 0)
            {
                MessageBox.Show("Введите название ключа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxCreateKeyPassprase.Text.Length == 0)
            {
                MessageBox.Show("Введите парольную фразу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int moduleSize = (int) numericCreateKeySize.Value;
            rsaGenerator.generateNewKeys(textBoxCreateKeyName.Text, textBoxCreateKeyPassprase.Text, moduleSize);
            textBoxCreateKeyMessage.Text = rsaGenerator.ToHelpMessage();
            button3.Enabled = true;
        }

        private void buttonCreateKeyClear_Click(object sender, EventArgs e)
        {
            textBoxCreateKeyMessage.Text = "";
            textBoxCreateKeyName.Clear();
            textBoxCreateKeyPassprase.Clear();
            numericCreateKeySize.Value = 20;
            rsaGenerator.Clear();
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog oPrivateDialog = new SaveFileDialog();
            oPrivateDialog.Title = "Save private key to File";
            oPrivateDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            oPrivateDialog.FileName = textBoxCreateKeyName.Text;
            oPrivateDialog.Filter = "Private key (*.private)|*.private";
            if (oPrivateDialog.ShowDialog() == DialogResult.OK)
            {
                rsaGenerator.GetPrivateKey().SaveToFile(oPrivateDialog.FileName);
            }

            SaveFileDialog oPublicDialog = new SaveFileDialog();
            oPublicDialog.Title = "Save public key to File";
            oPublicDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            oPublicDialog.FileName = textBoxCreateKeyName.Text;
            oPublicDialog.Filter = "Public key (*.public)|*.public";
            if (oPublicDialog.ShowDialog() == DialogResult.OK)
            {
                rsaGenerator.GetPublicKey().SaveToFile(oPublicDialog.FileName);
            }
        }
    }
}
