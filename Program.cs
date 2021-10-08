using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Password";
            //Console.WriteLine("You have 3 tries to guess the password");
            int guess_count = 0;
            int guess_limit = 3;

            bool hasGuess = true;

            string guess_password ="";
            while (guess_password != password & hasGuess)
            {
                if (guess_count < guess_limit)
                {
                    Console.WriteLine("Start guessing: ");
                    guess_password = Console.ReadLine();
                    guess_count++;
                }
                else
                {
                    hasGuess = false;
                }
            }
            if (!hasGuess)
            {
                Console.WriteLine("You're out of tries");
            }
            else
            {
                Console.WriteLine("You're in");
            }


        }
    }
}

