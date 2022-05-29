using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class myclass3
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
    }

    class Program18
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nEnter No of Employees");
            //int no_emp = int.Parse(Console.ReadLine());

            List<employee> obj_arr = new List<employee>();
            char choice = 'y';

            Console.WriteLine("\t\tenter Employee records");
            //for (int i = 0; i < no_emp; i++)
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


                obj_arr.Add(new employee
                {
                    empno = eno,
                    empname = ename,
                    job = job1,
                    deptno = dno,
                    salary = sal
                });

                Console.WriteLine();

                Console.WriteLine("\nDo you Want to Create Another Object y/n ?");
                choice = char.Parse(Console.ReadLine());
            }
            while (choice == 'y');



            //for (int i = 0; i < obj_arr.Count; i++)
            //{
            //    Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4}", obj_arr[i].empno, obj_arr[i].empname, obj_arr[i].job, obj_arr[i].deptno, obj_arr[i].salary);
            //}

            foreach (employee x in obj_arr)
            {
                Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4}", x.empno, x.empname, x.job, x.deptno, x.salary);
            }

            Console.WriteLine("\nEnter Employee No to Search");
            int eno1 = int.Parse(Console.ReadLine());

            myclass3 cls = new myclass3();
            employee obj = cls.Search(obj_arr, eno1);
            Console.WriteLine("empno = {0} empname = {1} job = {2} deptno = {3} salary = {4}", obj.empno, obj.empname, obj.job, obj.deptno, obj.salary);

            //pass the deptno and return the sum of salary of that deptno
            //pass job and return the list of employees based on job
            Console.ReadKey();
        }
    }

}
