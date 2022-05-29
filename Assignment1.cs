using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//write a logic to print the sum of result array values
namespace ConsoleMyPro1
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];
         
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

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                    sum += array1[i]+ array2[i];
            }
            Console.WriteLine("Sum of the result array values is: {0}", sum);

            Console.ReadKey();
        }
    }
}
