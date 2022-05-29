using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class parent
    {
        public void method1()
        {
            Console.WriteLine("this is method1 in parent");

        }
    }

    class child1:parent
    {
        public void method2() //base class
        {
            Console.WriteLine("this is method2 of child1");
        }
    }

    class child1_ch:child1
    {
        public void method6() //base class
        {
            Console.WriteLine("this is method6 of child1_ch");
        }
    }
    class child2:parent
    {
        public void method3() //base class
        {
            Console.WriteLine("this is method3 of child2");
        }
    }
    class child3:parent
    {
        public void method4() //base class
        {
            Console.WriteLine("this is method4 of child3");
        }
    }
    class child4:parent
    {
        public void method5() //base class
        {
            Console.WriteLine("this is method5 in child4");
        }
    }
    class Program21
    {
        static void Main(string[] args)
        {
            child1 cls = new child1();
            cls.method1();
            cls.method2();

            child2 cls1 = new child2();
            cls1.method1();
            cls1.method3();

            child3 cls2 = new child3();
            cls2.method1();
            cls2.method4();

            child4 cls3 = new child4();
            cls3.method1();
            cls3.method5();

            child1_ch cls4 = new child1_ch(); //hybrid inheritance
            cls4.method1();
            cls4.method2();
            cls4.method6();
            Console.Read();
        }
    }
}
