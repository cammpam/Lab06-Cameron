using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    abstract class MyBusiness
    {
        public bool CustomerService()
        {
            return true;
        }

        private string POSS()
        {
            return "Square";
        }

        protected int Sales()
        {
            int sales = 0;
            return sales;
        }
    }
}
