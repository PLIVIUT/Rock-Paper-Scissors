namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args )
        {
            Random random = new Random();
            bool playAgain = true;
            String playerChoice;
            String computerChoice;

            while ( playAgain )
            {
                playerChoice = "";
                computerChoice = "";
                while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                {
                    Console.Write("What are you choosing? Rock, paper or scissors?: ");
                    playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToUpper();
                }
                
                switch (random.Next(1,4))
                {
                    case 1:
                        computerChoice = "ROCK";
                        break;
                    case 2:
                        computerChoice = "SCISSORS";
                        break;
                    case 3:
                        computerChoice = "PAPER";
                        break;
                }
                switch (playerChoice)
                {
                    case "ROCK":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("Computer wins!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("Computer wins!!");
                        }
                        break;
                }

                Console.WriteLine("Player's choice is: {0}", playerChoice);
                Console.WriteLine("Computer's choice is: {0}", computerChoice);

                playerChoice = "";
                Console.WriteLine("Please type QUIT if you want to close the game. If you want to play again, press ENTER");
                playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToUpper();
                if (playerChoice == "QUIT" || playerChoice == "Q")
                {
                    playAgain= false;
                    Console.WriteLine("Thanks for playing!");
                }
                else
                {
                    playAgain= true;
                }
            }
            Console.ReadKey();
        }
    }
}