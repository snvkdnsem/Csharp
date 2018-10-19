﻿//델리게이트, 람다식을 이용한 익명메소드 구현
using System;

namespace p160
{
    class Program
    {
        delegate int Calc(int i, int j);

        static void Main(string[] args)
        {
            Calc c = new Calc(MySum); // 이 델리게이트는 이름있는 외부 메소드를 참조
            Console.WriteLine("1+2={0}", c(1, 2));

            Calc c1 = delegate (int i, int j) // 델리게이드를 이용한 익명 메소드
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));

            Calc c2 = (int a, int b) => a + b;
            Console.WriteLine("3+4={0}", c2(3, 4));

            // "형식 유추(Type Inference)"라고 해서 매개변수의 형식을 제거할 수 있다.
            // (델리게이트의 선언 코드로부터 형식을 유추함)
            Calc c3 = (a, b) => a + b;
            Console.WriteLine("3+4={0}", c3(3, 4));
        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
