using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;
using MyAdventureGame.InputChecks;
using MyAdventureGame.GameSegments;

namespace MyAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var stringInputCheck = new StringInputCheck();

            var intro = new Intro();
            var part1 = new Part1();
            var part2 = new Part2();
            var part3 = new Part3();
            var ending = new Ending();

            intro.Run();
            part1.Run();
            part2.Run();
            part3.Run();
            ending.Run();
        }
    }
}
