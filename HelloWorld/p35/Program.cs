using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p35
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int mok = 0;
            if (int.TryParse(num, out mok));
            string na = "";
            
            for(int i=mok; mok>0;)
            {
                na = (mok % 2) + na;
                mok = mok / 2;                
            }
            Console.WriteLine("{0}", na);
        }
    }
}