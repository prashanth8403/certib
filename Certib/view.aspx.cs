using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Diagnostics;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Certib.Modules;
using System.Configuration;
using Newtonsoft.Json;

namespace Certib
{
    public partial class view : System.Web.UI.Page
    {
        MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["CertibConnect"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["key"] == null)
                Response.Redirect("/verification");

            ViewPanel.Visible = false;
            ErrorPanel.Visible = false;

            try
            {
                string image_text = decode_image((string)Session["key"]);
                char[] TRIM = { '\r', '\n' };
                image_text = image_text.Trim(TRIM);
                string certificate_id = image_text.Split('#')[0];
                string certificate_hash = image_text.Split('#')[1];

                connect.Open();

                string Query2 = "select * from certificate where id=" + certificate_id.Split('-')[1];
                MySqlCommand SqlProcess1 = new MySqlCommand(Query2, connect);
                MySqlDataReader reader = SqlProcess1.ExecuteReader();
                reader.Read();
                string record = reader["data"].ToString();
                connect.Close();
                reader.Close();

                dynamic CertificateInformation = JsonConvert.DeserializeObject(record);
                string saved_hash = CertificateInformation.certificatehash;
                if (certificate_hash != saved_hash)
                {
                    ErrorPanel.Visible = true;
                }
                else
                {
                    ViewPanel.Visible = true;
                    certificateno.Text = CertificateInformation.certificate_id;
                    fullname.Text = CertificateInformation.full_name;
                    marks.Text = CertificateInformation.marks_obtained + "/" + CertificateInformation.max_marks + " (" + CertificateInformation.percentage + "%)";
                    usn.Text = "(" + CertificateInformation.university_seat_number + ")";
                    department.Text = CertificateInformation.department;
                    certificatedate.Text = CertificateInformation.certificate_date;
                    year.Text = CertificateInformation.academic_year;
                }
            }
            catch(Exception ex)
            {
                ErrorPanel.Visible = true;
            }
        }

        protected void ApprovalButton_Click(object sender, EventArgs e)
        {
            Session["key"] = null;
            Response.Redirect("/");
        }


        public string decode_image(string filename)
        {
            var PythonEncode = new ProcessStartInfo();
            PythonEncode.FileName = @"C:\Users\prash\AppData\Local\Programs\Python\Python39\python.exe";
            var Encodescript = @"D:\Project\certib\Certib\Images\script.py";
            var argument0 = 2;
            var argument1 = @"D:\Project\certib\Certib\TempImage\" + filename;

            var errors = "";
            var results = "";

            PythonEncode.Arguments = $"\"{Encodescript}\" \"{argument0}\" \"{argument1}\"";
            PythonEncode.UseShellExecute = false;
            PythonEncode.CreateNoWindow = true;
            PythonEncode.RedirectStandardOutput = true;
            PythonEncode.RedirectStandardError = true;

            errors = "";
            results = "";

            using (var process = Process.Start(PythonEncode))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            return results;
        }
    }
}