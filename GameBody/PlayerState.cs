using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody
{
    /// <summary>
    /// This class represents the game state, which includes whether the player has supplies and if they have a symbol clue.
    /// </summary>
    public class PlayerState
    {
        public bool hasSupplies { get; set; }
        public bool symbolClue { get; set; }
        public string playerName { get; set; }
    }
}
