using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class design_poly
    {
        public void search()
        {
            Console.WriteLine("parameterless method");
        }

        public void search(int x, int y)
        {
            Console.WriteLine("2 integer parameter method");
        }
        public int search(int x, string y)
        {
            Console.WriteLine(" integer and string parameter method");
            return 0;
        }
        public string search(int x, int y, int z)
        {
            Console.WriteLine("3 integer parameter method");
            return null;
        }
    }
    class Program26
    {
        static void Main(string[] args)
        {
            //designTime polymorphism, static polymorphism, method overloading,  function overloading, compileTime Overloading
            design_poly cls = new design_poly();
            cls.search(12, 22, 33);
            Console.Read();
        }
    }
}
