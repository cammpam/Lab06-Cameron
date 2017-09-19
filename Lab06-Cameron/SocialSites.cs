using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class SocialSites : OnlineSales
    {
        protected override bool AffiliateSite()
        {
            return true;
        }

        public int Facebook()
        {
            int fbSales = 10000;
            return fbSales;
        }
    }
}
