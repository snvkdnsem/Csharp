using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyConstants
    {
        public const double PI = 3.14; // const는 new 작성 필요없이 클래스를 가져와 사용할 수 있다.(자바에서는 class 내용을 사용하려면 new가 필요하기 때문)
        public const int MYAGE = 22;
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2;
            double area = MyConstants.PI * (radius * radius);
            Console.WriteLine("Area = {0}, Age = {1}", area, MyConstants.MYAGE);

            const string name = "홍길동";

            Console.WriteLine("name : " + name);

        }
    }
}
