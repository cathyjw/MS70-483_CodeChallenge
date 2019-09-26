using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveJobsLaundrySystem
{
    class Employee
    {
        public string Language;
        public string Money;
        public string Country;

        public Employee(string language, string money, string country)
        {
            this.Language = language;
            this.Money = money;
            this.Country = country;
        }
    }
}
