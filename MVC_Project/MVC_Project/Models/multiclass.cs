using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class multiclass
    {
        public List<PurchaseTbl> per { get; set; }
        public List<Stock> st { get; set; }
        public List<Customer> cust { get; set; }
    }
}