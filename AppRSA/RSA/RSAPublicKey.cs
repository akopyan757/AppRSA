using System;
using System.IO;
using System.Numerics;
using System.Text;

namespace AppRSA.RSA
{
    class RSAPublicKey
    {
        public static string SUFFIX_NAME = "public";

        private BigInteger _e;
        private BigInteger _n;

        private RSAPublicKey() {}

        public RSAPublicKey(BigInteger e, BigInteger n)
        {
            _e = e;
            _n = n;
        }

        public BigInteger Encrypt(BigInteger value)
        {
            return BigInteger.ModPow(value, _e, _n);
        }

        public static RSAPublicKey LoadFromFile(string path, string passphrase)
        {
            RSAPublicKey publicKey = new RSAPublicKey();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string stringE = sr.ReadLine();
                    string stringD = sr.ReadLine();

                    publicKey._e = BigInteger.Parse(stringE);
                    publicKey._n = BigInteger.Parse(stringD);
                }
            }
            catch (Exception)
            {
                throw new Exception("Неккоректный формат файла!");
            }

            return publicKey;
        }

        public void SaveToFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            // Create a new file     
            using (FileStream fs = File.Create(filename))
            {
                // Add some text to file    
                byte[] eValue = new UTF8Encoding(true).GetBytes(_e.ToString() + Environment.NewLine);
                fs.Write(eValue, 0, eValue.Length);
                byte[] nValue = new UTF8Encoding(true).GetBytes(_n.ToString());
                fs.Write(nValue, 0, nValue.Length);
            }
        }

        public new string ToString => $"PublicKey=(e={_e}, n={_n})";
    }
}
