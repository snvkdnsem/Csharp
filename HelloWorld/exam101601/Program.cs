using System;

namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 0;
            for (i=0; i<=2; i++)                
            {
                j = 0 + i;
                Console.WriteLine("i = {0} and j = {1}", i, j);
            }
        }
    }
}