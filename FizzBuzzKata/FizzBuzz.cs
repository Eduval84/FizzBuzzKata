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
            if (CheckIfNumIsDivisibleBy3And3(num, out var fizzbuzz)) return fizzbuzz;
            if (CheckIfNumIsDibisibleBy3(num, out var Fizz)) return Fizz;
            if (CheckIfNumIsDivisibleBy5(num, out var buzz)) return buzz;
            return num.ToString();
        }

        private static bool CheckIfNumIsDivisibleBy5(int num, out string buzz)
        {
            if (num % 5 == 0)
            {
                buzz = "Buzz";
                return true;
            }

            buzz = null;
            return false;
        }

        private static bool CheckIfNumIsDibisibleBy3(int num, out string fizz)
        {
            if (num % 3 == 0)
            {
                fizz = "Fizz";
                return true;
            }

            fizz = null;
            return false;
        }

        private static bool CheckIfNumIsDivisibleBy3And3(int num, out string fizzbuzz)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                fizzbuzz = "FizzBuzz";
                return true;
            }

            fizzbuzz = null;
            return false;
        }
    }
}
