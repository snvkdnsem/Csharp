using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101501
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for(i=0; i<=10; i++)
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}", i);
            }            
        }
    }
}
