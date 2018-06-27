using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)        {            //通过ParameterizedThreadStart创建线程            Thread thread = new Thread(new ParameterizedThreadStart(Thread1));
            //给方法传值
            thread.Name="test";//获取或设置线程的名称
            int id = thread.ManagedThreadId;
            Console.WriteLine(id);
            thread.Priority= ThreadPriority.Normal;//设置线程的优先级别
            Console.WriteLine(thread.Name);            thread.Start("这是一个有参数的委托");            Console.ReadKey();        }        /// <summary>        /// 创建有参的方法        /// 注意：方法里面的参数类型必须是Object类型        /// </summary>        /// <param name="obj"></param>        static void Thread1(object obj)        {            string test = "";            test = obj.ToString();            Console.WriteLine(test);        }
    }
}
