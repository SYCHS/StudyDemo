using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvert_9
{
    class Program
    {
        /*
         * 5.1、类型转换： 分为隐式转换和显示转换
         * 
         * 5.1.1、隐式转换：从类型A到类型B的转换可在所有情况下进行，执行转换的规则非常简单，可以让编译器进行转换。
         *        隐式转换的规则：任何类型A，只要其取值范围完全包含在类型B的取值范围内，就可以隐式转换为类型B。
         *        
         * 5.1.2、显示转换：从类型A到类型B的转换只能在某些情况下进行，转换规则比较复杂，应进行某种类型的额外处理。
         *        对于为表达式设置所谓的溢出检查上下文，需要用到两个关键字——checked和unchecked。
         *        如果类型转换会发生数据丢失，加了checked，会显示错误信息，程序会崩溃。
         *        但是加了unchecked不会出现报错误的情况。
         *        
         *        可以配置应用程序，让这种类型的表达式都和包含了checked关键字一样，除非表达式明确使用unchecked关键字。
         *        步骤：右击Solution Explorer窗口中的项目，选择Properties选项，单击窗口左边的Build，打开Build设置。
         *        修改Advanced设置，选中Check for arithmetic overflow/underflow选项。
         *        
         * 
         */
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            WriteLine("Variable Conversion Examples ;");
            doubleResult = floatVal * shortVal;
            WriteLine($"implicit,-> double :{floatVal} * {shortVal} -> {doubleResult}");
            shortResult = (short)floatVal;
            WriteLine($"Explicit,-> short : {floatVal} -> {shortResult}");
            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            WriteLine($"Explicit,->string : \"{boolVal}\" + \"{doubleVal}\" -> "+$"{stringResult}");
            longResult = integerVal + Convert.ToInt64(stringVal);
            WriteLine($"Mixed,-> long : {integerVal} + {stringVal} -> {longResult}");
            ReadKey();
        }
    }
}
