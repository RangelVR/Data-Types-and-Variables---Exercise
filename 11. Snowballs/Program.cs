using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger theBestSnowBallValue = 0;
            int theBestSnowballSnow = 0;
            int theBestSnowballTime = 0;
            int theBestSnowballQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > theBestSnowBallValue)
                {
                    theBestSnowBallValue = snowballValue;
                    theBestSnowballSnow = snowballSnow;
                    theBestSnowballTime = snowballTime;
                    theBestSnowballQuality = snowballQuality;
                }

            }

            Console.WriteLine($"{theBestSnowballSnow} : {theBestSnowballTime} = {theBestSnowBallValue} ({theBestSnowballQuality})");

            //int n = int.Parse(Console.ReadLine());
            //BigInteger maxValue = 0;
            //string bestResult = "";

            //for (int i = 0; i < n; i++)
            //{
            //    int snowBalls = int.Parse(Console.ReadLine());
            //    int snowBallTime = int.Parse(Console.ReadLine());
            //    int snowBallQuality = int.Parse(Console.ReadLine());

            //    BigInteger value = BigInteger.Pow(snowBalls / snowBallTime, snowBallQuality);

            //    if (value >= maxValue)
            //    {
            //        maxValue = value;
            //        string result = ($"{snowBalls} : {snowBallTime} = {maxValue} ({snowBallQuality})");
            //        bestResult = result;
            //    }
            //}

            //Console.WriteLine(bestResult);

        }
    }
}
