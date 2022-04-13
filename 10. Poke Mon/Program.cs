using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsCount = 0;
            double percent = (double)pokePower * 0.50;
            while (pokePower >= distance)
            {
                
                pokePower -= distance;

                if (pokePower == percent && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }

                targetsCount++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsCount);

        }
    }
}
