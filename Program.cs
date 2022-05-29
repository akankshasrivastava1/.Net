using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to CSharp Language..");
            Console.WriteLine("c# and web development Training");
            Console.WriteLine("Hello Welcome to CSharp Language..");
            Console.WriteLine("c# and web development Training");

            int x, y, z;
            x = 100;
            y = 200;
            z = 300;

            int rollno = 56677;

            Console.WriteLine("The Variable Values x = {0} y = {1} z = {2}", x, y, z);
            Console.WriteLine("Roll no is {0}", rollno);

            int empno, salary, deptno, netsal, tax, cal_tax;
            string empname, job;


            //empno = 1001;
            //empname = "Kevin";
            //job = "Manager";
            //deptno = 10;
            //salary = 3500.56f;

            Console.WriteLine("Enter EmpName");
            empname = Console.ReadLine();

            Console.WriteLine("Enter Empno");
            empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Job");
            job = Console.ReadLine();

            Console.WriteLine("Enter Deptno");
            deptno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Tax Percentage");
            tax = int.Parse(Console.ReadLine());

            cal_tax = salary * tax / 100;
            netsal = salary - cal_tax;

            Console.WriteLine("\nEmpname = {0} \nempno = {1} \njob = {2} \ndeptno = {3} \nsalary ={4}  \ntax_amount {5} \nnetsalary = {6}", empname, empno, job, deptno, salary, cal_tax, netsal);

            //Console.WriteLine("\nEmployeeNo ="+empno+"\nEmpname="+empname+"\njob="+job);
            Console.Read();
        }
    }
}
