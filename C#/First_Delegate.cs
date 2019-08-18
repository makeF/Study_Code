using System;

namespace TestConsole
{
    class Program
    {
        #region 委托
        delegate int TDelegate(int x, int y);//申明委托

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multi(int x,int y)
        {
            return x * y;
        }

        static void TestDelegate(int x,int y,TDelegate tdele)//委托作为参数
        {
            int TResult = tdele(2, 3);
            Console.WriteLine("结果是：{0}",TResult);
        }

        #endregion

        static void Main(string[] args)
        {
            TDelegate @delegate = new TDelegate(Add);//实例化委托
            TestDelegate(2, 3, @delegate);

            TDelegate @delegate1 = new TDelegate(Multi);//实例化委托
            TestDelegate(2, 3, delegate1);

        }

    }
}
