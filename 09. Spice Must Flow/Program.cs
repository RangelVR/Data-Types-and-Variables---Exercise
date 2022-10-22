using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            double yield = double.Parse(Console.ReadLine());
            double totalSpice = 0;
            int day = 0;

            if (yield >= 100)
            {
                for (double i = yield; i >= 100; i -= 10)
                {
                    double spice = i;
                    spice -= 26;
                    totalSpice += spice;
                    day++;
                }
                totalSpice -= 26;
            }
            Console.WriteLine(day);
            Console.WriteLine(totalSpice);
        }
    }
}
