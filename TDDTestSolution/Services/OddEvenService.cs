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

        public string CheckRange(uint start, uint end)
        {
            var result = new StringBuilder(); 
            for (uint i = start; i <= end; i++)
            {
                result.Append($"{i} - {CheckNumber(i)}\r\n");
            }

            return result.ToString();
        }

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

        private bool IsEven(uint number)
        {
            return number % 2 == 0;
        }
    }
}
