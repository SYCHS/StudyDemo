using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;
namespace Collection_26
{
    class Program
    {
        /*
         * System.Collections名称空间中的几个接口提供了基本的集合功能：
         *     1.IEnumerable 可以迭代集合中的项
         *     2.ICollection(继承于IEnumerable)可以获取集合中项的个数，并能把想复制到一个简单的数组类型中。
         *     3.IList（继承于IEnumerable和ICollection）提供了集合的项列表，允许访问这些项，并提供一些与项列表功能相关的基本功能。
         *     4.IDictionary（继承于IEnumerable和ICollection）类似于IList，但提供了可通过键值（而不是索引）访问的项列表。
         *     
         * 自定义集合：
         *      继承CollectionBase,实现Add() \ Remove()
         * 
         * 
         */
        static void Main(string[] args)
        {
            /*ArrayList animalArrayList = new ArrayList();
            Cow myCow = new Cow("Rual");
            animalArrayList.Add(myCow);
            animalArrayList.Add(new Chicken("Andrea"));
            foreach (Animal myAnimal in animalArrayList)
            {
                WriteLine($"New {myAnimal.ToString()} object added to ArrayList "
                    +$"collection ,Name = {myAnimal.Name}");
            }
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();*/

            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Kevin"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            ReadKey();
        }
    }
}
