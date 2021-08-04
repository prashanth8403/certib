using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Certib.Dashboard
{
    public partial class Mypage1 : System.Web.UI.Page
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
                        _UserName.Text = Session["ID"].ToString();
                    }
                    else
                        Response.Redirect("~/Login");
                }
                catch (Exception Error)
                {
                    Response.Redirect("~/Login?fault=" + Error.Message);
                }
            }
            CardLoad();
            GridLoad();
        }

        protected void CardLoad()
        {
            connect.Open();
            string Query1 = "select count(*) from certificate where status=0";
            MySqlCommand SqlProcess1 = new MySqlCommand(Query1, connect);

            string Query2 = "select count(*) from certificate where status=1";
            MySqlCommand SqlProcess2 = new MySqlCommand(Query2, connect);

            string Query3 = "select count(*) from certificate";
            MySqlCommand SqlProcess3 = new MySqlCommand(Query3, connect);

            string Query4 = "select count(*) from certificate where status=1";
            MySqlCommand SqlProcess4 = new MySqlCommand(Query4, connect);

            _PendingLabel.Text = Convert.ToString(SqlProcess1.ExecuteScalar());
            _ApprovedLabel.Text = Convert.ToString(SqlProcess2.ExecuteScalar());
            _CertificatesIssued.Text = Convert.ToString(SqlProcess3.ExecuteScalar());
            _CertificatesViewed.Text = "4";
            connect.Close();
        }

        protected void GridLoad()
        {
            connect.Open();
            string Query2 = "select * from certificate where status=0";
            MySqlCommand SqlProcess1 = new MySqlCommand(Query2, connect);
            GridFinal.DataSource = SqlProcess1.ExecuteReader();
            GridFinal.DataBind();
            connect.Close();
        }
    }
}