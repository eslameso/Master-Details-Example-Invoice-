using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Models
{
    public class Customers
    {
        public Customers()
        {
            Invoices = new List<Invoices>();
           
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }

        public List<Invoices> Invoices { get; set; }
       

    }
}
