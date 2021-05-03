using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIPProgramAssessment.Models;
using VIPProgramAssessment.ViewModels;

namespace VIPProgramAssessment.Controllers
{
    public class HomeController : Controller
    {
        public MooseEntities5 dbc { get; set; }

        public HomeController()
        {
            dbc = new MooseEntities5();
        }

        public ActionResult Index()
        {
            var products = dbc.Product.ToList();

            return View(products);
        }

        [HttpGet]
        public ActionResult ProductDetails(int id)
        {
            ProductDetailsViewModel model = new ProductDetailsViewModel();
            model.ProductId = id;
            model.CustomerId = (int)(Session["CustomerId"]);
            model.SizeList = dbc.ProductSize.ToList();
            model.ColorList = dbc.ProductColor.ToList();

            var product = dbc.Product.Where(x => x.ID == id).FirstOrDefault();

            ViewBag.ProductName = product.Name;
            ViewBag.ProductPrice = product.Price;
            ViewBag.ImageName = product.Image;


            return View(model);
        }

        [HttpPost]
        public ActionResult ProductDetails(ProductDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Content("good"); 
            }

            return Content("good");
        }
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return  View();
        //}
    }
}