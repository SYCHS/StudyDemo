using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_13
{
    class Program
    {
        /*
         * 
         * 1.string类型的变量可以看成char变量的只读数组。
         *             string  myString = "A string";
         *             char myChar = myString[1];
         * 
         * 2.string类型的变量转化成char类型的数组，使用ToCharArray()
         *             string str = "a string";
         *             char[] myChars = str.ToCharArray();
         *             
         * 3.使用foreach循环输出所有字符
         *             foreach(char character in str)
         *             {
         *                writeLine(character);
         *             }            
         *         
         * 4.通过str.Length获取字符串中的字符数
         *             
         * 5.str.ToLower()和str.ToUpper() 可以分别把字符串转换为小写或大写。
         *    注意：上面的两个命令并未真正改变str的内容，而是创建了一个新的字符串。
         *    
         * 6.str.Trim()——删除字符串前后的空格。
         * 
         * 7.str.Trim(char[] charArray)     删除字符串前后的字符(包含在charArray里的字符)
         * 
         * 8.str.TrimStart()——删除字符串前面的空格
         *   str.TrimEnd()——删除字符串后面的空格
         *   注意： 使用上面的两个方法也可以指定char数组。
         *  
         * 9.str.PadLeft(Int32)——在字符串的左边添加空格，使字符串达到指定的长度。
         *   str.PadRight(Int32)——在字符串的右边添加空格，使字符串达到指定的长度。
         *   
         * 10.str.PadLeft(Int32, Char)——返回一个新字符串，该字符串通过在此实例中的字符左侧填充指定的 
         *                                Unicode 字符来达到指定的总长度，从而使这些字符右对齐。
         *    str.PadRight(Int32, Char)——返回一个新字符串，该字符串通过在此字符串中的字符右侧填充指定的
         *                                 Unicode 字符来达到指定的总长度，从而使这些字符左对齐。
         *
         *11.str.Split(Char[])——基于数组中的字符将字符串拆分为多个子字符串。
         * 
         * 12.StartsWith(String)——确定此字符串实例的开头是否与指定的字符串匹配。
         *             
         */
        static void Main(string[] args)
        {
            string str = "a string";
            foreach (char myChar in str)
            {
                Console.WriteLine(myChar); 
            }

            string str1 = "This is a test.";
            char[] separator = {' '};
            string[] myWords;
            myWords = str1.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine(word);

            }
            Console.ReadKey();
        }
    }
}
