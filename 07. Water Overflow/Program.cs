int n = int.Parse(Console.ReadLine());
int totalLiters = 0;
int TANKCAPACITY = 255;

while (n > 0)
{
    int liters = int.Parse(Console.ReadLine());

    if (liters + totalLiters <= TANKCAPACITY)
    {
        totalLiters += liters;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
    n--;
}
Console.WriteLine(totalLiters);


//int n = int.Parse(Console.ReadLine());
//int totalLiters = 0;

//while (n > 0)
//{
//    int liters = int.Parse(Console.ReadLine());

//    if (liters <= 255 - totalLiters)
//    {
//        totalLiters += liters;
//    }
//    else
//    {
//        Console.WriteLine("Insufficient capacity!");
//    }
//    n--;
//}
//Console.WriteLine(totalLiters);
