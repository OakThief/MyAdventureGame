using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.GameSegments
{
    /// <summary>
    /// This class represents the ending segment of the game, where the player completes the game and receives a thank you message.
    /// </summary>
    internal class Ending
    {
        /// <summary>
        /// This method is called when the player has completed the game. It displays a message thanking the player for playing and prompts them to exit the game.
        /// </summary>
        public void EndDialouge()
        {
            Console.WriteLine("You have completed the game! \n" +
                "Thank you for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
