using MVCAndOOP.Models;
using MVCAndOOP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAndOOP.Controllers
{
    public class StoreController : Controller
    {
        StockRepository rep = new StockRepository();
        // GET: Store
        public ActionResult Index()
        {

            IEnumerable<Product> obj = rep.SeletctALLPS();
            return View(obj);
        }



        public ActionResult CartList()
        {
            IEnumerable<Product> obj = rep.ALLProductsAINCart();
            return View(obj);
        }

        [HttpPost]
        public ActionResult AddtoCart(Product collection)
        {
            try
            {
                rep.Addtocart(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
