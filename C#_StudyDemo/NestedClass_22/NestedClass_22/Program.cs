using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NestedClass_22
{
    public class ClassA
    {
        private int state = -1;
        public int State { get {
                return state;
            } }
        public class ClassB
        {
            public void setPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }

    class Program
    {
        /*
         * 10.2.3、嵌套的类型定义
         * 
         */ 
        static void Main(string[] args)
        {
            ClassA A = new ClassA();
            WriteLine("A.state = "+A.State);
            ClassA.ClassB B = new ClassA.ClassB();
            B.setPrivateState(A,999);
            WriteLine("A.state = "+A.State);
            ReadKey();
        }
    }
}
