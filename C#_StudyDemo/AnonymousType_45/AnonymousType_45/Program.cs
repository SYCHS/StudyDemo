using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AnonymousType_45
{
    class Program
    {
        static void Main(string[] args)
        {
            var curries = new[]//匿名类型对象的数组
            {
                new { MainIngredient = "Lamb",Style = "Dhansak",Spiciness = 5},
                new { MainIngredient = "Lamb",Style = "Dhansak",Spiciness = 5},
                new { MainIngredient = "Chicken",Style = "Dhansak",Spiciness = 5},
            };
            WriteLine(curries[0].ToString());
            WriteLine(curries[0].GetHashCode());
            WriteLine(curries[1].GetHashCode());
            WriteLine(curries[2].GetHashCode());
            WriteLine(curries[0].Equals(curries[1]));//比较的是哈希值
            WriteLine(curries[0].Equals(curries[2]));
            WriteLine(curries[0] == curries[1]);
            WriteLine(curries[0] == curries[2]);
            ReadKey();
        }
    }
}
