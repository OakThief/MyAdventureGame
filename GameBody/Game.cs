using MyAdventureGame.GameBody.GameSegments;
using MyAdventureGame.GameBody.InputChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody
{
    public class Game
    {
        public void Start()
        {
            var stringInputCheck = new StringInputCheck();

            var intro = new IntroSegment();
            var part1 = new SegmentA();
            var part2 = new SegmentB();
            var part3 = new SegmentC();
            var ending = new Ending();

            intro.Intro();
            part1.Part1();
            part2.Part2();
            part3.Part3();
            ending.EndDialouge();
        }
    }
}
