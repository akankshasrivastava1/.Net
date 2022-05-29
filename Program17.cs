using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class Program17
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            List<int> arr1 = new List<int>();
            List<int> res_arr = new List<int>();

            arr.Add(150);
            arr.Add(250);
            arr.Add(350);

            arr1.Add(180);
            arr1.Add(230);
            arr1.Add(840);
            
            for(int i =0; i<arr.Count; i++)
            {
                res_arr.Add(arr[i] + arr1[i]);
            }

            for(int i =0; i<arr.Count; i++)
            {
                Console.WriteLine(res_arr[i]);
            }

            List<string> st_arr = new List<string>();

            st_arr.Add("Bangalore");
            st_arr.Add("Pune");
            st_arr.Add("Mumbai");
            st_arr.Add("Chennai");

            for (int i = 0; i < st_arr.Count; i++)
            {
                Console.WriteLine(st_arr[i]);
            }
            Console.ReadKey();
        }
    }
}
