using MyAdventureGame.GameBody.InputChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.GameSegments
{
    /// <summary>
    /// This class handles the introductory segment of the game, setting the stage for the adventure.
    /// </summary>
    internal class IntroSegment
    {
        /// <summary>
        /// Displays the introduction to the game, prompts for the player's name, and sets the scene for the adventure.
        /// </summary>
        public void Intro(PlayerState state, StringInputCheck check)
        {
            Console.WriteLine("Welcome to my Adventure Game! \n" +
               "This is a 5 minute text adventure to showcase what i've been learning.");
            Thread.Sleep(1500);
            Console.WriteLine("Please enter your name:");

            state.playerName = Console.ReadLine();

            StringInputCheck.IsValidString(state.playerName);

            Console.Clear();

            Console.WriteLine($"You are {state.playerName}, an explorer in search of the Lost Relic of Eldara,\n" +
                "it is said to grant the wisdom of the ancients.");
            Thread.Sleep(1500);
            Console.WriteLine("Your journey begins now.");
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
