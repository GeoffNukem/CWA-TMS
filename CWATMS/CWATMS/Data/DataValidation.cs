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
        /// Checks if a number is within a range. 
        /// </summary>
        /// <param name="num">The number to check</param>
        /// <param name="min">The minimum number in the range</param>
        /// <param name="max">The maximum number in the range</param>
        /// <param name="useLessThanOrEqualTo">Include the min and max values in the range</param>
        /// <returns>returns if the number is in the range</returns>
        public bool IsInRange(int num, int min, int max, bool useLessThanOrEqualTo = false)
        {
            return useLessThanOrEqualTo ? (num >= min && num <= max) : (num > min && num < max);
        }

        public static DataValidation Instance
        {
            get { return instance; }
        }
    }
}
