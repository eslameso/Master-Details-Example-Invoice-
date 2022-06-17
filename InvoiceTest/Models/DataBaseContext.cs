using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Models
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            :base(options)
        {

        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<Items> Items { get; set; }

    }
}
