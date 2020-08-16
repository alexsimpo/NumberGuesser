using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo

            GreetUser(); // Greets User

            while (true) {
                // Init correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string numberInput = Console.ReadLine();

                    if (!int.TryParse(numberInput, out guess))
                    {
                        // Print error msg
                        PrintColor(ConsoleColor.Red, "Please enter a valid number.");
                        continue;
                    }
                    // Cast to int and put in guess
                    guess = Int32.Parse(numberInput);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Red, "Wrong number, guess again!!");
                    }
                }

                // Output success
                PrintColor(ConsoleColor.Green, "Correct!! Well done");

                Console.WriteLine("Would you like to play again? (y/n)");

                string answer = Console.ReadLine().ToUpper();

                while (answer != "Y" && answer != "N")
                {
                    // Print error msg
                    PrintColor(ConsoleColor.Red, "Please enter y or n");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    PrintColor(ConsoleColor.Magenta, "Thank you for playing");
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Alex Simpson";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Welcome to {0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user name
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }

        static void PrintColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
