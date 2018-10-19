//(통합SW과정) C#,닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드)
/*
//1. 콤마로 구분해서 여러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.
using System;

namespace commasum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("숫자를 입력하세요.");
            Console.WriteLine("입력예제 1,2");

            string ent = Console.ReadLine();
            string[] str = ent.Split(',');
            int first, second;
            int sum = 0;

            first = int.Parse(str[0]);
            second = int.Parse(str[1]);

            Console.WriteLine("{0} + {1} = {2}", first, second, sum = first + second);
        }
    }
}
*/

/*
//2. 하나의 숫자를 입력받아서 홀수/짝수를 판정하세요.
using System;

namespace HJ
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int num;

            num = int.Parse(str);

            if( num % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
*/

/*
//3. 사용자로 부터 두수를 입력받아 변수에 넣고 변수값을 뒤짚어서 출력하는 프로그램 입니다. (C# Program to Swap two Numbers)
//코드를 완성하세요.
//[결과]
//Enter the First Number : 1 
//Enter the Second Number : 2 
//After Swapping :
//First Number : 2 
//Second Number : 1 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            temp = num2;
            num2 = num1;
            num1 = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.WriteLine("\nSecond Number : " + num2);

        }
    }
}
*/

/*
//4. 아래와 같이 출력하는 프로그램을 작성하세요.
//*
//***
//*****

using System;

namespace star
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 4; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    if(i % 2 == 0)
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
*/


//5. 실행결과가 아래와 같다.
//Enter a Number : 123
//Reverse of Entered Number : 321
//코드를 완성하세요

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
   class Program
   {
       static void Main(string[] args)
       {
           int num, reverse = 0;
           Console.Write("Enter a Number : ");
           num = int.Parse(Console.ReadLine());
           while (num != 0)
           {
               // 채워 주세요, 10으로 나누어서 몫, 나머지 이용
               if(num % 10 == 3)
                {
                    reverse = 
                }

           }
           Console.WriteLine("Reverse of Entered Number is : " + reverse);
           Console.ReadLine();
       }
   }
}


/*
//6. 사용자로 부터 하나의 수를 입력받고 그수까지의 소수의 합을 구하는 프로그램을 작성하세요.
*/

/*
//7. 간단한 C# 속성(Property) 예문 입니다. 결과를 보고 괄호를 채우세요
//[결과]
//Student Info: Code = 001, Name = Zara, Age = 9
//Student Info: Code = 001, Name = Zara, Age = 10

using System;
namespace tutorialspoint
{
   class Student
   {
       private string code = "N.A";
       private string name = "not known";
       private int age = 0;

       // Declare a Code property of type string:
       public string Code
       {
         (채워주세요 )
   }

   // Declare a Name property of type string:
   public string Name
   {
         ( 채워주세요 )
     }

   // Declare a Age property of type int:
   public int Age
   {
         ( 채워주세요 )
     }
   public override string ToString()
   {
       return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
   }
}

class ExampleDemo
{
   public static void Main()
   {

       // Create a new Student object:
       Student s = new Student();

       // Setting code, name and the age of the student
       s.Code = "001";
       s.Name = "Zara";
       s.Age = 9;
       Console.WriteLine("Student Info: {0}", s);

       //let us increase age
       s.Age += 1;
       Console.WriteLine("Student Info: {0}", s);
       Console.ReadKey();
   }
}
}
*/

/*
//8. 자동구현 속성 입니다.괄호를 채워주세요.

using System;

public class Customer
{
   public int ID {   (  )
}
public string Name { (  ) }
}

public class AutoImplementedCustomerManager
{
   static void Main()
   {
       Customer cust = new Customer();

       cust.ID = 1;
       cust.Name = "Amelio Rosales";

       Console.WriteLine(
           "ID: {0}, Name: {1}",
           cust.ID,
           cust.Name);

       Console.ReadKey();
   }
}
*/

/*
//9. 실행결과 참조해서 괄호 채워주세요.
//[실행결과]
//Zara
//Riz
//Nuha
//Asif
//Davinder
//Sunil
//Rubic
//N. A.
//N.A.
//N.A.
 
using System;
 
namespace IndexerApplication
{

    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    (  )
                }
                else
                {
                    (  )
                }

                return (  );
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
*/

/*
//10. 실행결과는? (먼저 예측하고 코딩해보세요.)
 
using System;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        List<int> elements = new List<int>() { 10, 20, 31, 40 };
        // ... Find index of first odd element.
        int oddIndex = elements.FindIndex(x => x % 2 != 0);
        Console.WriteLine(oddIndex);
    }
}
*/

/*
//11. 실행결과는? (먼저 예측하고 코딩해보세요.)
 
using System;
 
class Program
{
    static void Main()
    {
        //
        // Use implicitly-typed lambda expression.
        // ... Assign it to a Func instance.
        //
        Func<int, int> func1 = x => x + 1;
        //
        // Use lambda expression with statement body.
        //
        Func<int, int> func2 = x => { return x + 1; };
        //
        // Use formal parameters with expression body.
        //
        Func<int, int> func3 = (int x) => x + 1;
        //
        // Use parameters with a statement body.
        //
        Func<int, int> func4 = (int x) => { return x + 1; };
        //
        // Use multiple parameters.
        //
        Func<int, int, int> func5 = (x, y) => x * y;
        //
        // Use no parameters in a lambda expression.
        //
        Action func6 = () => Console.WriteLine();
        //
        // Use delegate method expression.
        //
        Func<int, int> func7 = delegate (int x) { return x + 1; };
        //
        // Use delegate expression with no parameter list.
        //
        Func<int> func8 = delegate { return 1 + 1; };
        //
        // Invoke each of the lambda expressions and delegates we created.
        // ... The methods above are executed.
        //
        Console.WriteLine(func1.Invoke(1));
        Console.WriteLine(func2.Invoke(1));
        Console.WriteLine(func3.Invoke(1));
        Console.WriteLine(func4.Invoke(1));
        Console.WriteLine(func5.Invoke(2, 2));
        func6.Invoke();
        Console.WriteLine(func7.Invoke(1));
        Console.WriteLine(func8.Invoke());
    }
}
*/

/*
//12. 실행결과는? (먼저 예측하고 코딩해보세요.)


int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = oneToTen.Where(n => n % 2 == 0);
 
foreach (int i in evenNumbers)
    Console.Write("{0} ", i);
*/

/*
//13. 실행결과는? (먼저 예측하고 코딩해보세요.)
 
using System;  
using System.Collections.Generic;  
using System.Linq;  
class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class demo
{
    static void Main()
    {
        List<Dog> dogs = new List<Dog>() {
            new Dog { Name = "Rex", Age = 4 },
            new Dog { Name = "Sean", Age = 0 },
            new Dog { Name = "Stacy", Age = 3 }
         };
        var names = dogs.Select(x => x.Name);
        foreach (var name in names)
        {
            Console.WriteLine(name);

        }
        Console.Read();
    }
}
*/

/*
//14. 괄호를 채워주세요.
//[실행결과]
//Number: 10,000 
//Number: 200 
//Money: $ 10,000.00 
//Money: $ 200.00
 
using System;
class Program
{
    // declare delegate
    public delegate void Print(int value);

    static void Main(string[] args)
    {
        // Print delegate points to PrintNumber
        Print printDel = (  );

        printDel(100000);
        printDel(200);

        // Print delegate points to PrintMoney
        printDel = (  );

        printDel(10000);
        printDel(200);
    }

    public static void PrintNumber(int num)
    {
        Console.WriteLine("Number: {0,-12:N0}", num);
    }

    public static void PrintMoney(int money)
    {
        Console.WriteLine("Money: {0:C}", money);
    }
}
*/

/*
//15.  실행결과는? (먼저 예측하고 코딩해보세요.)
 
using System;
using System.Threading;
class Program
{

    public static void Main(string[] args)
    {
        Thread[] t = new Thread[10];
        for (int tNum = 0; tNum < 10; tNum++)
        {
            t[tNum] = new Thread(() => {
                Thread.Sleep(new Random().Next(20));
                Console.Write(tNum + " ");
            });
            t[tNum].Start();
        }
        // wait for the threads to finish
        for (int tNum = 0; tNum < 10; tNum++)
        {
            t[tNum].Join();
        }
        Console.WriteLine("\nPress a key...");
        Console.Read();
    }
}
*/
