using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
    class Faberge
    {
        private static BigInteger mo = new BigInteger(998244353);
        private static List<BigInteger> inv = new List<BigInteger>(new BigInteger[] { BigInteger.Zero, BigInteger.One });
        static Faberge()
        {
            for (BigInteger i = 2; i <= 80000; i++)
            {
                int index = (int)(mo % i);
                inv.Add((mo - mo / i) * inv[index] % mo);
            }
        }
        public static BigInteger Height(BigInteger n, BigInteger m)
        {
            BigInteger h = BigInteger.Zero;
            BigInteger t = BigInteger.One;
            m %= mo;

            for (int i = 1; i <= n; i++)
            {
                t = t * (m - i + 1) * inv[i] % mo;
                h = (h + t) % mo;
            }

            return h % mo;
        }
    }
}
