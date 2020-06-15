using AppRSA.StringUtils;
using System;
using System.Collections.Generic;
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
        
        public BigInteger GetE()
        {
            return _e;
        }

        public BigInteger GetN()
        {
            return _n;
        }

        public BigInteger Encrypt(BigInteger value)
        {
            return BigInteger.ModPow(value, _e, _n);
        }

        public List<BigInteger> Encrypt(List<BigInteger> message)
        {
            List<BigInteger> values = new List<BigInteger>();
            foreach (BigInteger bigInteger in message)
            {
                values.Add(Encrypt(bigInteger));
            }
            return values;
        }

        public string Encrypt(string message)
        {
            List<BigInteger> messageValues = SplitMessages(message);
            List<BigInteger> encrypted = Encrypt(messageValues);
            StringBuilder sb = new StringBuilder();
            foreach (BigInteger value in encrypted)
            {
                sb.Append(value.ToString());
                sb.Append("\n");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static RSAPublicKey LoadFromFile(string path)
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

        /**
         * Private methods
         */
        public List<BigInteger> SplitMessages(string message)
        {
            List<BigInteger> toEncrypt = new List<BigInteger>();
            byte[] bytes = new UTF8Encoding(true).GetBytes(message);
            BigInteger messageBytes = new BigInteger(bytes);

            if (IsModulusSmallerThanMessage(messageBytes))
            {
                List<string> messageList = new List<string> { message };
                toEncrypt = GetValidEncryptionBlocks(StringUtil.SplitUtf8Messages(messageList));
            }
            else
            {
                toEncrypt.Add(messageBytes);
            }

            return toEncrypt;
        }

        private List<BigInteger> GetValidEncryptionBlocks(List<string> messages) {
            List<BigInteger> validBlocks = new List<BigInteger>();
            new UTF8Encoding(true).GetBytes(messages[0]);
            BigInteger messageBytes = new BigInteger(new UTF8Encoding(true).GetBytes(messages[0]));
            if (!IsModulusSmallerThanMessage(messageBytes)) {
                foreach (string msg in messages) {
                    validBlocks.Add(new BigInteger(new UTF8Encoding(true).GetBytes(msg)));
                }
                return validBlocks;
            } else {//message is bigger than modulus so we have o split it
                return GetValidEncryptionBlocks(StringUtil.SplitUtf8Messages(messages));
            }
        }

        private bool IsModulusSmallerThanMessage(BigInteger messageBytes) {
            return BigInteger.Compare(_n, messageBytes) < 0; 
        }
    }
}
