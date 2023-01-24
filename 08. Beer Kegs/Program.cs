int n = int.Parse(Console.ReadLine());
double biggestVolume = 0;
string biggestKeg = string.Empty;

while (n > 0)
{
    string model = Console.ReadLine();
    double raduis = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(raduis, 2) * height;

    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        biggestKeg = model;
    }

    n--;
}

Console.WriteLine(biggestKeg);

