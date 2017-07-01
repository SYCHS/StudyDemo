using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_10
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    class Program
    {
        /*
         * 5.2、复杂的变量类型：枚举、结构和数组。
         * 
         * 5.2.1、枚举
         *        定义枚举：可以用enum关键字定义枚举，如下所示：
         *        enum <typeName>
         *        {
         *          <value1>,
         *          <value2>,
         *          <value3>,
         *          ...
         *          <valueN>
         *        }
         *        接着声明这个新类型的变量：
         *        <typeName> <varName>;
         *        并赋值：
         *        <valName> = <typeName>.<valueX>;
         *        枚举使用一个基本类型来存储。枚举类型可取的每个值都存储为该基本类型
         *        的一个值，默认情况下该类型为int。在枚举声明中添加类型，就可以指定其它基本类型：
         *        enum <typeName> ; <underlyingType>
         *        {
         *          <value1>,
         *          <value2>,
         *          <value3>,
         *          ...
         *          <valueN>
         *        }
         *        枚举的基本类型可以是：byte、sbyte、short、ushort、int、uint、long、ulong
         *        默认情况下，每个值都会根据定义的顺序（从0开始），被自动赋予对应的基本类型值。即
         *        <value1> = 0, <value2> = 1; <value3> = 2;......
         *        可以重新赋值：
         *        enum <typeName> ：<underlyingType>
         *        {
         *          <value1> = <actualVal1>,
         *          <value2> = <actualVal2>,
         *          <value3> = <actualVal3>,
         *          ...
         *          <valueN> = <actualValN>
         *        }
         * 
         * 
         */



        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            orientation myDirection = orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}"); 
            Console.ReadKey();
        }
    }
}
