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
            // Run GetAppInfo function to get info
            GetAppInfo();

            // Ask for users name and greet
            GreetUser();

            while (true)
            {

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("\nGuess a number between 1 and 10\n");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "\nPlease enter an actual number\n");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "\nWrong number, please try again\n");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "\nCORRECT!!! You guessed it!\n");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]\n");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Siphosihle Mdunyelwa";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}\n", appName, appVersion, appAuthor);

            // Reset text colour
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask user name
            Console.WriteLine("What is your name?\n");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("\nHello {0}, let's play a game...\n", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text colour
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text colour
            Console.ResetColor();
        }
    }
}
