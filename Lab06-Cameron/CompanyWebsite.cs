using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class CompanyWebsite : OnlineSales
    {
        public int PayPerClickSales(SummerEvent online)
        {
            online.SiteVisits();
            int ppc = 2000;
            return ppc;
            Console.WriteLine("Money!");
        }
        protected int SiteSales()
        {
            int siteSale = 50000;
            return siteSale;
        }
    }
}
