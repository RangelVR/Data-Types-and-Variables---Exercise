using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int stopIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= stopIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }
            
            //int start = int.Parse(Console.ReadLine());
            //int stop = int.Parse(Console.ReadLine());

            //for (int i = start; i <= stop; i++)
            //{
            //    char ch = (char)i;
            //    Console.Write(ch + " ");
            //}
        }
    }
}
