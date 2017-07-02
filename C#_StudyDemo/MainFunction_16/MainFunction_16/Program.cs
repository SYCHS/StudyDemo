using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFunction_16
{
    class Program
    {
        /*
         * 6.3、Main()函数
         * 
         *     Main()是C#应用程序的入口点，执行这个函数就是执行应用程序。
         *     Main() 函数有如下4种版本：
         *          1.static void Main()
         *          2.static void Main(string[] args)
         *          3.static int Main()
         *          4.static int Mian(string[] args)
         * 
         *  命令行参数的设置：Solution Explorer ->  Properties -> Debug -> Command line arguments 
         * 
         * 6.4、结构函数：结构中处理包含数据，还可以包含函数。
         * 
         * 6.5、函数的重载
         *      函数重载允许创建多个同名函数，每个函数可以使用不同的参数类型或个数。
         *      注意：函数的返回值类型不是其签名的一部分，所以不能定义两个仅返回类型不同的函数，它们实际上有相同的签名。
         * 
         * 6.6、委托（delegate）     
         *       委托是一种存储函数引用的类型。委托的声明非常类似于函数，但不带函数体，且要使用delegate关键字。
         *       委托的声明指定了一个返回类型和一个参数列表。
         *       
         *       委托的用途：事件编程
         *       
         * 
         */
        struct CustomerName
        {
            public string firstName, lastName;
            public string Name() => firstName + " " + lastName;
        }

        static int write()
        {
            int i = 0;
            return i;
        }

        static double write(double d )
        {
            d = 0;
            return d;
        }

        delegate double ProcessDelegate(double d1,double d2);//定义一个委托
        static double Multiply(double d1, double d2) => d1 * d2;
        static double Divide(double d1, double d2) => d1 / d2;
        static void Main(string[] args)
        {
            CustomerName myCustomer;
            myCustomer.firstName = "John";
            myCustomer.lastName = "Franklin";
            Console.WriteLine(myCustomer.Name());
            Console.WriteLine("=====================");

            double d1 = 18;
            double d2 = 3;
            ProcessDelegate process;//声明委托类型变量
            Console.WriteLine("Enter M to multiply or D to divide :");
            string input = Console.ReadLine();
            if (input == "M")
                process = new ProcessDelegate(Multiply);//初始化委托变量
            else
                process = new ProcessDelegate(Divide);
            /*
             * 还可以使用简单的语法：
             *   if(input == "M")
             *       process = Multiply;
             *    else
             *       process = Divide;
             *  
             */ 
            Console.WriteLine(process(d1,d2));
            Console.ReadKey();
        }
    }
}
