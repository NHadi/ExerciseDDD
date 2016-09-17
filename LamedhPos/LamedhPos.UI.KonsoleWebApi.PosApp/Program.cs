using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LamedhPos.UI.KonsoleWebApi.PosApp
{
    class Program
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            appBuilder.UseWebApi(config);
        }

        static void Main(string[] args)
        {
            string url = "http://localhost:9000";

            using (WebApp.Start<Program>(url))
            {
                Console.WriteLine("Server started at " + url);
                Console.ReadLine();
            }
            Console.WriteLine("Server has stopped");
        }
    }
}
