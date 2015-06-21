namespace ShoppingSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;
    using System.Linq;

    using AutoMapper.QueryableExtensions;

    using ShoppingSystem.Web.Areas.Admin.Models.Shop;
    using ShoppingSystem.Models;

    public class CategoriesController : AdminBaseController
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var categoryViewModel = this.DbContext.Categories
                                .Select(c => c)
                                .Project()
                                .To<CategoryViewModel>()
                                .ToList();

            return View(categoryViewModel);
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST: Admin/Category/Create
        public ActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newCategory = AutoMapper.Mapper.Map<Category>(model);

                this.DbContext.Categories.Add(newCategory);
                this.DbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}