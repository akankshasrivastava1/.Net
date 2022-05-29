using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            int[] arr1 = new int[size];

            /* arr[0] = 120;
             arr[1] = 340;
             arr[2] = 530;
             arr[3] = 210;
             arr[4] = 380;*/
           
            Console.WriteLine("Reading Array Values");

            for(int i=0; i<size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Printing Array Values");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Enter the value to check in Array");
            int val = int.Parse(Console.ReadLine());
            int flag = 0;

            for(int i = 0; i < size; i++)
            {
                if (arr[i] == val)
                {
                    flag = 1;
                    Console.WriteLine("Array value {0} is found in the Index position of {1}", val, i);
                }
              
            }
            if(flag==0)
            {
                Console.WriteLine("Value doesn't exist");
            }
            Console.ReadKey();
        }
    }
}
