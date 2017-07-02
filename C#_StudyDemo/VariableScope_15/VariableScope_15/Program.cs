using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope_15
{
    
    class Program
    {
        /*
         * 6.2、变量的作用域
         *      局部变量
         *      全局变量
         *      
         * 6.2.1、其它结构中变量的作用域
         *        int i;
         *        string str;
         *        for(i=0;i<10;i++)
         *        {
         *            str = "Line" + Convert.ToString(i);
         *            WriteLine(str);
         *        }
         *        WriteLine("Last text output in loop : " +str);
         *        此段代码不能编译。这是因为赋给str的值在退出循环后就丢失数据了
         *        
         *        int i;
         *        string str=""；
         *        for(i=0;i<10;i++)
         *        {
         *            str = "Line" + Convert.ToString(i);
         *            WriteLine(str);
         *        }
         *        WriteLine("Last text output in loop : " +str);
         *        此段代码可以正常运行。
         *        
         *        注意：只声明一个简单变量类型，并不会引起其他变化。只有在给变量赋值后，这个值才会被分配一块内存。
         *              如果这种分配内存空间的行为在循环中发生，该值实际上定义为一个局部值，在循环外部会超出其作用域。
         */
        static string str = "String defined in Program.";
        static void write()
        {
            string str = "String defined in write().";
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            string str = "String defined in Main().";
            write();
            Console.WriteLine(str);
            Console.WriteLine("Global varible :"+ Program.str);
            Console.ReadKey();
        }
        
    }
}
