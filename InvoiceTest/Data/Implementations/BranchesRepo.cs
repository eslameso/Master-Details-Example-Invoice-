using InvoiceTest.Data.Interfaces;
using InvoiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Data.Implementations
{
    public class BranchesRepo : IBranchesRepo
    {
        private readonly DataBaseContext _db;

        public BranchesRepo(DataBaseContext db)
        {
            _db = db;
        }
        public List<Branches> GetBranches()
        {
            return _db.Branches.ToList();
        }
    }
}
