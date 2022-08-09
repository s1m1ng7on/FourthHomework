using System;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMatrix(int.Parse(Console.ReadLine()));
        }

        static void PrintMatrix(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                for(int j = 1; j <= number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}