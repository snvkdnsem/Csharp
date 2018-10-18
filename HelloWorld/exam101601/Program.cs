/*
//과제101601
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
*/

/*
//과제101602
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
*/

/*
//과제101603
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3,5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');
            if (strarr.Length != 2)
            {
                Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
                return;
            }
            int first, second;
            try
            {
                first = int.Parse(strarr[0]);
                second = int.Parse(strarr[1]);
            }
            catch
            {
                Console.WriteLine("입력이 잘못되었습니다.");
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
            Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
            Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
            Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
        }
        static double Calc(int first, int second, string op)
        {
            double result = 0;
            switch (op)
            {
                case"+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
            }
            return result;
        }
    }
}
*/

/*
//과제101604
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101604
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 4 };
            int bag = 0;

            for (int i = 1; i < arr.Length; i++) {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        bag = arr[j];
                        arr[j] = arr[i];
                        arr[i] = bag;
                    }
                }               
        }
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
*/

/*
//과제101605
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101605
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 4 };
            int minindex = 0;

            for(int i=0; i<arr.Length-1; i++)
            {
                minindex = i;
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[minindex]>arr[j])
                    {
                        minindex = j;
                    }
                }
                int bag = arr[minindex];
                arr[minindex] = arr[i];
                arr[i] = bag;
            }
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
*/
