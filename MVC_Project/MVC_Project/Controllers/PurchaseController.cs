using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;
using System.Data.Entity;

namespace MVC_Project.Controllers
{
    public class PurchaseController : Controller
    {
        projectmvcEntities db = new projectmvcEntities();
        // GET: /Purchase/

        public ActionResult PurchaseInventory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult PurchaseInventory(PurchaseTbl s)
        {
            db.PurchaseTbls.Add(s);
            Stock sk = new Stock()
            {
                Product_Name = s.Product_Name,
                Product_Quantity=s.Product_Quantity,
                Product_Price=s.Product_Price,
                Date=s.Date
                
            };


            db.Stocks.Add(sk);
            db.SaveChanges();

            return View();
        }

        //-----purchase List

        public ActionResult PurchaseList()
        {
            var data = db.PurchaseTbls.ToList();
            return View(data);
        }


        //delete purchase data

        public ActionResult Delete(int id)
        {
            var row = db.PurchaseTbls.Where(model => model.Product_id == id).FirstOrDefault();
            db.Entry(row).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("PurchaseList");
        }
	}
}