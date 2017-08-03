using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;
using static System.Console;

namespace DynamicType_46
{
    class MyClass1
    {
        public int Add(int var1, int var2) => var1 + var2;
    }
    class MyClass2
    {

    }
    class Program
    {
        /*
         * 13.9.动态查找
         *     动态变量：类型可变的变量
         *     引入动态变量的主要目的：
         *         1.在许多情况下，希望使用C#处理另一种语言创建的对象。这包括与旧技术的
         *           交互操作，例如Component Object Model(COM),也包括动态处理语言，例如
         *           javascript\Python\Ruby.
         *         2.处理未知类型的C#对象。
         *         
         *     动态查找功能由Dynamic Language Runtime(动态语言运行库，DLR)支持。       
         * 
         *    动态类型：使用dynamic关键字
         *    注意：动态类型不同寻常之处在于，它仅在编译期间存在，在运行期间它会被System.Object类型
         *          替代。
         * 
         * 
         */
        static int callCount = 0;
        static dynamic GetValue()//dynamic可用作方法的返回类型
        {
            if (callCount++ == 0)
            {
                return new MyClass1();
            }
            return new MyClass2();
        }
        static void Main(string[] args)
        {
            //一般情况下，应仅在动态类型是唯一选项时才使用他们，例如处理非.NET对象。
            try
            {
                dynamic firstResult = GetValue();
                dynamic secondResult = GetValue();
                WriteLine($"firstResult is : {firstResult.ToString()}");
                WriteLine($"secondResult is : {secondResult.ToString()}");
                WriteLine($"firstResult is : {firstResult.Add(2, 3)}");
                WriteLine($"secondResult is : {secondResult.Add(2, 3)}");
            }
            catch(RuntimeBinderException e)
            {
                WriteLine(e.Message);
            }

            ReadKey();
        }
    }
}
