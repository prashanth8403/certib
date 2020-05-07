using System;
using Silicon;

namespace Certib_1A
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Modules.Login LOGIN = new Modules.Login();
            if (LOGIN.Validate(_userid.Text, SILICON64.GenerateHash(_password.Text)))
            {
                Random rand = new Random();
                int num = rand.Next();
                Session["Access"] = num;
                Response.Redirect("Dashboard/Mypage?Security=" + SILICON64.GenerateHash(num.ToString())+ "#Home");
            }
            else
            {
                LoginLabel.Text = "Invalid Username or Password!";
            }
        }
    }
}