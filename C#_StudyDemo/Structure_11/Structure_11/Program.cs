using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_11
{
    enum oritentation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
       
    }

    struct route
    {
        public oritentation direction;
        public double distance;
    }

    class Program
    {
        /*
         * 5.2.2、结构：由几个数据组成的数据结构，这些数据可能具有不同的类型。
         * 
         *        定义结构：
         *        使用struct关键字定义结构，如下所示：
         *        struct <typeNmae>
         *        {
         *           <memberDeclarations>
         *        }
         *        <memberDeclarations>部分包含变量的声明（称为结构的数据成员），其格式如下：
         *        <accessibility>  <type>  <name>;
         *       
         * 
         */ 

        static void Main(string[] args)
        {
            route myRoute;//定义结构类型变量
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) South\n3)East\n4) West");
            do {
                Console.WriteLine("Select a direction :");
                myDirection = Convert.ToInt32(Console.ReadLine());
            } while ((myDirection < 1)||(myDirection >4));
            Console.WriteLine("Input a distance :");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (oritentation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine($"myRoute specifies a direction of {myRoute.direction} "+$"and a distance of {myRoute.distance}");
            Console.ReadKey();
        }
    }
}
