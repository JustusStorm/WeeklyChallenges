using System;
using System.Data.Common;

namespace PersonalTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 3;
            Console.WriteLine(number);
            Console.WriteLine(Factorial(number));



            Console.ReadLine();

        }
        
        public static int Factorial(int number)
        {
            var result = 1;
            for (int i = number; i > 0; i--)
            {
                result = result * number;
            }
            return result;
        }
    }
}
