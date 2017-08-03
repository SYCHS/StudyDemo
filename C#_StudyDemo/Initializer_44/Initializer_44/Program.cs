using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Initializer_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>
            {
                new Cow { Name = "Lea"},
                new Chicken { Name = "Noa"},
                new Chicken(),
                new SuperCow { Name = "Andrea"}
            };

            /*Farm<Animal> farm = new Farm<Animal>
            {
            //另外一种写法，就不需要提供add方法
                Animals =
                {
                    new Cow { Name = "Lea"},
                    new Chicken { Name = "Noa"},
                    new Chicken(),
                    new SuperCow { Name = "Andrea"}
                }
            };*/

            farm.MakeNoises();
            ReadKey();
            
        }
    }
}
