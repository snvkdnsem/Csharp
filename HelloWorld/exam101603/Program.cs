using System;

namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int i = 1;
            for (i=1; i<=5;)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
                i++;
            }
        }
    }
}