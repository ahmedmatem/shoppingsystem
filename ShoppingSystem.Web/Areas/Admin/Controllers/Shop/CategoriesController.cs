namespace ShoppingSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;
    using System.Linq;
    using System.Data.Entity;

    using AutoMapper.QueryableExtensions;

    using ShoppingSystem.Web.Areas.Admin.Models.Shop;
    using ShoppingSystem.Models;

    public class CategoriesController : AdminBaseController
    {
        // GET: Admin/Shop/Categories
        public ActionResult Index()
        {
            var categoryViewModel = this.DbContext.Categories
                                .Select(c => c)
                                .Project()
                                .To<CategoryViewModel>()
                                .ToList();

            return View(categoryViewModel);
        }

        // GET: Admin/Shop/Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST: Admin/Shop/Categories/Create
        public ActionResult Create(CategoryViewModel model)
        {
            var existCategoryName = this.DbContext.Categories
                                        .Any(c => c.Name.Equals(model.Name));

            if (existCategoryName)
            {
                ModelState.AddModelError("Name", "Category name \"" + model.Name + "\" already exist!");
            }

            if (ModelState.IsValid & !existCategoryName)
            {
                var newCategory = AutoMapper.Mapper.Map<Category>(model);

                this.DbContext.Categories.Add(newCategory);
                this.DbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Admin/Shop/Categories/Update
        public ActionResult Update(string id)
        {
            var matchedCategory = this.DbContext.Categories
                                    .Where(c => c.Id.Equals(id))
                                    .Project()
                                    .To<CategoryViewModel>()
                                    .FirstOrDefault();

            return View(matchedCategory);
        }

        // POST: Admin/Shop/Categories/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(CategoryViewModel model)
        {
            var matchedCategory = this.DbContext.Categories
                                    .Find(model.Id);

            if(ModelState.IsValid)
            {
                this.DbContext.Entry(matchedCategory).CurrentValues.SetValues(model);
                this.DbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(matchedCategory);
        }

        // GET: Admin/Shop/Categories/Delete/id
        public ActionResult Delete(string id)
        {
            var matchedCategory = this.DbContext.Categories.Find(id);

            matchedCategory.IsActive = false;
            this.DbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Admin/Shop/Categories/Restore/id
        public ActionResult Restore(string id)
        {
            var matchedCategory = this.DbContext.Categories.Find(id);

            matchedCategory.IsActive = true;
            this.DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}