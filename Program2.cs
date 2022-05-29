using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--Employee Payroll System---");

            int empno, salary, deptno, tax, netsal;
            string empname, job;

            Console.WriteLine("Enter Empno");
            empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter EmpName");
            empname = Console.ReadLine();

            Console.WriteLine("Enter Job");
            job = Console.ReadLine();

            Console.WriteLine("Enter Deptno");
            deptno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

            if (salary >= 35000 && salary < 200000)
            {
                tax = salary * 18 / 100;
            }
            else if (salary >= 20000 && salary < 35000)
            {
                tax = salary * 12 / 100;
            }
            else if (salary >= 15000 && salary < 20000)
            {
                tax = salary * 8 / 100;
            }
            else if (salary >= 10000 && salary < 15000)
            {
                tax = salary * 5 / 100;
            }
            else
            {
                tax = salary * 2 / 100;
            }
            netsal = salary - tax;

            Console.WriteLine("\nEmpname = {0} \nempno = {1} \njob = {2} \ndeptno = {3} \nsalary ={4}  \ntax_amount {5} \nnetsalary = {6}", empname, empno, job, deptno, salary, tax, netsal);





            //if(empno.ToString().Length==4)
            //{
            //    Console.WriteLine("valid empno");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid empno: Enter 4 digit");
            //}


            //if(salary>15000)
            //{
            //    Console.WriteLine("Taxable Income");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Taxable Income");
            //}


            //int x;
            //string y;
            //Console.WriteLine("Enter x value");
            //x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter y value");
            //y = Console.ReadLine();

            //if (x == 10 && y == "sam")
            //{
            //    Console.WriteLine(" statement True x = {0} y = {1}", x, y);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Statement");
            //}

            //if (x == 10 || y == "sam")
            //{
            //    Console.WriteLine(" statement True x = {0} y = {1}", x, y);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Statement");
            //}

        }
    }
}
