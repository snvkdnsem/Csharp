/*
//과제101501
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
*/

/*
//과제101502
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
*/

/*
//과제101503
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
*/

/*
//과제101504
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
*/