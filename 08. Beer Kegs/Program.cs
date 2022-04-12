using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfKegs = int.Parse(Console.ReadLine());
            double biggestVolumeOfKeg = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < countOfKegs; i++)
            {
                string typeOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                double heightOfKeg = double.Parse(Console.ReadLine());

                //π* r^2 * h.
                double currVolume = Math.PI * Math.Pow(radiusOfKeg, 2) * heightOfKeg;
                if (currVolume > biggestVolumeOfKeg)
                {
                    biggestVolumeOfKeg += currVolume;
                    biggestKeg = typeOfKeg;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
