using MyAdventureGame.GameBody.GameSegments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.InputChecks
{
    /// <summary>
    /// This class provides a method to check if the input string is a valid integer.
    /// </summary>
    public class IntegerInputCheck
    {
        /// <summary>
        /// This method checks if the input string is a valid integer and greater than or equal to zero.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool GetValidIntegerInput(string input, out int number)
        {
            return int.TryParse(input, out number) && number >= 0;
        }

    }
}
