using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"Result: {calc.SaltedSumm(10, 12)}");
        }
    }
}