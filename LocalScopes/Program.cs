using System;

namespace LocalScopes
{
    class Program
    {
        static void Main(string[] args)
        {
            int outside = 1;
            
            {
                int inside = outside;
                inside = 2;
            }

            outside = inside;
        }
    }
}
