using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Generic_34
{
    /*
     * 12.2.2   System.Collections.Generic名称空间
     *      1.List<T>
     *      
     *      2.对泛型列表进行排序和搜索
     *      
     *       一般情况下，给列表排序需要有一个方法来比较两个T类型的对象。要在列表中搜索，
     *       只需要一个方法来检查T类型的对象，看看它是否满足某个条件。可以使用的泛型委托类型如下：
     *          1.Comparison<T> : 这个委托类型用于排序方法，其返回类型和参数如下：
     *               int method(T objectA,T objectB)
     *          2.Predicate<T> : 这个委托类型用于搜索方法，其返回类型和参数如下：
     *               bool method(T targetObject)
     *        可以定义任意多个这样的方法，使用它们实现List<T> 的搜索和排序方法。
     */ 

    class Program
    {
        static void Main(string[] args)
        {
            Vectors route = new Vectors();
            route.Add(new Vector(2.0,90.0));
            route.Add(new Vector(1.0, 180.0));
            route.Add(new Vector(0.5, 45.0));
            route.Add(new Vector(2.5, 315.0));
            WriteLine(route.Sum());
            Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);
            route.Sort(sorter);
            //route.Sort(VectorDelegates.Compare);另外一种简写方式
            WriteLine(route.Sum());
            Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);
            Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));
            WriteLine(topRightQuadrantRoute.Sum());
            ReadKey();

        }
    }
}
