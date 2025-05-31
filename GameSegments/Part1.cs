using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameSegments
{
    internal class Part1
    {
        bool hasSupplies;
        bool symbolClue;
        // This class represents the first part of the adventure game.
        // It introduces the player to the setting and presents a choice of paths.
        public void Run()
        {
            Console.WriteLine("Your walking through a dense, misty forest.");
            Thread.Sleep(1500);
            Console.WriteLine("Whispers surround you, though no one is in sight.");
            Thread.Sleep(1500);
            Console.WriteLine("You come across a fork in the path.");
            Thread.Sleep(1500);
            Console.WriteLine("The left path is narrow and overgrown, the right path looks recently traveled.");
            Thread.Sleep(1500);
            Console.WriteLine("Which path do you choose?\n" +
                "Press L then Enter for left or R and Enter for right.");

            string playerChoice = Console.ReadLine().ToUpper();

            while (playerChoice != "L" && playerChoice != "R")
            {
                Console.WriteLine("Please type: L or R.");
                playerChoice = Console.ReadLine();
            }

            // I want to recode this to use a switch statement.

            if (playerChoice == "L")
            {
                Console.WriteLine("You decide to push through the overgrown brambles and spot a hidden carving on a tree.");
                Thread.Sleep(1500);
                Console.WriteLine("It shows 3 spiral symbols pointing north-east.");
                Thread.Sleep(1500);
                Console.WriteLine("You take a moment to memorize the symbols then continue through the overgrown path.");

                symbolClue = true;

                Thread.Sleep(1500);
                Console.WriteLine("The bushes seem to start to thin and you come to a path leading to some vine draped stairs.");
                Thread.Sleep(1500);
                Console.WriteLine("The stairs descend to a sunken stone courtyard.\n" +
                    "The entrance to the temple you've been searching for.");
            }
            else if (playerChoice == "R")
            {
                Console.WriteLine("You decide to follow the well-trodden path.");
                Thread.Sleep(1500);
                Console.WriteLine("After walking for a while, you come across a hunter that has set up camp nearby.");
                Thread.Sleep(1500);
                Console.WriteLine("The hunter asks if you would like to have some food.");
                Thread.Sleep(1500);
                Console.WriteLine("What will you tell him?\n" +
                    "Press Y and enter for yes or N and enter for no.");

                playerChoice = Console.ReadLine().ToUpper();

                while (playerChoice != "Y" && playerChoice != "N")
                {
                    Console.WriteLine("Please type: Y or N.");
                    playerChoice = Console.ReadLine();
                }

                if (playerChoice == "Y")
                {
                    Console.WriteLine("You accept the hunter's offer and share a meal.");
                    Thread.Sleep(1500);
                    Console.WriteLine("The hunter tells you about the temple and warns you of the dangers that lie ahead.");
                    Thread.Sleep(1500);
                    Console.WriteLine("He passes you a map and a simple slingshot, you thank him for the food and supplies, then continue on your way.");
                    Thread.Sleep(1500);
                    hasSupplies = true;
                }
                else if (playerChoice == "N")
                {
                    Console.WriteLine("You politely decline the hunter's offer.");
                    Thread.Sleep(1500);
                    Console.WriteLine("He shrugs and continues to eat his meal.");
                    Thread.Sleep(1500);
                }

                if (hasSupplies)
                {
                    Console.WriteLine("You take a moment to study the map and notice the temple is at the end of the path, down some stiars.");
                    Thread.Sleep(1500);
                    Console.WriteLine("You also notice some strange sprial symbols around the temple.");
                    Thread.Sleep(1500);
                    Console.WriteLine("You take a moment to memorize the symbols then continue on your way.");
                    Thread.Sleep(1500);
                    symbolClue = true;

                }
                else
                {
                    Console.WriteLine("You continue on your way.");
                    Thread.Sleep(1500);
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
