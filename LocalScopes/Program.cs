using System;

namespace LocalScopes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding curly brackets adds a new scope which can't be accessed from outside.
            int outside = 1;
            
            {
                int inside = outside;
                inside = 2;
            }

            outside = inside;
        }
    }
}
