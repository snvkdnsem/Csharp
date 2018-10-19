/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. 임의의 수를 콤마로 구분해서 Console.ReadLine() 으로 입력 받은 후 델리게이트를
// 이용하여 사칙연산을 구하는 프로그램을 델리게이트 체인 및 델리게이트 멀티 캐스팅(델리게이트 체인을써보자)을
// 이용하여 구현하세요.

namespace ConsoleApp9
{
    //리턴할것은없고 바로 전달받은 값으로 계산해서 콘솔찍게 할거임
    public delegate void sachikOut(int i, int j);

    class Program
    {
        static void Main(string[] args)
        {
            Program d = new Program(); //Program여기에 있는 메소드 쓸꺼니까 해준다 안해주면 안됨!

            //이것이 체인이다
            sachikOut outHaja = (sachikOut)Delegate.Combine( //콤바인이 묶는다는것이다
                new sachikOut(d.plus),
                new sachikOut(d.minus),
                new sachikOut(d.gop),
                new sachikOut(d.na) //이것들을 묶어서 한꺼번에 하겠다
                );

            //이것이 멀티캐스팅이다
            sachikOut outHaja1 = new sachikOut(d.plus); //일단 넣고
            outHaja1 += new sachikOut(d.minus); //+=로 또넣는다
            outHaja1 += new sachikOut(d.gop); //+=로 또넣는다
            outHaja1 += new sachikOut(d.na); //+=로 또넣는다

            //이것이 멀티태스킹2다
            sachikOut outHaja2 = new sachikOut(d.plus); //이거 넣고 일단은 따로따로
            sachikOut outHaja3 = new sachikOut(d.minus); //이거도 넣고 일단은 따로따로
            sachikOut outHaja4 = new sachikOut(d.gop); //이거도 넣고 일단은 따로따로
            sachikOut outHaja5 = new sachikOut(d.na); //이거도 넣는다 일단은 따로따로

            sachikOut outHaja6 = outHaja2 + outHaja3 + outHaja4 + outHaja5;// 그다음에 하나로 합체

            outHaja(6, 5);
            Console.WriteLine("\n여기까지가 체인\n");
            outHaja1(5, 4);
            Console.WriteLine("\n여기까지가 멀티 태스킹\n");
            outHaja6(4, 3);
            Console.WriteLine("\n여기까지가 멀티 태스킹2\n");
        }


        //델리게이트가 볼 메소드를 일단 만들었다
        void plus(int i, int j)
        {
            Console.WriteLine(i + "+" + j + "=" + (i + j));
        }
        void minus(int i, int j)
        {
            Console.WriteLine(i + "-" + j + "=" + (i - j));
        }
        void gop(int i, int j)
        {
            Console.WriteLine(i + "*" + j + "=" + (i * j));
        }
        void na(int i, int j)
        {
            Console.WriteLine(i + "/" + j + "=" + (i / j));
        }
    }

}
*/ 
 
/*
using System;
 
public delegate void Callback();

class Program

{

    static void Main(string[] args)

    {

        MyClass my = new MyClass();

        //Direct call

        my.MyMethod1();

        my.MyMethod2();

        Console.WriteLine("------------");

        // Call via a delegate

        // MyClass의 GetCallback(Callback callBack) 메소드를 호출하여

        // MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요



        // 1.MyClass의 GetCallback쓸거니까 MyClass my = new MyClass(); 해준다
        // 2.my.으로 접근한다 --> my.GetCallback()
        // 3.my.GetCallback()의 파라미터 자리에 바로 델리게이트 생성하여 전달한다 my.GetCallback(new Callback());
        // 4.GetCallback메소드의 내용이 메소드 전달받아 메소드 호출이니까 파라미터로 호출할 메소드를 바로넣는다
        // 5.my.GetCallback(new Callback(my.MyMethod1));
        my.GetCallback(my.MyMethod1); //생략이 가능하다!!
        my.GetCallback(new Callback(my.MyMethod2));

    }

}

public class MyClass

{

    public MyClass() { }

    public void GetCallback(Callback Back)

    {

        Back();

    }

    public void MyMethod1()

    {

        Console.WriteLine("My Method 1");

    }

    public void MyMethod2()

    {

        Console.WriteLine("My Method 2");

    }

}
*/
 
/*
using System;
 
using System.IO;
 
namespace DelegateAppl

{

    class PrintString

    {

        static FileStream fs;

        static StreamWriter sw;

        // 델리게이트 선언

        //(채워 주세요)
        //아래 델리게이트 생성하는 구문에서 델리게이트 이름가져왔다
        //그 구문에서 쓰는(보는) 메소드(델리게이트와 인자와 리턴형이 동일해야함)을 보고 리턴형과 인자를 넣었다
        public delegate void printString(string s);//

        // 콘솔화면에 출력

        public static void WriteToScreen(string str)

        {

            Console.WriteLine("The String is: {0}", str);

        }

        //파일에 출력

        //public static void WriteToFile(string s)

        //{

        //    fs = new FileStream("d:\\message.txt",

        //    FileMode.Append, FileAccess.Write);

        //    sw = new StreamWriter(fs);

        //    sw.WriteLine(s);

        //    sw.Flush();

        //    sw.Close();

        //    fs.Close();

        //}

        // 델리게이트를 인자로 받아 실행

        // 결국 델리게이트가 참조하는 메소드 실행된다.

        public static void sendString(printString ps)

        {

            ps("Hello Korea~");// sendString(ps1); 이런식으로 써서 할라믄 ps1=WriteToScreen이고 WriteToScreen이 문자열전달받아 콘솔찍는 메소드니까 이렇게 해주면 된다
                               //전달받은 메소드를 문자열 넣어서 호출하겠다라는 뜻이다

        }

        static void Main(string[] args)

        {

            //printString ps1 = new printString(WriteToScreen);//ps1에   델리게이트 집어넣었다
            printString ps1 = WriteToScreen;//ps1에   델리게이트 집어넣었다 이렇게 해도된다 생략가능!!

            //printString ps2 = new printString(WriteToFile);

            sendString(ps1);

            //sendString(ps2); //이건  파일에 출력하는건데 WriteToFile가 파악도 잘안됬고 당장문제푸는데는 상관없으니까 주석처리

            Console.ReadKey();

        }

    }

}
*/

/*
//(통합SW과정 이벤트, 델리게이트 기초 실습과제)

//1. 괄호채우기
//[결과]
//Static method: 10
//My instance: 5
 
using System;
 
public delegate string FirstDelegate(int x);

class DelegateTest
{
    string name;

    static void Main()
    {
        FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);
        DelegateTest instance = new DelegateTest();
        instance.name = "My instance";
        FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

        Console.WriteLine(d1(10)); // Writes out "Static method: 10"
        Console.WriteLine(d2(5));  // Writes out "My instance: 5"
    }

    static string StaticMethod(int i)
    {
        return string.Format("Static method: {0}", i);
    }

    string InstanceMethod(int i)
    {
        return string.Format("{0}: {1}", name, i);
    }
}
*/

/*
//2. 실행결과는?
 
using System;
 
class Test
{
    public event EventHandler MyEvent
    {
        add
        {
            Console.WriteLine("add operation");
        }

        remove
        {
            Console.WriteLine("remove operation");
        }
    }

    static void Main()
    {
        Test t = new Test();

        t.MyEvent += new EventHandler(t.DoNothing);
        t.MyEvent -= null;

    }

    void DoNothing(object sender, EventArgs e)
    {
        Console.WriteLine("DoNothing Called...");
    }
}
*/

/*
//3. 괄호채우기 
//[결과]
//iAnswer = 7
//Multiple of five reached!
//iAnswer = 10
 
using System;
public class Adder
{
    public delegate void EventRaiser();
    public event EventRaiser OnMultipleOfFiveReached;
 
    public int Add(int x, int y)
    {
        int iSum = x + y;
        if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
        {
            //EventRaiser m = new EventRaiser(Program.);
            OnMultipleOfFiveReached();
        }
        return iSum;
    }
}
 
class Program
{
    static void Main()
    {
        Adder a = new Adder();
        a.OnMultipleOfFiveReached += MultipleOfFiveReached;//static이 있기 때문에 new EventRaiser 및 a.MultipleOfFiveReached 할 필요가 없다.

        int iAnswer = a.Add(4, 3);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        iAnswer = a.Add(4, 6);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        Console.ReadKey();
    }
 
    static void MultipleOfFiveReached()
    {
        Console.WriteLine("Multiple of five reached!");
    }
}
*/

/*
//4. 이벤트 호출시 데이터를 넘기는 예제 입니다.괄호채워 주세요
//[실행결과]
//iAnswer = 7
//Multiple of five reached:
//iAnswer = 10
 
using System;
 
class Program
{
    static void Main()
    {
        Adder a = new Adder();
        a.OnMultipleOfFiveReached += new EventHandler<MultipleOfFiveEventArgs>(a_MultipleOfFiveReached);
        int iAnswer = a.Add(4, 3);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        iAnswer = a.Add(4, 6);
        Console.WriteLine("iAnswer = {0}", iAnswer);
        Console.ReadKey();
    }

    static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)
    {
        Console.WriteLine("Multiple of five reached: " +  e.Total);
    }
}

public class Adder
{
    public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
    public int Add(int x, int y)
    {
        int iSum = x + y;
        if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
        {
            OnMultipleOfFiveReached(null, new MultipleOfFiveEventArgs(iSum)); 
        }
        return iSum;
    }
}

public class MultipleOfFiveEventArgs : EventArgs
{
    public MultipleOfFiveEventArgs(int iTotal)
    {
        Total = iTotal;
    }
    public int Total { get; set; }
}
*/

/*
//5. 다이렉트 호출 스크립트 입니다.
 
using System;
 
namespace A
{
    public delegate void Name();
    public delegate void Name2(string s);
    public class MyClass
    {
        public void Process()
        {
            Console.WriteLine("Process() begin");
            Console.WriteLine("Process() end");
        }
        public void SayHo(string s) {
            Console.WriteLine("형 밥사줘 {0}", s);
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Process();
            Name deli = new Name(myClass.Process);
            deli();
            Action deli2 = myClass.Process;
            deli2();

            Name2 deli3 = new Name2(myClass.SayHo);
            deli3("신구에게 지금당장");
            Action<string> deli4 = myClass.SayHo;
            deli4("집에가자");
        }
    }
}

//델리게이트를 사용하여 호출하는 예제로 재작성 하세요.
//1. 델리게이트를 별도로 선언하여
//2. Action 델리게이트를 이용하여
//1. 델리게이트를 별도로 선언하여
//2. Func 델리게이트를 이용하여
*/


//6. 괄호 채워 주세요
//[c:\GitHub\process.log 파일의 내용]
//Process() begin
//Process() end


using System;
using System.IO;

namespace Akadia.SimpleDelegate
{
   public class MyClass
   {
       public delegate void LogHandler(string message);
       public void Process(LogHandler logHandler)
       {
            logHandler("Process() begin");
            logHandler("Process() end");
        }
   }

   public class FileLogger
   {
       FileStream fileStream;
       StreamWriter streamWriter;

       // Constructor
       public FileLogger(string filename)
       {
           fileStream = new FileStream(filename, FileMode.Create);
           streamWriter = new StreamWriter(fileStream);
       }

       // Member Function which is used in the Delegate
       public void Logger(string s)
       {
           streamWriter.WriteLine(s);
       }

       public void Close()
       {
           streamWriter.Close();
           fileStream.Close();
       }
   }

   public class TestApplication
   {
       static void Main(string[] args)
       {
           FileLogger fl = new FileLogger("c:\\GitHub\\process.log");

           MyClass myClass = new MyClass();

           MyClass.LogHandler myLogger = new MyClass.LogHandler(fl.Logger);
            myClass.Process(myLogger);
           fl.Close();
       }
   }
}
