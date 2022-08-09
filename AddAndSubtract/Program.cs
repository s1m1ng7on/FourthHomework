using System;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(subtract(sum(firstNumber, secondNumber), thirdNumber));
        }

        static int sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        static int subtract(int sum, int thirdNumber)
        {
            int result = sum - thirdNumber;
            return result;
        }
    }
}