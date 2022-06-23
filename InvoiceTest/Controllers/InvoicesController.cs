using InvoiceTest.Data.Interfaces;
using InvoiceTest.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IUnitOfWork _uow;

        public InvoicesController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        // GET: InvoicesController
        public ActionResult Index()
        {

            var Model = new CreateInvoiceVm
            {
                Customers = _uow.Customers.GetCustomers(),
                Branches = _uow.Branches.GetBranches(),
                Items = _uow.Items.GetItems(),
                InvoiceDate=DateTime.Now
                          };

            //Model.Details.Add(new DetailsVm() {DetailId=1 });
            //Model.Details.Add(new DetailsVm() { DetailId = 2 });
            //Model.Details.Add(new DetailsVm() { DetailId = 3 });
            return View(Model);
        }

        public JsonResult GetItems()
        {
            var data = _uow.Items.GetItemsForelect();
             return Json(data);
        }

        // GET: InvoicesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvoicesController/Create
        public ActionResult Create()
        {
            return View();
        }

        public IActionResult GetDetails(string InvoiceNumber)
        {
            var Data = _uow.Invoices.GetDetails(InvoiceNumber);
            return PartialView("BodyRows", Data);
        }

        // POST: InvoicesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateInvoiceVm model)
        {
            if (_uow.Invoices.IsInvoiceExist(model.InvoiceNumber))
            {
                _uow.Invoices.CreateDetails(model);
            }
            else
            {
                _uow.Invoices.CreateInvoice(model);
            }
            
            _uow.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: InvoicesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoicesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoicesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoicesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
