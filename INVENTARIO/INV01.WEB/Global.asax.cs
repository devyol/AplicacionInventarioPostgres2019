using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using INV01.DO.DATA;

namespace INV01.WEB
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public static string UserName
        {
            get
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    return HttpContext.Current.User.Identity.Name.ToUpper();
                }
                return "NO_USER";
            }
        }

        public static string NombreUsuario
        {
            get
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    return ObtenerNombreUsuario();
                }
                return "NO_USER";
            }
        }

        private static string ObtenerNombreUsuario()
        {
            try
            {
                using (var db = new EntitiesINV01())
                {
                    var nombre = db.inv01_usuario
                                .Where(us => us.usuario == HttpContext.Current.User.Identity.Name.ToUpper())
                                .Select(us => us.nombre).SingleOrDefault();
                    return nombre.ToString();
                }
            }
            catch (Exception)
            {
                return "NO_USER";
            }
        }
    }
}