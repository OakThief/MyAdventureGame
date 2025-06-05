using MyAdventureGame.GameBody.InputChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.GameSegments
{
    internal class SegmentB
    {
        bool hasSupplies = false;
        bool symbolClue = false;
        string playerChoice = "";

        public void Part2()
        {
            Console.WriteLine("You come to the ancient temple, ruined and overgrown.");
            Thread.Sleep(1500);
            Console.WriteLine("On the door you notice two spiral symbols on stones that pretrude outwards slightly from the rest of the door.\n" +
                "The symbols are what looks to be a sun and a moon.");
            Thread.Sleep(1500);

            if (symbolClue == true)
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

                if (playerChoice == "sun")
                {
                    Console.WriteLine("You press the stone with the sun symbol, and the door creaks open, revealing a dark hall.");
                    Thread.Sleep(1500);
                }
                else if (playerChoice == "moon")
                {
                    Console.WriteLine("You press the stone with the moon symbol, and suddenly the floor beneath you swings open!");
                    Thread.Sleep(1500);
                    Console.WriteLine("You narrowly manage to grasp the edge but lose your slingshot in the process.");
                    Thread.Sleep(1500);
                    hasSupplies = false;

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
            int userInput;

            if (hasSupplies == true)
            {
                shot = shots.Next(1, 4);

                Console.WriteLine("You take out your slingshot and gather some stones from the floor around you.");
                Thread.Sleep(1500);
                Console.WriteLine("Press a number between 1 and 3 to see if you hit the switch.");
                userInput = int.Parse(Console.ReadLine());
                IntegerInputCheck.IsValidInteger(userInput.ToString());

                while (userInput != shot)
                {
                    Console.WriteLine("You miss the switch, try again.");
                    userInput = int.Parse(Console.ReadLine());
                }
                if (userInput == shot)
                {
                    Console.WriteLine("You hit the switch and the door creeks open.");
                }

            }
            else
            {
                shot = shots.Next(1, 7);

                Console.WriteLine("You look around and grab some stones to throw at the switch.");
                Thread.Sleep(1500);
                Console.WriteLine("Press a number between 1 and 6 to see if you hit the switch.");


                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    while (userInput != shot)
                    {
                        Console.WriteLine("You miss the switch, try again.");
                        int.TryParse(Console.ReadLine(), out userInput);
                    }
                    if (userInput == shot)
                    {
                        Console.WriteLine("You hit the switch and the door creeks open.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                while (userInput != shot)
                {
                    Console.WriteLine("You miss the switch, try again.");
                    userInput = int.Parse(Console.ReadLine());
                }
                if (userInput == shot)
                {
                    Console.WriteLine("You hit the switch and the door creeks open.");
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
