using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Models
{
    public class Items
    {
        public Items()
        {
            InvoiceDetails = new List<InvoiceDetails>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public List<InvoiceDetails> InvoiceDetails { get; set; }

    }
}
