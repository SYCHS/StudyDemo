using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberDifinition_21
{
    public class MyClass
    {
        public readonly string name;
        private int intVal;
        private int myDoubleInt = 5;
        public int myDoubleIntProp => (myDoubleInt*2);//只读属性
        private string myString;

        public int val
        {
            get { return intVal; }
            set {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else {
                    throw (new ArgumentOutOfRangeException("val",value,"val must be assigned a value between 0 and 10."));
                }
            }
        }

        public string MyString
        {
            get
            {
                return myString;
            }

            set
            {
                myString = value;
            }
        }

        public override string ToString()
        {
            return "name:"+name+"\nval："+val;
        }

        private MyClass() : this("Default Name") { }

        public MyClass(string newName)
        {
            name = newName;
            intVal = 0;
        }

       
    }

    
}
