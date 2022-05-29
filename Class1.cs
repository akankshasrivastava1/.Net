using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dlst = new Dictionary<int, string>();
            dlst.Add(1001, "India");
            dlst.Add(1002, "Germany");
            dlst.Add(1003, "France");
            dlst.Add(1004, "Japan");
            dlst.Add(1005, "Malaysia");

            Dictionary<string, string> dlst1 = new Dictionary<string, string>();
            dlst1.Add("IND", "India");
            dlst1.Add("MLY", "Malaysia");
            dlst1.Add("GER", "Germany");

            //for (int i = 1001; i <= 1005; i++)
            //{
            //    Console.WriteLine(dlst[i]);
            //}

            foreach (KeyValuePair<int, string> x in dlst)
            {
                Console.WriteLine("key = {0} value = {1}", x.Key, x.Value);
            }

            Console.WriteLine("country List");
            foreach (KeyValuePair<string, string> x in dlst1)
            {
                Console.WriteLine("key = {0} value = {1}", x.Key, x.Value);
            }

            Dictionary<int, employee> objd = new Dictionary<int, employee>();

            objd.Add(1001, new employee { empno = 1001, empname = "sam", deptno = 10, salary = 10000 });
            objd.Add(1002, new employee { empno = 1002, empname = "john", deptno = 20, salary = 20000 });
            objd.Add(1003, new employee { empno = 1003, empname = "roni", deptno = 30, salary = 30000 });
            objd.Add(1004, new employee { empno = 1004, empname = "bob", deptno = 40, salary = 40000 });
            objd.Add(1005, new employee { empno = 1005, empname = "david", deptno = 50, salary = 50000 });

            Console.WriteLine("Employee List");
            foreach (KeyValuePair<int, employee> x in objd)
            {
                Console.WriteLine("key = {0}, empno = {1} empname = {2} job = {3} deptno = {4} salary = {5}",
                    x.Key, x.Value.empno, x.Value.empname, x.Value.deptno, x.Value.job, x.Value.salary);

            }
        }
    }
}
