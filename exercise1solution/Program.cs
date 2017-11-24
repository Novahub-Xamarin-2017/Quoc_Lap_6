using System;
using System.Collections.Generic;

namespace exercise1solution
{
    class Program
    {
        static List<int> InitPrimeNumbers(int n)
        {
            bool IsPrme(int number)
            {
                if (number < 2)
                    return false;
                for (int i = (int)Math.Sqrt(number); i >= 2; i--)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            var primeNumbers = new List<int>();
            for (var i = 2; i < n; i++)
            {
                if (IsPrme(i))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime numbers below {number} are :");
            InitPrimeNumbers(number).ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
