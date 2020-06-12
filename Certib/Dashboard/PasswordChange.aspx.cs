using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Configuration;
using Silicon;

namespace Certib.Dashboard
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int GetPasswordStrength(string password)
        {
            int Marks = 0;

            if (password.Length < 8)
            {
                return 1;
            }
            else
            {
                Marks = 1;
            }
            if (Regex.IsMatch(password, "[a-z]"))
            {
                Marks++;
            }
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                Marks++;
            }
            if (Regex.IsMatch(password, "[0-9]"))
            {
                Marks++;
            }
            if (Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
            {
                Marks++;
            }
            return Marks;

        }



        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["CertibConnect"].ConnectionString);
            connect.Open();
            string _email = "123456";
            string _oldpassword = OldPassword.Text;
            string _newpassword = NewPassword.Text;
            string _newagain = NewAgain.Text;
            string Query = "SELECT COUNT(*) FROM usercredentials where EMAIL='" + _email + "' AND PASSWORD='" + SILICON64.GenerateHash(_oldpassword) + "'";
            MySqlCommand process0 = new MySqlCommand(Query, connect);
            bool Flag = Convert.ToBoolean(process0.ExecuteScalar());
            if (Flag)
            {
                if (_newpassword == _newagain)
                {
                    Query = "UPDATE usercredentials SET PASSWORD='" + SILICON64.GenerateHash(_newpassword) + "' WHERE EMAIL='" + _email + "'";
                    process0 = new MySqlCommand(Query, connect);
                    process0.ExecuteNonQuery();
                    ChangeLabel.Text = "Password Successfully Updated!";
                    ChangeLabel.ForeColor = System.Drawing.Color.Green;
                    int strength = GetPasswordStrength(_newpassword);
                    switch (strength)
                    {
                        case 1:
                            StrengthValue.Text = "Very Weak(0 / 100)";
                            StrengthValue.ForeColor = System.Drawing.Color.Red;
                            break;
                        case 2:
                            StrengthValue.Text = "Weak(25 / 100)";
                            StrengthValue.ForeColor = System.Drawing.Color.Orange;
                            break;
                        case 3:
                            StrengthValue.Text = "Moderate(50 / 100)";
                            StrengthValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
                            break;
                        case 4:
                            StrengthValue.Text = "Strong(75 / 100)";
                            StrengthValue.ForeColor = System.Drawing.Color.Green;
                            break;
                        case 5:
                            StrengthValue.Text = "Very Strong(100 / 100)";
                            StrengthValue.ForeColor = System.Drawing.Color.DarkGreen;
                            break;
                    }
                    OldPassword.Text = "";
                    NewPassword.Text = "";
                    NewAgain.Text = "";
                }
                else
                {
                    ChangeLabel.Text = "New Password Re-entered Incorrectly!";
                    ChangeLabel.ForeColor = System.Drawing.Color.Red;
                    OldPassword.Text = "";
                    NewPassword.Text = "";
                    NewAgain.Text = "";
                }
            }
            else
            {
                ChangeLabel.Text = "Invalid Current Password!";
                ChangeLabel.ForeColor = System.Drawing.Color.Red;
                OldPassword.Text = "";
                NewPassword.Text = "";
                NewAgain.Text = "";
            }

            connect.Close();
        }
    }
}