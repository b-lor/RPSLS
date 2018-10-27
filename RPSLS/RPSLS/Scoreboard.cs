using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scoreboard
    {
        public string Player1;
        public int Player1Score;
        public string Player2;
        public int Player2Score;

        public Scoreboard(string player1, string player2)
        {
            Player1 = player1;
            Player1Score = 0;
            Player2 = player2;
            Player2Score = 0;
            CurrentScoreboard();
        }
        
        public void CurrentScoreboard()
        {
            Console.WriteLine("The current score is: \n" + Player1 + " : " + Player1Score + "\n" + Player2 + " : " + Player2Score + "\n\n");
        }
    }

}
