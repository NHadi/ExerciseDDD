using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MangoSale.MVCWebApplication.Startup))]
namespace MangoSale.MVCWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
