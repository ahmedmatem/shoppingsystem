namespace ShoppingSystem.Web.Areas.Admin.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Data.Entity;

    using AutoMapper.QueryableExtensions;

    using ShoppingSystem.Web.Areas.Admin.Models.Shop;    

    public class ProductsController : AdminBaseController
    {
        // GET: Admin/Shop/Products
        public ActionResult Index()
        {
            var productViewModel = this.DbContext.Products
                                    .Select(p => p)
                                    .Project()
                                    .To<ProductViewModel>()
                                    .ToList();

            return View(productViewModel);
        }

        // GET: Admin/Shop/Products/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}