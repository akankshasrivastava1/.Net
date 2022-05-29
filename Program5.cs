using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("value of i {0}", i);
                i++;
            }

            Console.WriteLine("Enter table Value");
            int t_val = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter table Size");
            int t_size = int.Parse(Console.ReadLine());

            int j = 1;
            while (j <= t_size)
            {
                Console.WriteLine("{0}  *  {1}  =  {2}", t_val, j, (t_val * j));
                j++;
            }
        }
    }
}
