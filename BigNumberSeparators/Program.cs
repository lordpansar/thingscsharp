using System;

namespace BigNumberSeparators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Increase readability in big numbers by adding underscores. The compiler will ignore them.
            int myInt = 2_146_654_442;
            long myLong = 4_000_000_000;
            short myShort = 1_2_3;
            double mydouble = 20_123_443.9;
            float myFloat = 12_313.23f;
            decimal myDecimal = 1.126_549_878_945_641m;


            Console.WriteLine($"Your number is {myInt}");
            Console.ReadLine();
        }
    }
}
