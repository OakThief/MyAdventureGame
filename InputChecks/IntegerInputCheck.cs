using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame.InputChecks
{
    /// <summary>
    /// This class provides a method to check if the input string is a valid integer.
    /// </summary>
    public class IntegerInputCheck
    {
        /// <summary>
        /// This method checks if the input string is a valid integer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValidInteger(string input)
        {
            do
            {
                if (!int.TryParse(input, out _))
                {
                    Console.WriteLine("Input must be a valid integer. Please try again.");
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
