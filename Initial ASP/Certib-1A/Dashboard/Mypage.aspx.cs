using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Silicon;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Certib_1A.Dashboard
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
                            CardText1.Text = Session["ID"].ToString();
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