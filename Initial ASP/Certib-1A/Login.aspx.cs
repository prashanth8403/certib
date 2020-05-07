using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Silicon;
using MySql.Data.MySqlClient;


namespace Certib_1A
{
    public partial class Login : System.Web.UI.Page
    {

        
        string _id, _pass1, _pw;
        protected void Page_Load(object sender, EventArgs e)
        {
            // CLEAR ALL THE SESSIONS
            Session.Clear();
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
             
            _id = _userid.Text; 
            _pw = _password.Text; 
            _pass1 = SILICON64.GenerateHash(_pw);
            Login lg = new Login();
            if(lg.Validate(_id,_pass1))
            {
                Session["id"] = _id;
                Random rand = new Random();
                int num = rand.Next();
                Session["id"] = num;
                Response.Redirect("Dashboard/Mypage#Home?Security=" + SILICON64.GenerateHash(num.ToString()));
            }
            else
            {
                _loginfail.Text = "Invalid Username or Password!";
            }
        
        }

        private bool Validate(string USERNAME, string PASSWORD)
        {
            // connect : Local Instance of Connection String
            //MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["CertibConnect"].ConnectionString);
            MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=certib; UID=root;PASSWORD=*******;");
            string Query = "SELECT COUNT(*) FROM usercredentials where USERID='" + USERNAME + "' AND PASSWORD='" + PASSWORD + "'";
            connect.Open();
            MySqlCommand LoginProcess = new MySqlCommand(Query, connect);
            bool var = Convert.ToBoolean(LoginProcess.ExecuteScalar());
            connect.Close();
            return var;
        }
    }
}