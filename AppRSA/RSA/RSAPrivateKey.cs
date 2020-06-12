using System;
using System.IO;
using System.Numerics;
using System.Text;
using AppRSA.AES;

namespace AppRSA.RSA
{
    class RSAPrivateKey
    {
        public static string SUFFIX_NAME = "private";

        private BigInteger _d;
        private BigInteger _n;
        private string encryptedD = "";
        private string encryptedN = "";

        private RSAPrivateKey() {}

        public RSAPrivateKey(BigInteger d, BigInteger n)
        {
            _d = d;
            _n = n;
        }

        public BigInteger Decrypt(BigInteger encryptedValue)
        {
            return BigInteger.ModPow(encryptedValue, _d, _n);
        }

        public void EncryptByPassphrase(string passphrase)
        {
            encryptedD = AES.AES.Encrypt(passphrase, _d.ToString());
            encryptedN = AES.AES.Encrypt(passphrase, _n.ToString());
        }

        public static RSAPrivateKey LoadFromFile(string path, string passphrase)
        {
            RSAPrivateKey privateKey = new RSAPrivateKey();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    privateKey.encryptedD = sr.ReadLine();
                    privateKey.encryptedN = sr.ReadLine();

                    privateKey._d = BigInteger.Parse(AES.AES.Decrypt(passphrase, privateKey.encryptedD));
                    privateKey._n = BigInteger.Parse(AES.AES.Decrypt(passphrase, privateKey.encryptedN));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Неккоректный формат файла!");
            }

            return privateKey;
        }

        public void SaveToFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (FileStream fs = File.Create(fileName))
            {
                byte[] eValue = new UTF8Encoding(true).GetBytes(encryptedD + Environment.NewLine);
                fs.Write(eValue, 0, eValue.Length);
                byte[] nValue = new UTF8Encoding(true).GetBytes(encryptedN);
                fs.Write(nValue, 0, nValue.Length);
            }
        }

        public new string ToString => $"PrivateKey=(d={encryptedD}, n={encryptedN})";
    }
}
