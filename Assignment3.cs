using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//read 2 double dimension arrays and print the result array;

namespace ConsoleMyPro1
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of rows");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the no of columns");
            int cols = int.Parse(Console.ReadLine());

            int[,] darr = new int[rows, cols];

            Console.WriteLine("Enter Array Values");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    darr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < darr.Length; i++)
            {
                for (int j = 0; j < darr.Length; j++)
                {
                    sum += rows + cols;
                }
            }
            Console.WriteLine("Sum of the result array values is: {0}", sum);

            Console.ReadKey();

        }
    }
}
