namespace AppRSA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonEncryptSave = new System.Windows.Forms.Button();
            this.textBoxEncryptedText = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEncryptPublicKeyFile = new System.Windows.Forms.Label();
            this.buttonEncryptChoosePublicKey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEncryptMessage = new System.Windows.Forms.TextBox();
            this.tabPageDecrypt = new System.Windows.Forms.TabPage();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDecryptMessage = new System.Windows.Forms.TextBox();
            this.textBoxEDecryptPassphrase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDecryptPrivateKey = new System.Windows.Forms.Label();
            this.buttonDecryptChoosePblicKey = new System.Windows.Forms.Button();
            this.buttonDecryptImportPublicKey = new System.Windows.Forms.Button();
            this.textBoxDecryptText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageKeys = new System.Windows.Forms.TabPage();
            this.textBoxCreateKeyMessage = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCreateKeyClear = new System.Windows.Forms.Button();
            this.textBoxCreateKeyPassprase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericCreateKeySize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateKey = new System.Windows.Forms.Button();
            this.textBoxCreateKeyName = new System.Windows.Forms.TextBox();
            this.tabPageAboutProgram = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageDecrypt.SuspendLayout();
            this.tabPageKeys.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreateKeySize)).BeginInit();
            this.tabPageAboutProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPageDecrypt);
            this.tabControl.Controls.Add(this.tabPageKeys);
            this.tabControl.Controls.Add(this.tabPageAboutProgram);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(503, 443);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEncryptSave);
            this.tabPage1.Controls.Add(this.textBoxEncryptedText);
            this.tabPage1.Controls.Add(this.buttonEncrypt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelEncryptPublicKeyFile);
            this.tabPage1.Controls.Add(this.buttonEncryptChoosePublicKey);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxEncryptMessage);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptSave
            // 
            this.buttonEncryptSave.Enabled = false;
            this.buttonEncryptSave.Location = new System.Drawing.Point(320, 375);
            this.buttonEncryptSave.Name = "buttonEncryptSave";
            this.buttonEncryptSave.Size = new System.Drawing.Size(166, 27);
            this.buttonEncryptSave.TabIndex = 7;
            this.buttonEncryptSave.Text = "Save encrypted text";
            this.buttonEncryptSave.UseVisualStyleBackColor = true;
            this.buttonEncryptSave.Click += new System.EventHandler(this.buttonEncryptSave_Click);
            // 
            // textBoxEncryptedText
            // 
            this.textBoxEncryptedText.Location = new System.Drawing.Point(7, 249);
            this.textBoxEncryptedText.Multiline = true;
            this.textBoxEncryptedText.Name = "textBoxEncryptedText";
            this.textBoxEncryptedText.ReadOnly = true;
            this.textBoxEncryptedText.Size = new System.Drawing.Size(479, 120);
            this.textBoxEncryptedText.TabIndex = 6;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(409, 151);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(77, 30);
            this.buttonEncrypt.TabIndex = 5;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Encrypted text";
            // 
            // labelEncryptPublicKeyFile
            // 
            this.labelEncryptPublicKeyFile.AutoSize = true;
            this.labelEncryptPublicKeyFile.Location = new System.Drawing.Point(163, 154);
            this.labelEncryptPublicKeyFile.Name = "labelEncryptPublicKeyFile";
            this.labelEncryptPublicKeyFile.Size = new System.Drawing.Size(0, 20);
            this.labelEncryptPublicKeyFile.TabIndex = 3;
            // 
            // buttonEncryptChoosePublicKey
            // 
            this.buttonEncryptChoosePublicKey.Location = new System.Drawing.Point(6, 149);
            this.buttonEncryptChoosePublicKey.Name = "buttonEncryptChoosePublicKey";
            this.buttonEncryptChoosePublicKey.Size = new System.Drawing.Size(151, 30);
            this.buttonEncryptChoosePublicKey.TabIndex = 2;
            this.buttonEncryptChoosePublicKey.Text = "Choose public key";
            this.buttonEncryptChoosePublicKey.UseVisualStyleBackColor = true;
            this.buttonEncryptChoosePublicKey.Click += new System.EventHandler(this.buttonEncryptChoosePublicKey_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Message";
            // 
            // textBoxEncryptMessage
            // 
            this.textBoxEncryptMessage.Location = new System.Drawing.Point(7, 44);
            this.textBoxEncryptMessage.Multiline = true;
            this.textBoxEncryptMessage.Name = "textBoxEncryptMessage";
            this.textBoxEncryptMessage.Size = new System.Drawing.Size(479, 99);
            this.textBoxEncryptMessage.TabIndex = 0;
            // 
            // tabPageDecrypt
            // 
            this.tabPageDecrypt.Controls.Add(this.buttonDecrypt);
            this.tabPageDecrypt.Controls.Add(this.label11);
            this.tabPageDecrypt.Controls.Add(this.textBoxDecryptMessage);
            this.tabPageDecrypt.Controls.Add(this.textBoxEDecryptPassphrase);
            this.tabPageDecrypt.Controls.Add(this.label10);
            this.tabPageDecrypt.Controls.Add(this.labelDecryptPrivateKey);
            this.tabPageDecrypt.Controls.Add(this.buttonDecryptChoosePblicKey);
            this.tabPageDecrypt.Controls.Add(this.buttonDecryptImportPublicKey);
            this.tabPageDecrypt.Controls.Add(this.textBoxDecryptText);
            this.tabPageDecrypt.Controls.Add(this.label8);
            this.tabPageDecrypt.Location = new System.Drawing.Point(4, 29);
            this.tabPageDecrypt.Name = "tabPageDecrypt";
            this.tabPageDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecrypt.Size = new System.Drawing.Size(495, 410);
            this.tabPageDecrypt.TabIndex = 1;
            this.tabPageDecrypt.Text = "Decrypt";
            this.tabPageDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(405, 246);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(80, 30);
            this.buttonDecrypt.TabIndex = 16;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Message";
            // 
            // textBoxDecryptMessage
            // 
            this.textBoxDecryptMessage.Location = new System.Drawing.Point(6, 298);
            this.textBoxDecryptMessage.Multiline = true;
            this.textBoxDecryptMessage.Name = "textBoxDecryptMessage";
            this.textBoxDecryptMessage.ReadOnly = true;
            this.textBoxDecryptMessage.Size = new System.Drawing.Size(479, 93);
            this.textBoxDecryptMessage.TabIndex = 14;
            // 
            // textBoxEDecryptPassphrase
            // 
            this.textBoxEDecryptPassphrase.Location = new System.Drawing.Point(6, 195);
            this.textBoxEDecryptPassphrase.Multiline = true;
            this.textBoxEDecryptPassphrase.Name = "textBoxEDecryptPassphrase";
            this.textBoxEDecryptPassphrase.Size = new System.Drawing.Size(478, 45);
            this.textBoxEDecryptPassphrase.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Passphrase for private key";
            // 
            // labelDecryptPrivateKey
            // 
            this.labelDecryptPrivateKey.AutoSize = true;
            this.labelDecryptPrivateKey.Location = new System.Drawing.Point(165, 130);
            this.labelDecryptPrivateKey.Name = "labelDecryptPrivateKey";
            this.labelDecryptPrivateKey.Size = new System.Drawing.Size(0, 20);
            this.labelDecryptPrivateKey.TabIndex = 11;
            // 
            // buttonDecryptChoosePblicKey
            // 
            this.buttonDecryptChoosePblicKey.Location = new System.Drawing.Point(8, 125);
            this.buttonDecryptChoosePblicKey.Name = "buttonDecryptChoosePblicKey";
            this.buttonDecryptChoosePblicKey.Size = new System.Drawing.Size(151, 30);
            this.buttonDecryptChoosePblicKey.TabIndex = 10;
            this.buttonDecryptChoosePblicKey.Text = "Choose private key";
            this.buttonDecryptChoosePblicKey.UseVisualStyleBackColor = true;
            this.buttonDecryptChoosePblicKey.Click += new System.EventHandler(this.buttonDecryptChoosePblicKey_Click);
            // 
            // buttonDecryptImportPublicKey
            // 
            this.buttonDecryptImportPublicKey.Location = new System.Drawing.Point(305, 14);
            this.buttonDecryptImportPublicKey.Name = "buttonDecryptImportPublicKey";
            this.buttonDecryptImportPublicKey.Size = new System.Drawing.Size(181, 27);
            this.buttonDecryptImportPublicKey.TabIndex = 9;
            this.buttonDecryptImportPublicKey.Text = "Import encrypted text";
            this.buttonDecryptImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonDecryptImportPublicKey.Click += new System.EventHandler(this.buttonDecryptImportPublicKey_Click);
            // 
            // textBoxDecryptText
            // 
            this.textBoxDecryptText.Location = new System.Drawing.Point(8, 47);
            this.textBoxDecryptText.Multiline = true;
            this.textBoxDecryptText.Name = "textBoxDecryptText";
            this.textBoxDecryptText.Size = new System.Drawing.Size(479, 77);
            this.textBoxDecryptText.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Encrypted text";
            // 
            // tabPageKeys
            // 
            this.tabPageKeys.Controls.Add(this.textBoxCreateKeyMessage);
            this.tabPageKeys.Controls.Add(this.button3);
            this.tabPageKeys.Controls.Add(this.label6);
            this.tabPageKeys.Controls.Add(this.groupBox3);
            this.tabPageKeys.Location = new System.Drawing.Point(4, 29);
            this.tabPageKeys.Name = "tabPageKeys";
            this.tabPageKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeys.Size = new System.Drawing.Size(495, 410);
            this.tabPageKeys.TabIndex = 2;
            this.tabPageKeys.Text = "Keys";
            this.tabPageKeys.UseVisualStyleBackColor = true;
            // 
            // textBoxCreateKeyMessage
            // 
            this.textBoxCreateKeyMessage.Location = new System.Drawing.Point(13, 207);
            this.textBoxCreateKeyMessage.Multiline = true;
            this.textBoxCreateKeyMessage.Name = "textBoxCreateKeyMessage";
            this.textBoxCreateKeyMessage.ReadOnly = true;
            this.textBoxCreateKeyMessage.Size = new System.Drawing.Size(476, 158);
            this.textBoxCreateKeyMessage.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(411, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCreateKeyClear);
            this.groupBox3.Controls.Add(this.textBoxCreateKeyPassprase);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericCreateKeySize);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonCreateKey);
            this.groupBox3.Controls.Add(this.textBoxCreateKeyName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 197);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create key";
            // 
            // buttonCreateKeyClear
            // 
            this.buttonCreateKeyClear.Location = new System.Drawing.Point(327, 156);
            this.buttonCreateKeyClear.Name = "buttonCreateKeyClear";
            this.buttonCreateKeyClear.Size = new System.Drawing.Size(75, 31);
            this.buttonCreateKeyClear.TabIndex = 12;
            this.buttonCreateKeyClear.Text = "Clear";
            this.buttonCreateKeyClear.UseVisualStyleBackColor = true;
            this.buttonCreateKeyClear.UseWaitCursor = true;
            this.buttonCreateKeyClear.Click += new System.EventHandler(this.buttonCreateKeyClear_Click);
            // 
            // textBoxCreateKeyPassprase
            // 
            this.textBoxCreateKeyPassprase.Location = new System.Drawing.Point(10, 96);
            this.textBoxCreateKeyPassprase.Multiline = true;
            this.textBoxCreateKeyPassprase.Name = "textBoxCreateKeyPassprase";
            this.textBoxCreateKeyPassprase.Size = new System.Drawing.Size(473, 54);
            this.textBoxCreateKeyPassprase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passphrase for private key";
            // 
            // numericCreateKeySize
            // 
            this.numericCreateKeySize.Location = new System.Drawing.Point(417, 30);
            this.numericCreateKeySize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericCreateKeySize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericCreateKeySize.Name = "numericCreateKeySize";
            this.numericCreateKeySize.Size = new System.Drawing.Size(66, 26);
            this.numericCreateKeySize.TabIndex = 3;
            this.numericCreateKeySize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of key";
            // 
            // buttonCreateKey
            // 
            this.buttonCreateKey.Location = new System.Drawing.Point(408, 156);
            this.buttonCreateKey.Name = "buttonCreateKey";
            this.buttonCreateKey.Size = new System.Drawing.Size(75, 31);
            this.buttonCreateKey.TabIndex = 7;
            this.buttonCreateKey.Text = "Create";
            this.buttonCreateKey.UseVisualStyleBackColor = true;
            this.buttonCreateKey.Click += new System.EventHandler(this.buttonCreateKey_Click);
            // 
            // textBoxCreateKeyName
            // 
            this.textBoxCreateKeyName.Location = new System.Drawing.Point(109, 30);
            this.textBoxCreateKeyName.MaxLength = 20;
            this.textBoxCreateKeyName.Name = "textBoxCreateKeyName";
            this.textBoxCreateKeyName.Size = new System.Drawing.Size(192, 26);
            this.textBoxCreateKeyName.TabIndex = 2;
            // 
            // tabPageAboutProgram
            // 
            this.tabPageAboutProgram.Controls.Add(this.label19);
            this.tabPageAboutProgram.Controls.Add(this.label18);
            this.tabPageAboutProgram.Controls.Add(this.label17);
            this.tabPageAboutProgram.Controls.Add(this.label16);
            this.tabPageAboutProgram.Controls.Add(this.label15);
            this.tabPageAboutProgram.Controls.Add(this.label14);
            this.tabPageAboutProgram.Controls.Add(this.label13);
            this.tabPageAboutProgram.Controls.Add(this.label12);
            this.tabPageAboutProgram.Controls.Add(this.label9);
            this.tabPageAboutProgram.Location = new System.Drawing.Point(4, 29);
            this.tabPageAboutProgram.Name = "tabPageAboutProgram";
            this.tabPageAboutProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAboutProgram.Size = new System.Drawing.Size(495, 410);
            this.tabPageAboutProgram.TabIndex = 3;
            this.tabPageAboutProgram.Text = "About program";
            this.tabPageAboutProgram.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(379, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Курсовой проект по курсу \"Защита информации\"";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Преподаватель: Хорев В.П.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Студент: Акопян А.А.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Группа: ИД-0201-17";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(430, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Тема: Программная реализация криптоалгоритма RSA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(204, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Функционал приложения:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "* Создание ключей";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 311);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(277, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "* Шифрование по открытому ключу";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(54, 331);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(284, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "* Расшифровка по закрытому ключу";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 443);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "RSA";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageDecrypt.ResumeLayout(false);
            this.tabPageDecrypt.PerformLayout();
            this.tabPageKeys.ResumeLayout(false);
            this.tabPageKeys.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreateKeySize)).EndInit();
            this.tabPageAboutProgram.ResumeLayout(false);
            this.tabPageAboutProgram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageDecrypt;
        private System.Windows.Forms.TabPage tabPageKeys;
        private System.Windows.Forms.TabPage tabPageAboutProgram;
        private System.Windows.Forms.TextBox textBoxCreateKeyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCreateKeyPassprase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericCreateKeySize;
        private System.Windows.Forms.Button buttonCreateKeyClear;
        private System.Windows.Forms.Button buttonCreateKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncryptMessage;
        private System.Windows.Forms.TextBox textBoxCreateKeyMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonEncryptSave;
        private System.Windows.Forms.TextBox textBoxEncryptedText;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEncryptPublicKeyFile;
        private System.Windows.Forms.Button buttonEncryptChoosePublicKey;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDecryptMessage;
        private System.Windows.Forms.TextBox textBoxEDecryptPassphrase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDecryptPrivateKey;
        private System.Windows.Forms.Button buttonDecryptChoosePblicKey;
        private System.Windows.Forms.Button buttonDecryptImportPublicKey;
        private System.Windows.Forms.TextBox textBoxDecryptText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
    }
}

