using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class myclass6
    {
        int x, y, z;

        public myclass6()
        {
            Console.WriteLine("am Constructor");
            x = 100;
            y = 200;
            z = 300;
        }

        public myclass6(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public myclass6(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.z = 100;
        }

        public myclass6(myclass6 obj)
        {
            this.x = obj.x;
            this.y = obj.y;
            this.z = obj.z;
        }
        public void print()
        {
            Console.WriteLine("x = {0} y = {1} z = {2}", x, y, z);
        }

        public void print1()
        {
            Console.WriteLine("x = {0} y = {1} z = {2}", x+y, z+z, x+x);
        }
    }
    class Program19
    {
        static void Main(string[] args)
        {
            myclass6 cls = new myclass6(10, 15, 20);
            cls.print();
            cls.print1();

            myclass6 cls1 = new myclass6();
            cls.print();
            cls.print1();

            myclass6 cls2 = new myclass6(1000, 2000);
            cls.print();
            cls.print1();

            myclass6 cls3 = new myclass6(cls2);
            cls.print();
            cls.print1();

            //myclass6 cls1 = new myclass6(250, 350, 400);
            //cls.print();
            Console.Read();
        }
    }
}
