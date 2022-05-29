using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
        class employee
        {
            public int empno { get; set; }
            public string empname { get; set; }
            public string job { get; set; }
            public int deptno { get; set; }
            public int salary { get; set; }
            public int netsalary { get; set; }
             public int cal_tax { get; set; }
        }

    class Program14
    {
        static void Main(string[] args)
        {
            employee obj = new employee();
            obj.empno = 1001;
            obj.empname = "sam";
            obj.job = "manager";
            obj.deptno = 2;
            obj.salary = 8000;

            employee obj1 = new employee();
            obj.empno = 1002;
            obj.empname = "david";
            obj.job = "dev";
            obj.deptno = 3;
            obj.salary = 9000;

            Console.WriteLine("empno = {0} empname = {1} job = {2} deptno {3} salary = {4}", obj.empno, obj.empname, obj.empname, obj.job, obj.deptno, obj.salary);
            Console.WriteLine("empno = {0} empname = {1} job = {2} deptno {3} salary = {4}", obj1.empno, obj1.empname, obj1.empname, obj1.job, obj1.deptno, obj1.salary);
            Console.Read();
        }
    }
}
