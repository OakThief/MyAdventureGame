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
        /// This method checks if the input string is a valid integer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetValidIntegerInput(string prompt)
        {
            bool isValid = false;
            int parsedInteger;

            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out parsedInteger))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            return parsedInteger;
        }

    }
}
