using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_20
{
    public class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine("MyBaseClass()被调用了。");
        }
        public MyBaseClass(int i)
        {
            Console.WriteLine("MyBaseClass(int i)被调用了。");
        }
    }

    public class MyTestClass : MyBaseClass
    {
        public MyTestClass(){
            Console.WriteLine("MyTestClass()被调用了。");
        }

        public MyTestClass(int i)
        {
            Console.WriteLine("MyTestClass(int i)被调用了。");
        }
        public MyTestClass(int i,int j):base(i)
        {
            Console.WriteLine("MyTestClass(int i,int j)被调用了。");
        }

    }
    class Program
    {
        /*
         * 9.3.构造函数和析构函数
         *    a、构造函数的语法：
         *    class MyClass
         *    {
         *      public MyClass(){}
         *    }
         *    注意：1.构造函数与包含它的类同名。
         *          2.如果使用private ，则不能在外部用这个构造函数来创建这个类的实例。
         *          3.构造函数可以有参数。
         *          4.可提供的构造函数的数量不受限制。
         *          
         *   b、析构函数
         *      class MyClass
         *      {
         *         ~MyClass()
         *         {
         *           ......
         *         }
         *      }
         *    注意：1.当进行垃圾回收时，就会执行析构函数中的代码，释放资源。
         *          2.调用着析构函数，还将隐式地调用基类的析构函数，包括System.Object
         *            根类中的Finalize()调用。
         * 
         * 构造函数的执行序列：
         *     默认情况下，先执行父类的无参构造函数。
         *     base关键字指定.NET实例化过程使用基类中具有指定参数的构造函数。
         *     还可以使用this关键字调用自身的构造函数。
         *     this和base均可指定构造函数的字面值。
         * 
         */ 
        static void Main(string[] args)
        {
            MyTestClass test = new MyTestClass();

            Console.WriteLine("========================");

            MyTestClass test1 = new MyTestClass(1);

            Console.WriteLine("========================");

            MyTestClass test2 = new MyTestClass(1,2);

            Console.ReadKey();
            
        }
    }
}
