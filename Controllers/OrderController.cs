using MastersDetailsInMvc.DAL;
using MastersDetailsInMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MastersDetailsInMvc.Controllers
{
    public class OrderController : Controller
    {
        public OrderDetailsContext db= new OrderDetailsContext();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getProductCategories()
        {
            List<Category> categories = new List<Category>();
            categories = db.Categories.OrderBy(c => c.CatogoryName).ToList();
            return new JsonResult { Data = categories, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult getProducts(int categoryId)
        {
            List<Product> products = new List<Product>();
            products=db.Products.Where(p=>p.CategoryId.Equals(categoryId)).OrderBy(po=>po.ProductName).ToList();
            return new JsonResult { Data = products, JsonRequestBehavior= JsonRequestBehavior.AllowGet };
        }
    }
}