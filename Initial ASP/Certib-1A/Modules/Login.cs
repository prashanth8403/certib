/* 
 * -------------------------------------------------------------------------------
 * |    LOGIN MODULE                                                             | 
 * -------------------------------------------------------------------------------
 * 
 *  Copyright(c) 2020 PRASHANTH KUMAR, SUSHMA S, SANDRA MARIA PAUL
 *
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in all
 *  copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE  IS PROVIDED "AS IS", WITHOUT  WARRANTY OF  ANY KIND, EXPRESS OR
 *  IMPLIED,  INCLUDING  BUT  NOT  LIMITED T O THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS  FOR A  PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS  OR  COPYRIGHT  HOLDERS  BE  LIABLE  FOR  ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *  SOFTWARE.
 *  
 *  Add description here......
 *  ------------------------------------------------------------------------------
 * |
 * |
 * |
 *  ------------------------------------------------------------------------------
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Certib_1A.Modules
{
    public class Login
    {

    }
    public partial class inputform : System.Web.UI.Page
    {
        public static MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=forminp; UID=root;PASSWORD=****************;");
        string _id, _pass1, _password, actual_id = "", actual_pass = "", username = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            _id = TextBox1.Text;
            _password = TextBox5.Text;
            _pass1 = SILICON64.GenerateHash(_password);
            MySqlDataReader dr;
            string Query = "SELECT * FROM user_details;";
            MySqlCommand process0 = new MySqlCommand(Query, connect);
            dr = process0.ExecuteReader();
            while (dr.Read())
            {
                actual_id += dr.GetValue(0);
                actual_pass += dr.GetValue(1);
                username += dr.GetValue(2);
            }

            if (_id == actual_id && _pass1 == actual_pass)
            {
                Session["id"] = actual_id;
                Random rand = new Random();
                int num = rand.Next();
                Session["id"] = num;
                Response.Redirect("/Dashboard.aspx?Security=" + SILICON64.GenerateHash(num.ToString()));

            }
            else
            {
                Label1.Text = "Login failed!";
            }
            connect.Close();

        }
    }
}