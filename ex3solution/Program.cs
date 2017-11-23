using System;

namespace ex3solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, Func<int, long>, long> sum = (n, method) =>
            {
                var sumResult = 0L;
                for (var i = 1; i <= n; i++)
                {
                    sumResult += method(i);
                }
                return sumResult;
            };
            var s = sum(5, x => (long) Math.Pow(x, x));
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
