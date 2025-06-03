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
    public class StringInputCheck
    {
        /// <summary>
        /// This method checks if the input string is a valid non-empty string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValidString(string input)
        {
            do
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    input = Console.ReadLine();
                }
                else
                {
                    return true;
                }
            } 
            while (true);
        }
    }
}
