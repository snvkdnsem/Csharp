using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181024
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("Top");
            mystack.Push("Middle");
            mystack.Push("Bottom");

            Console.WriteLine(mystack.Count);

            Console.WriteLine(mystack.Peek());
        }
    }
}
