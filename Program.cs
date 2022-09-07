using System;

// Namespace
namespace RockPaperScissorsGame
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //App Info
            GetAppInfo();

            //User Greeting
            GreetUser();

            while (true)
            {
                // Set computer selection 
                var compAnswers = new List<string> { "rock", "paper", "scissors" };

                Random rand = new Random();
                int randomAnswer = rand.Next(compAnswers.Count);
                // Computer Random Selection 
                string answer = compAnswers[randomAnswer];


                Console.WriteLine("Select one: Rock, Paper, Scissors");

                // Get player input
                string playerAnswer = Console.ReadLine().ToLower();


                if (playerAnswer == "rock" || playerAnswer == "paper" || playerAnswer == "scissors")
                {


                    // Match answer to players answer
                    if (playerAnswer == "rock" && answer == "scissors" || playerAnswer == "paper" && answer == "rock" || playerAnswer == "scissors" && answer == "paper")
                    {
                        // Print color message
                        PrintColorMessage(ConsoleColor.Green, $"Computer selected {answer}, you won!");

                    }
                    else if (playerAnswer == answer)
                    {
                        // Print color message
                        PrintColorMessage(ConsoleColor.Yellow, $"Computer selected {answer}, is a tied!");

                    }
                    else
                    {
                        // Print color message
                        PrintColorMessage(ConsoleColor.Red, $"Computer selected {answer}, you lost!");

                    }

                }
                else
                {
                    // Print color message
                    PrintColorMessage(ConsoleColor.Red, "Invalid answer!");

                    continue;
                }

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string playAgainAnswer = Console.ReadLine().ToUpper();

                if (playAgainAnswer == "Y")
                {
                    continue;
                }
                else if (playAgainAnswer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // App Info

        static void GetAppInfo()
        {
            // Set App vars

            string appName = "MyFirstApp";
            string appVersion = "1.0.0";
            string appAuthor = "Antonio Caraballo";


            PrintColorMessage(ConsoleColor.Green, $"{appName}: Version {appVersion} by {appAuthor}");

        }

        // User greetings
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, lets play a game...");
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

    }
}