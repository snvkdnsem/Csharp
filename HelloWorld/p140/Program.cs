/* 방법1
using System;

public class Delegate1
{
    private delegate int OnjSum(int i, int j); //1. 선언
    public static void Main(string[] args)
    {
        OnjSum myMethod = new OnjSum(Delegate1.Sum); //2. 생성, 메소드이름을 인자로
        //OnjSum myMethod = new OnjSum(Sum); //2. 생성
        //OnjSum myMethod = Sum; //2. 생성
        Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
    }
    static int Sum(int i, int j)
    {
        return i + j;
    }
}
//OnjSum myMethod = new OnjSum(Delegate1.Sum);에서 new OnjSum 생략가능
*/

/*
//방법2
using System;

public class Delegate1
{
   private delegate int OnjSum(int i, int j); //1. 선언
   public static void Main(string[] args)
   {
       Func<int, int, int> myMethod = Delegate1.Sum; //2. 생성, 메소드이름을 인자로
       //OnjSum myMethod = new OnjSum(Sum); //2. 생성
       //OnjSum myMethod = Sum; //2. 생성
       Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
   }
   static int Sum(int i, int j)
   {
       return i + j;
   }
}
// Func에 int가 3개인 이유는 int i, int j 2개의 파라미터가 앞에 두개이고
// static에 있는 int가 마지막 int이다.
*/

/*
// static 없을때
using System;

public class Delegate1
{
    private delegate int OnjSum(int i, int j); //1. 선언
    public static void Main(string[] args)
    {
        Delegate1 s = new Delegate1();
        Func<int, int, int> myMethod = s.Sum;
        Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
    }
    int Sum(int i, int j)
    {
        return i + j;
    }
}
//static이 없다면 객체참조가 필요하다.
*/

/*
// void 사용시
using System;

public class Delegate1
{
    private delegate int OnjSum(int i, int j); //1. 선언
    public static void Main(string[] args)
    {
        Delegate1 s = new Delegate1();
        Action<int, int> myMethod = s.Sum;
        myMethod(10, 30);
    }
    void Sum(int i, int j)
    {
        Console.WriteLine(i + j);
    }
}
*/

/*
// deligate
using System;

public class Delegate1
{
    public static void Main(string[] args)
    {
        Action<int, int> myMethod = delegate (int i, int j)
        {
            Console.WriteLine(i + j);
        };
        myMethod(10, 30);
    }
}
*/


// 람다식 사용
using System;

public class Delegate1
{
    public static void Main(string[] args)
    {
        Action<int, int> myMethod = (i, j) =>
            Console.WriteLine(i + j);
        myMethod(10, 30);
    }
}
// Action에 int가 선언되어 있으므로 ()괄호안의 int를 삭제해도 된다.