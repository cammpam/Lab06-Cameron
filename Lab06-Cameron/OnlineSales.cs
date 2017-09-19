using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class OnlineSales : MyBusiness, SummerEvent, HolidayPrep
    {
        protected virtual bool AffiliateSite()
        {
            return true;
        }

        public string DiscountCode()
        {
            return "TODAYONLY100%";
        }

        public int TicketSales()
        {
            return 1100;
        }

        public int SiteVisits()
        {
            return 1500;
        }

        public bool IncreasedPPC()
        {
            return true;
        }

        public string HolidayHours()
        {
            return "New Hours";
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
