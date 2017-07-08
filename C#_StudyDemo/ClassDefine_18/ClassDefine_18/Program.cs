using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefine_18
{
    public abstract class MyBase{ }
    internal class MyClass : MyBase { }
    public interface IMyBaseInterface { }
    internal interface IMyBaseInterface2 { }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    internal sealed class MyComplexClass : MyClass, IMyInterface { }
    
    class Program
    {
        /*
         * OOP: Object-oriented Programming ,即面向对象编程。
         * 
         * UML：Unified Modeling Language ,即统一建模语言。
         *      用三个连续的白框来表示。
         *      在顶部，首先显示实例名，其后是类名。
         *      在类的UML表示方法中，用第二部分显示属性和字段。+号表示公共成员，-号表示私有成员。
         *      在UML的类框中，方法显示在第三部分。
         *      在UML语法中，类的静态成员带有下划线。
         *      在UML中，在对象上实现的接口用“棒棒糖”语法来表示。
         *      在UML中，用白色的空箭头表示继承。
         *      在UML中，被包含类可以用关联线条来表示。用带有1的线条说明一对一的关系。0..*  表示0个或多个
         *    
         * 9.1、C#中的类定义：
         *      使用class关键字来定义类。
         *      class MyBase {
         *         ......;
         *      }    
         *      1.默认情况下，类声明为内部的，internal。
         *      2.还可以有public修饰，表示可以被其他项目所访问。
         *      3.abstract 抽象的   不能实例化，只能继承，可以有抽象成员。
         *      4.sealed 密封的   不能继承
         *      
         *      继承的语法：
         *      public class MyClass : MyBase
         *      {
         *          .......
         *      }
         *      注意：1.在C#的类定义中，只能有一个基类。
         *            2.如果继承了一个抽象类，就必须实现所继承的所有抽象成员(除非派生类也是抽象的)。
         *            3.编译器不允许派生类的可访问性高于基类。也就是说，内部类可以继承于一个公共类，但公共类不能继承于一个内部类。
         *            4.所有类的根都是System.Object.
         *            
         *      定义接口的语法：
         *      interface IMyInterface
         *      {
         *         .......
         *      }
         *      注意：1.默认情况下，接口被定义为内部接口，interface
         *            2.接口可以公开访问，必须使用public关键字。
         *            3.不能在接口中使用abstract和sealed。
         *            4.接口可以继承，与类的继承方式一样。
         *                 public interface IMyInterface : IMyBaseInterface,IMyBaseInterface2
         *                 {
         *                    .......
         *                 }
         *            主要区别在于接口可以多继承。
         *            5.实现接口的语法同继承的方式也一样。
         *             public class MyClass : IMyInterface
         *             {
         *               .......
         *             }
         *           
         */
        static void Main(string[] args)
        {
            MyComplexClass myObj = new MyComplexClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
