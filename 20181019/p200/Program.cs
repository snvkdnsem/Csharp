//p200 멀티쓰레드
using System;
using System.Threading;

namespace p200
{
    public class ThreadTest
    {
        public void FirstWork()
        {
            for(int i=0; i<100; i++)
            {
                Thread.Sleep(1000); // 밀리세컨드 단위
                Console.Write("F{0}", i);
            }
        }

        public void SecondWork()
        {
            for(int i=0; i<100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("S{0}", i);
            }
        }

        [MTAThread]
        public static void Main()
        {
            ThreadTest t = new ThreadTest();

            // Thread는 생성자에 ThreadStart형 Delegate를 인자로 받는다.
            Thread first = new Thread(t.FirstWork);
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Priority = ThreadPriority.Lowest;
            second.Priority = ThreadPriority.Highest;

            first.Start();
            second.Start();
        }
    }
}

/*
//[예제1-1]
using System;
using System.Threading;
class ThreadTest
{
    static void Thmethod()
    {
        int id = AppDomain.GetCurrentThreadId();
        Console.WriteLine("Thread[{0}] Thmethod Method Running", id);
    }
    static void Main()
    {
        int id = AppDomain.GetCurrentThreadId();
        Console.WriteLine("Main Thread[{0}]", id);
        for (int i = 0; i < 10; i++)
        {
            Thread th = new Thread(new ThreadStart(Thmethod));
            th.Start();
        }
    }
}*/