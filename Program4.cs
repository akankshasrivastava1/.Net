using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("value of i {0}", i);
            }

            Console.WriteLine("Enter table Value");
            int t_val = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter table Size");
            int t_size = int.Parse(Console.ReadLine());


            for (int i = 1; i <= t_size; i++)
            {
                Console.WriteLine("{0}  *  {1}  =  {2}", t_val, i, (t_val * i));
                sum = sum + (t_val * i);
                if (sum == 30)
                {
                    break;
                }
            }

            Console.WriteLine("Sum of product {0}", sum);

            int post_fix = 50;
            Console.WriteLine("when variable initialized {0}", post_fix);
            Console.WriteLine("at the time of increment {0}", post_fix++);
            Console.WriteLine("after the increment " + post_fix);

            int pre_fix = 50;
            Console.WriteLine("\nwhen variable initialized {0}", pre_fix);
            Console.WriteLine("at the time of increment {0}", ++pre_fix);
            Console.WriteLine("after the increment " + pre_fix);

        }
    }
}
