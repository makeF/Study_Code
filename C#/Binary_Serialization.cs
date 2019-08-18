using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestConsole
{
    [Serializable] //特性，表示可序列化
    class DadAndSon //可序列化类申明
    {
        //三个私有字段
        private int ageSon;
        private int ageDad;
        private int ageSubtration;

        //构造函数
        public DadAndSon(int ageDad, int ageSon)
        {
            this.ageDad = ageDad;
            this.ageSon = ageSon;
            Console.WriteLine("父子年龄在构造函数中指定！\n");
        }

        //求父亲儿子年龄差
        public int DoSubtration()
        {
            ageSubtration = ageDad - ageSon;
            return ageSubtration;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int iDad = 40;
            int iSon = 20;
            DadAndSon ds = new DadAndSon(iDad,iSon); //实例化可序列化类
            Console.WriteLine("父子年龄差值（方法）："+ds.DoSubtration());

            //序列化代码开始
            BinaryFormatter formatter = new BinaryFormatter(); //二进制序列化，会序列化私有字段

            FileStream fs = new FileStream("e:\\DadAndSon.bin",FileMode.Create,FileAccess.Write); //实例化数据流对象

            formatter.Serialize(fs,ds); //序列化
            fs.Close();

            Console.WriteLine("序列化完毕，ds状态已存储到 e\\DadAndSon.bin \n");
            Console.WriteLine("开始反序列化，从 e\\DadAndSon.bin 中恢复ds的状态\n");

            fs = new FileStream("e:\\DadAndSon.bin", FileMode.Open, FileAccess.Read,FileShare.Read);
            DadAndSon ds1 = (DadAndSon)formatter.Deserialize(fs); //反序列化
            fs.Close();

            Console.WriteLine("============ 以下输出基于反序列化对象 ============");
            Console.WriteLine("父子年龄差值（方法）：" + ds1.DoSubtration());
        }

    }
}
