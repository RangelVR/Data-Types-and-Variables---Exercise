﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numOfInputs; i++)
            {
                char inputLetter = char.Parse(Console.ReadLine());
                sum += inputLetter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
