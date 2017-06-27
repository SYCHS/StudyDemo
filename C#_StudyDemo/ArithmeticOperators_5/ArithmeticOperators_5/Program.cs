using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators_5
{
    class Program
    {
        static void Main(string[] args)
        /*
         * 运算符大致可以分为以下三类：
         *    1.一元运算符，处理一个操作数
         *    2.二元运算符，处理两个操作数
         *    3.三元运算符，处理三个操作数
         *    
         * 简单的数学运算符：
         *    1.+  也可作为字符串连接运算符
         *    2.-   
         *    3.*
         *    4./
         *    5.%
         * 
         * ++和--的用法如下：
         *    运算符        类别            用法举例            结果   
         *      ++          一元          var1 = ++var2;       var1的值是var2+1，var2自加1
         *      --          一元          var1 = --var2;       var1的值是var2-1，var2自减1
         *      ++          一元          var1 = var2++;       var1的值是var2，var2自加1
         *      --          一元          var1 = var2--;       var1的值是var2，var2自减1
         *    总结：操作数在运算符之前则先用，再进行自增减。主要运用在循环中
         *    
         * 赋值运算符：
         *       运算符      类别        实例表达式                 结果
         *         =         二元        var1 = var2;          var1被赋予var2的值
         *         +=        二元        var1 += var2;         即var1 = var1 + var2;
         *         -=        二元        var1 -= var2;         即var1 = var1 - var2;
         *         *=        二元        var1 *= var2;         即var1 = var1 * var2;
         *         /=        二元        var1 /= var2;         即var1 = var1 / var2;
         *         %=        二元        var1 %= var2;         即var1 = var1 % var2;
         *
         * 运算符的优先级：
         *       优先级由高到低：  ++、--（用作前缀）、+、-(一元)
         *                         *   /    %
         *                         +   -（二元）
         *                         =、*=、/=、%=、+=、-=
         *                         ++、--（用作后缀）
         *      在写代码时不用刻意记忆运算符的优先级，可以合理利用（）解决。   
         * 
         */

        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name :");
            userName = Console.ReadLine();//接收用户输入信息，且返回字符串
            Console.WriteLine($"Welcome {userName} !");
            Console.WriteLine("Now give me a number :");
            firstNumber = Convert.ToDouble(Console.ReadLine());//Convert.ToDouble()  将字符串转换为double类型
            Console.WriteLine("Now give me another number :");
            secondNumber  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is "+$"{firstNumber + secondNumber}.");
            Console.WriteLine($"{firstNumber}-{secondNumber} = "+$"{firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber}*{secondNumber} = " + $"{firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber}/{secondNumber} = " + $"{firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber}%{secondNumber} = " + $"{firstNumber % secondNumber}");
            Console.ReadKey();
        }
    }
}
