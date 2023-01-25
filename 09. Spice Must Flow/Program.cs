int startingYield = int.Parse(Console.ReadLine());
int totalYield = 0;
int crewConsumption = 26;
int daysMining = 0;

while (startingYield >= 100)
{
    int dayYeld = startingYield - crewConsumption;
    totalYield += dayYeld;

    startingYield -= 10;
    daysMining++;
}

if (totalYield >= crewConsumption)
{
    totalYield -= crewConsumption;
}

Console.WriteLine(daysMining);
Console.WriteLine(totalYield);

---------------------------------------------------------------------------
//int yield = int.Parse(Console.ReadLine());
//int totalYield = 0;
//int day = 0;

//for (int i = yield; i >= 100; i -= 10)
//{
//    int yieldDay = i - 26;
//    totalYield += yieldDay;
//    day++;
//}
//if (totalYield >= 26)
//{
//    totalYield -= 26;
//}


//Console.WriteLine(day);
//Console.WriteLine(totalYield);
