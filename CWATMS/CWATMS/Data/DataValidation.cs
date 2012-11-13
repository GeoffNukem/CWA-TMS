using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public sealed class DataValidation
    {
        private static readonly DataValidation instance = new DataValidation();

        private DataValidation() { }

        /// <summary>
        /// Checks if a string contains any numbers
        /// </summary>
        /// <param name="text">Text to check for numbers</param>
        /// <returns>Boolean value if the string contains numbers</returns>
        public bool ContainsNumbers(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Is an Integer within a range.
        /// </summary>
        /// <param name="num">Number to check</param>
        /// <param name="min">Minimum number</param>
        /// <param name="max">Maximum number</param>
        /// <param name="lessThanOrEqualTo">Can number equal to the min and max numbers</param>
        /// <returns>Returns if the number is between the min & max values</returns>
        public bool IsInRange(int num, int min, int max, bool lessThanOrEqualTo = false)
        {
            return lessThanOrEqualTo ? (num >= min && num <= max) : (num > min && num < max);
        }

        public static DataValidation Instance
        {
            get { return instance; }
        }
    }
}
