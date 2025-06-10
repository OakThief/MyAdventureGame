using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.GameBody.InputChecks
{
    /// <summary>
    /// This class provides a method to check if the input string is not null or whitespace.
    /// </summary>
    public class StringInputCheck
    {
        /// <summary>
        /// Continuously prompts the user for input until a valid, non-empty string is provided.
        /// </summary>
        /// <param name="input">Initial input (optional).</param>
        /// <returns>A valid, non-empty string.</returns>
        public static string IsValidString(string input)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty or whitespace. Please try again.");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
