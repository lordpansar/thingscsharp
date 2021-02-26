using System;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding an @ before the variable name allows you to use the normally reserved keywords in C# 
            var @double = 1.1;
            var @string = "All your base are belong to us";

            
            Console.WriteLine($"Your number is: {@double}");
            Console.WriteLine(@string);

            Console.ReadLine();
        }
    }
}
