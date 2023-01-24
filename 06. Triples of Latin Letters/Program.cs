int num = int.Parse(Console.ReadLine());

for (char i = 'a'; i < 'a' + num; i++)
{
    for (char j = 'a'; j < 'a' + num; j++)
    {
        for (char k = 'a'; k < 'a' + num; k++)
        {
            Console.Write($"{i}{j}{k}");
            Console.WriteLine();
        }

    }
}
-------------------------------------------------------------------------

//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//	for (int j = 0; j < n; j++)
//	{
//		for (int k = 0; k < n; k++)
//		{
//			char ch1 = (char)('a' + i);
//			char ch2 = (char)('a' + j);
//			char ch3 = (char)('a' + k);

//			Console.Write($"{ch1}{ch2}{ch3}");
//			Console.WriteLine();
//		}

//	}
//}
-------------------------------------------------------------------------

//char ch = char.Parse(Console.ReadLine());
//int stopCh = ch + '0';

//for (char i = 'a'; i <= stopCh; i++)
//{
//    for (char j = 'a'; j <= stopCh; j++)
//    {
//        for (char k = 'a'; k <= stopCh; k++)
//        {
//            Console.Write($"{(char)(i)}{(char)(j)}{(char)(k)}");
//            Console.WriteLine();
//        }

//    }
//}
