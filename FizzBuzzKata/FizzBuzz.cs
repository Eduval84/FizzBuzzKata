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
            if(num == 1)
                return "1";
            else
            {
                if (num == 2)
                    return "2";
                else
                {
                    return "Fizz";
                }
            }
        }
    }
}
