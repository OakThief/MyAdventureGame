using MyAdventureGame.InputChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameSegments
{
    internal class Intro
    {
        public void Run()
        {
            Console.WriteLine("Welcome to my Adventure Game! \n" +
               "This is a 5 minute text adventure to showcase what i've been learning.");
            Thread.Sleep(1500);
            Console.WriteLine("Please enter your name:");

            string playerName = Console.ReadLine();

            while (!StringEmptyInputCheck.IsValidString(playerName))
            {
                playerName = Console.ReadLine();
            }

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
    }
}
