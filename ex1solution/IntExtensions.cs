using System;

namespace ex1solution
{
    public static class IntExtensions
    {
        public static bool IsPrme(this int number)
        {
            if (number < 2)
                return false;
            for (int i = (int) Math.Sqrt(number); i >= 2; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}