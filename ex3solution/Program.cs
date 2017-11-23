using System;

namespace ex3solution
{
    class Program
    {
        static long Sum(int n, Func<int, long> method)
        {
            var sumResult = 0L;
            for (var i = 1; i <= n; i++)
            {
                sumResult += method(i);
            }
            return sumResult;
        }

        static void Main(string[] args)
        {
            var s = Sum(5, x => (long) Math.Pow(x, x));
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
