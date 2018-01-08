using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParamMethod(1, 2, 3);
            ParamMethod();
            Console.ReadLine();
        }
        public static void ParamMethod(params int[] Digits)
        {
            Console.WriteLine("the no of elements in Digits is {0}", Digits.Length);
            foreach(int i in Digits)
            {
                Console.WriteLine(i);
            }
        }
    }
}
