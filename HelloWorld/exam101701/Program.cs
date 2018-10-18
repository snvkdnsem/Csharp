/*
//과제101701
using System;

namespace ConsoleApplication3

{
    class Program
    {
        static void Main(string[] args)
        {
            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4
            int[][] a = new int[3][];
            a[0] = new int[]{ 1, 2};
            a[1] = new int[] { 1, 2, 3 };
            a[2] = new int[] { 1, 2, 3, 4 };

            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)
            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //가변배열 출력
            foreach (int[] i in a)
            {
                foreach (int j in i)
                {
                    Console.Write(j + "");
                }
                Console.Write(",");
            }

            Console.WriteLine("\n---------------\n");
            //이차원 배열 출력
            foreach (int k in b)
            {
                Console.Write(k + "");                
            }            
        }
    }
}
*/

/*
//과제101702
using System;
using System.Collections.Generic;

namespace ConsoleApplication17

{
    class Program
    {
        static void Main(string[] args)
        {
            //----4행2열
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };            
            for (int i=0; i<4; i++ )
            {
                for (int j=0; j<2; j++ )
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();
            foreach (int k in twoDim)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
    }
}
*/

/*
//과제101703
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101703
{
    class Program
    {
        static void Main()
        {
            // This is a zero-element int array.
            var values1 = new int[] { };
            Console.WriteLine(values1.Length);

            // This is a zero-element int array also.
            var values2 = new int[0];
            Console.WriteLine(values2.Length);
        }
    }
}
*/

/*
//과제101704
using System;

class Program
{
    static void Main()
    {
        // Loop over array of integers.
        foreach (int id in GetEmployeeIds())
        {
            Console.WriteLine(id);
        }
        // Loop over array of integers.
        int[] employees = GetEmployeeIds();
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }

    /// <summary>
    /// Returns an array of integers.
    /// </summary>
    static int[] GetEmployeeIds()
    {
        int[] employees = new int[5];
        employees[0] = 1;
        employees[1] = 3;
        employees[2] = 5;
        employees[3] = 7;
        employees[4] = 8;
        return employees;
    }
}
*/

/*
//과제101705
using System;

class Program
{
    static void Main()
    {
        // Declare new int array.
        int[] teams = new int[3];
        teams[0] = 1;
        teams[1] = 2;
        teams[2] = 3;

        // New employee that stores int array reference.
        Employee employee = new Employee(teams);
        
        // Loop through each int in employee's class.
        foreach (int team in employee.Teams)
        {
            Console.WriteLine(team);
        }
    }
}

/// <summary>
/// Stores an employee and his teams.
/// </summary>
class Employee
{
    /// <summary>
    /// Int array reference at class level.
    /// </summary>
    int[] _teams;

    /// <summary>
    /// Create new employee.
    /// </summary>
    /// <param name="teams">Teams for the employee.</param>
    public Employee(채워주세)
    {
        _teams = teams;
    }

    /// <summary>
    /// Get array of teams.
    /// </summary>
    public (채워주세요  ) Teams
    {
        get
        {
            return (채워주세요);
        }
    }
}
*/

/*
//과제101706
using System;


//일반화 클래스
class DataStore<T>
{
 
    private T[] s = new T[10];

public T this[int index]
{
    get
    {
        if (index < 0 || index >= s.Length)
            throw new IndexOutOfRangeException("Cannot store more than 10 objects");
        return s[index];
    }
    set
    {
        if (index < 0 || index >= s.Length)
            throw new IndexOutOfRangeException("Cannot store more than 10 objects");
        s[index] = value;
    }
}
}
 
class Program
{
    static void Main(string[] args)
    {
        DataStore<string> ds1 = new DataStore<string>();

        ds1[0] = "One";
        ds1[1] = "Two";
        ds1[2] = "Three";

        for (int i = 0; i < 3; i++)
            Console.WriteLine(ds1[i]);

        DataStore<int> ds2 = new DataStore<int>();

        ds2[0] = 1;
        ds2[1] = 2;
        ds2[2] = 3;

        for (int i = 0; i < 3; i++)
            Console.WriteLine(ds2[i]);

        ds2[11] = 11;
    }
}
*/

/*
//과제101707
using System;

class DataStore
{
    private string[] strArr = new string[10]; // internal data storage

    public DataStore() { }
    public string this [int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            return strArr[index];
        }
        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            strArr[index] = value;
        }
    }

    public string this[string name] // if문에 ToLower가 string이므로 [string name]으로 작성해줘야한다.
    {
        get
        {
            foreach (string s in strArr) // if문에 ToLower가 string이므로 string s로 작성 해줘야한다.
            {
                if (s.ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataStore strStore = new DataStore();
        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";

        Console.WriteLine(strStore["ONE"]);
        Console.WriteLine(strStore["two"]);
        Console.WriteLine(strStore["Three"]);
        Console.WriteLine(strStore["FOUR"]);
    }
}
*/

/*
//과제101708
//인덱서 오버로딩 예제 입니다.결과를 보고 코드의 괄호를 채워 주세요~

using System;

/// <summary>
///     Implements overloaded indexers.
/// </summary>
class OvrIndexer
{
    private string[] myData;
    private int arrSize;

    public OvrIndexer(int size)
    {
        arrSize = size;
        myData = new string[size];

        for (int i = 0; i < size; i++)
        {
            //myData setting
            myData[i] = "empty";
        }
    }

    public string this[int pos]
    {
        get
        {
            return myData[pos];
        }
        set
        {
            myData[pos] = value;
        }
    }

    public string this[string data]
    {
        get
        {
            int count = 0;

            for (int i = 0; i < arrSize; i++)
            {
                if (myData[i] == data)
                {
                    count++;
                }
            }
            return count.ToString();
        }
        set
        {
            for (int i = 0; i < arrSize; i++)
           {
                if (myData[i] == data)
                {
                    myData[i] = value;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int size = 10;
        OvrIndexer myInd = new OvrIndexer(size);

        myInd[9] = "Some Value";
        myInd[3] = "Another Value";
        myInd[5] = "Any Value";

        myInd["empty"] = "no value";

        Console.WriteLine("\nIndexer Output\n");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
        }

        Console.WriteLine("\nNumber of \"no value\" entries: {0}", myInd["no value"]);
    }
}
*/