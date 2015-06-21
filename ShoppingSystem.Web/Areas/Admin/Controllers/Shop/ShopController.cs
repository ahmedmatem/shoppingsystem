namespace ShoppingSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    public class ShopController : AdminBaseController
    {
        // GET: Admin/Shop
        public ActionResult Index()
        {
            return View();
        }
    }
}