using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public Player player1;
        public Player player2;
        public Scoreboard scoreboard;
        public bool AnyWinner;

           public void NewGame()
        {
            AnyWinner = false;
            DisplayRules();
            DeterminePlayers(numberOfPlayers());
        }


        public int numberOfPlayers()
        {
            string selection;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("\nMain Menu:\n");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Please enter number of players - ('1' for One Player or '2' for Two Players)\n\n");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    return 1;
                }
                else if (selection == "2")
                {
                    return 2;
                }
                else
                {
                }
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("\nWelcome to Rock, Paper, Sisscor, Lizard, Spock!\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nHere are the rules to the Game.  Best of 3 games win\n");
            Console.WriteLine("\nRock crushes Scissors\n \nScissors cuts Paper\n \nPaper covers Rock\n \nRock crushes Lizard\n \nLizard poisons Spock\n \nSpock smashes Scissors\n \nScissors decapitates Lizard\n \nLizard eats Paper\n \nPaper disproves Spock\n \nSpock vaporizes Rock\n");
            Console.WriteLine("\n\n\nPress 'Enter' to continue");
            Console.ReadLine();
        }

        public void DeterminePlayers(int numOfPlayers)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(2000);
            if (numOfPlayers == 1)
            {
                Console.Clear();
                Console.WriteLine("Please enter your name:");
                player1 = new Human(Console.ReadLine());
                player2 = new Computer();
                Console.Clear();
                Console.WriteLine($"Welcome {player1.name}, your opponent is {player2.name} today. Let's Get Ready to RUMBLEEEEEEE!!!!!!!");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
            }
            if (numOfPlayers == 2)
            {
                Console.Clear();
                Console.WriteLine("Player 1: Please enter your name:\n");
                string playerOne = Console.ReadLine();
                player1 = new Human(playerOne);
                Console.WriteLine("\n\nPlayer 2: Please enter your name:\n");
                string playerTwo = Console.ReadLine();
                if (playerOne == playerTwo)
                {
                    Console.WriteLine("ERROR!! You can not have the same Name when playing this game");
                    Console.ReadLine();
                    DeterminePlayers(numberOfPlayers());
                }
                else
                {
                    player2 = new Human(playerTwo);
                    Console.WriteLine($"Welcome {player1.name} and {player2.name}, Let's Get Ready to RUMBLEEEEEEE!!!!!!!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            StartBattle();
        }

        public void StartBattle()
        {
            scoreboard = new Scoreboard(player1.name, player2.name);
            while (!AnyWinner)
            {
                DisplayGestures();
                CompareGestures();
                scoreboard.CurrentScoreboard();
                WinConditions();
            }

        }
    
        public void DisplayGestures()
        {
            int counter = 0;
            Gesture gestureList = new Gesture();
            foreach (string gesture in gestureList.gestures)
            {
                
                Console.WriteLine(counter + " : " + gesture);
                counter++;
            }
            Console.WriteLine("\n\n");
            player1.gestureSelected = player1.PlayerSelection();
            player2.gestureSelected = player2.PlayerSelection();
            System.Threading.Thread.Sleep(4000);
        }

        public void CompareGestures()
        {
            if (player1.gestureSelected == player2.gestureSelected)
            {
                Console.WriteLine("It's a tie - next round");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
            }
            else if ((player1.gestureSelected == 0 && player2.gestureSelected == 3) || (player1.gestureSelected == 0 && player2.gestureSelected == 2) || (player1.gestureSelected == 0 && player2.gestureSelected == 3) || (player1.gestureSelected == 1 && player2.gestureSelected == 0) || (player1.gestureSelected == 1 && player2.gestureSelected == 4) || (player1.gestureSelected == 2 && player2.gestureSelected == 1) || (player1.gestureSelected == 2 && player2.gestureSelected == 3) || (player1.gestureSelected == 3 && player2.gestureSelected == 4) || (player1.gestureSelected == 3 && player2.gestureSelected == 1) || (player1.gestureSelected == 4 && player2.gestureSelected == 2) || (player1.gestureSelected == 4 && player2.gestureSelected == 0))
            {
                Console.WriteLine($"{player1.name} is the winner");
                scoreboard.Player1Score++;
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"{player2.name} is the winner");
                scoreboard.Player2Score++;
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
            }
        }

        public bool WinConditions()
        {
            if (scoreboard.Player1Score == 2)
            {
                AnyWinner = true;
                Console.WriteLine($"WOW!!! {player1.name}, you won. Congrats on your sweet victory");
                System.Threading.Thread.Sleep(3000);
                PlayAgain();
            }
            if (scoreboard.Player2Score == 2)
            {
                AnyWinner = true;
                Console.WriteLine($"{player2.name} won this match.  {player1.name}, keep practicing.");
                System.Threading.Thread.Sleep(3000);
                PlayAgain();
            }
                return AnyWinner;
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? Type 'yes' to play again or 'no' to quit.");
            string playAgainInput = Console.ReadLine();
            if (playAgainInput[0] == 'y' || playAgainInput[0] == 'Y')
            {
                NewGame();
            }
            if (playAgainInput[0] == 'n' || playAgainInput[0] == 'N')
            {
                Console.WriteLine("Goodbye, see you soon!");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Console.WriteLine("That is not a valid option, exiting program.........");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

    }
}
