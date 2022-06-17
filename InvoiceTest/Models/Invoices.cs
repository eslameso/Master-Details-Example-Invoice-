using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Models
{
    public class Invoices
    {
        public Invoices()
        {
            InvoiceDetails = new List<InvoiceDetails>();
        }
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal GrandTotalPrice { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customers Customer { get; set; }

        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public Branches Branch { get; set; }

        public List<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
