using MyAdventureGame.GameBody.GameSegments;
using MyAdventureGame.GameBody.InputChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody
{
    /// <summary>
    /// This class represents the main game logic, orchestrating the flow of the game segments.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Starts the game by initializing the segments and executing them in order.
        /// </summary>
        public void Start()
        {
            var stringInputCheck = new StringInputCheck();
            var intro = new IntroSegment();
            var part1 = new SegmentA();
            var part2 = new SegmentB();
            var part3 = new SegmentC();
            var ending = new Ending();
            var gameState = new GameState();

            intro.Intro(gameState, stringInputCheck);
            part1.Part1(gameState, stringInputCheck);
            part2.Part2(gameState, stringInputCheck);
            part3.Part3(gameState, stringInputCheck);
            ending.EndDialouge();
        }
    }
}
