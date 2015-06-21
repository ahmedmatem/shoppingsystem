namespace ShoppingSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    using ShoppingSystem.Common;
    using ShoppingSystem.Web.Controllers;

    [Authorize(Roles=GlobalConstants.RoleAdmin)]
    public class AdminBaseController : BaseController
    {
    }
}