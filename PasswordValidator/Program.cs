using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] characters = password.ToCharArray();

            CheckPassword(characters);
        }

        static bool between6And10Characters(char[] characters)
        {
            if(characters.Length >= 6 && characters.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool onlyLettersAndDigits(char[] characters)
        {
            for(int i = 0; i < characters.Length; i++)
            {
                if(Char.IsDigit(characters[i]) && Char.IsLetter(characters[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static bool has2Digits(char[] characters)
        {
            int digitCounter = 0;

            for(int i = 0; i < characters.Length; i++)
            {
                if(Char.IsDigit(characters[i]))
                {
                    digitCounter++;
                }
            }

            if(digitCounter > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void CheckPassword(char[] characters)
        {
            if (!between6And10Characters(characters))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!onlyLettersAndDigits(characters))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!has2Digits(characters))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (between6And10Characters(characters) && onlyLettersAndDigits(characters) && has2Digits(characters))
            {
                Console.WriteLine("Password is valid.");
            }
        }
    }
}