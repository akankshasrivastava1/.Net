using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class employee5
    {
        protected string empname, job;
        protected int empno, monthly_pay, salary, tax, pf;

        public void Read_info()
        {
            Console.WriteLine("Enter empno");
            empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter empname");
            empname = Console.ReadLine();

            Console.WriteLine("enter Job");
            job = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter tax");
            int tax = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter pf");
            int pf = int.Parse(Console.ReadLine());

   
        }
        public virtual void cal_sal()
        {
            monthly_pay = salary - tax;
            monthly_pay = monthly_pay - pf;
           // monthly_pay = monthly_pay + ta;
            Console.WriteLine("\nSalary slip \n\nempno = {0}, \nempname = {1}, \njob = {2}, \nsalary = {3}, \ntax = {4}, \npf = {5}, \nta = {6} ",empno, empname, job, salary, tax, pf);
        }
    }
    class sub_employee5:employee5 //subsitution method of that method
    {
        int ta, ma;
        public override void cal_sal()
        {
            monthly_pay = salary - tax;
            monthly_pay = monthly_pay - pf;
            ta = salary * 2 / 100;
            ma = salary * 2 / 100;
            monthly_pay = monthly_pay + (ta + ma);
            Console.WriteLine("\nSalary slip \n\nempno = {0}, \nempname = {1}, \njob = {2}, \nsalary = {3}, \ntax = {4}, \npf = {5}, \nta = {6} ma = {7} monthly_pay", empno, empname, job, salary, tax, pf, ta);
        }
        public void test()
        {
            Console.WriteLine("this is a test method");
        }
    }
    class sub_employee6 : employee5 //subsitution method of that method
    {
        int ta, ma, sa;
        public override void cal_sal()
        {
            monthly_pay = salary - tax;
            monthly_pay = monthly_pay - pf;
            ta = salary * 2 / 100;
            ma = salary * 2 / 100;
            sa = salary * 2 / 100;
            monthly_pay = monthly_pay + (ta + ma);
            monthly_pay = monthly_pay + sa;
            Console.WriteLine("\nSalary slip \n\nempno = {0}, \nempname = {1}, \njob = {2}, \nsalary = {3}, \ntax = {4}, \npf = {5}, \nta = {6} ma = {7} monthly_pay", empno, empname, job, salary, tax, pf, ta);
        }
        public void test()
        {
            Console.WriteLine("this is a test method");
        }
    }
    class Program28
    {
        static void Main(string[] args)
        {
            //employee5 obj = new employee5();
            //obj.Read_info();

            Console.WriteLine("--Employee salarySlip Versions--");

            Console.WriteLine("1. cal_salary Versions--");
            Console.WriteLine("2. cal_salary Versions--");
            int choice = 0;
            employee5 obj;
            do
            {

                Console.WriteLine("--Press Any Key--");
                int key = int.Parse(Console.ReadLine());
                if (key == 1)
                {
                   obj = new employee5();
                    obj.Read_info();
                    obj.cal_sal();
                }
                if (key == 2)
                {
                    obj = new sub_employee5();
                    obj.Read_info();
                    obj.cal_sal();
                    //obj.test();
                }
                if (key == 3)
                {
                    obj = new employee5();
                    obj.Read_info();
                    obj.cal_sal();
                }

                Console.WriteLine("Press 1 to continue 0 to exit");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice == 1);
        }
    }
}
