using System;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            FindSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        static void FindSmallestNumber (int x, int y, int z)
        {
            int min = x;

            if (x <= y && x <= z)
            {
                min = x;
            }
            else if (y <= x && y <= z)
            {
                min = y;
            }
            else if (z <= x && z <= y)
            {
                min = z;
            }

            Console.WriteLine(min);
        }
    }
}