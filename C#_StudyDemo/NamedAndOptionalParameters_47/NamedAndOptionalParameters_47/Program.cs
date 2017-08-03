using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NamedAndOptionalParameters_47
{
    /*
     * 13.10.高级方法参数
     *       
     *       13.10.1 可选参数//C# 4 
     *           1.可选参数的值
     *           为方法定义可选参数的语法如下：
     *           <parameterType> <parameterName> = <defaultValue>
     *           注意：对于<defaultValue>的值，存在一些限制。默认值必须是字面值、常量值或者默认值类型值
     *                 例如：
     *                  public bool CapitalizationDefault;
     *                  public List<string> GetWords(string sentence, bool capitalizeWords = CapitalizationDefault)
     *                  { ....}
     *                 此段代码不会被编译，可以做如下修改：
     *                 public bool CapitalizationDefault = false;
     *            2.Optional特性
     *               可以使用Optional特性定义可选参数：
     *               [Optional] <parameterType> <parameterName>
     *               注意：1.此特性包含在System.Runtime.InteropService名称空间中。
     *                     2.使用这种语法，无法为参数提供默认值。
     *            3.可选参数的顺序
     *               使用可选值时，它们必须位于方法的参数列表末尾。没有默认值的参
     *               数不能放在有默认值的参数后面
     *       
     *       13.10.2 命名参数//C# 4 
     *             命名参数。它允许指定要使用哪个参数。这不需要在方法定义中进行任何处理，
     *             它是一个在调用方法时使用的技术。其语法如下：
     *             Method(
     *             <parameter1Name>:<parameter1Name>,
     *             ......
     *             <parameterNName>:<parameterNName>)；//参数的名称是在方法定义中使用的变量名
     *             注意：1.只要命名参数存在，就可以采用这种方式指定需要的任意多个参数，而且参
     *                      数的顺序是任意的，命名参数也可以是可选的。
     */
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "his gaze against the sweeping bars has grown so weary";
            List<string> words;
            words = WordProcessor.GetWords(sentence);
            WriteLine("original sence:");
            foreach (string word in words)
            {
                Write(word);
                Write(' ');
            }
            WriteLine('\n');
            words = WordProcessor.GetWords(sentence, reverseWords: false, capitalizeWords: true);
            WriteLine("Capitalized sentence with reversed words:");
            foreach (string word in words)
            {
                Write(word);
                Write(' ');
            }
            ReadKey();
            
        }
    }
}
