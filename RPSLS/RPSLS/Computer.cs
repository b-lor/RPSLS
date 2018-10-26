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
            score = 0;
        }
    }
}
