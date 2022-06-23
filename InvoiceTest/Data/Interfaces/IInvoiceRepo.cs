using InvoiceTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Interfaces
{
   public interface IInvoiceRepo
    {
        void CreateInvoice(CreateInvoiceVm model);
        CreateInvoiceVm GetDetails(string InvoiceNumber);
        bool IsInvoiceExist(string InvoiceNumber);
        void DeleteDetails(int InvoiceId);
        void CreateDetails(CreateInvoiceVm Data);
        decimal GetItemPrice(int ItemId);
        
    }
}
