using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101604
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 4 };
            int bag = 0;

            for (int i = 1; i < arr.Length; i++) {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        bag = arr[j];
                        arr[j] = arr[i];
                        arr[i] = bag;
                    }
                }               
        }
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
