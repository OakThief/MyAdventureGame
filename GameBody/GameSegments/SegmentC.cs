using MyAdventureGame.GameBody.InputChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.GameSegments
{
    /// <summary>
    /// This class represents the third segment of the game, where the player encounters a guardian and must prove their worth through a memory game to claim the Lost Relic of Eldara.
    /// </summary>
    internal class SegmentC
    {
        /// <summary>
        /// This method represents the third part of the game where the player encounters a guardian and must prove their worth through a memory game to claim the Lost Relic of Eldara.
        /// </summary>

        public void Part3(GameState state, StringInputCheck check)
        {
            Console.WriteLine("The guardian is a tall, shadowy figure with glowing eyes.");
            Thread.Sleep(1500);
            Console.WriteLine("It speaks in a deep, echoing voice, 'To claim the relic, you must prove your worth.'");
            Thread.Sleep(1500);
            Console.WriteLine("The guardian presents you with a challenge, a memory game.");
            Thread.Sleep(1500);
            Console.WriteLine("You must remember the sequence of colours it shows you.");
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to start the memory game.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("The guardian shows you a sequence of colours.");

            string[] pattern = { "red", "blue", "green" };
            string[] playerGuess = new string[pattern.Length];

            Console.WriteLine("The pattern is:");
            Thread.Sleep(2000);

            foreach (string color in pattern)
            {
                Console.WriteLine(color);
                Thread.Sleep(1000);
            }

            Console.Clear();

            Console.WriteLine("Now repeat the pattern:");

            for (int i = 0; i < pattern.Length; i++)
            {
                Console.Write($"Enter color {i + 1}: ");
                playerGuess[i] = Console.ReadLine().ToLower();
            }

            bool isCorrect = true;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (playerGuess[i] != pattern[i])
                {
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                Console.WriteLine("Correct! You have proven your mind worthy.");
                Thread.Sleep(1500);
                Console.WriteLine("The guardian steps aside, allowing you to approach the relic.");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("Wrong pattern. The relic fades from your reach.");
            }
        }
    }
}
