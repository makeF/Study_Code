using System;

namespace TestConsole
{
    class Gclass<T> //申明泛型类
    {
        T field;

        public Gclass(T value) //构造函数
        {
            field = value;
        }

        public T GetValue()
        {
            return field;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Gclass<int> igclass = new Gclass<int>(1024); //实例化泛型类,int参数
            Console.WriteLine("igclass,GetValue() 调用结果: {0} \n",igclass.GetValue());

            Gclass<DateTime> dgclass = new Gclass<DateTime>(DateTime.Now); //实例化泛型类,DateTime参数
            Console.WriteLine("dgclass,GetValue() 调用结果: {0} \n", dgclass.GetValue());
        }

    }
}
