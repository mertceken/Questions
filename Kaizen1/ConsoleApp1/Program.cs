using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
                Console.WriteLine(ProductCodes(8, random));

            Console.ReadLine();
        }
        public static string ProductCodes(int length, Random random)
        {
            var chars = "ACDEFGHKLMNPRTXYZ234579";
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }
    }
}
