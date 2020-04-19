using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Silicon;

namespace Forminput
{
    public partial class inputform : System.Web.UI.Page
    {
        public static MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=forminp; UID=root;PASSWORD=**********;");
        string _id, _name, _phone, _address, _pass1, _password;
        protected void Page_Load(object sender, EventArgs e)
        {
                 
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            _id = TextBox1.Text;
            _name = TextBox2.Text;
            _phone = TextBox3.Text;
            _address = TextBox4.Text;
            _password = TextBox5.Text;
            _pass1 = SILICON64.GenerateHash(_password);
            string Query = "INSERT INTO user_details (ID,NAME,PHONE,ADDRESS,PASSWORD) VALUES " +
            "('" + _id + "','" + _name + "','" + _phone + "','" + _address + "','" + _pass1 + "');";
            MySqlCommand process0 = new MySqlCommand(Query, connect);
            process0.ExecuteNonQuery();
            connect.Close();
            
        }
    }
}