//C#, 이벤트 예제, 사용자로부터 숫자입력받아 짝수일때 만 이벤트 발생 
 
using System;

namespace EventTest
{
    delegate void MyDelegate(int i);
    class EventPublsher
    {
        public event MyDelegate ClapEvent;

        public void Clap(int num)
        {
            if (num % 2 == 0)
            {
                ClapEvent(num);
            }
            else
            {
                Console.WriteLine("{0} : 홀!", num);
            }
        }
    }
    class EventSub
    {
        public static void Main()
        {
            EventPublsher p = new EventPublsher();
            p.ClapEvent += new MyDelegate(Caller);

            int[] iArr = Array.ConvertAll(
                         (Console.ReadLine()).Split(','),
                         i => int.Parse(i));

            foreach (int i in iArr)
            {
                p.Clap(i);
            }
        }
        static void Caller(int num)
        {
            Console.WriteLine("{0} : 짝!", num);
        }        
    }
}
