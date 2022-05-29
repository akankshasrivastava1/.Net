using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class employee2
    {
        //empno, empname, address, email, phone, job
        public void getinfo()
        {
            Console.WriteLine(" reading empno, empname, address, email, phone, job");
        }
        public void print()
        {
            Console.WriteLine(" printing empno, empname, address, email, phone, job");
        }
    }
    class regular : employee2
    {
        //salary, tax, pf, ta, monthly_pay
        public void getinfo_reg()
        {
            base.getinfo();
            Console.WriteLine("reading salary, tax, pf, ta");
        }
        public void monthlyPay_reg()
        {
            Console.WriteLine("calculating monthlyPay = salary+Ta-pf-tax");
        }
        public void print_reg()
        {
            base.print();
            Console.WriteLine("printing salary, tax, pf, ta ");
        }
    }
    class contract : employee2
    {
        //cont_Amount, cout_Period, status, GST, monthlypay
        public void getinfo_con()
        {
            base.getinfo();
            Console.WriteLine("cont_Amount, cout_Period, con_status, GST");
        }
        public void monthlyPay_con()
        {
            Console.WriteLine("CALCULATING monthlyPay = count_amount/count_pet-GST");
        }
        public void print_con()
        {
            base.print();
            Console.WriteLine(" cont_amount,cont_per, cont_status,GST,monthlyPay");
        }
    }
        class freelancer : employee2
        {
            //hourlypay, perday_hours, TDS, SA, monthly pay
            public void getinfo_free()
            {
                base.getinfo();
                Console.WriteLine("hourlypay, perday_hours, TDS, SA");
            }
            public void monthlyPay_free()
            {
                Console.WriteLine("CALCULATING monthlyPay = hourlypay*cost *perday_hours");
            }
            public void print_free()
            {
                base.print();
                Console.WriteLine("printing hourlypay, perday_hours, TDS, SA, monthlyPay");
            }

        }
        class Program25
        {
            static void Main(string[] args)
            {
                Console.WriteLine("1.Regular Employee");
                Console.WriteLine("2.Contract Employee");
                Console.WriteLine("3.Freelancer Employee");
                int key = 0;
                do
                {

                    Console.WriteLine("Press Any Key,,(1 to 3)");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                regular x = new regular();
                                x.getinfo_reg();
                                x.monthlyPay_reg();
                                x.print_reg();
                                break;
                            }
                        case 2:
                            {
                                contract cls = new contract();
                                cls.getinfo_con();
                                cls.monthlyPay_con();
                                cls.print_con();
                                break;
                            }

                        case 3:
                            {
                                freelancer cls = new freelancer();
                                cls.getinfo_free();
                                cls.monthlyPay_free();
                                cls.print_free();
                                break;
                            }
                        default:
                            Console.WriteLine("Invalid Key");
                            break;

                    }
                    Console.WriteLine("Press 1 to continue 0 to exit");
                    key = int.Parse(Console.ReadLine());
                }
                while (key == 1);
            }
        }
    }

