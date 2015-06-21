namespace ShoppingSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    public class HomeController : AdminBaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}