using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;
using System.Data.Entity;

namespace MVC_Project.Controllers
{
    public class StockController : Controller
    {
        projectmvcEntities db = new projectmvcEntities();
        // GET: /Stock/


        public ActionResult StockList()
        {
            var data = db.Stocks.ToList();
            return View(data);
        }


        //delete stock record
        public ActionResult Delete(int id)
        {
            var row = db.Stocks.Where(model => model.Product_id == id).FirstOrDefault();
            db.Entry(row).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("StockList");
        }
	}
}