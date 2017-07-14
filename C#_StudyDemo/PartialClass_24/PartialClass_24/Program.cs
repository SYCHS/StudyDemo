using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_24
{

    //代码分组
    public partial class MyClass
    {
        #region Fields
        private int myInt;
        #endregion
        #region Constructor
        public MyClass() { myInt = 99; }
        #endregion
        #region Properties
        public int MyInt
        {
            get { return MyInt; }
            set { MyInt = value; }
        }
        #endregion
        #region Methods
        public void DoSomething()
        {
            //..........
            Console.WriteLine("DoSomething()...被调用了");
            run();
        }
        #endregion

        //部分方法定义
        partial void run();
        
    }
    //部分类定义：把类的定义放在多个文件中，使用partial关键字。
    public partial class MyClass
    {
        //............
        public void print()
        {
            Console.WriteLine("print()...被调用了");
            run();
            //DoSomething();        
        }
        partial void run()
        {
            Console.WriteLine("run()....被调用了");
        }

    }
    /*
     * 部分类应注意的细节：
     *      1.应用于部分类的接口也会应用于整个类。
     *      2.部分类定义可以在一个部分类定义文件或者多个部分类定义文件中包含基类。
     *        但如果基类在多个定义文件中指定，它就必须是同一个基类。
     * 
     *部分方法为什么不能有返回值？
     *    如果部分方法允许有返回值，则可作用于表达式：
     *     例如：  z = add(x,y);
     *     如果在程序中没有实现add（）方法，则编译器就不知道如何处理这个表达式。
     * 
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            myObj.DoSomething();
            myObj.print();
            Console.ReadKey();
        }
    }
}
