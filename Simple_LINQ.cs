using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] lol = { "niko", "ezreal", "yasuo" }; //创建数据源
            Console.WriteLine("数据源 { niko, ezreal, yasuo }\n");

            Console.WriteLine("查询满足'字符长度>4'的数据 ...");
            IEnumerable<string> nutest =
                from l in lol
                where l.Length > 4
                select l;

            //遍历输出
            foreach (var n in nutest)
            {
                Console.Write(n + "\t");
            }

            /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
            Console.WriteLine("\n--------------------LINQ To ADO.NET--------------------");

            Model1 model = new Model1(); //来自数据库的CodeFirst

            var gem =
                from m in model.Gems
                select m;

            foreach (var g in gem)
            {
                Console.WriteLine("技能名：{0,-15} 简介：{1,-25}", g.CN_Name, g.Introduction.Substring(0, 30));
            }
        }

    }
}
