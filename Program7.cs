using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program7
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {

                Console.WriteLine("--Banking System--");
                Console.WriteLine("1.Opening Account");
                Console.WriteLine("2.Transfers");
                Console.WriteLine("3.Loan Details");
                Console.WriteLine("4.Online Registration");
                Console.WriteLine("5.Closing Accounts");

                Console.WriteLine("Press any Key Value....");
                int key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        {
                            Console.WriteLine("Calling Opening Account Functions");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Calling All Banking Transfers Function");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Calling Loan Details Functions");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Calling Online Registration Functions");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Calling Closing Account Functions");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Key");
                            break;
                        }
                }
                Console.WriteLine("Do you Want to Continue y/n ?");
                choice = Console.ReadLine();
            }
            while (choice == "y");

        }
    }
}
