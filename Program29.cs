using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    public interface trans
    {
        void source_deduct();
        bool check_bal();
        void beni_add();
    }
    public interface calc
    {
        int add(int a, int b);
        int subs(int a, int b);
        int multi(int a, int b);
        int divs(int a, int b);

    }

    class calculator:calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subs(int a, int b)
        {
            return a - b;
        }
        public int multi(int a, int b)
        {
            return a * b;
        }
        public int divs(int a, int b)
        {
            return a / b;
        }
    }
    class calculator1 : calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subs(int a, int b)
        {
            return a - b;
        }
        public int multi(int a, int b)
        {
            return a * b;
        }
        public int divs(int a, int b)
        {
            return a / b;
        }
    }
    class Program29
    {
    }
}
