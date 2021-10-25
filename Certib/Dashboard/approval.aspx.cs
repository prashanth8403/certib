using System;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using Newtonsoft.Json;
using Certib.Modules;
using System.Text;
using System.Drawing;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using Silicon;
using Newtonsoft.Json.Linq;

namespace Certib.dashboard
{
    public partial class approval : System.Web.UI.Page
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

            if (Session["CertificateJson"] == null)
            {
                SucessPanel.Visible = false;
                degreecertificate.Visible = false;
                achivementcertificate.Visible = false;
                participationcertificate.Visible = false;
            }
            GridLoad();
        }

        protected void GridLoad()
        {
            connect.Open();
            string Query2 = "select * from certificate where status=0";
            MySqlCommand SqlProcess1 = new MySqlCommand(Query2, connect);
            GridFinal.DataSource = SqlProcess1.ExecuteReader();
            GridFinal.DataBind();
            connect.Close();
        }

        protected void GridWithHeld_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();
            string id = GridFinal.SelectedRow.Cells[0].Text;
            string Query2 = "select * from certificate where id=" + id;
            MySqlCommand SqlProcess1 = new MySqlCommand(Query2, connect);
            MySqlDataReader reader = SqlProcess1.ExecuteReader();
            reader.Read();
            Session["CertificateJson"] = reader["data"].ToString();
            int type = Convert.ToInt32(reader["type"]);
            Session["CertificateType"] = Convert.ToString(type);
            reader.Close();
            connect.Close();
            dynamic CertificateInformation = JsonConvert.DeserializeObject((string)Session["CertificateJson"]);

            if(type == 0)
            {
                certificateno.Text = CertificateInformation.certificate_id;
                fullname.Text = CertificateInformation.full_name;
                marks.Text = CertificateInformation.marks_obtained + "/" + CertificateInformation.max_marks + " (" + CertificateInformation.percentage + "%)";
                usn.Text = "(" + CertificateInformation.university_seat_number + ")";
                department.Text = CertificateInformation.department;
                certificatedate.Text = CertificateInformation.certificate_date;
                year.Text = CertificateInformation.academic_year;
                degreecertificate.Visible = true;
                achivementcertificate.Visible = false;
                participationcertificate.Visible = false;
            }
            else if(type == 1)
            {
                achivementcertificatedate.Text = CertificateInformation.certificate_date;
                achivementcertificateno.Text = CertificateInformation.certificate_id;
                achivementname.Text = CertificateInformation.full_name;
                achivmentusn.Text = "(" + CertificateInformation.university_seat_number + ")";
                achivment.Text = CertificateInformation.achivement;

                degreecertificate.Visible = false;
                achivementcertificate.Visible = true;
                participationcertificate.Visible = false;
            }
            else
            {
                ParticipationCertificateNo.Text = CertificateInformation.certificate_id;
                ParticipationCertificateDate.Text = CertificateInformation.certificate_date;
                participationname.Text = CertificateInformation.full_name;
                participationUSN.Text = "(" + CertificateInformation.university_seat_number + ")";
                participation.Text = CertificateInformation.participation;

                degreecertificate.Visible = false;
                achivementcertificate.Visible = false;
                participationcertificate.Visible = true;

            }
            
        }

        protected void ApprovalButton_Click(object sender, EventArgs e)
        {
            try
            {

                string JsonData = (string)Session["CertificateJson"];
                dynamic Certificate = JsonConvert.DeserializeObject(JsonData);
                string email = Certificate.email;

                Mailer.MailFunction(email, JsonData);
                // send mail -- complete
                string temp = Certificate.certificate_id;
                string id = temp.Split('-')[1];

                if((string)Session["CertificateType"] == "0")
                {
                    string root = HttpContext.Current.Server.MapPath("~/Resource/Templates/template.png");
                    System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(root); // set image     
                    Font font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
                    Color color = Color.FromArgb(255, 0, 0, 0);

                    SolidBrush brush = new SolidBrush(color);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    string certificateNo = Certificate.certificate_id;
                    string fullname = Certificate.full_name;
                    string marks = Certificate.marks_obtained + "/" + Certificate.max_marks + " (" + Certificate.percentage + "%)";
                    string usn = "(" + Certificate.university_seat_number + ")";
                    string department = Certificate.department;
                    string certificatedate = Certificate.certificate_date;
                    string year = Certificate.academic_year;
                    string hash = Certificate.certificatehash;
                    Point NamePoint = new Point(bitmap.Width / 2, bitmap.Height / 2 - 8);
                    Point CertificateDatePoint = new Point(210, 205);
                    Point CertificateNoPoint = new Point(280, 170);
                    Point MarksPoint = new Point(bitmap.Width / 2 - 190, bitmap.Height / 2 + 85);
                    Point DepartmentPoint = new Point(bitmap.Width / 2 + 250, bitmap.Height / 2 + 150);
                    Point YearPoint = new Point(bitmap.Width / 2 + 55, bitmap.Height / 2 + 180);

                    graphics.DrawString(certificatedate, font, brush, CertificateDatePoint, sf);
                    graphics.DrawString(certificateNo, font, brush, CertificateNoPoint, sf);
                    graphics.DrawString(marks, font, brush, MarksPoint, sf);
                    graphics.DrawString(fullname + " " + usn, font, brush, NamePoint, sf);
                    graphics.DrawString(department, font, brush, DepartmentPoint, sf);
                    graphics.DrawString(year, font, brush, YearPoint, sf);
                    graphics.Dispose();

                    MemoryStream m = new MemoryStream();
                    bitmap.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] convertedToBytes = m.ToArray();
                    string imagefile = SILICON64.GenerateHash(certificateNo);
                    string saveto = HttpContext.Current.Server.MapPath("~/Images/" + imagefile + ".png");
                    File.WriteAllBytes(saveto, convertedToBytes);

                    var PythonEncode = new ProcessStartInfo();

                    string[] system_configuration = File.ReadAllLines(HttpContext.Current.Server.MapPath("configuration.txt"));

                    PythonEncode.FileName = @system_configuration[0];
                    var Encodescript = @system_configuration[1];
                    var argument0 = 1;
                    var argument1 = @system_configuration[2] + imagefile + ".png";
                    var argument2 = certificateNo + "#" + hash;

                    PythonEncode.Arguments = $"\"{Encodescript}\" \"{argument0}\" \"{argument1}\" \"{argument2}\"";

                    PythonEncode.UseShellExecute = false;
                    PythonEncode.CreateNoWindow = true;
                    PythonEncode.RedirectStandardOutput = true;
                    PythonEncode.RedirectStandardError = true;

                    var errors = "";
                    var results = "";

                    using (var process = Process.Start(PythonEncode))
                    {
                        errors = process.StandardError.ReadToEnd();
                        results = process.StandardOutput.ReadToEnd();
                    }
                    argument0 = 2;

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
                }
                else if((string)Session["CertificateType"] == "1")
                {
                    string root = HttpContext.Current.Server.MapPath("~/Resource/Templates/template2.png");
                    System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(root); // set image     
                    Font font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
                    Color color = Color.FromArgb(255, 0, 0, 0);

                    SolidBrush brush = new SolidBrush(color);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    string certificateNo = Certificate.certificate_id;
                    string fullname = Certificate.full_name;
                   
                    string usn = "(" + Certificate.university_seat_number + ")";
                    string certificatedate = Certificate.certificate_date;
                    string year = Certificate.academic_year;
                    string hash = Certificate.certificatehash;
                    Point NamePoint = new Point(bitmap.Width / 2, bitmap.Height / 2 - 8);
                    Point CertificateDatePoint = new Point(210, 205);
                    Point CertificateNoPoint = new Point(280, 170);
                   
                    Point DepartmentPoint = new Point(bitmap.Width / 2 + 250, bitmap.Height / 2 + 150);
                    Point YearPoint = new Point(bitmap.Width / 2 + 55, bitmap.Height / 2 + 180);

                    graphics.DrawString(certificatedate, font, brush, CertificateDatePoint, sf);
                    graphics.DrawString(certificateNo, font, brush, CertificateNoPoint, sf);
                    graphics.DrawString(fullname + " " + usn, font, brush, NamePoint, sf);
                    graphics.DrawString(year, font, brush, YearPoint, sf);
                    graphics.Dispose();

                    MemoryStream m = new MemoryStream();
                    bitmap.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] convertedToBytes = m.ToArray();
                    string imagefile = SILICON64.GenerateHash(certificateNo);
                    string saveto = HttpContext.Current.Server.MapPath("~/Images/" + imagefile + ".png");
                    File.WriteAllBytes(saveto, convertedToBytes);

                    var PythonEncode = new ProcessStartInfo();

                    string[] system_configuration = File.ReadAllLines(HttpContext.Current.Server.MapPath("configuration.txt"));

                    PythonEncode.FileName = @system_configuration[0];
                    var Encodescript = @system_configuration[1];
                    var argument0 = 1;
                    var argument1 = @system_configuration[2] + imagefile + ".png";
                    var argument2 = certificateNo + "#" + hash;

                    PythonEncode.Arguments = $"\"{Encodescript}\" \"{argument0}\" \"{argument1}\" \"{argument2}\"";

                    PythonEncode.UseShellExecute = false;
                    PythonEncode.CreateNoWindow = true;
                    PythonEncode.RedirectStandardOutput = true;
                    PythonEncode.RedirectStandardError = true;

                    var errors = "";
                    var results = "";

                    using (var process = Process.Start(PythonEncode))
                    {
                        errors = process.StandardError.ReadToEnd();
                        results = process.StandardOutput.ReadToEnd();
                    }
                    argument0 = 2;

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
                }
                else
                {
                    string root = HttpContext.Current.Server.MapPath("~/Resource/Templates/template3.png");
                    System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(root); // set image     
                    Font font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
                    Color color = Color.FromArgb(255, 0, 0, 0);

                    SolidBrush brush = new SolidBrush(color);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    string certificateNo = Certificate.certificate_id;
                    string fullname = Certificate.full_name;
                    string usn = "(" + Certificate.university_seat_number + ")";
                    string department = Certificate.department;
                    string certificatedate = Certificate.certificate_date;
                    string year = Certificate.academic_year;
                    string hash = Certificate.certificatehash;
                    Point NamePoint = new Point(bitmap.Width / 2, bitmap.Height / 2 - 8);
                    Point CertificateDatePoint = new Point(210, 205);
                    Point CertificateNoPoint = new Point(280, 170);
                    Point DepartmentPoint = new Point(bitmap.Width / 2 + 250, bitmap.Height / 2 + 150);
                    Point YearPoint = new Point(bitmap.Width / 2 + 55, bitmap.Height / 2 + 180);

                    graphics.DrawString(certificatedate, font, brush, CertificateDatePoint, sf);
                    graphics.DrawString(certificateNo, font, brush, CertificateNoPoint, sf);
                    graphics.DrawString(fullname + " " + usn, font, brush, NamePoint, sf);
                    graphics.DrawString(department, font, brush, DepartmentPoint, sf);
                    graphics.DrawString(year, font, brush, YearPoint, sf);
                    graphics.Dispose();

                    MemoryStream m = new MemoryStream();
                    bitmap.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] convertedToBytes = m.ToArray();
                    string imagefile = SILICON64.GenerateHash(certificateNo);
                    string saveto = HttpContext.Current.Server.MapPath("~/Images/" + imagefile + ".png");
                    File.WriteAllBytes(saveto, convertedToBytes);

                    var PythonEncode = new ProcessStartInfo();

                    string[] system_configuration = File.ReadAllLines(HttpContext.Current.Server.MapPath("configuration.txt"));

                    PythonEncode.FileName = @system_configuration[0];
                    var Encodescript = @system_configuration[1];
                    var argument0 = 1;
                    var argument1 = @system_configuration[2] + imagefile + ".png";
                    var argument2 = certificateNo + "#" + hash;

                    PythonEncode.Arguments = $"\"{Encodescript}\" \"{argument0}\" \"{argument1}\" \"{argument2}\"";

                    PythonEncode.UseShellExecute = false;
                    PythonEncode.CreateNoWindow = true;
                    PythonEncode.RedirectStandardOutput = true;
                    PythonEncode.RedirectStandardError = true;

                    var errors = "";
                    var results = "";

                    using (var process = Process.Start(PythonEncode))
                    {
                        errors = process.StandardError.ReadToEnd();
                        results = process.StandardOutput.ReadToEnd();
                    }
                    argument0 = 2;

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
                }
              
                /*Send it to server*/
                RemoteSend(JsonData);      

                /*Update Status*/
                string query = "UPDATE CERTIFICATE SET STATUS=1 WHERE ID=" + id;
                connect.Open();
                MySqlCommand SqlProcess1 = new MySqlCommand(query, connect);
                SqlProcess1.ExecuteNonQuery();
                connect.Close();

                degreecertificate.Visible = false;
                SucessPanel.Visible = true;
                /*Grid Load*/
                GridLoad();
                //Session["CertificateJson"] = null;
            }
            catch (Exception ex)
            {
                certificateno.Text = ex.Message;
            }
        }

        public void RemoteSend(string data)
        {
            string _CONFIGURATION_DATA_ = File.ReadAllText(Modules.Configuration.CONFIGPATH);
            JObject ConfigurationData = JObject.Parse(_CONFIGURATION_DATA_);
            JArray ConfigItem = (JArray)ConfigurationData["CONFIGURATION"];
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            string Data = data + "$" + timestamp;

            for (int i = 0; i < ConfigItem.Count; i++)
            {
                int PORT_NO = Modules.Configuration.FetchPort(i);
                string SERVER_IP = Modules.Configuration.FetchServer(i);
                SendData(SERVER_IP, Data, PORT_NO);
            }
        }

        public static void SendData(string SERVER_IP, string Data, int PORT_NO)
        {
            try
            {
                TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Data);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                client.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error: " + Ex.Message);
            }
        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            SucessPanel.Visible = false;
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Session["CertificateJson"] = null;
            degreecertificate.Visible = false;
            achivementcertificate.Visible = false;
            participationcertificate.Visible = false;
            SucessPanel.Visible = false;
        }
    }
}