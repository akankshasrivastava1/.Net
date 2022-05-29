using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyPro1
{
    class patient
    {
        //empno, empname, address, email, phone, job
        string patientName, patientAddress, email;
        int patientID, phone, age;
        public void getinfo()
        {
            Console.WriteLine("Enter Patient ID");
            patientID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Patient Name");
            patientName = Console.ReadLine();

            Console.WriteLine("Enter address");
            patientAddress = Console.ReadLine();

            Console.WriteLine("Enter email");
            email = Console.ReadLine();

            Console.WriteLine("enter phone");
            phone = int.Parse(Console.ReadLine());

            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine("patientID = {0}, patientName = {1}, patientAddress = {2}, email = {3}, phone = {4}, age = {5}", patientID, patientName, patientAddress, email, phone, age);
        }
    }
    class childPatient : patient
    {
        string illness, Vaccine; 
        public void getinfo_reg()
        {
            base.getinfo();
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter tax");
            tax = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter pf");
            pf = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ta");
            ta = int.Parse(Console.ReadLine());

        }
        
        public void print_reg()
        {
            base.print();
            Console.WriteLine("printing salary = {0}, tax = {1}, pf = {2}, ta = {3} monthly-pay = {4}", salary, tax, pf, ta, monthly_pay);
        }
    }
    class Adult : patient
    {
        int cont_Amount, cont_Period, status, GST, monthlypay;
        public void getinfo_con()
        {
            base.getinfo();
            Console.WriteLine("Enter CONT Amount");
            cont_Amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cont Period");
            cont_Period = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter status");
            status = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter GST");
            GST = int.Parse(Console.ReadLine());

        }
        
        public void print_con()
        {
            base.print();
            Console.WriteLine(" cont_amount = {0} ,cont_per = {1}, cont_status = {2}, GST = {3}, monthlyPay = {4}", cont_Amount, cont_Period, status, GST, monthlypay);
        }
    }
    class OldAge : patient
    {
        int hourlypay, perday_hours, TDS, SA, monthlyPay, cost;
        public void getinfo_free()
        {
            base.getinfo();
            Console.WriteLine("Enter hourly pay");
            hourlypay = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter perday hours");
            perday_hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter TDS");
            TDS = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter SA");
            SA = int.Parse(Console.ReadLine());
        }
        public void monthlyPay_free()
        {
            //Console.WriteLine("CALCULATING monthlyPay = hourlypay*cost *perday_hours");
            monthlyPay = hourlypay * cost;
            cost = monthlyPay * perday_hours;
        }
        public void print_free()
        {
            base.print();
            Console.WriteLine("printing hourlypay = {0}, perday_hours = {1}, TDS = {2} , SA = {3}, monthlyPay = {4}, cost = {5}", hourlypay, perday_hours, TDS, SA, monthlyPay, cost);
        }

    }
    class Assignment9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Child Patient");
            Console.WriteLine("2. Adult Patient");
            Console.WriteLine("3. Oldage Patient");
            int key = 0;
            do
            {

                Console.WriteLine("Press Any Key,,(1 to 3)");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            childPatient x = new childPatient();
                            x.getinfo_reg();
                            //x.monthlyPay_reg();
                            x.print_reg();
                            break;
                        }
                    case 2:
                        {
                            contract1 cls = new contract1();
                            cls.getinfo_con();
                            cls.monthlyPay_con();
                            cls.print_con();
                            break;
                        }

                    case 3:
                        {
                            freelancer1 cls = new freelancer1();
                            cls.getinfo_free();
                            cls.monthlyPay_free();
                            cls.print_free();
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Key");
                        break;

                }
                Console.WriteLine("Press 1 to continue 0 to exit");
                key = int.Parse(Console.ReadLine());
            }
            while (key == 1);
        }
    }
}
}
