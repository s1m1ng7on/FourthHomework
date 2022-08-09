using System;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(vowelsCount(input));
        }

        static int vowelsCount(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    if(input[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}