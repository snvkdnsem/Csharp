using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101502
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 0, j = 0;
            int num=10;

            for (i = 0; i <= num; i++)
            {
                j = 0 + i;
                sum = sum + j;
            }
            Console.WriteLine("{0}까지의 합은 {1}", num, sum);
        }
    }
}
