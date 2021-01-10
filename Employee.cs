using System;
using System.Collections.Generic;
using System.Text;

namespace HRAdminAPI
{
    public interface Employee
    {
        //get and set
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        decimal salary { get; set; }
    }
}
