using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Cameron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Holiday effects on sales");

            OnlineSales decStore = new OnlineSales();

            CompanyWebsite decSite = new CompanyWebsite();

            decSite.PayPerClickSales(decStore);

            Console.WriteLine();

            Console.Read();

        }
    }
}
