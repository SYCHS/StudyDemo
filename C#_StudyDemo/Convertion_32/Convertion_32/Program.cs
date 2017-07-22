using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Convertion_32
{
    /*
     * 11.3.转换
     * 
     *    11.3.1.重载转换运算符
     *          使用关键字implicit和explicitl来指定转换。
     * 
     *    11.3.2.as运算符
     *           语法如下：
     *           <operand> as <type>
     *           
     *          适用的情况如下：
     *              1.<operand> 的类型是 <type>.
     *              2.<operand> 可以隐式转换为 <type> 类型。
     *              3.<operand>  可以封箱到 <type> 类型中。
     *              
     *          注意：如果不能从<operand> 转换为 <type> ，则表达式的结果就是null。与简单类型转换的区别即在于此。
     *                因为在简单类型转换中如果不能转换则会抛出异常。
     * 
     * 
     */

    public class IntClass
    {
        public int val;
        public static implicit operator DoubleClass(IntClass op1)
        {
            DoubleClass returnVal = new DoubleClass();
            returnVal.val = op1.val;
            return returnVal;
        }

    }

    public class DoubleClass
    {
        public double val;
        public static explicit operator IntClass(DoubleClass op1)
        {
            IntClass returnVal = new IntClass();
            checked { returnVal.val = (int)op1.val; };
            return returnVal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //隐式转换
            IntClass op1 = new IntClass();
            op1.val = 5;
            DoubleClass op2 = op1;
            WriteLine(op2.val);

            //显式转换
            DoubleClass op3 = new DoubleClass();
            op3.val = 3e15;
            IntClass op4 = (IntClass)op3;//产生异常
            ReadKey();
        }
    }
}
