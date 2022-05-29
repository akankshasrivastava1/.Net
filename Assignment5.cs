using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class myclass4
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
            Console.WriteLine("Printing Array Values");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public int[] ArrayAdd(int[] arr, int[] arr1)
        {
            int[] res_arr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                res_arr[i] = arr[i] + arr1[i];
            }
            return res_arr;
        }

    }
    class Assignment5
    {
        static void Main(string[] args)
        {
            myclass4 cls = new myclass4();
            int[] array1 = new int[3];
            int[] array2 = new int[3];

            array1[0] = 120;
            array1[1] = 130;
            array1[2] = 140;

            array2[0] = 300;
            array2[1] = 350;
            array2[2] = 400;

            int[] res_arr = cls.ArrayAdd(array1, array2);

            Console.WriteLine("Printing result Array Values");

            for (int i = 0; i < res_arr.Length; i++)
            {
                Console.WriteLine(res_arr[i]);
            }

            //Pass two array to function, add two arrays and return the 
            //addition array and print in the main
            Console.ReadKey();
        }
    }
}

