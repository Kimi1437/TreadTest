﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
            //给方法传值
            thread.Name="test";//获取或设置线程的名称
            int id = thread.ManagedThreadId;
            Console.WriteLine(id);
            thread.Priority= ThreadPriority.Normal;//设置线程的优先级别
            Console.WriteLine(thread.Name);
    }
}