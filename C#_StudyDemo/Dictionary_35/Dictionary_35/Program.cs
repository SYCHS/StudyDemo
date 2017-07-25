using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Dictionary_35
{
    /*
     * 3.Dictionary<K,V>: 定义键值对的集合
     *   
     *     键必须是唯一的，否则会抛出ArgumentException异常。
     *    
     */ 

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> things = new Dictionary<string, int>();
            things.Add("chs",25);
            things.Add("liuyuan",26);
            things.Add("ycc",24);
            things.Add("zyc",24);
            /*
            foreach (string key in things.Keys)
            {
                Write(key);
                Write(" ");
            }
            WriteLine();
            foreach (int value in things.Values)
            {
                Write(value);
                Write(" ");
            }*/
            things.Remove("ycc");
            try
            {
                things.Add("chs", 123);
            }
            catch (ArgumentException)
            {
                WriteLine("The key of \"chs\" already exits. ");
            }
            foreach (KeyValuePair<string, int> thing in things)
            {
                WriteLine($"{thing.Key} = {thing.Value}");
            }
            //索引初始化器
            var d = new Dictionary<int, string>()
            {
                [1] = "chs",
                [2] = "liuyuan"
            };
            WriteLine(d[1]);

            ReadKey();

        }
    }
}
