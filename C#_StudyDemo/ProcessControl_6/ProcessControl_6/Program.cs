using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControl_6
{
    class Program
    {
        /*
         * 1.名称空间：.NET中提供应用程序代码容器的方式，可以唯一地标识代码及其内容。
         *           可使用namespace关键字为花括号中的代码块显示定义名称空间。
         *           namespace LevelOne
         *           {
         *             //code in LevelOne namespace
         *           }
         *           C# 6新增了using static关键字，如把using static System.Console添加到名称空间列表时，访问WriteLine()方法就不再需要在前面加上静态类名。
         *
         * 2.流程控制
         *    2.1.布尔逻辑
         *        布尔比较运算符，也称为关系运算符。
         *        主要有：==、!=、<、>、<=、>=
         *        
         *        条件布尔运算符：&&、||
         *        注意：如果&&运算符的第一个操作数是false，就不需要考虑第二个操作数的值了，因为无论第二个操作数的值是什么，其结果都是false。
         *              同样，如果第一个操作数是false，||运算符就返回true，不必考虑第二个操作数的值。
         *              即程序不处理第二个操作数。
         *        
         *        布尔赋值运算符：&=、|=、^=
         *        注意：异或运算符中只有当两个操作数bool值不相同时才为true。
         */

        static void Main(string[] args)
        {
           WriteLine("Enter an integer :");
            int myInt = ToInt32(ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <=5);
            WriteLine($"{myInt} < 10 ?"+$"{isLessThan10 }");
            WriteLine($"0<= {myInt} <= 5 ?" + $"{isBetween0And5}");
            WriteLine($"{isLessThan10 } ^ {isBetween0And5 } = {isLessThan10 ^ isBetween0And5}");
            WriteLine($"true ^ true = {true ^ true}");
            WriteLine($"false ^ false = {false ^ false}");
            ReadLine();
        }
    }
}
