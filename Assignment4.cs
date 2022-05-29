using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Assignment4
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
            Console.WriteLine("The Sum of Elements of a Rows in a Matrix ");
            for (int i = 0; i < rows; i++)
            {
                int Sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    Sum = Sum + darr[i, j];
                    Console.Write("\t"+ darr[i, j]);
                    
                }
                Console.WriteLine(" =  {0} ", Sum);
            }
            Console.ReadKey();
        }
    }
}
