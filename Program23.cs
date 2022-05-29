using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
  //Access Modifiers (Public, Private, Protected, Internal, Protected Internal
    class father //derived class
    {
        public int x = 10, y = 20, z = 30;
        public void method1()
        {
            Console.WriteLine("this is method1 in Myclass7 x={0}, y={1}, z={2}", x, y, z);
        }
    }

    class child : father  //derived class
    {
        public void method2()
        {
            Console.WriteLine("this is method3 in Myclass8");
            Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);
        }
    }

    class g_child : child  //derived class
    {
        public void method3()
        {
            Console.WriteLine("this is method3 in g_child");
            Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);
        }
    }
    class Program23
    {
        static void Main(string[] args)
        {
            g_child cls = new g_child();
            Console.WriteLine("in main x={0}, y={1}, z={2}", cls.x, cls.y, cls.z);

            cls.method1();
            cls.method2();
            cls.method3();
        }
    }
}
