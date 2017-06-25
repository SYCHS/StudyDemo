using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *声明变量的C#语法：指定类型和变量名
             *   <DataType>  <VariableName>;
             *   
             * C#中的整数类型有：
             *    类型        别名                  允许的值
             *  sbyte       System.SByte        介于-128到127之间的整数
             *  byte        System.Byte         介于0和255之间的整数
             *  short       System.Int16        介于-32768和32767之间的整数
             *  ushort      System.UInt16       介于0和65535之间的整数
             *  int         System.Int32        介于-2^31和2^31-1之间的整数
             *  uint        System.UInt32       介于0和2^32之间的整数
             *  long        System.Int64        介于-2^63和2^63-1之间的整数
             *  ulong       System.UInt64       介于0和2^64之间的整数
             *  
             * C#中的浮点数类型有：
             *       float      System.Single
             *       double     System.Double
             *       decimal    System.Decimal
             * 
             * C#中的文本和布尔类型：
             *       char       System,Char
             *       bool       System.Boolean
             *       string     System.String
             *  
             * 以上就是C#中的基本数据类型
             *
             * 基本的变量命名规则：
             *     1.变量名的第一个字符必须是字母、下划线（_）或@
             *     2.其后的字符可以是字母、下划线或数字
             *    
             *字符串字面值的转义序列：
             *         转义序列                   产生的字符
             *          \'                        单引号
             *          \"                        双引号
             *          \\                        反斜杠
             *          \0                        null
             *          \a                        警告（产生蜂鸣）
             *          \b                        退格
             *          \f                        换页
             *          \n                        换行
             *          \r                        回车
             *          \t                        水平制表符
             *          \v                        垂直制表符
             *      
             * 一字不变的字符串：
             *        @"c:\Temp\myDir\MyFile.doc"与下面的字符串等价：
             *        "c:\\Temp\\myDir\\MyFile.doc"
             *            
             */
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is ";//使用转义序列 \" 来转义双引号    \n-----换行
            Console.WriteLine($"{myString}{myInteger}");//这里使用了C#6中的一个新功能，称为字符串插入
            Console.ReadKey();//暂停代码的执行，等待用户按下一个键


        }
    }
}
