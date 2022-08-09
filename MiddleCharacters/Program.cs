using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(middleCharacters(Console.ReadLine()));
        }

        static string middleCharacters(string text)
        {
            string result;
            char[] textCharacters = text.ToCharArray();

            if(textCharacters.Length % 2 == 0)
            {
                result = textCharacters[textCharacters.Length / 2 - 1].ToString() + textCharacters[textCharacters.Length / 2].ToString();
            }
            else
            {
                result = textCharacters[textCharacters.Length / 2].ToString();
            }

            return result;
        }
    }
}