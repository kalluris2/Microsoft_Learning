using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    class Maruti : Cars
    {
        public override void Driving()
        {
            Console.WriteLine("we cannot drive this car");
        }
            
        public void Mileage()
        {
            Console.WriteLine("the mileage of thiss car is 40 miles/gallon");
        }
        public void LightOn()
        {
            Console.WriteLine("The lights are off");
        }
        public void BackCamera()
        {
            Console.WriteLine("back camera is on");
        }
    }
}
