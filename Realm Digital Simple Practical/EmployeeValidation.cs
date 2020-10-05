using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realm_Digital_Simple_Practical
{
    public class EmployeeValidation
    {
        EmployeeModel empl = new EmployeeModel();
        int currentYear = DateTime.Now.Year;
        bool empstatus;
        bool yearstatus;


       //check if its a leapyear
        public bool CheckLeapYear()
        {
         if (DateTime.IsLeapYear(currentYear))
            {
                yearstatus = true;
            }
            else { yearstatus = false; }
            return yearstatus;
        }

        //check if employee has started working or is no longer working for the company
        public bool CheckEmploymentStatus()
        {
            if(empl.employmentEndDate==null)
            {
                empstatus = true;
            }
            else if ( empl.employmentStartDate ==null )
            {
                    empstatus = false;
            }
            else { empstatus = true; }
            
            return empstatus;
           
        }

    }
}
