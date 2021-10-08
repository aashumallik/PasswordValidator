using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "cunt";
            //Console.WriteLine("You have 3 tries to guess the password");
            int guess_count = 0;
            int guess_limit = 3;

            bool hasGuess = true;

            string guess_password ="";
            while (guess_password != password & hasGuess) //If the entered password is not equal to the hardcoded password and the user has guesses left
            {
                if (guess_count < guess_limit)
                {
                    Console.WriteLine("Start guessing fucker: ");
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
                Console.WriteLine("You ran out of tries and the log has been sent to the FBI");
            }
            else
            {
                Console.WriteLine("You're in");
            }
        }
    }
}

