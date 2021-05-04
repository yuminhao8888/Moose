using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIPProgramAssessment.Models;
using VIPProgramAssessment.ViewModels;

namespace VIPProgramAssessment.Controllers
{
    public class CartController : Controller
    {

        public MooseEntities5 dbc { get; set; }

        List<CartItem> items = new List<CartItem>();
        List<OrderDetail> orderItem = new List<OrderDetail>();

        public CartController()
        {
            dbc = new MooseEntities5();
        }
        // GET: Cart
        public ActionResult Index(int id)
        {
            // get cart items for customer id
            var cartItems = dbc.Cart.Where(x => x.CustomerId == id).ToList();
            ViewBag.CustomerId = id;

            foreach(var cartItem in cartItems)
            {
                CartItem ci = new CartItem();
                

                ci.CustomerId = cartItem.CustomerId;
                ci.ProductId = cartItem.ProductId;
                ci.ProductSizeId = cartItem.ProductSizeId;
                ci.ProductColorId = cartItem.ProductColorId;

                ci.ProductName = dbc.Product.Where(x => x.ID == cartItem.ProductId).FirstOrDefault().Name;
                ci.ProductPrice = dbc.Product.Where(x => x.ID == cartItem.ProductId).FirstOrDefault().Price;
                ci.ProductImage = dbc.Product.Where(x => x.ID == cartItem.ProductId).FirstOrDefault().Image;
                

                ci.Size = dbc.ProductSize.Where(x => x.Id == cartItem.ProductSizeId).FirstOrDefault().Size;
                ci.Color = dbc.ProductColor.Where(x => x.Id == cartItem.ProductColorId).FirstOrDefault().Color;

                items.Add(ci);

                OrderDetail od = new OrderDetail();
                od.ProductId = cartItem.ProductId;
                od.ProductSizeId = cartItem.ProductSizeId;
                od.ProductColorId = cartItem.ProductColorId;

                orderItem.Add(od);

            }

            Session["OrderDetails"] = orderItem;
            return View(items);
        }
    }
}