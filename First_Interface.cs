using System;

interface star //新建接口
{
    //接口体，成员不使用修饰符
    string Name { get; set; } 
    void Introduce();
}

class singer : star //新建类，实现star接口
{
    public string Name { get; set; }
    public void Introduce()
    {
        Console.WriteLine("我叫{0}，今年18",Name);
    }
}

namespace TestConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            singer singer = new singer();//实例化Singer类
            singer.Name = "霸宋";

            singer.Introduce();
        }

    }
}
