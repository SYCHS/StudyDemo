using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UseLambda_48
{
    /*
     * Lambda表达式由3个部分组成：
     *     1.放在括号中的参数列表（未类型化）
     *     2. => 运算符
     *     3. C#语句
     * 注意：1.Lambda表达式使用类型推理功能来确定所传送的参数类型，实际上这不是必须的，
     *         也可以定义类型。
     *       2.不能在一个Lambda表达式中同时使用隐式和显式的参数类型。例如：
     *                （int A, B） => A +B      //错误的写法
     *       3.Lambda表达式的参数列表始终包含一个用逗号分隔的列表，其中的参数要么都是显式
     *         类型化的，要么都是隐式类型化的。
     *       4.如果只有一个隐式化类型的参数，就可以省略括号。例如：
     *                 A => A * A 
     *       5.没有参数的Lambda表达式使用空括号来表示，例如：
     *                 () => Math.PI
     *       6.可将Lambda表达式看成匿名方法语法的扩展，所以在Lambda表达式的语句体中可以包含多个语句，
     *         只需要把一个代码块放在花括号中。如果使用Lambda表达式和返回类型不是void的委托类型，就
     *         必须用return关键字返回一个值。
     * 
     * Lambda表达式与匿名方法的区别：
     *     1.Lambda表达式比较灵活。
     *     2.可以把Lambda表达式解释为一个委托。
     *           一般可以把拥有至多8个参数的Lambda表达式表示为如下泛型类型，它们都在System名称空间中：
     *           2.1. Action,表示的Lambda表达式不带参数，返回类型是void
     *           2.2. Action<>,表示的Lambda表达式有至多8个参数，返回类型是void
     *           2.3. Func<>,表示的Lambda表达式有至多8个参数，返回类型不是void
     *     3.可以把Lambda表达式解释为表达式树。在LING框架中具体介绍。
     */ 


    delegate int TwoIntegerOperationDelegate(int paramA, int paramB);

    class Program
    {
        static void PerformOperations(TwoIntegerOperationDelegate del)
        {
            for (int paramAVal = 1; paramAVal <= 5; paramAVal++)
            {
                for (int paramBVal = 1; paramBVal <= 5; paramBVal++)
                {
                    int delegateCallResult = del(paramAVal,paramBVal);
                    Write($"f({paramAVal},{paramBVal})={delegateCallResult}");
                    if (paramAVal != 5)
                    {
                        Write(", ");
                    }
                }
                WriteLine();
            }
        }
        static void Main(string[] args)
        {
            WriteLine("f(a,b) = a + b:");
            PerformOperations((paramA, paramB) => paramA + paramB);
            /*
             * 使用匿名方法
             * WriteLine("f(a,b) = a + b:");
               PerformOperations(delegate (int paramA, int paramB)
               {
                return paramA + paramB;
                });*/
            WriteLine();
            WriteLine("f(a,b) = a * b:");
            PerformOperations((paramA, paramB) => paramA * paramB);
            WriteLine();
            WriteLine("f(a,b) = (a - b) % b:");
            PerformOperations((paramA, paramB) => (paramA - paramB) % paramB);
            ReadKey();
        }
    }
}
