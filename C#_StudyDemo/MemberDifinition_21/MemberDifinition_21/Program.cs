using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MemberDifinition_21
{
    class Program
    {
        private int MyInt;
        public static int myInt;
        public int MyProperty { get; set; }


        /*
         * 10.1、成员定义
         *       所有成员都有自己的访问级别：
         *             public——成员可以由任何代码访问
         *             private——成员只能由类中的代码访问（如果没有任何关键字，就默认使用这个关键字）
         *             internal——成员只能由定义它的程序集（项目）内部的代码访问
         *             protected——成员只能由类或派生类中的代码访问
         *             static——表示类的静态成员
         *             注意：internal和protected可以结合使用，它们只能由程序集中派生类的代码来访问
         *             
         * 10.1.1、定义字段
         *         class MyClass
         *         {
         *            public int MyInt;
         *            private double myDouble;
         *            public readonly int MyInt1 = 17;
         *            public static float MyFloat; 
         *            public const byte MyByte;
         *         }            
         *          注意：1..NET Framework中的公共字段以PascalCasing形式来命名。
         *                2.私有字段通常用camelCasing形式来命名。
         *                3.readonly——表示这个字段只能在执行构造函数的过程中赋值，或由初始化赋值语句赋值。
         *                4.静态字段通过加static关键字，静态字段必须通过定义它们的类来访问。
         *                5.可以使用const关键字来定义常量，const成员也是静态的，不能使用关键字static。
         *                
         * 10.1.2、定义方法
         *         方法使用标准函数、可访问性和可选的static修饰符来声明。
         *         也可以在方法定义中使用以下关键字：
         *         virtual——方法可以重写。
         *         abstract——方法必须在非抽象的派生类中重写（只用于抽象类中）。
         *         override——方法重写了一个基类方法（如果方法被重写，就必须使用该关键字）。
         *         extern——方法定义放在其它地方。
         *         sealed——方法不能被重写
         *         
         * 10.1.3、定义属性
         *         属性定义方式与字段类似，但包含的内容比较多。属性拥有两个类似于函数的块，
         *         一个块用于获取属性的值，另一个块用于设置属性的值。这两个块也称为访问器，
         *         分别用get和set关键字来定义。例如：
         *         private int MyInt;
         *         public int MyIntProp
         *         {
         *            get{return MyInt;}
         *            protected set{MyInt = value;}//只有类或派生类中的代码才能使用set访问器
         *         }    
         *         注意：访问器可以使用的访问修饰符（virtual、override、abstract、protected。。。）
         *               取决于属性的可访问性，访问器的可访问性不能高于它所属的属性，即私有属性对它的访问器不能包含
         *               任何可访问修饰符，而公共属性可以对其访问器使用所有的可访问修饰符。
         *              
         *               C#6中引入了一个名为“基于表达式的属性”的功能,这个功能可以把属性的定义减少为一行代码。
         *               private int MyInt;
         *               public int MyIntProp => (MyInt * 2);                   
         * 10.1.4、重构属性
         *         利用工具自动生成访问器的代码
         *         
         * 10.1.5、自动属性
         *         public int MyIntProp
         *         {
         *            get;
         *            set;
         *         }    
         *         键入prop再按两下Tab键，就会自动创建访问器。
         *         
         *         如下方式可以创建一个外部只读属性：
         *         public int MyProperty { get; private set;}
         *         
         *         C# 6 引入了两个与自动属性相关的新概念：
         *           1.只有get存取器的自动属性
         *           2.自动属性的初始化器
         *           其语法如下：
         *           public int MyProperty{get;}
         *           自动属性的初始化功能由以下声明字段的方式来实现：
         *           public int MyProperty{ get;} = 9;
         *           
         * 10.2、类成员的高级主题：
         *          1.隐藏基类方法
         *          2.调用重写或隐藏的基类方法
         *          3.嵌套的类型定义
         *          
         *       10.2.1、隐藏基类方法
         *             public class MyBaseClass
         *             {
         *                public void DoSomething()
         *                {
         *                  .......
         *                }
         *             }
         *             public class MyDerivedClass : MyBaseClass
         *             {
         *               new public void DoSomething()
         *               {    
         *                 .......
         *               }
         *             }
         *           注意：不加new关键字的情况下也可以正常运行代码，但它会生成一个警告，说明隐藏了一个基类成员。
         *                 使用new关键字来显示地表明意图，不会出现警告。尽管隐藏了基类的实现代码，但仍可以通过
         *                 基类访问它。
         *       
         *       10.2.2、调用重写或隐藏的基类方法
         *               this——表示当前对象的引用，不能在静态成员中使用该关键字，因为静态成员不是对象实例的一部分
         *               base——表示父类对象的引用，同样不能在静态成员中使用该关键字。
         * 
         * 
         */

        static void Main(string[] args)
        {
            WriteLine("Create object myObj...");
            MyClass myObj = new MyClass("My Object");
            WriteLine("myObj created.");
            for (int i = -1; i < 0; i++)
            {
                try
                {
                    myObj.val = i;
                }
                catch (Exception e)
                {
                    WriteLine($"Exception {e.GetType().FullName} throw.");
                    WriteLine($"Message:\n\"{e.Message}\"");
                }
            }

            WriteLine(myObj.ToString());

            WriteLine("\nmyDoubleIntProp = 5...");
            WriteLine($"Getting myDoubleIntProp of 5 is {myObj.myDoubleIntProp}");
            ReadKey();
        }
    }
}
