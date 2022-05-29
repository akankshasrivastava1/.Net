using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter No of Employees");
            int no_emp = int.Parse(Console.ReadLine());

            employee[] obj_arr = new employee[no_emp];
            Console.WriteLine("\t\t enter Employee records");

            for (int i = 0; i < no_emp; i++)
            {
                Console.WriteLine("\n Employee No.");
                int eno = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Employee Name");
                string ename = Console.ReadLine();

                Console.WriteLine("Employee Job");
                string job1 = Console.ReadLine();

                Console.WriteLine("Dept No.");
                int dno = int.Parse(Console.ReadLine());

                Console.WriteLine("Salary");
                int sal = int.Parse(Console.ReadLine());

                obj_arr[i] = new employee
                {
                    empno = eno,
                    empname = ename,
                    job = job1,
                    deptno = dno,
                    salary = sal
                };

                Console.WriteLine();
            }

            for(int i = 0; i < no_emp; i++)
            {
                Console.WriteLine("empno = {0}, empname = {1}, job = {2}, deptno = {3}, salary = {4}", obj_arr[i].empno, obj_arr[i].empname, obj_arr[i].job, obj_arr[i].deptno, obj_arr[i].salary);
            }
            Console.ReadKey();
        }
    
    }
}
