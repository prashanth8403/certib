using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using Certib.Modules;
using Newtonsoft.Json;

namespace Certib.dashboard
{
    public partial class achivementcertificate : System.Web.UI.Page
    {
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
            else if (Session["CertificateWizard"] == "1")
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
                    ApprecitationCertificate certificate = new ApprecitationCertificate(certificate_id, FullName.Text, Email.Text, Usn.Text,Achivement.Text ,Remarks.Text,"2017", department_selection.SelectedValue);
                    string stringjson = JsonConvert.SerializeObject(certificate);
                    string insert_query = "INSERT INTO CERTIFICATE (USN,NAME,EMAIL,DESCRIPTION,STATUS,DATA,AUTHORITY,TYPE) VALUES " +
                        "('" + Usn.Text + "'," +
                        "'" + FullName.Text + "'," +
                        "'" + Email.Text + "'," +
                        "'" + Description.Text + "'," +
                        "0," +
                        "'" + stringjson + "'," +
                        "'0'," +
                        "1);";
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