using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volumeOfKeg = 0;
            string bigesstKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double currVolume = Math.PI * radius * radius * height;

                if (currVolume > volumeOfKeg)
                {
                    volumeOfKeg = currVolume;
                    bigesstKeg = model;
                }
            }
            Console.WriteLine(bigesstKeg);
        }
    }
}
