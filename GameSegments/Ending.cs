using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameSegments
{
    internal class Ending
    {
        public void Run()
        {
            Console.WriteLine("You have completed the game! \n" +
                "Thank you for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
