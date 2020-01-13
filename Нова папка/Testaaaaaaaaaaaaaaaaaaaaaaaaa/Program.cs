using System;

namespace zada4a_4_METHODS_EXERCISE_PASSWORD_VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();
            bool passIsValidOfChars = false;
            bool passIsValidOfLetters = true;
            bool passIsValidOfDigits = false;
            bool choice1 = limitOfChars(passWord, passIsValidOfChars);
          bool choice2 =  LimitOfLetters(passWord, passIsValidOfLetters);
           bool choice3 = LimitOfDigits(passWord, passIsValidOfDigits);
            if (choice1 && choice2 && choice3)
            {
                Console.WriteLine("Password is valid");
            }
        }
    static bool limitOfChars(string passWord, bool passIsValidOfChars)
    {
            int counter = 0;
            for (int i = 0; i < passWord.Length; i++)
            {
                counter++;
            }
            if (counter >= 6 && counter <= 10)
            {
                passIsValidOfChars = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        return passIsValidOfChars;
    }
        static bool LimitOfLetters(string passWord, bool passIsValidOfLetters)
        {
            int counter = 0;
            passIsValidOfLetters = true;
            bool chek = false;
            for (int i = 0; i < passWord.Length; i++)
            {
                char digits = passWord[i];
                if (char.IsDigit(digits) || char.IsLetter(digits))
                {
                    counter++;
                }
                else
                {
                    chek = true;
                    passIsValidOfLetters = false;
                }
            }
            if (chek == true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                passIsValidOfLetters = true;
            }
        return passIsValidOfLetters;
        }
        static bool LimitOfDigits(string passWord, bool passIsValidOfDigits)
        {
            int count = 0;
            for (int i = 0; i < passWord.Length; i++)
            {
                char digits = passWord[i];
                if (char.IsDigit(digits))
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                passIsValidOfDigits = true;
            }
        return passIsValidOfDigits;
        }
    }
}
