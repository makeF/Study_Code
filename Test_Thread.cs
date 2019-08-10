using System;
using System.Threading;

namespace TestConsole
{
    class ThreadTest //申明测试类
    {
        public void M1() //测试方法1
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("1 ");
            }
        }

        public void M2() //测试方法2
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("2 ");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("这里是主线程，即将创建两个新线程！");
                ThreadTest tt = new ThreadTest(); //实例化测试类

                //创建两个新线程
                Thread t1 = new Thread(tt.M1);
                Thread t2 = new Thread(tt.M2);

                Console.WriteLine("两个新线程创建完成，开始运行！");

                //启动线程
                t1.Start();
                t2.Start();

                Console.WriteLine("两个线程已开启运行！");

                //等待辅线程执行完毕
                t1.Join();
                t2.Join();

                Console.WriteLine("辅线程运行完毕");
            }

        }
    }
}
