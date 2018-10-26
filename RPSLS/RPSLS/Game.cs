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

        /* Game Rules:
           Rock crushes Scissors 
           Scissors cuts Paper
           Paper covers Rock
           Rock crushes Lizard
           Lizard poisons Spock
           Spock smashes Scissors
           Scissors decapitates Lizard
           Lizard eats Paper
           Paper disproves Spock
           Spock vaporizes Rock 
           */
           public void NewGame()
        {
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
            Console.WriteLine("\nHere are the rules to the Game\n");
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
                Console.ReadKey();
            }
            if (numOfPlayers == 2)
            {
                Console.Clear();
                Console.WriteLine("Player 1: Please enter your name:\n");
                string playerOne = Console.ReadLine();
                player1 = new Human(playerOne);
                Console.WriteLine("Player 2: Please enter your name:\n");
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
                }

            }
        }
    }
}
