using InvoiceTest.Data.Interfaces;
using InvoiceTest.Models;
using InvoiceTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Implementations
{
    public class InvoiceRepo : IInvoiceRepo
    {
        private readonly DataBaseContext _db;

        public InvoiceRepo(DataBaseContext db)
        {
            _db = db;
        }
        public void CreateInvoice(CreateInvoiceVm model)
        {
            var Invoice = new Invoices();
            Invoice.BranchId = model.BrancheId;
            Invoice.CustomerId = model.CustomerId;
            Invoice.InvoiceNumber = model.InvoiceNumber;
            //Invoice.InvoiceDate = model.InvoiceDate;
            Invoice.GrandTotalPrice = model.GrandTotal;
            _db.Add(Invoice);

            if (model.Details.Count>0)
            {
                foreach (var item in model.Details)
                {
                    Invoice.InvoiceDetails.Add(new InvoiceDetails { 
                    ItemId=item.ItemId,
                    Price=item.Price,
                    Quantity=item.Quantity,
                    Discount=item.Discount,
                    Total=item.Total
                        });
                }
            }
            
        }
    }
}
