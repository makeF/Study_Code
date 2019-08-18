using System;

namespace TestConsole
{
    public abstract class Start //明星基类,抽象类
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public abstract void Introduce(); //抽象方法
    }

    class Singer : Start//歌手类,继承明星类
    {
        public string Song { get; set; }

        public override  void Introduce() => Console.WriteLine("我的名字是{0},我{1}岁了,我的代表歌曲是'{2}'.", Name, Age, Song);//重写抽象方法
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singer singer = new Singer();//实例化
            singer.Name = "刘某";
            singer.Age = "29";
            singer.Song = "全英雄联盟最骚的骚猪";

            singer.Introduce();
        }

    }
}
