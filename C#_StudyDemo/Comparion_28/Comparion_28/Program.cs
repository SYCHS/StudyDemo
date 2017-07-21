using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Comparion_28
{
    /*
     * 11.2.比较
     *      对象之间的两类比较：
     *         1.类型比较
     *         2.值比较
     *         
     * 11.2.1.类型比较
     *      获取对象类型的方法：GetType() 与typeof()一起使用，就可以确定对象的类型
     *      举例如下：
     *            if(myObj.GetType() == typeof(MyClass))
     *            {
     *               //myObj is an instance of the class MyClass.
     *            }         
     *    1.封箱和拆箱
     *        封箱：封箱是把值类型转换为System.Object类型，或者转换为由值类型实现的接口类型。
     *        拆箱：与封箱相反的过程。
     *        struct MyStruct
     *        {
     *           public int val;
     *        }
     *        MyStruct valType1 = new MyStruct();
     *        valType.val = 5;
     *        object refType = valType1;
     *        封箱是在没有用户干扰的情况下进行的，即不需要编写任何代码。
     *        但拆箱一个值需要进行显式转换。
     *        
     *    2.is运算符     
     * 
     * 
     * 
     */
    /*public class MyClass
    {
        private string str;

        public MyClass(string newStr)
        {
            str = newStr;
        }
    }

    struct MyStruct
    {
        public int val;
    }*/
    class Checker
    {
        public void Check(object param1)
        {
            if (param1 is ClassA)
                WriteLine("Variable can be converted to ClassA.");
            else
                WriteLine("Variable can't be converted to ClassA.");
            if (param1 is IMyInterface)
                WriteLine("Variable can be converted to IMyInterface.");
            else
                WriteLine("Variable can't be converted to IMyInterface.");
            if (param1 is MyStruct)
                WriteLine("Variable can be converted to MyStruct.");
            else
                WriteLine("Variable can't be converted to MyStruct."); 
        }
    }

    interface IMyInterface { }
    class ClassA : IMyInterface { }
    class ClassB : IMyInterface { }
    class ClassC { }
    class ClassD :ClassA { }
    struct MyStruct : IMyInterface { }

    class Program
    {
        static void Main(string[] args)
        {
            /*MyClass myObj = new MyClass("chs");
            WriteLine(myObj.ToString());
            WriteLine(myObj.GetType());
            WriteLine(typeof(MyClass));*/

            /*
            MyStruct valType1 = new MyStruct();
            valType1.val = 5;
            object refType = valType1;//封箱
            valType1.val = 6;
            MyStruct valType2 = (MyStruct)refType;//拆箱
            WriteLine("valType2.val = "+valType2.val);
            */

            //is 运算符  测试
            Checker check = new Checker();
            ClassA try1 = new ClassA();
            ClassB try2 = new ClassB();
            ClassC try3 = new ClassC();
            ClassD try4 = new ClassD();
            MyStruct try5 = new MyStruct();
            object try6 = try5;
            WriteLine("Analyzing ClassA type variable:");
            check.Check(try1);
            WriteLine();
            WriteLine("Analyzing ClassB type variable:");
            check.Check(try2);
            WriteLine();
            WriteLine("Analyzing ClassC type variable:");
            check.Check(try3);
            WriteLine();
            WriteLine("Analyzing ClassD type variable:");
            check.Check(try4);
            WriteLine();
            WriteLine("Analyzing MyStruct type variable:");
            check.Check(try5);
            WriteLine();
            WriteLine("Analyzing boxed MyStruct type variable:");
            check.Check(try6);
            ReadKey();

        }
    }
}
