using System;
using System.Web.Routing;

namespace Certib
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Home", "Home", "~/Default.aspx");
            routes.MapPageRoute("Login", "Login", "~/Login.aspx");
            routes.MapPageRoute("Dashboard/Mypage", "Dashboard/Mypage", "~/Dashboard/Mypage.aspx");
            routes.MapPageRoute("Dashboard/Temp", "Dashboard/Temp", "~/Dashboard/temp.aspx");
            routes.MapPageRoute("Dashboard/Settings", "Dashboard/Settings", "~/Dashboard/Settings.aspx");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}