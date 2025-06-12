using MyAdventureGame.GameBody.InputChecks;
using MyAdventureGame.GameBody;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.GameSegments
{
    /// <summary>
    /// This class represents the second segment of the game, where the player navigates through an ancient temple and encounters a guardian.
    /// </summary>
    internal class SegmentB
    {
        string playerChoice = "";

        /// <summary>
        /// This method represents the second part of the game where the player navigates through an ancient temple and hits a switch to open a door, leading to the Lost Relic of Eldara.
        /// </summary>
        public void Part2(PlayerState state, StringInputCheck check)
        {
            Console.WriteLine("You come to the ancient temple, ruined and overgrown.");
            Thread.Sleep(1500);
            Console.WriteLine("On the door you notice two spiral symbols on stones that pretrude outwards slightly from the rest of the door.\n" +
                "The symbols are what looks to be a sun and a moon.");
            Thread.Sleep(1500);

            if (state.symbolClue)
            {
                Console.WriteLine("You remember the symbols you saw earlier and realize they are the same as the sun symbol.");
                Thread.Sleep(1500);
                Console.WriteLine("After pressing the stone with the sun symbol, the door creaks open, revealing a dark hall");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("Which stone will you press?");
                playerChoice = Console.ReadLine().ToUpper();

                while (playerChoice != "SUN" && playerChoice != "MOON")
                {
                    Console.WriteLine("Please type: sun or moon.");
                    playerChoice = Console.ReadLine();
                }

                if (playerChoice == "SUN")
                {
                    Console.WriteLine("You press the stone with the sun symbol, and the door creaks open, revealing a dark hall.");
                    Thread.Sleep(1500);
                }
                else if (playerChoice == "MOON")
                {
                    Console.WriteLine("You press the stone with the moon symbol, and suddenly the floor beneath you swings open!");
                    Thread.Sleep(1500);
                    Console.WriteLine("You narrowly manage to grasp the edge but lose your slingshot in the process.");
                    Thread.Sleep(1500);
                    state.hasSupplies = false;

                    Console.WriteLine("You pull yourself up into the doorway of the temple revealing a dark hall.");
                    Thread.Sleep(1500);
                }
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You step inside and the door slams shut behind you.");
            Thread.Sleep(1500);
            Console.WriteLine("The air is thick with dust and the smell of damp stone.");
            Thread.Sleep(1500);
            Console.WriteLine("There is a vast gap between you and the door you can see on the other side.");
            Thread.Sleep(1500);
            Console.WriteLine("Above the door seems to be a switch or button of sorts.");
            Thread.Sleep(1500);

            Random shots = new Random();
            int shot = shots.Next(1, 4);
            string input;
            int number;

            if (state.hasSupplies == true)
            {
                shot = shots.Next(1, 4);

                Console.WriteLine("You take out your slingshot and gather some stones from the floor around you.");
                Thread.Sleep(1500);

                while (true)
                {
                    Console.WriteLine("Guess a number between 1 and 3 to see if you hit the switch.");
                    input = Console.ReadLine();

                    if (IntegerInputCheck.GetValidIntegerInput(input, out number) && number != shot)
                    {
                        Console.WriteLine("You miss the switch, try again.");
                        input = Console.ReadLine();
                    }
                    else if (IntegerInputCheck.GetValidIntegerInput(input, out number) && number == shot)
                    {
                        Console.WriteLine("You hit the switch and the door creeks open.");
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }
            else
            {
                shot = shots.Next(1, 7);

                Console.WriteLine("You look around and grab some stones to throw at the switch.");
                Thread.Sleep(1500);

                while (true)
                {
                    Console.WriteLine("Guess a number between 1 and 6 to see if you hit the switch.");
                    input = Console.ReadLine();

                    if (IntegerInputCheck.GetValidIntegerInput(input, out number) && number != shot)
                    {
                        Console.WriteLine("You miss the switch, try again.");
                        input = Console.ReadLine();
                    }
                    else if (IntegerInputCheck.GetValidIntegerInput(input, out number) && number == shot)
                    {
                        Console.WriteLine("You hit the switch and the door creeks open.");
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }
            Thread.Sleep(1500);
            Console.WriteLine("Behind the door you see The Lost Relic of Eldara.\n" +
                "Resting on a podium.");
            Thread.Sleep(1500);
            Console.WriteLine("standing right infront of the podium stands the guardian the hunter warned you about.");
            Thread.Sleep(1500);
            Console.WriteLine("Press any ket to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
