using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleMyPro1
{
    class iterator
    {
        public void print(IEnumerable lst)
        {
            IEnumerator en = lst.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current.ToString());
            }
        }
    }
    class Program33
    {
        static void Main(string[] args)
        {
            iterator t = new iterator();
            List<int> ls = new List<int>();
            ls.Add(100);
            ls.Add(200);
            ls.Add(800);
            ls.Add(900);
            ls.Add(546);
            ls.Add(765);
            ls.Add(876);
            ls.Add(912);

            Console.WriteLine("integer list");
            t.print(ls);
            //foreach (int x in ls)
            //{
            //    Console.WriteLine(x);
            //}

            List<string> clst = new List<string>();
            clst.Add("mumbai");
            clst.Add("chennai");
            clst.Add("bangalore");
            clst.Add("delhi");
            clst.Add("pune");

            Console.WriteLine("string list");

            //foreach (string x in clst)
            //{
            //    Console.WriteLine(x);
            //}
            t.print(clst);

            ArrayList arrlst2 = new ArrayList();
            arrlst2.Add(100);
            arrlst2.Add(2055);
            arrlst2.Add("mumbai");
            arrlst2.Add("pune");
            arrlst2.Add(10.5f);
            arrlst2.Add(true);
            Console.WriteLine("mixed list in ArrayList");
            t.print(arrlst2);

            ArrayList arrlst = new ArrayList();
            arrlst.Add(100);
            arrlst.Add(500);
            arrlst.Add(400);
            arrlst.Add(600);
            Console.WriteLine("ArrayList numbers");
            t.print(arrlst);

        }
    }
}
