using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer:Player
    {
        public Computer()
        {
            name = "Android";
            isComputer = true;
        }
        public override int PlayerSelection()
        {
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 5);
            randomNumber -= 1;
            selectedGesture = gesture.gestures.ElementAt(randomNumber);
            Console.WriteLine("\n" + name + " chooses " + selectedGesture + "\n");
            return randomNumber;
        }
    }
}
