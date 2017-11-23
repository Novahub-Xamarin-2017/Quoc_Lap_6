using System;
using System.Collections.Generic;

namespace ex2solution
{
    class Program
    {
        private static List<int> InitArray(int n, Func<int, bool> condition)
        {
            var list = new List<int>();
            for (var i = 1; i < n; i++)
            {
                if (condition(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Odd number below {number} :");
            var oddnumbers = InitArray(number, x => x % 2 == 1);
            oddnumbers.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
