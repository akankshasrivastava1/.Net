using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class myclass5
    {
        public employee Search(List<employee> ls, int eno)
        {
            employee obj = new employee();
            foreach (employee x in ls)
            {
                if (x.empno == eno)
                {
                    obj = x;
                }
            }
            return obj;
        }

        public int sal_sum(List<employee> ls, int dno)
        {
            int sum = 0;
            foreach (employee x in ls)
            {
                if (x.deptno == dno)
                {
                    sum = sum + x.salary;
                }
            }
            return sum;
        }

        public List<employee> job_list(List<employee> ls, string job1)
        {
            List<employee> ls1 = new List<employee>();
            foreach (employee x in ls)
            {
                if (x.job == job1)
                {
                    ls1.Add(x);
                }
            }
            return ls1;
        }
        public List<employee> netsalary(List<employee> ls, int netsal,int tax, int cal_tax, int salary)
        {
            List<employee> ls2 = new List<employee>();
            foreach (employee x in ls)
            {
                if (x.netsalary == netsal)
                {
                    cal_tax = salary * tax / 100;
                    netsal = salary - cal_tax;
                }
            }
            return ls2;
        }
    }

    class Assignment6
    {
        static void Main(string[] args)
        {

            List<employee> obj_arr = new List<employee>();
            char choice = 'y';
            Console.WriteLine("\t\tenter Employee records");
            do
            {
                Console.WriteLine("\nEmployee No");
                int eno = int.Parse(Console.ReadLine());

                Console.WriteLine("Employee Name");
                string ename = Console.ReadLine();

                Console.WriteLine("Employee Job");
                string job1 = Console.ReadLine();

                Console.WriteLine("Dept No");
                int dno = int.Parse(Console.ReadLine());

                Console.WriteLine("Salary");
                int sal = int.Parse(Console.ReadLine());

                Console.WriteLine("Netsal");
                int netsal = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Tax Percentage");
                int cal_tax = int.Parse(Console.ReadLine());

                obj_arr.Add(new employee
                {
                    empno = eno,
                    empname = ename,
                    job = job1,
                    deptno = dno,
                    salary = sal,
                    netsalary = netsal
                });

                Console.WriteLine();

                Console.WriteLine("\nDo you Want to Create Another Object y/n ?");
                choice = char.Parse(Console.ReadLine());
            }
            while (choice == 'y');

            Console.WriteLine("\t--Employee Management System--");
            Console.WriteLine("1.Display all Employees");
            Console.WriteLine("2.Search Employee by Empno");
            Console.WriteLine("3.Search Employee by Job");
            Console.WriteLine("4.Sum of salary  Deptno wise");
            Console.WriteLine("5.display all employees with netsal(10% tax)");
            myclass5 cls = new myclass5();
            myclass5 cls1 = new myclass5();
            int choice1 = 0;
            do
            {

                Console.WriteLine("Press Any Key...");
                int key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        {
                            foreach (employee x in obj_arr)
                            {
                                Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4} netsalary = {5}", x.empno, x.empname, x.job, x.deptno, x.salary, x.netsalary);
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\nEnter Employee No to Search");
                            int eno1 = int.Parse(Console.ReadLine());
                            employee obj = cls.Search(obj_arr, eno1);
                            Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4} netsalary = {5}", obj.empno, obj.empname, obj.job, obj.deptno, obj.salary, obj.netsalary);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\nEnter job to get Employee list");
                            string job2 = Console.ReadLine();
                            List<employee> ls1 = cls.job_list(obj_arr, job2);
                            foreach (employee x in ls1)
                            {
                                Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4} netsalary = {5}", x.empno, x.empname, x.job, x.deptno, x.salary, x.netsalary);
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\nEnter Deptno to get Sum of Salary");
                            int dno1 = int.Parse(Console.ReadLine());
                            int sum = cls.sal_sum(obj_arr, dno1);
                            Console.WriteLine("deptno {0} sum of salary is {1}", dno1, sum);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\n enter employees netsal(10% tax)");
                            int netsal = int.Parse(Console.ReadLine());
                            int cal_tax = int.Parse(Console.ReadLine());
                            int tax = int.Parse(Console.ReadLine());
                            int salary = int.Parse(Console.ReadLine());
                            List<employee> ls1 = cls.netsalary(obj_arr, netsal, cal_tax, tax, salary);
                            foreach (employee x in ls1)
                            {
                                Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4} netsalary = {5} tax_amount {5} ", x.empno, x.empname, x.job, x.deptno, x.salary, x.netsalary, x.cal_tax);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Key.. Press 1 to 4");
                        break;
                }
                Console.WriteLine("Press 1 to continue 0 to exit");
                choice1 = int.Parse(Console.ReadLine());
            }
            while (choice1 == 1);

        }
    }
}
