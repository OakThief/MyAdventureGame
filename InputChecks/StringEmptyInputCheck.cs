using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.InputChecks
{
    /// <summary>
    /// This class provides a method to check if the input string is not null or whitespace.
    /// </summary>
    public class StringEmptyInputCheck
    {
        /// <summary>
        /// This method checks if the input string is valid (not null or whitespace).
        /// Returns to the console if the input is invalid and prompts the user to try again.
        /// </summary>
        public static bool IsValidString(string input)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                return false;
            }
            return true;
        }
    }
}
