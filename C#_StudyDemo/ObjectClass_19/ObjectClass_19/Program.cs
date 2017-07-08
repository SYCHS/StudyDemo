using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass_19
{
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            // If this and obj do not refer to the same type, then they are not equal.
            if (obj.GetType() != this.GetType()) return false;

            // Return true if  x and y fields match.
            Point other = (Point)obj;
            return (this.x == other.x) && (this.y == other.y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }

        // Return the point's value as a string.
        public override String ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }

        class Program
        {
        /*
         * 9.2.System.Object
         *     所有的类都继承于System.Object,所以这些类都可以访问该类中受保护的成员和公共成员。
         *     1.构造函数
         *         Object() ：初始化 Object 类的新实例。
         *         
         *     2.方法：
         *         Equals(Object):确定指定的对象是否等于当前对象。
         *         Equals(Object, Object)：确定指定的对象实例是否被视为相等。
         *         GetHashCode()：作为默认哈希函数。
         *         GetType()：获取当前实例的 Type。
         *         ToString()：返回表示当前对象的字符串。
         *         MemberwiseClone():创建当前 Object 的浅表副本。
         * 
         * 
         */
        static void Main(string[] args)
            {
                Point p = new Point(2, 1);
                Console.WriteLine(p);
            Console.ReadKey();
            }
        }
    }

