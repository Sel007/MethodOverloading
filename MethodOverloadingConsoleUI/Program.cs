using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverloadingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number please :)");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a another number please :)");
            int y = int.Parse(Console.ReadLine());

            int Answer = Add(x, y);
            Console.WriteLine($"{Answer}");

            decimal result = Add(x, y);
            Console.WriteLine($"{Answer}");

            var result2 = Add(1, 1, true);
            Console.WriteLine(result);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool shouldAddDollars)
        {  
            int sum = x + y;

            if(sum == 1 && shouldAddDollars)
            {
                return  $"{sum} dollar";
            }
            else if(sum > 1 && shouldAddDollars)
            {
                return  $"{sum} dollars";
            }

            return sum.ToString();
        }

    }
}
