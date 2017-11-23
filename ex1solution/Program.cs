using System;
using System.Collections.Generic;

namespace ex1solution
{
    class Program
    {
        static List<int> PrimeNumbers(int n)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = 2; i < n; i++)
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
            createList(100).ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
