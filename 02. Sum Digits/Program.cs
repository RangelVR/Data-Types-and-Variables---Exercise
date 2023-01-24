int number = int.Parse(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine(sum);

-------------------------------------------------------------------
    
//string num = Console.ReadLine();
//int sum = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    int currNum = num[i];
//    sum += currNum - '0';
//}

//Console.WriteLine(sum);
