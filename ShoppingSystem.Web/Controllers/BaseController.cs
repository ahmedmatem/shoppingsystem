namespace ShoppingSystem.Web.Controllers
{
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity.EntityFramework;

    using ShoppingSystem.Data;

    public class BaseController : Controller
    {
        protected ShoppingSystemDataContext DbContext;

        public BaseController()
        {
            this.DbContext = new ShoppingSystemDataContext();
        }
    }
}