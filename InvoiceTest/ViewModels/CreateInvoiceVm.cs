using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.ViewModels
{
    public class CreateInvoiceVm
    {
        public CreateInvoiceVm()
        {
            Details = new List<DetailsVm>();
            Items = new List<Items>();
        }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<Customers> Customers { get; set; }
        public int CustomerId { get; set; }
        public List<Branches> Branches { get; set; }
        public int BrancheId { get; set; }
        public IList<DetailsVm> Details { get; set; }
        public IList<Items> Items { get; set; }
        public decimal GrandTotal { get; set; }

    }
}
