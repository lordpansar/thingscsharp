using static System.Console; //Referencing static types
using static UsingStatic.Logger;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSuccess = true;

            if(isSuccess)
            {
                Log("System is  a-okay!"); //Using a static member without referencing it's type
            }
            else
            {
                Log("The system is down :(");
            }

            WriteLine("All your base are belong to us"); //Also works with predefined static types

            ReadLine();
        }
    }
}