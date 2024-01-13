namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialise a random number generator for computer's choice
            Random random = new Random();
            // Flag to control if the game should be played again
            bool playAgain = true;
            // Strings to store the player's and computer's choices
            String player;
            String computer;
            // String to store players reponse to playing again
            String answer;

            // Main game loop
            while (playAgain)
            {
                // Reset player and computer choices for a new round
                player = "";
                computer = "";

                // Input loop for player's choice, ensures valid input
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Please enter rock, paper, or scissors: ");
                    player = Console.ReadLine();
                    player = player.ToUpper(); // Convert to uppercase for case-insensitive comparison
                }

                // Generate random number (1, 2, or 3) to represent computer's choice
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                // Display player and computer choices
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                // Determine the winner of the round based on choices
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                // Ask if the player wants to play again
                // If yes, the outer loop continues; if no, the loop exits
                Console.WriteLine("Do you want to play again? (yes/no): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "YES")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            
            Console.WriteLine("Thanks for playing the game!");
            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
