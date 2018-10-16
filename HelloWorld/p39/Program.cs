using System;

namespace p39
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            ParamsTest p = new ParamsTest();
            Console.WriteLine(p.Sum(1, 2));
            Console.WriteLine(p.Sum(1, 2, 3));
        }
        int Sum(params int[] iArray)
        {
            int sum = 0;
            foreach (int i in iArray) sum += i;
            return sum;
        }
    }
}
