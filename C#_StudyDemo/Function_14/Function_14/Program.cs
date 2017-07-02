using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_14
{
    class Program
    {
        /*
         * 6.函数：在C#中，函数可提供在应用程序中的任何一处执行的代码块。
         * 
         *         作用：1.减少重复代码的书写，维护方便。
         *               2.可重复利用。
         *               3.可以提高代码的可读性。
         *               4.创建多用途的代码，让它们对不同的数据执行相同的操作。
         *               
         *         函数的定义包括函数名、返回类型以及一个参数列表。函数的名称和参数共同定义了函数的签名。
         * 
         * 6.1、定义和使用函数
         *       static void Write() {
         *              Console.WriteLine("Text output from function.");
         *         }
         *       函数定义由以下几部分组成：
         *          1.两个关键字;static \  void
         *          2.函数名后跟圆括号，如write()
         *          3.一个要执行的代码块，放在花括号中。
         *    
         * 6.1.1、返回值
         *     当函数返回一个值时，可以按以下方式修改函数：
         *         a、在函数声明中指定返回值的类型，但不使用关键字void。
         *         b、使用return关键字结束函数的执行，把返回值传送给调用代码。
         *         其结构如下所示：
         *         static <returnType> <FunctionName>()
         *         {
         *            ...
         *            return <returnValue>;//<returnValue>必须是<returnType>类型的值
         *         }
         *        注意：执行一行代码的函数可使用C#6 引入的一个功能：表达式体方法
         *              该函数模式使用 =>(Lambda箭头) 来实现这一功能。
         *              static <returnType> <FunctionName>() => <expression body>;
         *              
         *              例如：static double Multiply(double var1, double var2) => var1 * var2;
         * 
         * 6.1.2、参数
         *     a、当函数接收参数时，必须指定以下内容：
         *       1.函数在其定义中指定接收的参数列表，以及这些参数的类型。
         *       2.在每个函数调用中提供匹配的实参列表。
         *       
         *       语法：static <returnType> <FunctionName>(<paramType> <paramName>,...)
         *       {
         *          ...
         *          return <returnValue>;
         *       }
         *     b、参数匹配
         *        在调用参数时，必须使提供的参数与函数定义中指定的参数完全匹配，这意味着要匹配参数的类型、个数和顺序。
         *        
         *     c、参数数组
         *        C#允许为函数指定一个(只能指定一个)特殊参数，这个参数必须是函数定义中的最后一个参数，称为参数数组。
         *        注意：参数数组允许使用个数不定(甚至不指定参数)的参数调用函数，可使用params关键字定义它们。
         *        
         *        语法如下：
         *        static <returnType> <FunctionName>(p1Type> <p1Name>,...,params <type>[] <name>)
         *        {
         *           ...
         *           return <returnValue>;
         *        }
         * 
         *     d、引用参数和值参数
         *        值参数：在使用参数时，是把一个值传递给函数使用的一个变量，在函数中对此变量的任何修改都不影响函数调用中的指定参数。
         *        
         *        引用参数：即函数处理的变量与函数调用中使用的变量相同，而不仅仅是值相同的变量，对这个变量进行的任何修改都会影响用作参数的变量值。
         *                  需要使用 ref 关键字指定参数。
         *                  
         *                  例如：static void ShowDouble(ref int val)
         *                  {
         *                     val *= 2;
         *                     WriteLine("val = "+val);
         *                  }
         *                  在Main函数中如下：
         *                  int myInt = 2;
         *                  WriteLine("myInt = "+ myInt); 
         *                  ShowDouble(ref myInt);
         *                  WriteLine("myInt = "+ myInt); 
         *                  则在控制台的输出结果如下：
         *                  myInt = 2
         *                  val = 4;
         *                  myInt = 4;
         *                  
         *                注意：用作ref参数的变量有两个限制：
         *                      1.在函数调用中使用“非常量” 的变量，因为函数可能会改变引用参数的值。
         *                      2.必须使用初始化过的变量。不允许假定ref参数在使用它的函数中初始化。
         *                      
         *      e、输出参数
         *         除了按引用传递值外，还可以使用out关键字，指定所给的参数是一个输出参数。out关键字的使用方式和ref相同
         *         引用参数和输出参数的区别：
         *         1.把未赋值的变量用作ref参数是非法的，但可以把未赋值的变量用作out参数。
         *         2.在函数使用out参数时，必须把它看成尚未赋值。即已经赋值的参数会在函数执行时丢失数据。
         *         
         *                                        
         */
        static void Write() {
            Console.WriteLine("Text output from function.");
        }

        static double Multiply(double var1, double var2) => var1 * var2;

        static int MaxValue(int[] intArray,out int maxIndex)
        {
            int max;
            max = intArray[0];
            maxIndex = 0;
            for (int i=1;i < intArray.Length;i++) {
                if (intArray[i]>max) {
                    max = intArray[i];
                    maxIndex = i;//获取最大值所在的位置
                }
            }
            return max;
        }

        static int Sum(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Write();
            double d = Multiply(1.1, 1.2);
            Console.WriteLine(d);
            int maxIndex;
            int[] arr = { 1, 8, 6, 41, 12, 56, 56,20 };
            int max = MaxValue(arr,out maxIndex);
            Console.WriteLine("max = "+max+" maxaIndex = "+maxIndex);

            Console.WriteLine("==============================");
            int sum = Sum(1,2,3,4,5,6,4);
            Console.WriteLine("sum = "+ sum);
            Console.ReadKey();
        }
    }
}
