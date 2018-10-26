using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human:Player
    {
        public Human(string name)
        {
            this.name = name;
            isComputer = false;
            score = 0;
        }

        public override int PlayerSelection()
        {
            Console.WriteLine(name + ", Please choose your gesture!\n");
            string userInput = Console.ReadLine();
            if (userInput != "0" && userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                Console.WriteLine("You have entered an invalid number. Please enter a number between 0 - 4\n\n");
                userInput = PlayerSelection().ToString();
            }
            int convertedUserInput = int.Parse(userInput);
            selectedGesture = gesture.gestures.ElementAt(convertedUserInput);
            Console.WriteLine(name + " Has Chosen " + selectedGesture +"\n\n");
            return convertedUserInput;
        }
    }


}
