using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Program
{
    class boxndunbox
    {
        static void Main(string[] args)
        {
            int a = 10;
            object b = a;
            Console.WriteLine(b);

            object c = 100;
            int d = (int)c;
            Console.WriteLine(d);
            Console.ReadLine();

        }
        
    }
}
