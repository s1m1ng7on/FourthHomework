using System;

namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());

            Console.WriteLine(range(firstCharacter, secondCharacter));
        }

        static string range(char firstCharacter, char secondCharacter)
        {
            List<char> range = new List<char>();
            string rangeLine;

            if((int)Char.GetNumericValue(firstCharacter) < (int)Char.GetNumericValue(secondCharacter))
            {
                char temp = secondCharacter;
                firstCharacter = secondCharacter;
                secondCharacter = temp;
            }

            for(int i = (int)Char.GetNumericValue(firstCharacter); i < (int)Char.GetNumericValue(secondCharacter); i++)
            {
                rangeLine = Console.Write((char)i);
                //range.Add((char)i);
            }
            //rangeLine = string.Join(" ", range);

            return rangeLine;
        }
    }
}