using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());

            double halfOfPower = (double)pokePower * 0.50;
            int targets = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                if (pokePower == halfOfPower && exhaustFactor != 0)
                {
                    pokePower /= exhaustFactor;
                }
                targets++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targets);
        }
    }
}
