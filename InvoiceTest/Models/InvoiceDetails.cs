using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Models
{
    public class InvoiceDetails
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoices Invoice { get; set; }
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Items Item { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        
    }
}
