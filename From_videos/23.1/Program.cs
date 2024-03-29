﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23._1
{
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 начал работу");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method1 выводит счетчик = {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method1 окончил работу");
        }
        static void Method2(int n)
        {
            Console.WriteLine("Method2 начал работу");
            for (int i = n; i < n + 10; i++)
            {
                Console.WriteLine($"Method2 выводит счетчик = {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method2 окончил работу");
        }
        static int Method3()
        {
            Console.WriteLine("Method3 начал работу");
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += i;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method2 окончил работу");
            return S;
        }
        static void Main(string[] args)
        {
            //Action action = new Action(Method1);
            //Task task = new Task(action);
            //task.Start();

            //Task task1 = new Task(Method1);

            //Task task2 = new Task(delegate () { Method1(); });

            //Task task3 = new Task(() => Method1());

            //Task task4 = Task.Factory.StartNew(action);

            int r = Method1Async().Result;

            Method2(100);
            

            Console.WriteLine("Main окончил работу");
            Console.ReadKey();
        }
        static async Task<int> Method1Async()
        {
            Console.WriteLine("Method1Async начал работу");
            int result = await Task.Run(() => Method3());
            Console.WriteLine("Method1Async окончил работу");
            return result;
        }
    }
}
