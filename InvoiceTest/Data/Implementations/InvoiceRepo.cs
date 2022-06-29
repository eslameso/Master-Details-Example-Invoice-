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

        public void CreateDetails( CreateInvoiceVm Data)
        {
            var Invoice = _db.Invoices.FirstOrDefault(m => m.InvoiceNumber == Data.InvoiceNumber);
           
                DeleteDetails(Invoice.Id);

                foreach (var item in Data.Details)
                {
                    Invoice.InvoiceDetails.Add(new InvoiceDetails
                    {
                        InvoiceId=Invoice.Id,
                        ItemId = item.ItemId,
                        Price = item.Price,
                        Quantity = item.Quantity,
                        Discount = item.Discount,
                        Total = item.Total
                        });
                }

                _db.InvoiceDetails.AddRange(Invoice.InvoiceDetails);


                    }

        public void CreateInvoice(CreateInvoiceVm model)
        {
            var Invoice = new Invoices();
            Invoice.BranchId = model.BrancheId;
            Invoice.CustomerId = model.CustomerId;
            Invoice.InvoiceNumber = model.InvoiceNumber;
            Invoice.InvoiceDate = model.InvoiceDate;
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

        public void DeleteDetails(int InvoiceId)
        {
             var Details = _db.InvoiceDetails.Where(m => m.InvoiceId == InvoiceId).ToList();
             _db.InvoiceDetails.RemoveRange(Details);
            _db.SaveChanges();
        }

        public CreateInvoiceVm GetDetails(string InvoiceNumber)
        {
            var Items = _db.Items.ToList();
            var InvoiceId = 0;
            var Invoice= _db.Invoices.Where(m => m.InvoiceNumber == InvoiceNumber);
            if (Invoice.Any())
            {
                InvoiceId=Invoice.Select(m => m.Id).FirstOrDefault();
            }
           
            var Data = new CreateInvoiceVm();
            if (InvoiceId == 0)
            {
                Data.Details.Add(new DetailsVm() { });
            }
            else
            {
                var Details = _db.InvoiceDetails.Where(m => m.InvoiceId == InvoiceId).Select(m => new DetailsVm { DetailId = m.Id, ItemId = m.ItemId, Price = m.Price, Quantity = m.Quantity, Discount = m.Discount, Total = m.Total }).ToList();
                Data.Details = Details;
                

            }
            Data.Items = Items;


            return Data;

        }

        public decimal GetItemPrice(int ItemId)
        {
            return _db.Items.Where(M => M.Id == ItemId).FirstOrDefault().Price;
        }

        public decimal GetItemQuantity(int ItemId)
        {
            return _db.Items.Where(M => M.Id == ItemId).FirstOrDefault().Quantity;
        }

        public bool IsInvoiceExist(string InvoiceNumber)
        {

            return _db.Invoices.Where(m => m.InvoiceNumber == InvoiceNumber).Any();
           
        }


    }
}
