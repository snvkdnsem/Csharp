using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            int b = a;
            int c = 50000;

            try
            {
                short d = checked((short)c);
                Console.WriteLine("예외 : {0}", d);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외 : {0}", e.StackTrace);
                Console.WriteLine("예외 : " + e.StackTrace);
            }
        }
    }
}
