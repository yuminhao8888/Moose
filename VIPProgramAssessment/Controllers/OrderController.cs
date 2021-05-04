using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIPProgramAssessment.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Checkout(int customerId, decimal? subtotal)
        {
            int rt = 5;
            return View();
        }

        
    }
}