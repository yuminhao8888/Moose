using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIPProgramAssessment.ViewModels;

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
            CheckoutViewModel model = new CheckoutViewModel();

            model.CustomerId = customerId;
            model.Subtotal = subtotal;

            return View(model);
        }

        
    }
}