using System;

namespace Obsolete
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding the Obsolete attribute to a method allows you to give information about the method's current status.
            //There is also an overload that allows you to set whether the attribute should mark usage of the method as an error or just as a warning.
            MyObsoleteMethod();
            MyNewMethod();

            //It also works on class level!
            var myPrettyObject = new MyPrettyClass();

            Console.ReadLine();
        }

        [Obsolete("This endpoint is nearing end of life. Consider upgrading to v2.0 of our API", false)]
        public static void MyObsoleteMethod()
        {
            Console.WriteLine("I'm old and broken!");
        }

        public static void MyNewMethod()
        {
            Console.WriteLine("Brand spanking new!");
        }
    }
}