using System;

namespace Extra01
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create a program that prints in the command line o character code:
            // ® (registered trademark symbol)
            // Unicode Number: U+00AE

            char TrademarkSymbol = '\u00AE';
            Console.WriteLine(TrademarkSymbol);
        }
    }
}
