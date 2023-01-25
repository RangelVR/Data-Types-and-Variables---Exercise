using System.Numerics;

int snowballs = int.Parse(Console.ReadLine());

BigInteger bestSnowballValue = 0;
string bestSnowBall = string.Empty;

for (int i = 0; i < snowballs; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    BigInteger currSnowBallValue = BigInteger.Pow(snow / time, quality);

    if (currSnowBallValue > bestSnowballValue)
    {
        bestSnowballValue = currSnowBallValue;
        bestSnowBall = ($"{snow} : {time} = {bestSnowballValue} ({quality})");
    }
}

Console.WriteLine(bestSnowBall);
