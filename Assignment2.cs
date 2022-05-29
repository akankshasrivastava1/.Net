using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a logic to compare two arrays and print common values

namespace ConsoleMyPro1
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("Reading Array1 value");
            {
                for(int i = 0; i<size; i++)
                {
                    array1[i] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Reading Array2 value");
            {
                for (int i = 0; i < size; i++)
                {
                    array2[i] = int.Parse(Console.ReadLine());
                }
            }
            int flag = 0;

            for (int i =0; i<size; i++)
            {
                if (array1[i] == array2[i])
                {
                    flag =1;
                    Console.WriteLine("Common elements is {0}", array1[i]);
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Value doesn't exist");
            }
            Console.ReadKey();
            
        }
    }
}
