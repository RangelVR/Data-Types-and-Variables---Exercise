using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCh = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < numCh; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                totalSum += ch;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
