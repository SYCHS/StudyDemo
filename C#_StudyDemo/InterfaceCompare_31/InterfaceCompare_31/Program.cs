using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace InterfaceCompare_31
{
    /*
     * 3.IComparable和IComparer接口：
     * 
     *    IComparable和IComparer接口是.NET Framework中比较对象的标准方式，其区别如下：
     *        1.IComparable在要比较的对象的类中实现，可以比较该对象和另一个对象。
     *        2.IComparer在一个单独的类中实现，可以比较任意两个对象。
     *        3.IComparable提供了一个方法CompareTo(object obj).
     *        4.IComparer也提供一个方法Compare(object obj1,object obj2).
     *        5.均返回一个int值。0代表相等，1  -1
     *        
     *        一般使用IComparable给出类的默认比较代码，使用其它类给出非默认的比较代码。
     *        
     *        通过Comparer.Default静态成员可以获取Comparer类的一个实例。
     *        
     *        .NET Framework在类Comparer上提供了IComparer接口的默认实现方式，类Comparer位于System.Collections名称空间中。
     *        
     *        使用Comparer类时的一些注意事项：
     *           1.检查传送给Comparer.Compare()的对象，看看它们是否支持IComparable。如果支持，就使用该实现代码。
     *           2.允许用null值，它表示小于其它任意对象。
     *           3.字符串根据当前文化来处理，要根据不同的文化（或语言）处理字符串，Comparer类必须使用其构造函数
     *             进行实例化，以便传送用于指定所使用的文化的System.Globalization.CultureInfo对象。
     *           4.字符串在处理时要区分大小写。如果要区分大小写的方式来处理它们，就需要使用CaseInsensitiveComparer类，
     *             该类以相同的方式工作。
     *             
     * 4.对集合排序
     *     ArrayList中包含一个Sort()方法，这个方法使用时可以不带参数，此时使用默认的比较方式。
     *     也可以给它传送ICoparer接口，以比较对象对。
     *     注意：对于自定义的类必须实现IComparable接口，或创建一个IComparer的类来进行比较。
     *    
     * 
     * 
     */

    public class Person : IComparable
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person otherPerson = obj as Person;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException(
                    "Object to compare to is not a person object.");
            }
        }

        public override string ToString()
        {
            return "Name: "+this.Name  + "    Age: "+this.Age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Person("Rual",30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            WriteLine("Unsorted people:");
            for(int i = 0;i<list.Count;i++)
            {
                WriteLine($"第 {i+1} 个人的信息：");
                WriteLine((list[i] as Person).ToString());
            }

            WriteLine();
            WriteLine("使用默认的排序(按age)顺序后：");
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"第 {i + 1} 个人的信息：");
                WriteLine((list[i] as Person).ToString());
            }

            WriteLine();
            WriteLine("使用非默认的排序（按name）顺序后：");
            list.Sort(PersonComparerName.Default);
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"第 {i + 1} 个人的信息：");
                WriteLine((list[i] as Person).ToString());
            }
            ReadKey();
        }
    }
}
