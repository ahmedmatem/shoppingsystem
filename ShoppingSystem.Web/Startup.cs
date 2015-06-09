using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingSystem.Web.Startup))]
namespace ShoppingSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
