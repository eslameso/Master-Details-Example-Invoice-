using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.ViewModels
{
    public class DetailsVm
    {
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public List<Items> Items { get; set; }
        public int ItemId { get; set; }
        public decimal Total { get; set; }
        public int DetailId { get; set; }
    }
}
