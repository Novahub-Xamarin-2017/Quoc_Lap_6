using System;
using System.Collections.Generic;

namespace ex2solution
{
    class Program
    {
        static List<int> OddNumbers(int number)
        {
            var oddnumbers = new List<int>();
            for (var i = 1; i < number; i += 2)
            {
                oddnumbers.Add(i);
            }
            return oddnumbers;
        }

        static void Main(string[] args)
        {
            Func<int, List<int>> createList = OddNumbers;
            Console.Write("Enter a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Odd number below {number} :");
            var oddnumbers = createList(number);
            oddnumbers.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
