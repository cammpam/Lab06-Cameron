using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class UptownStore : InstoreSales
    {
        public override bool FullStock()
        {
            return false;
        }

        protected int UptownSales()
        {
            int uptownSales = 10000;
            return uptownSales;
        }
    }
}
