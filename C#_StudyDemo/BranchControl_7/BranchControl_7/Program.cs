using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchControl_7
{
    class Program
    {
        /*
         * 4.2、分支：控制下一步要执行哪行代码的过程。
         * 
         * C#中的3种分支技术：
         *         1.三元运算符
         *         2.if语句
         *         3.switch语句
         *        
         * 4.2.1、三元运算符
         *        语法如下：
         *        <test> ? <resultIfTrue>: <resultIfFalse>;
         *        其中，计算<test>可以得到一个bool值。
         * 
         * 4.2.2、if语句
         *         if语句最简单的语法：
         *                 1.if(<test>)
         *                 <code executed if <test> is true>;
         *                 2.if-esle语句：
         *                 if(<test>)
         *                 <code executed if <test> is true>;
         *                 else
         *                 <code executed if <test> is false>;
         *                 3.if...else if...else...    其中。else if 可以有多个
         * 
         * 4.2.3、switch语句
         *        switch语句可以一次将测试变量与多个值进行比较，而不是仅测试一个条件。这种测试仅限于离散的值。
         *        switch语句的基本结构如下：
         *            switch(<testVar>)
         *            {
         *               case <comparisonVal1>:
         *               <code to executed if <testVar> == <comparisonVal1> >;
         *               break;
         *               case <comparisonVal2>:
         *               <code to executed if <testVar> == <comparisonVal2> >;
         *               break;
         *               ...
         *               case <comparisonVarN>:
         *               <code to executed if <testVar> == <comparisonValN> >;
         *               break;
         *               default:
         *               <code to executed if <testVar> != <comparisonVals> >;
         *               break;
         *            }
         *    注意：switch表达式或case标签必须是bool 、char 、string 、integral 、 enum或可以为null的相应类型。            
         *       
         * 
         */


        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number :");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than ";
            else
            {
                if (var1 == var2)
                    comparison = "equal to ";
                else
                    comparison = "greater than ";
            }
            Console.WriteLine($"The first number is {comparison} the second number .");
            string name;
            const string myName = "SYCHS";//定义字符串常量
            const string niceName = "tsq";
            const string sillyNmae = "xyh";
            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();
            switch (name.ToLower())//将键盘读取的字符串全部变为小写字母
            {
                case myName:
                    Console.WriteLine("You have the same name as me !");
                    break;
                case niceName:
                    Console.WriteLine("wow,what a nice name you have !");
                    break;
                case sillyNmae:
                    Console.WriteLine("That is a very silly name .");
                    break;
                default:
                    Console.WriteLine("default code to excuted ");
                    break;
            }
            Console.WriteLine($"Hello {name}");
            Console.ReadKey(); 
        }
    }
}
