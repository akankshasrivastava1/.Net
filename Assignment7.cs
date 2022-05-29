using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class employee3
    {
        //empno, empname, address, email, phone, job
        string empname, address, email, job;
        int empno, phone;
        public void getinfo()
        {
            Console.WriteLine("Enter empno");
            empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter empname");
            empname = Console.ReadLine();

            Console.WriteLine("address");
            address = Console.ReadLine();

            Console.WriteLine("email");
            email = Console.ReadLine();

            Console.WriteLine("enter phone");
            phone = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Job");
            job = Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("empno = {0}, empname = {1}, address = {2}, email = {3}, phone = {4}, job = {5}", empno, empname, address, email, phone, job);
        }
    }
    class regular1 : employee3
    {
        //salary, tax, pf, ta, monthly_pay
        int salary, tax, pf, ta, monthly_pay;
        public void getinfo_reg()
        {
            base.getinfo();
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter tax");
            tax = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter pf");
            pf = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ta");
            ta = int.Parse(Console.ReadLine());

        }
        public void monthlyPay_reg()
        {
            monthly_pay = salary - tax;
            monthly_pay = monthly_pay - pf;
            monthly_pay = monthly_pay + ta;
        }
        public void print_reg()
        {
            base.print();
            Console.WriteLine("printing salary = {0}, tax = {1}, pf = {2}, ta = {3} monthly-pay = {4}", salary, tax, pf, ta, monthly_pay);
        }
    }
    class contract1 : employee3
    {
        int cont_Amount, cont_Period, status, GST, monthlypay;
        public void getinfo_con()
        {
            base.getinfo();
            Console.WriteLine("Enter CONT Amount");
            cont_Amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cont Period");
            cont_Period = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter status");
            status = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter GST");
            GST = int.Parse(Console.ReadLine());

        }
        public void monthlyPay_con()
        {
            //Console.WriteLine("CALCULATING monthlyPay = count_amount/count_period-GST");
            monthlypay = cont_Amount - GST;
            monthlypay = cont_Amount / cont_Period - GST;
        }
        public void print_con()
        {
            base.print();
            Console.WriteLine(" cont_amount = {0} ,cont_per = {1}, cont_status = {2}, GST = {3}, monthlyPay = {4}", cont_Amount, cont_Period, status, GST, monthlypay);
        }
    }
    class freelancer1 : employee3
    {
        int hourlypay, perday_hours, TDS, SA, monthlyPay, cost;
        public void getinfo_free()
        {
            base.getinfo();
            Console.WriteLine("Enter hourly pay");
            hourlypay = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter perday hours");
            perday_hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter TDS");
            TDS = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter SA");
            SA = int.Parse(Console.ReadLine());
        }
        public void monthlyPay_free()
        {
            //Console.WriteLine("CALCULATING monthlyPay = hourlypay*cost *perday_hours");
            monthlyPay = hourlypay * cost;
            cost = monthlyPay * perday_hours;
        }
        public void print_free()
        {
            base.print();
            Console.WriteLine("printing hourlypay = {0}, perday_hours = {1}, TDS = {2} , SA = {3}, monthlyPay = {4}, cost = {5}", hourlypay, perday_hours, TDS, SA, monthlyPay, cost);
        }

    }
    class Assignment7
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
                            regular1 x = new regular1();
                            x.getinfo_reg();
                            x.monthlyPay_reg();
                            x.print_reg();
                            break;
                        }
                    case 2:
                        {
                            contract1 cls = new contract1();
                            cls.getinfo_con();
                            cls.monthlyPay_con();
                            cls.print_con();
                            break;
                        }

                    case 3:
                        {
                            freelancer1 cls = new freelancer1();
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

