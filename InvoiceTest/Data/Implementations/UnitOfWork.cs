using InvoiceTest.Data.Interfaces;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _db;

        public UnitOfWork(DataBaseContext db)
        {
            _db = db;
        }
        public IInvoiceRepo Invoices =>
            new InvoiceRepo(_db);

        public ICustomersRepo Customers =>
            new CustomersRepo(_db);

        public IBranchesRepo Branches =>
            new BranchesRepo(_db);

        public IItemsRepo Items =>
            new ItemsRepo(_db);

        public bool Save()
        {
           return _db.SaveChanges() > 0;
        }
    }
}
