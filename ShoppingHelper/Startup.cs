using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingHelper.Startup))]
namespace ShoppingHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
