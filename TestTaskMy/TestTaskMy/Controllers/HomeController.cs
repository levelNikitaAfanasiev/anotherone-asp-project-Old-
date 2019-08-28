using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TestTaskMy.Models;
using PagedList.Mvc;
using PagedList;

namespace TestTaskMy.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();
        public ActionResult ProductList(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            var products = db.Products.Include(c => c.Category_type);
            return View(products.ToList().ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            SelectList category_type = new SelectList(db.Category_types, "Id", "Name");
            ViewBag.Types = category_type;
            return PartialView("Create");
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (product == null)
                return HttpNotFound();
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

    }
}
