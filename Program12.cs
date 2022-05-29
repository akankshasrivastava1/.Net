using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class myclass2
    {
        int z;
        public int add(int x, int y)
        {
            z = x + y;
            return z;
        }

        public int subs(int x, int y)
        {
            z = x - y;
            return z;
        }

        public int multi(int x, int y)
        {
            z = x * y;
            return z;
        }

        public int divs(int x, int y)
        {
            z = x / y;
            return z;
        }
        public void Array1(int[] arr)
        {
            Console.WriteLine("Printing array Values");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        class Program12
        {
            static void Main(string[] args)
            {
                myclass2 cls = new myclass2();
                int result;

                Console.WriteLine("Enter first Value");
                int val = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Value");
                int val1 = int.Parse(Console.ReadLine());

                result = cls.add(val, val1);
                Console.WriteLine("The addition is {0}", result);

                result = cls.subs(val, val1);
                Console.WriteLine("The substraction is {0}", result);

                result = cls.multi(val, val1);
                Console.WriteLine("The multiplication is {0}", result);

                result = cls.divs(val, val1);
                Console.WriteLine("The division is {0}", result);

                int[] arr = new int[5];
                Console.WriteLine("Reading Array Values");

                for(int i =0; i<5; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                cls.Array1(arr);

                //pass two array to function, add two arrays and return the 
                //addition array and print in the main
            }
        }
    }
}
