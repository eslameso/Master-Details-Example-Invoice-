﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceTest.Controllers
{
    public class InvoicesController : Controller
    {
        // GET: InvoicesController
        public ActionResult Index()
        {
            return View();
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
            
            return PartialView("BodyRows");
        }

        // POST: InvoicesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
