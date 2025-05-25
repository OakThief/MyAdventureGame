using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MyAdventureGame
{
    internal class Program
    {
        static string playerName = "Player";
        static string playerChoice = "none";
        static bool symbolClue = false;
        static bool hasSupplies = false;

        static void Main(string[] args)
        {
            Intro();
            Act1();
            Act2();
            Act3();
            TheEnd();
        }

        static void Intro()
        {
            Console.WriteLine("Welcome to my Adventure Game! \n" +
    "This is a 5 minute text adventure to showcase what i've been learning.");
            Thread.Sleep(1500);
            Console.WriteLine("Please enter your name:");

            playerName = Console.ReadLine();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"You are {playerName}, an explorer in search of the Lost Relic of Eldara,\n" +
                "it is said to grant the wisdom of the ancients.");
            Thread.Sleep(1500);
            Console.WriteLine("Your journey begins now.");
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Act1()
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

            while (playerChoice.ToUpper() != "L" && playerChoice.ToUpper() != "R")
            {
                Console.WriteLine("Please type: L or R.");
                playerChoice = Console.ReadLine();
            }

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

                while (playerChoice.ToUpper() != "Y" && playerChoice.ToUpper() != "N")
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

                if (hasSupplies == true)
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

        static void Act2()
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

                while (playerChoice.ToUpper() != "SUN" && playerChoice.ToUpper() != "MOON")
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
            int numberChoice;

            if (hasSupplies == true)
            {
                shot = shots.Next(1, 4);

                Console.WriteLine("You take out your slingshot and gather some stones from the floor around you.");
                Thread.Sleep(1500);
                Console.WriteLine("Press a number between 1 and 3 to see if you hit the switch.");
                numberChoice = Convert.ToInt32(Console.ReadLine());

                while (numberChoice != shot)
                {
                    Console.WriteLine("You miss the switch, try again.");
                    numberChoice = Convert.ToInt32(Console.ReadLine());
                }
                if (numberChoice == shot)
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

                numberChoice = Convert.ToInt32(Console.ReadLine());

                while (numberChoice != shot)
                {
                    Console.WriteLine("You miss the switch, try again.");
                    numberChoice = Convert.ToInt32(Console.ReadLine());
                }
                if (numberChoice == shot)
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

        static void Act3()
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

            string[] pattern = {"red", "blue", "green"};
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

        static void TheEnd()
        {
            Console.WriteLine("You have completed the game! \n" +
                "Thank you for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
