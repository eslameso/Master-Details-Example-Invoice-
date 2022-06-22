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
        //CreateInvoiceVm GetDetails(string InvoiceNumber);
        
    }
}
