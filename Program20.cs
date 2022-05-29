using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    //five type of inheritance
 //sigle inheritance, multiple inheritance, mutilevel inheritance
 //heirarchical inheritance, hybrid inheritance
    
    //Multilevel Inheritance
    class myclass7
    {
        public void method1() //base class
        {
            Console.WriteLine("this is method1 in Myclass6");
        }
    }
    class myclass8:myclass7  //derived claa
    {
        public void method2()
        {
            Console.WriteLine("this is method2 in Myclass7");
        }
    }

    class myclass9 : myclass8  //derived class
    {
        public void method3()
        {
            Console.WriteLine("this is method3 in Myclass8");
        }
    }
    class Program20
    {
        static void Main(string[] args)
        {
            myclass9 cls = new myclass9();
            cls.method1();
            cls.method2();
            cls.method3();

            Console.Read();
            //myclass8 cls1 = new myclass8();
            //cls1.method2();
        }
    }
}
