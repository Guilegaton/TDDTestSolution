using System;
using System.Text;
using TDDTestSolution.Interfaces;

namespace TDDTestSolution.Services
{
    public class OddEvenService : IOddEvenService
    {
        private const string PRIME_TEXT = "Prime";
        private const string EVEN_TEXT = "Even";
        private const string ODD_TEXT = "Odd";

        /// <summary>
        /// Check three points for number: is number even? is number odd? is number prime?
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Information about number</returns>
        public string CheckNumber(uint number)
        {
            var result = string.Empty;
            if (IsPrime(number))
            {
                result = PRIME_TEXT;
            }
            else if (IsEven(number))
            {
                result = EVEN_TEXT;
            }
            else
            {
                result = ODD_TEXT;
            }

            return result;
        }

        /// <summary>
        /// Check three point for numbers in range: is number even? is number odd? is number prime?
        /// </summary>
        /// <param name="start">Start range position</param>
        /// <param name="end">End range position</param>
        /// <returns>Information about each number in range</returns>
        public string CheckRange(uint start, uint end)
        {
            var result = new StringBuilder(); 
            for (uint i = start; i <= end; i++)
            {
                result.Append($"{i} - {CheckNumber(i)}\r\n");
            }

            return result.ToString();
        }

        /// <summary>
        /// Check if number is prime
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Prime state for number</returns>
        private bool IsPrime(uint number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Check if number is even
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Even state for number</returns>
        private bool IsEven(uint number)
        {
            return number % 2 == 0;
        }
    }
}
