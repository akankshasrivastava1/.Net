using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    public class Person
    {
       
        public int Age { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        // age = int.Parse(Console.WriteLine());

    }
    public class PersonImplementation
    {
        public double[] age = new double[10];
        int size = int.Parse(Console.ReadLine());

        public double Average(IList<Person> person)
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += age[i];
            return sum;
        }
        public int Max(IList<Person> players)
        {
            int Max = 0;
             for(int i = 1; i < size; i++)
            {
                if(age[0] < age[i])
                {
                    age[0] = age[i];
                }
            }
            return Max;
        }

    }
    class Test
    {
        static void Main()
        {
            PersonImplementation s = new PersonImplementation();
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });

        }
    }
}
