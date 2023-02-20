//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day_5_Program
//{
//    class class1
//    {
//    }
    
//    class class2
//    {

//    }

//    class IsTest
//    {
//        public static void Main()
//        {
//            object[] myObjects = new object[6];
//            myObjects[0] = new class1();

//            myObjects[2] = "string";
//            myObjects[3] = 32;
//            myObjects[4] = null;
//            myObjects[1] = new class2();

            

//            for(int i=0; i<myObjects.Length; ++i)
//            {
//                string s = myObjects[i] as string;
//                Console.Write("{0}: ", i);
//                if (s != null)
//                    Console.WriteLine("'" + s + "'");
//                else
//                    Console.WriteLine("not a string");
                
//        }  
//    }
//}
