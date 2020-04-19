using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Silicon;
namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=certibdemo; UID=root;PASSWORD=;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connect.Open();
                
                string Query = "INSERT INTO user_details (ID,NAME,PHONE,ADDRESS,PASSWORD) VALUES " +
                    "('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + SILICON64.GenerateHash(TextBox5.Text) + "');";
                MySqlCommand process0 = new MySqlCommand(Query, connect);
                process0.ExecuteNonQuery();

            connect.Close();
            string script = "window.onload = function() { window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        }
    }
}