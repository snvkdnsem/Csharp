using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101504
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            int num = 9;
            int mul = 0;
            for(i=1; i<=9; i++)
                for(j=1; j<=9; j++)
                {
                    mul = i * j;
                    Console.WriteLine("{0}x{1}={2}", i, j, mul);
                }
        }
    }
}
