using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
        }

        public static string Generate(int num)
        {
            if (num %3 == 0)
                return "Fizz";
            if (num % 5 == 0)
                return "Buzz";
            return num.ToString();
        }
    }
}
