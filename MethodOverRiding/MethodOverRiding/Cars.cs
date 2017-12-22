using System;

namespace MethodOverRiding
{
    class Cars
    {
        public virtual void Start()
        {
            Console.WriteLine("the car has started");
        }
        public void Stop()
        {
            Console.WriteLine("the has come to stop");
        }
        public virtual void Driving()
        {
            Console.WriteLine("we are driving in the car");
        }
    }
}
