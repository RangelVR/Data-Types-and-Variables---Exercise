int pokePowerN = int.Parse(Console.ReadLine());
int distanceM = int.Parse(Console.ReadLine());
int exhaustionFactorY = int.Parse(Console.ReadLine());

double exact50 = pokePowerN * 0.5;
int targets = 0;

while (pokePowerN >= distanceM)
{

    pokePowerN -= distanceM;
    targets++;

    if (pokePowerN == exact50 && exhaustionFactorY != 0)
    {
        pokePowerN /= exhaustionFactorY;
    }
}

Console.WriteLine(pokePowerN);
Console.WriteLine(targets);
