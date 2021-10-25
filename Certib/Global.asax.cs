using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
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
            routes.MapPageRoute("home", "home", "~/Default.aspx");
            routes.MapPageRoute("login", "login", "~/login.aspx");
            routes.MapPageRoute("view", "view", "~/view.aspx");
            routes.MapPageRoute("verification", "verification", "~/verification.aspx");
            routes.MapPageRoute("dashboard/approval", "dashboard/approval", "~/dashboard/approval.aspx");
            routes.MapPageRoute("dashboard/achivement", "dashboard/achivement", "~/dashboard/achivement.aspx");
            routes.MapPageRoute("dashboard/participation", "dashboard/participation", "~/dashboard/participation.aspx");
            routes.MapPageRoute("dashboard/mypage", "dashboard/Mypage", "~/dashboard/mypage.aspx");
            routes.MapPageRoute("dashboard/certificate", "dashboard/certificate", "~/dashboard/certificate.aspx");
            routes.MapPageRoute("dashboard/settings", "dashboard/settings", "~/dashboard/settings.aspx");
            routes.MapPageRoute("dashboard/profile", "dashboard/profile", "~/dashboard/profile.aspx");

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