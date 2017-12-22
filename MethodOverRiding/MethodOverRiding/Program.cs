using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list of cars");
            Console.WriteLine("1. BMW");
            Console.WriteLine("2. Maruti");
            Console.WriteLine("please choose an option from above");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                BMW bmw = new BMW();
                bmw.Start();
                bmw.LightOn();
                bmw.Driving();
                bmw.Mileage();
                bmw.BackCamera();
                bmw.Stop();
                Console.ReadLine();

            }

            else if (a == 2)
            {
                Maruti maruti = new Maruti();
                maruti.Start();
                maruti.LightOn();
                maruti.Driving();
                maruti.Mileage();
                maruti.BackCamera();
                maruti.Stop();
                Console.ReadLine();
            }

            else
                Console.WriteLine("wrong choice");
        }
    }
}
