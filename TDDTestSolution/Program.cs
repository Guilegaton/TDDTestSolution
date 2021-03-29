using System;
using TDDTestSolution.Services;

namespace TDDTestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var lcdService = new LCDDigitsService();
            var oddEvenService = new OddEvenService();
            var wrapService = new WordWrapService(5);

            // test of lcd service using all available digits
            Console.WriteLine(lcdService.Convert(1234567890));

            // test of odd even service using each type of numbers
            Console.WriteLine(oddEvenService.CheckNumber(1));
            Console.WriteLine(oddEvenService.CheckNumber(2));
            Console.WriteLine(oddEvenService.CheckNumber(4));

            // test of odd even service using range of number
            Console.WriteLine(oddEvenService.CheckRange(1, 1000));

            // test of wrap service
            Console.WriteLine(wrapService.WordWrap("The quick brown fox jumps over the lazy dog"));
        }
    }
}
