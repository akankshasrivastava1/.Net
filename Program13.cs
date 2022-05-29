using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    public struct emp
    {
        public int empno;
        public string empname;
        public int salary;
    }

    public struct customer
    {
        public int cust_id;
        public string cust_address;
        public string cust_email;
        public string cust_phone;
    }


    class Program13
    {
        static void Main(string[] args)
        {
            emp obj;
            obj.empno = 1001;
            obj.empname = "sam";
            obj.salary = 8000;

            Console.WriteLine("empno = {0} empname = {1} salary = {2}", obj.empno, obj.empname, obj.salary);
            Console.Read();
        }
    }
}
