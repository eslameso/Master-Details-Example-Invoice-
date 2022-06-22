using InvoiceTest.Data.Interfaces;
using InvoiceTest.Models;
using InvoiceTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Implementations
{
    public class ItemsRepo : IItemsRepo
    {
        public readonly DataBaseContext _db;
        public ItemsRepo(DataBaseContext db)
        {
            _db = db;
        }
        public List<Items> GetItems()
        {
            return _db.Items.ToList();
        }

        public List<SelectOptionsMv> GetItemsForelect()
        {
            var data = _db.Items.Select(m => new SelectOptionsMv { Id = m.Id, Name = m.Name }).ToList();
            return data;
        }
    }
}
