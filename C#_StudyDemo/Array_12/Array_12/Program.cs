using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_12
{
    class Program
    {
        /*
         * 声明数组的语法：
         *     <baseType>[]  <ArrayName>;
         *     
         * 数组的初始化有四种方式：
         *    1.使用字面值指定数组，举例如下：
         *    int[] myIntArray = {5.6,9,8,7};
         *    2.使用new关键字
         *    int[] myIntArray = new int[5];//这种方式会给所有的数组元素赋予同一个默认值。
         *    3.组合上述的两种方式
         *    int[] myIntArray = new int[5]{5,5,4,7,8};//使用此方式，数组大小必须与元素个数想匹配。否则会导致编译失败
         *    注意：如果使用一个变量定义其数组大小，该变量必须是一个常量。例如：
         *    const int arraySize = 5;
         *    int[] myArray = new int[arraySize]{5,6,6,4,8};//如果省略了关键字const,运行这段代码就会失败。
         *    4.
         *       int[] myArray;
         *       myArray = new int[5];
         * 
         * 遍历数组的方法有：
         *    1.for循坏
         *          for(int i=0;i<ArrayName.Length;i++){
         *             //can use ArrayNmae[i] for each element
         *          }
         *    2.foreach循环访问数组元素的语法：  
         *             foreach(<baseType> <name> in <array>)
         *             {
         *                //can use <name> for each element
         *             }
         * 
         *二维数组：   <baseType>[,] <ArrayName>;
         *三维数组：   <baseType>[,,] <ArrayName>; 
         *         多维数组只需要更多逗号。
         *   
         * 锯齿数组：即数组的数组，每行的元素可能不同。
         * 
         *         int[][] jaggedIntArray;
         *         jaggedIntArray = new int[2][];
         *         jaggedIntArray[0] = new int[3];
         *         jaggedIntArray[1] = new int[4];
         *         
         *         
         *         int[][] jaggedIntArray = {new int[]{1,2,3},new int[][1],new int[]{1,2}};
         *         
         *                  
         * 
         * 
         */
        static void Main(string[] args)
        {
            string[] friendNames = {"CHS","TSQ","XYH" };
            int i;
            Console.WriteLine($"Here are {friendNames.Length} of my friends :");
            //方式1：
            /*for(i= 0;i <friendNames.Length;i++) {
                Console.WriteLine(friendNames[i]);
            }*/
            //方式2：
            foreach (string name in friendNames) {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
