using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int littersInTheTank = 0;

            for (int i = 0; i < count; i++)
            {
                int pouredLitters = int.Parse(Console.ReadLine());

                if (pouredLitters + littersInTheTank > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littersInTheTank += pouredLitters;
                }
                
            }

            Console.WriteLine(littersInTheTank);
            
        }
    }
}
