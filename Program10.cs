using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program10
    {
        static void Main(string[] args)
        {

            //darr[0, 0] = 100;
            //darr[0, 1] = 200;
            //darr[0, 2] = 300;
            //darr[0, 3] = 400;
            //darr[0, 4] = 500;

            //darr[1, 0] = 150;
            //darr[1, 1] = 250;
            //darr[1, 2] = 350;
            //darr[1, 3] = 450;
            //darr[1, 4] = 550;

            //darr[2, 0] = 155;
            //darr[2, 1] = 255;
            //darr[2, 2] = 355;
            //darr[2, 3] = 455;
            //darr[2, 4] = 555;

            //darr[3, 0] = 550;
            //darr[3, 1] = 650;
            //darr[3, 2] = 750;
            //darr[3, 3] = 850;
            //darr[3, 4] = 950;

            //darr[4, 0] = 190;
            //darr[4, 1] = 290;
            //darr[4, 2] = 390;
            //darr[4, 3] = 490;
            //darr[4, 4] = 590;
            Console.ReadKey();
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

            Console.WriteLine("Printing Double Dimension Array");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t"+ darr[i, j]);
                }
                Console.WriteLine();
            }

            //read 2 double dimension arrays and print the result array;
            //print sum of all rows in double dimension arrays
        }
    }
}
