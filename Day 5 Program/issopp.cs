using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Program
{
    class myclass1 { }

    class myclass2 { }

    class myclass
    {
        static void Main(string[] args)
        {
            myclass1 myclass1 = new myclass1();
            myclass2 myclass2 = new myclass2();

            test(myclass1);
            test(myclass2);

            Console.ReadLine();
        }

        static void test(object obj)
        {
            myclass1 obj1;
            myclass2 obj2;

            if(obj is myclass1)
            {
                Console.WriteLine("obj is myclass1");
                obj1 = (myclass1)obj;

            }
            else if(obj is myclass2)
            {
                Console.WriteLine("obj is myclass2");
                obj2 = (myclass2)obj;
            }
            else
            {
                Console.WriteLine("obj is neither class1 and neither class2");
            }
        }
    }
    
}
