using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleMyPro1
{
    public interface trans1
    {
        void source_deduct();
        bool check_bal();
        void beni_add();
    }

    public interface calc1
    {
        int add(int a, int b);
        int subs(int a, int b);
        int multi(int a, int b);
        int divs(int a, int b);
    }

    class calculator2 : calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int divs(int a, int b)
        {
            return a + b;
        }

        public int multi(int a, int b)
        {
            return a * b;
        }

        public int subs(int a, int b)
        {
            return a / b;
        }
    }

    class Program31
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            ls.Add(100);
            ls.Add(200);
            ls.Add(800);
            ls.Add(900);
            ls.Add(546);
            ls.Add(765);
            ls.Add(876);
            ls.Add(912);

            Console.WriteLine("reverse");
            ls.Reverse();
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }

            //for (int i = ls.Count-1; i >= 0; i--)
            //{
            //    Console.WriteLine(ls[i]);
            //}
            List<int> ls1 = new List<int>();
            ls1.Add(10);
            ls1.Add(20);
            ls1.Add(45);
            ls1.Add(96);

            int maxval = ls.Max();
            Console.WriteLine("maximum value is " + maxval);

            int count = ls.Count();
            Console.WriteLine("count is " + count);

            bool res = ls.Contains(780);
            if (res)
            {
                Console.WriteLine("value present");
            }
            else
            {
                Console.WriteLine("not present");
            }

            int sum = ls.Sum();
            Console.WriteLine("sum of the value is " + sum);

            Console.WriteLine("before removing values");
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }

            ls.Remove(100);

            Console.WriteLine("after removing values");
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }

            ls.RemoveRange(2, 3);
            Console.WriteLine("after removing range of values");
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }

            ls.InsertRange(4, ls1);

            Console.WriteLine("after insert range  of values");
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }
            ls.Reverse();
            ls.RemoveAt(2);

            int[] arr = ls.ToArray();

            string str = "bangalore,mumbai,chennai,delhi";
            string[] cities = str.Split(',');
            List<string> ctls = cities.ToList();
            Console.WriteLine("city list");
            foreach (string x in ctls)
            {
                Console.WriteLine(x);
            }

            //List<int> ls = new List<int>();
            ArrayList arrlst = new ArrayList();
            arrlst.Add(100);
            arrlst.Add(500);
            arrlst.Add(400);
            arrlst.Add(600);
            Console.WriteLine("Arraylist values");
            foreach (int x in arrlst)
            {
                Console.WriteLine(x);
            }

            ArrayList arrlst1 = new ArrayList();
            arrlst1.Add("bangalore");
            arrlst1.Add("chennai");
            arrlst1.Add("mumbai");
            arrlst1.Add("pune");
            Console.WriteLine("Arraylist values string");
            foreach (string x in arrlst1)
            {
                Console.WriteLine(x);
            }

            ArrayList arrlst2 = new ArrayList();
            arrlst2.Add(100);
            arrlst2.Add(2055);
            arrlst2.Add("mumbai");
            arrlst2.Add("pune");
            arrlst2.Add(10.5f);
            arrlst2.Add(true);
            Console.WriteLine("Arraylist values using Multiple");
            foreach (object x in arrlst2)
            {
                Console.WriteLine(x);
            }

        }
    }
}
