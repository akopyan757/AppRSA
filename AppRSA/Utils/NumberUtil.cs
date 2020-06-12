using System;
using System.Numerics;

namespace AppRSA
{
    public class PrimeNumberGenerator
    {
        private static Random random;

        /**
         * Генерирование простого числа заданного размера {size} 
         */
        public static BigInteger GeneratePrimeNumber(int size)
        {
            BigInteger n;
            RandomBigInteger rnd = new RandomBigInteger(Guid.NewGuid().GetHashCode());
            do {
                n = rnd.GenerateRandomBigInteger(size);
            } while (!FermaPrimaryTest(n)); 
            return n;
        }

        /**
         * Генерирование взаимно простого к {n} числа заданного размера {size} 
         */
        public static BigInteger GenerateMutuallyPrimeNumber(BigInteger n, int size)
        {
            BigInteger a;
            do
            {
                RandomBigInteger rnd = new RandomBigInteger(Guid.NewGuid().GetHashCode());
                a = rnd.GenerateRandomBigInteger(size);
            }
            while (!EuclidMutuallyPrimeNumber(n, a));
            return a;
        }

        /**
         * Нахождение мультипликативно обратного числа к {a} по модулю {b}
         */
        public static BigInteger MultiplicativelyInverseNumber(BigInteger a, BigInteger b)
        {
            BigInteger[] E = new BigInteger[4] { 1, 0, 0, 1 };
            while (true)
            {
                BigInteger r = BigInteger.Remainder(a, b);
                BigInteger qM = BigInteger.Multiply(BigInteger.Divide(a, b), -1);
                if (r.Equals(0))
                    return E[3];

                BigInteger a1 = E[1];
                BigInteger a2 = BigInteger.Add(E[0], BigInteger.Multiply(qM, E[1]));
                BigInteger a3 = E[3];
                BigInteger a4 = BigInteger.Add(E[2], BigInteger.Multiply(qM, E[3]));
                E = new BigInteger[4] { a1, a2, a3, a4 };
                a = b;
                b = r;
            }
        }

        /**
         * Алгоритм Евклида по нахождению взаимно простых чисел
         */
        public static bool EuclidMutuallyPrimeNumber(BigInteger a, BigInteger b)
        {
            BigInteger r = BigInteger.Remainder(a, b);
            while (r != 0)
            {
                a = b;
                b = r;
                r = BigInteger.Remainder(a, b);
            }
            return b.Equals(1);
        }


        /**
         * Тест Ферма
         */
        public static bool FermaPrimaryTest(BigInteger x)
        {
            if (BigInteger.Equals(x, 2))
                return true;

            if (BigInteger.Remainder(x, 2) == 0 || BigInteger.Remainder(x, 3) == 0)
                return false;

            random = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 100; i++)
            {
                BigInteger value = new BigInteger(random.Next());
                BigInteger a = BigInteger.Add(BigInteger.Remainder(value, BigInteger.Subtract(x, 2)), 2);

                if (GCD(x, a) != 1)
                    return false;
                
                if (BigInteger.ModPow(a, BigInteger.Subtract(x, 1), x) != 1)
                    return false;
            }
            return true;
        }

        /**
         * Нахождение НОДа
         */
        public static BigInteger GCD(BigInteger a, BigInteger b)
        {
            if (b.Equals(0))
                return a;
            return GCD(b, BigInteger.Remainder(a, b));
        }
    }
}
