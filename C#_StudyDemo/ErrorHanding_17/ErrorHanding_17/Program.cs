using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHanding_17
{
    class Program
    {
        /*
         * 7.调试和错误处理
         * 
         * 错误类型：
         *      1.语义错误（逻辑错误）：可能会使应用程序执行不正确，或者以未预料到的方式执行。
         *      2.致命错误：包括妨碍代码编译的简单错误（语法错误），或者只在运行期间发生的更严重错误。
         * 7.1、Visual Studio 中的调试
         *     执行应用程序的两种方式:
         *      1.调试模式：按下F5键或单击工具栏中的绿色Start按钮时，就是在调试模式下执行运用程序。
         *      2.非调试模式：按下Ctrl+F5键或选择Debug|Start Without Debugging,就是在非调试模式下运行程序。
         *      
         *      VS允许在两种配置下生成应用程序：
         *      1.调试（默认）
         *      2.发布
         *      
         * 7.1.1、非中断（正常）模式下的调试    
         *      控制台应用程序可以把文本输出到控制台，可以方便地获取到操作的额外反馈。但是在桌面应用程序中，没有用于输出信息的
         *      控制台。作为一种替代方法，可以把文本输出到IDE中的Output窗口。
         *      Output窗口： View|Output  在这个窗口中，可以查看与代码的编译和执行相关的信息，包括在编译过程中遇到的错误，还可以将
         *                   自定义的诊断信息直接写到这个窗口中。
         *      注意：使用Output窗口的下拉菜单可以选择几种模式：Build、Deployment和Debug.
         *            Build和Debug模式分别显示编译和运行期间的信息。
         *            
         *      a.输出调试信息
         *            在运行期间把文本写入Output窗口的方法：
         *            1.Debug.WriteLine()   仅在调试模式下运行
         *            2.Trace.WriteLine()   既可在调试模式下运行，也可用于发布程序。
         *            注意：上面的两个方法包含在System.Diagnostics名称空间内。
         *                  它们还可有第二个字符串参数（可选），用于显示输出文本的类别。如果在应用程序的不同地方输出了类似的信息，
         *                  我们马上可以确定Output窗口中显示的是哪些输出信息。
         *                  WriteLine(String, String)
         *                  
         * 
         */
        static void Main(string[] args)
        {
            int[] testArray = {4,7,4,2,7,3,7,8,3,9,1,9};
            int[] maxValIndices;
            int maxVal = Maxima(testArray,out maxValIndices);
            Console.WriteLine($"Maximum value {maxVal} found at element indices : ");
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }
        static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maxima value search started.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine(string.Format($"Maxima value initialized to {maxVal} ,at element index 0."));
            for (int i = 1; i < integers.Length; i++)
            {
                Debug.WriteLine(string.Format($"Now looking at element at index {i}."));
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format($"New maxima found . New value is {maxVal} ,at element index {i}"));
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices,0);//把oldIndices的值复制到新的indices数组中
                        indices[count - 1] = i;
                        Debug.WriteLine(string.Format($"Duplicate maximum found at element index {i}."));                     
                    }
                }
            }
            Trace.WriteLine(string.Format($"Maxima value {maxVal} found ,with {count} occurrences."));
            Debug.WriteLine("Maximum value search completed .");
            return maxVal;
        }
    }
}
