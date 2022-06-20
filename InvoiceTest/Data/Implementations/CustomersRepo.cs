using InvoiceTest.Data.Interfaces;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Implementations
{
    public class CustomersRepo : ICustomersRepo
    {
        private readonly DataBaseContext _db;

        public CustomersRepo(DataBaseContext db)
        {
            _db = db;
        }
        public List<Customers> GetCustomers()
        {
            return _db.Customers.ToList();
        }
    }
}
