using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int q = 10;
            int total = 0;
            int result = 0;
            
            Math(i, q, out total, out result);

            SimpleMethod(ref i);
            Console.WriteLine("i is "+i);

            Console.ReadLine();


        }
        public static void SimpleMethod(ref int j)
        {
            Console.WriteLine("j is "+j);
            j = 101;
            Console.WriteLine("after modifications j is "+j);
        }

        public static void Math(int FirstNumber,int SecondNumber, out int Sum, out int Product)
        {
            Sum = FirstNumber + SecondNumber;
            Product = FirstNumber * SecondNumber;
            Console.WriteLine("sum is "+Sum);
            Console.WriteLine("product is "+Product);
        }
    }
}
