using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public bool isComputer;
        public Gesture gesture = new Gesture();
        public string selectedGesture;
        public int gestureSelected;

        public virtual int PlayerSelection()
        {
            string userInput = Console.ReadLine();
            int convertedUserInput = int.Parse(userInput);
            gestureSelected = convertedUserInput;
            return convertedUserInput;
        }
    }


}
