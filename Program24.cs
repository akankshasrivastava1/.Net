using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{

    //Constructor Chaining in Inheritance
    class father1  //base class
    {
        int x, y;
        string z;
        public father1(int x, int y, string z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void method1()
        {
            Console.WriteLine("this is method1 in father1");
            Console.WriteLine("father1 constructor values x={0} y={1} z={2}", x, y, z);
        }
    }

    class child_1 : father1  //derived class
    {

        int x, y;
        public child_1(int x, int y) : base(x, y, "bangalore")
        {
            this.x = x;
            this.y = y;
        }

        public void method2()
        {
            Console.WriteLine("this is method2 in child_1");
            //Console.WriteLine("child_1 constructor values x={0} y={1} ", x, y);
        }
    }

    class g_child1:child_1 //derived class
    {
        int x, y, z;
        public g_child1(int x, int y, int z):base(100,200)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void method3()
        {
            Console.WriteLine("this is method3 in g_child");
            Console.WriteLine("g_child1 constructor values x={0}, y={1}, z={2}", x, y, z);
        }
    }
    class Program24
    {
        static void Main(string[] args)
        {
            g_child1 cls = new g_child1(100, 200, 300);
            cls.method1();
            cls.method2();
            cls.method3();
        }
    }
}
