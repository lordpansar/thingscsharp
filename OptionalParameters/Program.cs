using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //By setting one or more default values in the method signature, you can call the method without passing all required data. 
            PrintPersonInfo("Alex", 32, "Software developer");
            PrintPersonInfo("Kim", 29);
            Console.ReadLine();
        }

        public static void PrintPersonInfo(string name, int age, string occupation = "Unemployed")
        {
            Console.WriteLine($"Name: {name} Age: {age} Occupation: {occupation}");
        }
    }
}
