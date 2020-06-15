using AppRSA.RSA;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AppRSA
{
    public partial class MainForm : Form
    {

        RSAKeyGenerator rsaGenerator = new RSAKeyGenerator();
        RSAPublicKey publicKey;
        RSAPrivateKey privateKey;

        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * Create Key Tab
         */
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

        /**
         * Encrypt message Tab
         */
        private void buttonEncryptChoosePublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose public key";
            openFileDialog.Filter = "Public key (*.public)|*.public";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelEncryptPublicKeyFile.Text = Path.GetFileName(openFileDialog.FileName);
                publicKey = RSAPublicKey.LoadFromFile(openFileDialog.FileName);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryptMessage.Text.Length == 0)
            {
                MessageBox.Show("Введите текст сообщения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (publicKey == null)
            {
                MessageBox.Show("Выберете открытый ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            textBoxEncryptedText.Text = publicKey.Encrypt(textBoxEncryptMessage.Text);
            buttonEncryptSave.Enabled = true;
            textBoxEncryptMessage.Text = "";
            labelEncryptPublicKeyFile.Text = "";
            publicKey = null;
        }

        private void buttonEncryptSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save encrypted text to File";
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog.Filter = "Encrypted Text (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                {
                    File.Delete(saveFileDialog.FileName);
                }

                using (FileStream fs = File.Create(saveFileDialog.FileName))
                {
                    byte[] encryptedBytes = new UTF8Encoding(true).GetBytes(textBoxEncryptedText.Text);
                    fs.Write(encryptedBytes, 0, encryptedBytes.Length);
                }

                textBoxEncryptedText.Text = "";
                buttonEncryptSave.Enabled = false;
            }
        }

        /**
         * Decrypt message Tab
         */
        private void buttonDecryptImportPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose encrypted text";
            openFileDialog.Filter = "Encrypted text (*.txt)|*.txt";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                privateKey = RSAPrivateKey.LoadFromFile(openFileDialog.FileName);
                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    textBoxDecryptText.Text = sr.ReadToEnd();
                }
            }
        }

        private void buttonDecryptChoosePblicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose private key";
            openFileDialog.Filter = "Private key (*.private)|*.private";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelDecryptPrivateKey.Text = Path.GetFileName(openFileDialog.FileName);
                privateKey = RSAPrivateKey.LoadFromFile(openFileDialog.FileName);
                //label5.Text = AES.AES.Decrypt(textBoxEDecryptPassphrase.Text, privateKey.encryptedN);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDecryptText.Text.Length == 0)
            {
                MessageBox.Show("Введите текст зашифрованного сообщения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (privateKey == null)
            {
                MessageBox.Show("Выберете закрытый ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxEDecryptPassphrase.Text.Length == 0)
            {
                MessageBox.Show("Введите парольную фразу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                privateKey.DecryptByPassphrase(textBoxEDecryptPassphrase.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверная парольная фраза!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string decryption = privateKey.Decrypt(textBoxDecryptText.Text);

            textBoxDecryptMessage.Text = decryption;

            textBoxDecryptText.Text = "";
            textBoxEDecryptPassphrase.Text = "";
            labelDecryptPrivateKey.Text = "";
            privateKey = null;
        }
    }
}
