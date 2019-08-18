using System;
using System.Data;
using System.Data.SqlClient;

namespace TestConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            string strconn = "Data Source=.;Initial Catalog=POE;User Id=sa;Password=123"; //创建连接字符串
            SqlConnection sqlConn = new SqlConnection(strconn); //实例化连接对象
            Console.WriteLine("打开数据库连接... \n");
            sqlConn.Open(); //打开数据库连接

            string strcmd = "SELECT * FROM Gems"; //创建sql命令字符串
            SqlCommand sqlcmd = new SqlCommand(strcmd, sqlConn); //实例化

            Console.WriteLine("读取数据库内容... \n");
            SqlDataReader rd = sqlcmd.ExecuteReader(); //实例化，执行ExecuteReader()方法

            //获取表头
            for (int i = 0; i < rd.FieldCount; i++)
            {
                Console.Write("{0,-20}", rd.GetName(i));
            }
            Console.WriteLine("\n");

            while (rd.Read()) //逐行读取，直到完成
            {
                Console.Write("{0,-20}", (string)rd["Name"]);
                Console.Write("{0,-20}", (string)rd["CN_Name"]);
                Console.Write("{0,-20}", (string)rd["Type"]);
                Console.Write("{0,-20}", (string)rd["Color"]);
                Console.WriteLine("{0,-20}", ((string)rd["Introduction"]).Substring(0, 20) + "... \r\n");
            }
            
            //关闭连接
            rd.Close();
            sqlConn.Close();
            Console.WriteLine("关闭数据连接...");

            Console.WriteLine("-------------------- 读取完成 --------------------\n\n");


            DataSet ds = new DataSet(); //初始化数据集

            Console.WriteLine("重新打开连接...");
            sqlConn.Open(); //重新打开连接
            string stradp = "SELECT * FROM Maps";
            SqlDataAdapter sqladp = new SqlDataAdapter(stradp, sqlConn); //实例化

            DataTable dt = new DataTable(); //新建数据表
            Console.WriteLine("填充数据表...\n");
            sqladp.Fill(dt); //填充数据表

            ds.Tables.Add(dt); //把数据表添加进数据集
            ds.Tables[0].TableName = "Maps";

            //获取表头
            foreach (DataColumn dc in ds.Tables["Maps"].Columns)
            {
                Console.Write("{0,-20}", dc.ColumnName);
            }
            Console.WriteLine("\n");


            //遍历Maps表
            foreach (DataRow row in ds.Tables["Maps"].Rows)
            {
                foreach (DataColumn col in ds.Tables["Maps"].Columns)
                {
                    Console.Write("{0,-20}", row[col].ToString());
                }
                Console.WriteLine();
            }

            sqlConn.Close(); //关闭连接

        }

    }
}
