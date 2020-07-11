using System;
using Silicon;

namespace Certib
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            LoginLabel.Visible = false;
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Modules.Login LOGIN = new Modules.Login();
            LoginLabel.Visible = true;
            if (LOGIN.Validate(_userid.Text, SILICON64.GenerateHash(_password.Text)))
            {
                Session["ID"] = _userid.Text;
                Random RandomSeed = new Random();
                int AccessControl = RandomSeed.Next();               
                Session["Access"] = Convert.ToString(AccessControl);
                Response.Redirect("Dashboard/Mypage?Security=" + SILICON64.GenerateHash(AccessControl.ToString())+ "#Home");
            }
            else
            {
                LoginLabel.Text = "Invalid Username or Password";
            }
        }
    }
}