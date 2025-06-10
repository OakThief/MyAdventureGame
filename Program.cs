using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;
using MyAdventureGame.GameBody.InputChecks;
using MyAdventureGame.GameBody.GameSegments;
using MyAdventureGame.GameBody;

namespace MyAdventureGame
{
    /// <summary>
    /// This class represents the main entry point for the game application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the game application. It initializes the game and starts the adventure.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            var game = new Game();
            game.Start();
        }
    }
}
