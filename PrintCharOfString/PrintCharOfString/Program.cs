using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCharOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter input string");
            string input = Console.ReadLine();
           // Console.WriteLine("enter input character to find");
            char ch = char.Parse(Console.ReadLine());
            //print each character of a string using foreach()

            /*foreach (char ch in input)
                Console.WriteLine(ch.ToString());
            Console.ReadLine();*/


            // PrintCharOfString each character of a string in new line using ToChatArray()

            /*var ch = input.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
                Console.WriteLine(ch[i]);
            Console.ReadLine();*/


            //print a particular character

            var cha= input.ToCharArray();
            for (int i = 0; i < cha.Length; i++)
            {
                if (cha[i] == ch)
                    Console.WriteLine("the character is in"+ " "+ cha[i]);
            }
           Console.ReadLine();
        }
       
    }
}
