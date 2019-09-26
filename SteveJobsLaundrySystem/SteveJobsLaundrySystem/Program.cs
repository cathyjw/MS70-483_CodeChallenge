using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SteveJobsLaundrySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("English", "Dollars", "San Francisco");
            Clothes c= new Clothes("Dirty", "Can you get my clothes laundered, please.");
            Console.WriteLine(c.Message);

            if (e.Language == "English" && e.Money == "Dollars" && e.Country == "San Francisco")
            {
                Thread.Sleep(500);
            }

            c.Status = "Clean";
            c.Message = "Here are your clean clothes.";

            Console.WriteLine(c.Message);
            Console.ReadLine();
        }
    }
}
