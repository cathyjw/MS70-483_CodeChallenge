using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveJobsLaundrySystem
{
    class Clothes
    {
        public string Status;
        public string Message;

        public Clothes(string status, string message)
        {
            this.Status = status;
            this.Message = message;
        }
    }
}
