using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            int[] result = new int[size];

            Console.ReadKey();

            Console.WriteLine("Reading Array1 Values");

            for (int i = 0; i < size; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Reading Array2 Values");

            for (int i = 0; i < size; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                result[i] = array1[i]+array2[i];
            }
            Console.WriteLine("Printing additional Array Values");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(result[i]);
            }

            string[] str = new string[3];
            str[0] = "Banglore";
            str[1] = "Chennai";
            str[2] = "Pune";

            Console.WriteLine("Printig string Array Values");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(str[i]);
            }

            Console.ReadKey();
            //write a logic to print the sum of result array values
            //write a logic to compare two arrays and print common values
        }
    }
}
