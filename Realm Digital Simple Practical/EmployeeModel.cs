using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realm_Digital_Simple_Practical
{
    public class EmployeeModel
    {

        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime employmentStartDate { get; set; }
        public DateTime employmentEndDate { get; set; }

    }
}
