using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101503
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 0, j = 0;
            float num = 10;

            for(i=1; i<=num; i++)
            {
                Console.WriteLine("숫자{0}", i);
                j = 0 + i;
                sum = sum + i;
            }
            Console.WriteLine("합{0}", sum);
            Console.WriteLine("평균{0}", sum / num);
        }
    }
}
