using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Interfaces
{
   public interface IUnitOfWork
    {
        IInvoiceRepo Invoices { get; }
        ICustomersRepo Customers { get; }
        IBranchesRepo Branches { get; }
        bool Save();
    }
}
