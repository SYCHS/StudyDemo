using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceDefinition_23
{
    public interface IMyInterface
    {
        void DoSomething();
        void DoSomethingElse();
    }

    public class MyClass : IMyInterface
    {
        void IMyInterface.DoSomething()
        {
            WriteLine("DoSomething()被调用了！");
        }
        public void DoSomethingElse()
        {
            WriteLine("DoSomethingElse()被调用了！");
        }
    }
    class Program
    {
        /*
         * 10.3、接口的实现
         *       接口的定义：
         *       interface IMyInterface
         *       {
         *          ......
         *       }
         *       接口应注意的细节：
         *         1.不允许使用访问修饰符（public、private、protected或internal）所有接口成员都是隐式公共的。
         *         2.接口成员不能包含代码体。
         *         3.接口不能定义字段成员。
         *         4.不能用关键字static、virtual、abstract或sealed来定义接口成员。
         *         5.类型定义成员是禁止的。
         *         6.要隐藏基接口中继承的成员，可以用关键字new来定义它们。
         *               interface IMyBaseInterface
         *               {
         *                  void DoSomething();
         *               }
         *               
         *               interface IMyInterface : IMyBaseInterface
         *               {
         *                 new void DoSomething();
         *               }
         *         7.在接口中定义的属性可以定义访问块get和set。
         *               interface IMyInterface
         *               {
         *                 int MyInt{ get; set; }
         *               } 
         *              接口不能指定应如何存储属性数据，因为接口不能指定字段。
         *         8.接口与类一样，可以定义为类的成员，但是不能定义为其它接口的成员，因为接口不能包含类型定义。
         *         
         *         在类中实现接口：
         *         public interface IMyInterface
         *         {
         *            void DoSomething();
         *            void DoSomethingElse();
         *         }
         *         public class MyClass : IMyInterface
         *         {
         *            public void DoSomething(){}
         *            public void DoSomethingElse(){}
         *         }
         *         实现接口应注意的细节：
         *            1.实现接口的类必须包含该接口所有成员的实现代码，且必须匹配指定的签名，并且必须是公共的。
         *            2.可使用关键字virtual或abstract来实现接口成员，但不能使用static或const。
         *            3.可以在基类上实现接口成员，而子类在实现接口时不需要实现。
         *                public interface IMyInterface
         *            {
         *               void DoSomething();
         *               void DoSomethingElse();
         *            }
         *            public class MyBaseClass
         *            {
         *               public void DoSomething(){}
         *            }  
         *            public class MyClass : MyBaseClass,IMyInterface
         *            {
         *              public void DoSomethingElse(){}
         *            }
         *            4.继承一个实现给定接口的基类，就意味着派生类隐式地支持这个接口。
         *            5.public class MyClass : IMyInterface 
         *            {
         *               void IMyInterface.DoSomething(){} //显式实现接口成员
         *               public void DoSomethingElse(){}   //隐式实现接口成员
         *            }
         *             只有隐式实现可以直接通过MyClass的对象实例来访问。
         *             MyClass myObj = new MyClass();
         *             myObj.DoSomethingElse();
         *             IMyInterface myInt = myObj;
         *             myInt.DoSomething();
         *             myInt.DoSomethingElse();
         *             
         *             其他属性存取器：
         *                 如果实现带属性的接口，就必须实现匹配的get/set存取器，这并不是绝对正确的。
         *                 如果在定义属性的接口中只包含set块，就可给类中的属性添加get块，反之亦然。但只有隐式实现接口时才能这么做。
         *                 
         * 
         */
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            IMyInterface myInt = myObj;
            myObj.DoSomethingElse();
            myInt.DoSomething();
            myInt.DoSomethingElse();
            ReadKey();
        }
    }
}
