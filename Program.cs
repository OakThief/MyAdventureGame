using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;
using MyAdventureGame.GameBody.InputChecks;
using MyAdventureGame.GameBody.GameSegments;
using MyAdventureGame.GameBody;

namespace MyAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var game = new Game();
            game.Start();
        }
    }
}
