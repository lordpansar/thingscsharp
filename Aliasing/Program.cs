﻿using MyNamespaceAlias = System.Console; //Assigning System.Console to the alias myPrettyAlias
using MyTypeAlias = Aliasing.MyPrettyClass; //Assigning the type MyPrettyClass to the alias MyPrettyAlias


namespace Aliasing
{
    class Program
    {
        static void Main(string[] args)
        {
            //The above created namespace alias in action
            MyNamespaceAlias.WriteLine("This text is brought to you by the namespace alias myPrettyAlias!");
            MyNamespaceAlias.ReadLine();

            var myPrettyObject = new MyTypeAlias(); //An instance of the class MyPrettyClass as the alias MyTypeAlias

            myPrettyObject.DoStuff();
        }
    }
}
