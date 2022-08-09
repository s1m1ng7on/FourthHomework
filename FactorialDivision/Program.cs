using System;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(factorialDivision(firstNumber, secondNumber).ToString(".00"));
        }

        static int factorialDivision(int firstNumber, int secondNumber)
        {
            int firstFactorial = factorial(firstNumber);
            int secondFactorial = factorial(secondNumber);

            int result = firstFactorial / secondFactorial;

            return result;
        }

        static int factorial(int number)
        {
            int result = 1;

            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}