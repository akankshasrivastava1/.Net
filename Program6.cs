using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nested for loop");

            for (int i = 1; i <= 5; i++)   //i=2
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("\t" + j);  //j 1 2 3 4 5 1 2 3 4 5
                }
                Console.WriteLine();
            }

            Console.WriteLine("nested while loop");
            int i1 = 1;
            while (i1 <= 5)
            {
                int j = 1;
                while (j <= i1)
                {
                    Console.Write("\t" + j);
                    j++;
                }
                i1++;
                Console.WriteLine();
            }
        }
    }
}
