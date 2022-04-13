using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                totalAmount += startingYield;
                startingYield -= 10;
                days++;
                
            }
            if (days > 0)
            {
                totalAmount -= days * 26;
                totalAmount -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
