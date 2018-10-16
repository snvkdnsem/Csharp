using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam101605
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 4 };
            int minindex = 0;

            for(int i=0; i<arr.Length-1; i++)
            {
                minindex = i;
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[minindex]>arr[j])
                    {
                        minindex = j;
                    }
                }
                int bag = arr[minindex];
                arr[minindex] = arr[i];
                arr[i] = bag;
            }
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
