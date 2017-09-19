using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class InstoreSales : MyBusiness, HolidayPrep
    {
        public string WeekHours()
        {
            return "Mon-Fri / 9AM - 9PM";        
        } 

        public virtual string WeekendHours()
        {
            return "Sat-Sun / 12PM - 7PM";
        }

        public virtual bool FullStock()
        {
            return true;
        }

        public string HolidayHours()
        {
            return "Everyday / 9AM - 11PM";
        }

        public bool OverStock()
        {
            return true;
        }

        public int Employees()
        {
            return 20;
        }
    }
}
