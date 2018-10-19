﻿//p204 interrupt를 이용한 쓰레드 종료방법
using System;
using System.Threading;

namespace p204
{
    class Program
    {
        public static Thread sleeperThread;

        public static void Main(string[] args)
        {
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }
        private static void ThreadToSleep()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("[Sleeper : " + i++ + "]");
                if (i == 9)
                {
                    try
                    {
                        Console.WriteLine("i 가 9 가 되어 1 초쉼...");
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine("ThreadInterruptedException ...");
                        Environment.Exit(0);
                    }
                }            }
        }
    }
}
