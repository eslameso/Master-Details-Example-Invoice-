using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Interfaces
{
   public interface IItemsRepo
    {
        List<Items> GetItems();
     }
}
