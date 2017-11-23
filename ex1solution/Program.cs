using System;
using System.Collections.Generic;

namespace ex1solution
{
    class Program
    {
        static List<int> PrimeNumbers(int n)
        {
            var primeNumbers = new List<int>();
            for (var i = 2; i < n; i++)
            {
                if (i.IsPrme())
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }
        static void Main(string[] args)
        {
            Func<int, List<int>> createList = PrimeNumbers;
            Console.Write("Enter a number :");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime numbers below {number} are :");
            createList(number).ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
