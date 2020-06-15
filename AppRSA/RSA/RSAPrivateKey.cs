using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using AppRSA.AES;
using AppRSA.StringUtils;

namespace AppRSA.RSA
{
    class RSAPrivateKey
    {
        public static string SUFFIX_NAME = "private";

        private BigInteger _d;
        private BigInteger _n;
        public string encryptedD = "";
        public string encryptedN = "";

        private RSAPrivateKey() {}

        public RSAPrivateKey(BigInteger d, BigInteger n)
        {
            _d = d;
            _n = n;
        }

        public BigInteger GetD()
        {
            return _d;
        }

        public BigInteger GetN()
        {
            return _n;
        }

        public BigInteger Decrypt(BigInteger encryptedValue)
        {
            return BigInteger.ModPow(encryptedValue, _d, _n);
        }

        public List<BigInteger> Decrypt(List<BigInteger> encryption)
        {
            List<BigInteger> decryption = new List<BigInteger>();
            foreach (BigInteger bigInteger in encryption)
            {
                decryption.Add(Decrypt(bigInteger));
            }
            return decryption;
        }

        public string Decrypt(string encryption)
        {
            List<string> encryptString = encryption.Split('\n').ToList();
            List<BigInteger> encryptValue = new List<BigInteger>();
            foreach (string msg in encryptString)
            {
                encryptValue.Add(BigInteger.Parse(msg));
            }

            List<BigInteger> decryptValue = Decrypt(encryptValue);

            return StringUtil.JoinUtf8Messages(decryptValue);
        }

        public void EncryptByPassphrase(string passphrase)
        {
            encryptedD = AES.AES.Encrypt(passphrase, _d.ToString());
            encryptedN = AES.AES.Encrypt(passphrase, _n.ToString());
        }

        public void DecryptByPassphrase(string passphrase)
        {
            _d = BigInteger.Parse(AES.AES.Decrypt(passphrase, encryptedD));
            _n = BigInteger.Parse(AES.AES.Decrypt(passphrase, encryptedN));
        }

        public static RSAPrivateKey LoadFromFile(string path)
        {
            RSAPrivateKey privateKey = new RSAPrivateKey();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    privateKey.encryptedD = sr.ReadLine();
                    privateKey.encryptedN = sr.ReadLine();
                }
            }
            catch (Exception)
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
