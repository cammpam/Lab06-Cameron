using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class DowntownStore : InstoreSales
    {
        public override string WeekendHours()
        {
            return "Sat-Sun / CLOSED";
        }

        protected int DowntownSales()
        {
            int downtownSales = 20000;
            return downtownSales;
        }
    }
}
