using System;
using System.Collections.Generic;
using System.Text;

namespace HRAdminAPI
{
    public class EmployeeBase : Employee
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual decimal salary { get; set; }
    }
         
}
