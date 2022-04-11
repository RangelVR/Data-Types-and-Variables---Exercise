using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPeople = double.Parse(Console.ReadLine());
            double capacityOfElevator = double.Parse(Console.ReadLine());

            double courses = (numOfPeople / capacityOfElevator);

            Console.WriteLine(courses);
        }
    }
}
