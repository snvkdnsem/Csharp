using System;

namespace p42
{
    class Emp
    {
        //private string name; // c#은 접근제어자를 주지 안주면 private로 준다.
        //protected string name; // 자식클래스에서 접근 가능
        //internal string name; // 같은 어셈블리(.exe/.dll)에서 접근 가능하다.
        //public string name; // 위에 명령어들보다 더 큰 의미
        public string Name // 자동구현속성
        {
            get; set;
        }
        
        class EmpTest
        {
            static void Main()
            {
                Emp e = new Emp();
                e.Name = "KIM";
                Console.WriteLine(e.Name);
            }
        }
    }
}
