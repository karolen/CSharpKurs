using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = args[0];

            Console.Beep();
            Console.WriteLine("Hello world");
            Console.WriteLine(name);

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj " +item);
            //}
        }
    }
}
