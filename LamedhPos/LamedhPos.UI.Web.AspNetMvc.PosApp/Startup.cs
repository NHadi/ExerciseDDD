using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamedhPos.UI.Web.AspNetMvc.PosApp.Startup))]
namespace LamedhPos.UI.Web.AspNetMvc.PosApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
