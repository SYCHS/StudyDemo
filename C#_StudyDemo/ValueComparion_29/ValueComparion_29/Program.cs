using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ValueComparion_29
{
    /*
     * 11.2.2.值比较
     * 
     *   1.运算符重载
     *         重载：通过运算符重载，可以对我们设计的类使用标准的运算符，例如+、>等，这称为重载。
     *         
     *         运算符重载的基本语法：
     *           1.要重载运算符，可给类添加运算符类型成员（它们必须是static）.
     *           2.一般情况下，操作数的类型与定义运算符的类相同，但也可以定义处理混合类型的运算符。
     *           
     *         ky可以重载的运算符：
     *           1.一元运算符：+、-、！、++、--、~、true、false
     *           2.二元运算符：+、-、/、%、&、|、^、<<、>>
     *           3.比较运算符：==，!=，<,>,>=,<=
     *           
     *         注意的细节：
     *           1.不能重载赋值运算符，例如+=。但这些运算符使用与它们对应的简单运算符，
     *             即重载+意味着+=如期执行。
     *           2.不能重载&&和||，但它们使用对应的运算符&和|执行计算。
     *           一些运算符必须做成成对重载，如>和<.对于这些运算符，通常需要重写Object.Equals()和Object.GetHashCode(),
     *           因为这两个函数也可用于比较对象。
     * 
     * 
     * 
     * 
     * 
     */

    public class AddClass
    {
        public int val;
        public static AddClass operator +(AddClass op1,AddClass op2)
        {
            AddClass returnVal = new AddClass();
            returnVal.val = op1.val + op2.val;
            return returnVal;

        }

        public static bool operator >=(AddClass op1, AddClass op2) => (op1.val) >= (op2.val);
        public static bool operator <(AddClass op1,AddClass op2) => !(op1 >= op2);
        public static bool operator <=(AddClass op1, AddClass op2) => (op1.val) <= (op2.val);
        public static bool operator >(AddClass op1, AddClass op2) => !(op1 <= op2);

        public override bool Equals(object obj)
        {
            if (obj is AddClass)
            {
                return val == ((AddClass)obj).val;
            }
            else
            {
                throw new ArgumentException("Cannot compare AddClass objects with objects of type."+obj.GetType().ToString());
            }
            //return val == ((AddClass)obj).val;
        }

        public override int GetHashCode()
        {
            return val;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //重载运算符的简单举例测试
            AddClass op1 = new AddClass();
            op1.val = 5;
            AddClass op2 = new AddClass();
            op2.val = 10;
            AddClass op3 = op1 + op2;
            WriteLine(op3.val);
            WriteLine("op1 > op2 ? "+(op1>op2));
            ReadKey();

        }
    }
}
