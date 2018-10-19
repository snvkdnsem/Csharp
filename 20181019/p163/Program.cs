using System;
namespace Lambda
{
    class Program
    {
        delegate int Sum(int[] arg);
        static void Main(string[] args)
        {
            Sum sumdeli = (arg) => {
                int mySum = 0;
                foreach (int i in arg) mySum += i;
                return mySum;
            };
            int sum = sumdeli(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("1+2+3+4+5=" + sum);
        }
    }
}

/*
//- 람다식에서의 변수 범위예제
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication4
{
    //델리게이트 정의
    delegate bool Onj1();
    delegate bool Onj2(int i);
    class Program
    {
        Onj1 onj1; Onj2 onj2;
        public void MyMethod(int input)
        {
            int onjVal = 0;
            onj1 = () => {
                onjVal = 999;
                return input > onjVal;
            };
            onj2 = (x) => {
                return x == onjVal;
            };
            // 델리게이트가 아직 호출되지않음,
            Console.WriteLine("onjVal = {0}", onjVal);
            bool myRet1 = onj1();
            Console.WriteLine("onj1 :: 메소드 입력값이 999보다 큰가? {0}", myRet1);
            bool myRet2 = onj2(0);
            Console.WriteLine("onj2 :: onjVal == 0 ? {0}", myRet2);
            bool myRet3 = onj2(999);
            Console.WriteLine("onj2 :: onjVal == 999 ?? {0}", myRet3);
        }
        static void Main(string[] args)
        {
            Program p = new Program(); p.MyMethod(999);
        }
    }
}*/
