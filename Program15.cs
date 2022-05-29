using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program15
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 100;
            arr[1] = 100;
            arr[2] = 100;
            arr[3] = 100;
            arr[4] = 100;

            employee[] obj_arr = new employee[5];

            employee e1 = new employee();
            e1.empno = 1001;
            e1.empname = "sam";
            e1.job = "manager";
            e1.deptno = 10;
            e1.salary = 7000;
            obj_arr[0] = e1;

            employee e2 = new employee();
            e2.empno = 1002;
            e2.empname = "sana";
            e2.job = "manager";
            e2.deptno = 20;
            e2.salary = 8000;
            obj_arr[1] = e2;

            employee e3 = new employee();
            e3.empno = 1003;
            e3.empname = "virat";
            e3.job = "dev";
            e3.deptno = 30;
            e3.salary = 9000;
            obj_arr[2] = e3;

            employee e4 = new employee();
            e4.empno = 1004;
            e4.empname = "stuti";
            e4.job = "dev";
            e4.deptno = 40;
            e4.salary = 10000;
            obj_arr[3] = e4;

            employee e5 = new employee();
            e5.empno = 1005;
            e5.empname = "salina";
            e5.job = "manager";
            e5.deptno = 50;
            e5.salary = 11000;
            obj_arr[4] = e5;

            //obj_arr[0] = new employee
            //{
            //    empno = 1001,
            //    empname = "sam",
            //    job = "manager",
            //    deptno = 10,
            //    salary = 7000
            //};

            //obj_arr[1] = new employee
            //{
            //    empno = 1002,
            //    empname = "david",
            //    job = "developer",
            //    deptno = 20,
            //    salary = 8000
            //};

            //obj_arr[2] = new employee
            //{
            //    empno = 1003,
            //    empname = "akanksha",
            //    job = "analyst",
            //    deptno = 30,
            //    salary = 9000
            //};

            //obj_arr[3] = new employee
            //{
            //    empno = 1004,
            //    empname = "sama",
            //    job = "dev",
            //    deptno = 40,
            //    salary = 10000
            //};

            //obj_arr[4] = new employee
            //{
            //    empno = 1001,
            //    empname = "tara",
            //    job = "dev",
            //    deptno = 50,
            //    salary = 11000
            //};

            for(int i=0; i<obj_arr.Length;i++)
            {
                Console.WriteLine("empno = {0}, empname = {1}, job = {2}, deptno = {3}, salary = {4}",obj_arr[i].empno, obj_arr[i].empname, obj_arr[i].job, obj_arr[i].deptno, obj_arr[i].salary);
            }
            Console.ReadKey();
        }
    }
}
