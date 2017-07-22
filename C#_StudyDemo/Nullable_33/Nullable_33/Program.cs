using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nullable_33
{
    /*
     * 1.可空类型
     *      语法如下：
     *       <Type>?  <variableName>;
     *      
     *      //合法
     *      int？ op1 = 5;
     *      int?  op2 = op1*2;
     *      //不合法
     *      int？ op1 = 5;
     *      int  op2 = op1*2;    正确： int op2 = (int)op1*2;
     *      或通过Value属性值访问，即int op2 = op1.Value*2;
     *      
     * 2.??运算符:空接合运算符
     *          op1 ?? op2
     *          op1 == null ? op2:op1     
     *          两个表达式的作用相同。
     * 
     * 3.?.运算符：Elvis运算符或空推荐运算符
     *         int? count = cunstomer.order?.Count();
     *         使用?.运算符，会把int? count设置为null，而不是抛出异常。
     *         
     *         //如果结果是null，则可以设置默认值
     *          int? count = cunstomer.order?.Count() ?? 0;
     * 
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = GetVector("vector1");
            Vector v2 = GetVector("vector1");
            WriteLine($"{v1} + {v2} = {v1 + v2}");
            WriteLine($"{v1} - {v2} = {v1 - v2}");

            ReadKey();
        }
        static Vector GetVector(string name)
        {
            WriteLine($"Input {name} magnitude:");
            double? r = GetNullableDouble();
            WriteLine($"Input {name} angle (in degrees):");
            double? theta = GetNullableDouble();
            return new Vector(r,theta);

        }
        static double? GetNullableDouble()
        {
            double? result;
            string userInput = ReadLine();
            try
            {
                result = double.Parse(userInput);
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }
}
