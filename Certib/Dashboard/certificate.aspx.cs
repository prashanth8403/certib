using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
using Certib.Modules;
using Newtonsoft.Json;

namespace Certib.Dashboard
{
    public partial class Certificate1 : System.Web.UI.Page
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
            /*Certificate Wizard*/

            if (Session["CertificateWizard"] == "1")
            {
                SucessPanel.Visible = false;
                ConfirmationPanel.Visible = true;
                DetailsPanel.Visible = false;
                PrevButton.Visible = true;
            }
            else if (Session["CertificateWizard"] == "2")
            {
                SucessPanel.Visible = true;
            }
            else
            {
                SucessPanel.Visible = false;
                ConfirmationPanel.Visible = false;
                DetailsPanel.Visible = true;
                PrevButton.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["CertificateWizard"] == null)
            {
                ConfirmationPanel.Visible = true;
                DetailsPanel.Visible = false;
                PrevButton.Visible = true;
                Session["CertificateWizard"] = "1";
            }
            else if(Session["CertificateWizard"] == "1")
            {
                Session["CertificateWizard"] = "2";
            }

            if (Session["CertificateWizard"] == "2")
            {
                try
                {
                    MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["CertibConnect"].ConnectionString);
                    string index_query = "SELECT COUNT(*) FROM CERTIFICATE;";
                    connect.Open();
                    MySqlCommand Process0 = new MySqlCommand(index_query, connect);
                    int certificate_id = Convert.ToInt32(Process0.ExecuteScalar()) + 1;
                    AcademicCertificate certificate = new AcademicCertificate(certificate_id, Convert.ToInt32(Marks.Text),
                    Convert.ToInt32(MaxMarks.Text), FullName.Text, Email.Text, Usn.Text, Remarks.Text, StartYear.Text + "-" + EndYear.Text,department_selection.SelectedValue);
                    string stringjson = JsonConvert.SerializeObject(certificate);
                    string insert_query = "INSERT INTO CERTIFICATE (USN,NAME,EMAIL,DESCRIPTION,STATUS,DATA,AUTHORITY,TYPE) VALUES " +
                        "('" + Usn.Text + "'," +
                        "'" + FullName.Text + "'," +
                        "'" + Email.Text + "'," +
                        "'" + Description.Text + "'," +
                        "0," +
                        "'" + stringjson + "'," +
                        "'0'," +
                        "'"+ AlgorithmType.SelectedValue + "');";
                    MySqlCommand Process1 = new MySqlCommand(insert_query, connect);
                    Process1.ExecuteNonQuery();
                    connect.Close();
                    SucessPanel.Visible = true;
                    Session["CertificateWizard"] = "1";
                }
                catch (Exception error)
                {
                    SucessPanel.Visible = true;
                    SuccessMessage.Text = error.Message;
                }
            }

            /*int certificate_id = 0;

             * int CertificateNo, int Marks1, int Mark2, string FullName, string Email, 
             * string Usn, string Remarks, string AcademicYear
            AcademicCertificate certificate = new AcademicCertificate(certificate_id, Convert.ToInt32(Marks.Text),
            Convert.ToInt32(MaxMarks.Text), FullName.Text, Email.Text, Usn.Text, Remarks.Text, StartYear.Text + "-" + EndYear.Text);
            string stringjson = JsonConvert.SerializeObject(certificate);*/
        }

        protected void PrevButton_Click(object sender, EventArgs e)
        {
            ConfirmationPanel.Visible = false;
            DetailsPanel.Visible = true;
            PrevButton.Visible = false;
            Session["CertificateWizard"] = null;
        }
    }
}