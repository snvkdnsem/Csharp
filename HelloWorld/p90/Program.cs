using System;

namespace p90
{
    class Program
    {
        static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            int a; int b;

            Console.WriteLine("a={0}, b={1}", a, b);
            //Swap(a, b); // 메모리에 사라져 밑에 코드에 적용이 안된다.

            //Swap(ref a, ref b); // 주소값을 참조한다.
                                // 변수의 값이 초기화 되어 있어야한다.(변수에 값이 있어야됨)

            Swap(out a, out b); //변수의 값이 초기화 되어 있지 않아야한다.
            Console.WriteLine("a={0}, b={1}", a, b);
        }
    }
}
