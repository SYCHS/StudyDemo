#region Using directives
/*
 * 使用#region和#endregion可以将包含在其中的代码折叠为一行
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 
namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //File-->New-->Project
            //快捷键F5可以运行程序
            //所有C#代码文件都使用.cs文件扩展名
            //output text to the screen
            Console.WriteLine("This is my first Demo to study C# ");
            Console.ReadKey();//告诉代码在结束前等待按键，解决执行完毕后就立即终止的现象
        }
    }
}
