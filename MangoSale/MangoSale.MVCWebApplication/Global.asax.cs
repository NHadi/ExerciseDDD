using MangoSale.Common.Infrastructure.Data.Context;
using MangoSale.Common.Infrastructure.Data.Context.Interface;
using MangoSale.Data.Context;
using MangoSale.MVCWebApplication.App_Start;
using MangoSale.MVCWebApplication.AutoMapper;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MangoSale.MVCWebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            

            AutoMapperConfig.RegisterMappings();
        }

        protected void Application_EndRequest()
        {
            var contextManager = ServiceLocator.Current.GetInstance<IContextManager<MangoSaleContext>>() as ContextManager<MangoSaleContext>;
            if (contextManager != null)
            {
                contextManager.GetContext().Dispose();
            }            
        }
    }
}
