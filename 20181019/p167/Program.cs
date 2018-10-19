//p167
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("오라클자바커뮤니티");
            act1();
            int ret = 0;
            Action<int> act2 = (x) => ret = x * x;
            act2(2);
            Console.WriteLine("act2(2) :: {0}", ret);
            Action<double, double> act3 = (x, y) =>
            {
            double d = x / y; Console.WriteLine("Action<t1,t2>({0},{1}) : {2}", x, y, d);
            };
            act3(100, 3);
        }
    }
}

/*
[예제 2]
using System;
using System.Windows.Forms;
public delegate void ShowName();
public class Onj
{
    private string name;
    public Onj(string name) { this.name = name; }
    public void DisplayToConsole() { Console.WriteLine(this.name); }
    public void DisplayToWindow() { MessageBox.Show(this.name); }
}
public class Program
{
    public static void Main()
    {
        //delegate를 정의 후 호출
        Onj onj1 = new Onj("실무개발자닷넷교육");
        ShowName act1 = onj1.DisplayToWindow; act1();
        //Action delegate를 이용
        Onj onj2 = new Onj("오라클자바커뮤니티");
        Action act2 = onj2.DisplayToWindow; act2();
        //Action무명 메소드 이용
        Onj onj3 = new Onj("오라클자바커뮤니티교육센터");
        Action act3 = delegate ()
        {
            onj3.DisplayToWindow();
        };
        act3();
        //Action delegate에 람다식 이용
        Onj onj4 = new Onj("oraclejavacommunity");
        Action act5 = () => onj4.DisplayToWindow();
        act5();
    }
}
*/