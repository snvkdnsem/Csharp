/*
using System;

namespace p141_예제1
{
    class OnjMath
    {
        internal static double MultipleByTwo(double value) { return value * 2; }
        internal static double Square(double value) { return value * value; }
    }
    delegate double OnjDouble(double x);
    class DelegateTest2
    {
        static void Main(string[] args)
        {
            //Delegate를 배열로 지정
            OnjDouble[] op =
           {
new OnjDouble(OnjMath.MultipleByTwo),
new OnjDouble(OnjMath.Square)
};
            for (int i = 0; i < op.Length; i++)
            {
                Console.WriteLine("op[{0}] 호출:", i);
                CallDelegate(op[i], 3.0); //Delegate를 다른 메소드의 인자로 넘긴다.
                                          //Console.WriteLine("결과는 {0} 이다", op[i](3.0));
                Console.WriteLine();
            }
        }
        static void CallDelegate(OnjDouble func, double value)
        {
            //넘겨받은 Delegate를 실행 한다.
            double ret = func(value);
            Console.WriteLine("입력된 값은 {0}이고 결과는 {1} 이다", value, ret);
        }
    }
}
*/

/*
//위의 예제에서 OnjDelegate라는 메소드를 호출할 필요없이 곧바로 delegate가 참조하는 메소드를 실행하려면 다음과 같이 하면 된다
using System;

// 델리게이트 작성 방법
// 1. 선언
// 2. 생성
// 3. 호출
//
// 델리게이트는 메소드를 참조하고 있는 것으로
// 런타임시 델리게이트가 참조하는 메소드를 실행하고
// 구현을 동적으로 할 수 있는 콜백 함수를 구현하는 용도

namespace p141_예제2
{
    class Program
    {
        public delegate int MyDelegate(int i, int j);
        public static void Main()
        {
            //TakesADelegate 메소드를 부르면서 인자로 델리게이트를
            //생성하고 델리게이트의 인자로는 참조할 메소드명을 넣어준다.
            TakesADelegate(new MyDelegate(Add));
            TakesADelegate(new MyDelegate(Minus));
            TakesADelegate(new MyDelegate(Gop));
            TakesADelegate(new MyDelegate(Nanugi));
        }
        public static void TakesADelegate(MyDelegate SomeFunction)
        {
            //컴파일 시점에 할일이 지정되지 않고 런타임중에
            //메소드 인자로 대입되는 델리게이트에 의해 할 일이 결정된다.
            Console.WriteLine(SomeFunction(1, 2));
        }
        public static int Add(int i, int j)
        {
            return i + j;
        }
        public static int Minus(int i, int j)
        {
            return i - j;
        }
        public static int Gop(int i, int j)
        {
            return i * j;
        }
        public static int Nanugi(int i, int j)
        {
            return i / j;
        }
    }
}
*/

/*
 // Invoke를 이용한 델리게이트 호출
using System;

namespace p141_예제3
{
    class Program
    {
        delegate void Deli(string s);
        static void Main()
        {
            // Specify delegate with Lambda Expression
            Deli d0 = (v) => Console.WriteLine(v);
            //Invoke delegate.
            d0.Invoke("OJC");
            // Specify delegate with new Constructor
            Deli d1 = new Deli(d);
            d1.Invoke("OJC");
            // Specify delegate with method name
            Deli d2 = d;
            d2.Invoke("OJC");
        }
        static void d(string s)
        {
            Console.WriteLine(s);
        }
    }
}
*/


// 델리게이트 체인 예제
using System;
using System.Collections.Generic;
using System.Text;
namespace p141_예제4
{
    delegate void OnjDelegate(int a, int b);
    class MainApp
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }
        static void Main()
        {
            MainApp m = new MainApp();
            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
           new OnjDelegate(MainApp.Plus),
           new OnjDelegate(MainApp.Minus),
            new OnjDelegate(m.Multiplication),
            new OnjDelegate(m.Division));
            CallBack(4, 3);
        }
    }
}