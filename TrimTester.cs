using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char to trim string to");
            Char[] trim = Console.ReadLine().ToCharArray();

            Char singTrim = ' ';

            for (int i = 0; i < trim.Length; i++)
            {
                singTrim = trim[i];

            }

            Console.WriteLine("Enter string");
            string userStr = Console.ReadLine();

            string[] trimmedStr = userStr.Split(trim);



            for (int i = 0; i < trimmedStr.Length; i++)
            {
                Console.WriteLine(trimmedStr[i]);
            }
            

            Console.ReadKey();

        }
    }
}
