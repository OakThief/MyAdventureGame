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
        public static bool IsValidInteger(string input)
        {
            int number;
            do
            {
                if (!int.TryParse(input, out number))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Input must be a valid integer. Please try again.");
                    input = Console.ReadLine();
                }
            }
            while (true);
        }
    }
}
