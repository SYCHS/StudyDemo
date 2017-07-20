using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace Iterator_27
{
    /*
     * 在迭代器块中，使用yield关键字选择要在foreach循环中使用的值。其语法如下：
     *      yield return <value>;
     * 
     * 中断将信息返回给foreach循环的过程： yield break；
     * 
     * 使用IEnumerable和IEnumerator的场合：
     *    1.如果要迭代一个类，可使用GetEnumerator(),其返回类型是IEnumerator。
     *    2.如果要迭代一个类成员，例如一个方法，则使用IEnumerable。
     * 
     */
    public class Primes//该类实现上下限之间的素数
    {

        private long min;
        private long max;
        public Primes() : this(2, 100) { }
        public Primes(long minimum, long maximum)
        {
            if (minimum < 2)
                min = 2;
            else
                min = minimum;
            max = maximum;
        }

        public IEnumerator GetEnumerator()
        {
            for (long possiblePrime = min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;

                for (long possibleFactor = 2; possibleFactor <=
                    (long)Math.Floor(Math.Sqrt(possiblePrime));possibleFactor++)
                {
                    long remainderAfterDivision = possiblePrime % possibleFactor;
                    if (remainderAfterDivision == 0)//判断一个素数的方法：看看该数能否被2到该数平方根之间的所有整数整除，如果能，则该数不是素数。
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return possiblePrime;
                }
             }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Primes primesFrom2To1000 = new Primes(2,1000);
            foreach (long i in primesFrom2To1000)
                Write($"{i} ");
            ReadKey();
        }
    }
}
