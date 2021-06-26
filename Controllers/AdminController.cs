using MVCAndOOP.Models;
using MVCAndOOP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAndOOP.Controllers
{
    public class AdminController : Controller
    {
        StockRepository rep = new StockRepository();
        // GET: Admin
        public ActionResult Index()
        {
            IEnumerable<Product> obj = rep.SeletctALLPS();
            return View(obj);
        }

        // GET: Admin/Details/5
        public ActionResult Details(Guid id)
        {
            Product obj = rep.SelectById(id);
            return View(obj);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Product collection)
        {
            try
            {
                collection.Quantity = 0;
                rep.InsertProduct(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(Guid id)
        {
            Product obj = rep.SelectById(id);
            return View(obj);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Product collection)
        {
            try
            {
                rep.UpdateProduct(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(Guid id)
        {
            Product obj = rep.SelectById(id);
            return View(obj);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                rep.DeleteProduct(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
