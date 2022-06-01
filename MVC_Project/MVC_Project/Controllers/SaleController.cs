using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class SaleController : Controller
    {
        projectmvcEntities db = new projectmvcEntities();
        // GET: /Sale/


        public ActionResult CreateCustomer()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult CreateCustomer(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
            return RedirectToAction("Sale_Stock_List");
        }

        //---------------costumer List


        public ActionResult CustomerList()
        {
          var data = db.Customers.ToList();
            return View(data);
        }

        public ActionResult Sale_Stock_List()
        {
           var data= db.Stocks.ToList();
            return View(data);
        }


        public ActionResult Select(int id)
        {
           var row = db.Stocks.Where(model => model.Product_id == id).FirstOrDefault();
            return View(row);
        }


        [HttpPost]
        public ActionResult Select( int id,Stock s)
        {

            var row = db.Stocks.Where(a => a.Product_id == id).FirstOrDefault();
            var row1 = db.PurchaseTbls.Where(a => a.Product_id == id).FirstOrDefault();

            row.Product_Name = s.Product_Name;
            row.Product_Quantity = row.Product_Quantity - s.Product_Quantity;
            row.Product_Price = s.Product_Price;
            row.Date = s.Date;

            var data = new Sale()
            {
                Product_id=s.Product_id,
                Product_Name=s.Product_Name,
                Product_Quantity=s.Product_Quantity,
                Product_Price=s.Product_Price,
                Date=s.Date
            };
            db.Sales.Add(data);
            db.SaveChanges();
            return RedirectToAction("Sale_Stock_List");
          
        }

        public ActionResult SaleList()
        {
            var ata=db.Sales.ToList();
            return View(ata);
        }
	}
}