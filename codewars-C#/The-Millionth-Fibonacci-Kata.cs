using System.Numerics;
using System;
namespace ConsoleApp1
{
    public class Fibonacci
    {
        struct matrix2x2
        {
            public BigInteger a, b, c, d;

            public static matrix2x2 operator *(matrix2x2 A, matrix2x2 B)
            {
                return new matrix2x2
                {
                    a = A.a * B.a + A.b * B.c,
                    b = A.a * B.b + A.b * B.d,
                    c = A.c * B.a + A.d * B.c,
                    d = A.c * B.b + A.d * B.d
                };
            }
        }

        private static BigInteger Fibonacci_MatrixExponentiation(int n)
        {
            if (n == 0) return BigInteger.Zero;
            else if (n == 1) return BigInteger.One;

            bool isNegative = n < 0 && n % 2 == 0;

            matrix2x2 res = new matrix2x2 { a = 1, b = 0, c = 0, d = 1 };
            matrix2x2 fib = new matrix2x2 { a = 1, b = 1, c = 1, d = 0 };
            n = Math.Abs(n);
            do
            {
                if (n % 2 == 1) res *= fib;

                fib *= fib;
            } while ((n /= 2) > 0);

            if (isNegative) res.c = -res.c;
            return res.c;
        }

        public static BigInteger fib(int n)
        {
            return Fibonacci_MatrixExponentiation(n);
        }
    }
}
