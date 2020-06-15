using System;
using System.Numerics;

namespace AppRSA.RSA
{
    class RSAKeyGenerator
    {
        private BigInteger p;
        private BigInteger q;
        private BigInteger n;
        private BigInteger phi;

        private BigInteger e;
        private BigInteger d;

        private RSAPrivateKey privateKey;
        private RSAPublicKey publicKey;

        private string _keyName;

        

        public void generateNewKeys(string keyName, string passphrase, int moduleSize)
        {
            BigInteger testValue = 0;
            do
            {
                p = PrimeNumberGenerator.GeneratePrimeNumber(moduleSize / 2);
                q = PrimeNumberGenerator.GeneratePrimeNumber(moduleSize / 2);
                n = BigInteger.Multiply(p, q);
                phi = BigInteger.Multiply(BigInteger.Subtract(p, 1), BigInteger.Subtract(q, 1));

                e = PrimeNumberGenerator.GenerateMutuallyPrimeNumber(phi, moduleSize / 2);
                d = PrimeNumberGenerator.MultiplicativelyInverseNumber(phi, e);

                if (BigInteger.Compare(e, 0) < 0) continue;
                if (BigInteger.Compare(d, 0) < 0) continue;

                publicKey = new RSAPublicKey(e, n);
                privateKey = new RSAPrivateKey(d, n);
                privateKey.EncryptByPassphrase(passphrase);

                testValue = privateKey.Decrypt(publicKey.Encrypt(TEST_VALUE));
            } while (!BigInteger.Equals(testValue, TEST_VALUE));

            _keyName = keyName;
        }

        public void Clear()
        {
            p = 0;
            q = 0;
            n = 0;
            phi = 0;
            e = 0;
            d = 0;
            privateKey = null;
            publicKey = null;
            _keyName = "";
        }

        public RSAPrivateKey GetPrivateKey()
        {
            return privateKey;
        }

        public RSAPublicKey GetPublicKey()
        {
            return publicKey;
        }

        public string ToHelpMessage()
        {
            return string.Format(
                $"p = {p}{Environment.NewLine}" +
                $"q = {q}{Environment.NewLine}" +
                $"n = {n}{Environment.NewLine}{Environment.NewLine}" +
                $"phi(n) = {phi}{Environment.NewLine}{Environment.NewLine}" +
                $"{publicKey.ToString}{Environment.NewLine}" +
                $"{privateKey.ToString}"
            );  
        } 

        private static BigInteger TEST_VALUE = new BigInteger(111111);
    }
}
