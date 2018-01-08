using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly:log4net.Config.XmlConfigurator(Watch=true)]

namespace logging
{
    class Program
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            log.Error("This is my error message");
            Console.ReadLine();
        }
    }
}
