using System;

namespace MethodOverRiding
{
    class BMW : Cars
    {
        public override void Start()
        {
            Console.WriteLine("there is a starting problem for this car");
         }
        public void Mileage()
        {
            Console.WriteLine("the mileage of this car is 30 miles/gallon");
        }
        public void LightOn()
        {
            Console.WriteLine("The lights are on");
        }
        public void BackCamera()
        {
            Console.WriteLine("back camera is off");
        }

    }
}
