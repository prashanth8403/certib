using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Certib_1A.Dashboard
{
    public partial class Mypage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Access"] != null && Session["ID"] != null)
                {
                    
                    CardText1.Text = Session["ID"].ToString();
                }
                else
                    Response.Redirect("/login.aspx");

            }
        }
    }
}