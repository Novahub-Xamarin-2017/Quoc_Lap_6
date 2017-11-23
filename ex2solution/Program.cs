using System;
using System.Collections.Generic;

namespace ex2solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, Func<int, bool>, List<int>> InitArray = (n, method) =>
            {
                var list = new List<int>();
                for (var i = 1; i < n; i++)
                {
                    if (method(i))
                    {
                        list.Add(i);
                    }
                }
                return list;
            };
            Console.Write("Enter a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Odd number below {number} :");
            var oddnumbers = InitArray(number, x => x % 2 == 1);
            oddnumbers.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
