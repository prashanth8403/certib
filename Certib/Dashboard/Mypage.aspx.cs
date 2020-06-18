using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Certib.Dashboard
{
    public partial class Mypage : System.Web.UI.Page
    {
        MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["CertibConnect"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["Access"] != null && Session["ID"] != null)
                    {
                        //string AccessID = Request.QueryString["Security"];
                        //if (AccessID == SILICON64.GenerateHash((string)Session["Access"]))
                        //{
                        _UserName.Text = Session["ID"].ToString();
                        //}
                        //else
                        //{
                        //    Response.Redirect("~/Login");
                        //}
                    }
                    else
                        Response.Redirect("~/Login");
                }
                catch (Exception Error)
                {
                    Response.Redirect("~/Login?fault=" + Error.Message);
                }
            }
        }
    }
}