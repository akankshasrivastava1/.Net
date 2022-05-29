using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{

    class myclass1
    {
        int z;
        public void test()
        {
            Console.WriteLine("This is my Function test");
         
        }

        public void add(int x, int y)
        {
            z = x + y;
            Console.WriteLine("The Addition is {0}",z);
        }

        public void subs(int x, int y)
        {
            z = x - y;
            Console.WriteLine("The Substraction is {0}", z);
        }

        public void multi(int x, int y)
        {
            z = x * y;
            Console.WriteLine("The Multiplication is {0}", z);
        }

        public void divs(int x, int y)
        {
            z = x / y;
            Console.WriteLine("The Division is {0}", z);
        }
    }

    class Program11
    {
        static void Main(string[] args)
        {
            myclass1 cls = new myclass1();
            cls.test();

            Console.WriteLine("Enter first Value");
            int val = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Value");
            int val1 = int.Parse(Console.ReadLine());

            cls.add(val, val1);
            cls.subs(val, val1);
            cls.multi(val, val1);
            cls.divs(val, val1);

            //for(int i=0; i<5; i++)
            //{
            //    cls.test();
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //cls.test();
        }
    }
}
