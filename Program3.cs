using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program3
    {
        static void Main(string[] args)
        {
            //short,int,long,char,string,float,double,bool,object,var,dynamic,byte,ref
            int x = 10;
            short y = 20;
            long z = 30;


            uint y1 = 676767;
            int y2 = -66767;

            int d1 = 700;


            Int16 x1 = 100; //short datatype
            Int32 x2 = 200; //int Datatype
            Int64 x3 = 500; //long DataType

            Console.WriteLine("int32 var {0} int16 var {1} int64 var {2}", x2, x1, x3);

            int int_size = int.MaxValue;
            short short_size = short.MaxValue;
            long long_size = long.MaxValue;

            Console.WriteLine("int max_Size {0} short max_size {1} long max_size {2}", int_size, short_size, long_size);

            short sh = 32700;
            Console.WriteLine("Short sh value {0}", sh);

            char ch1 = 'a';
            string str = "bangalore";
            float fl = 567.67f;
            double dl = 78787.55d;
            bool bl = true;
        }
    }
}
