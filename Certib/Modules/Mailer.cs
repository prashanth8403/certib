using System;
using System.Net.Mail;
using System.Text;
using Silicon;
using Newtonsoft.Json;

namespace Certib.Modules
{
    public class Mailer
    {
        public static string mailstruct(string JSONData)
        {
            StringBuilder MailBody = new StringBuilder();

            dynamic CertificateInformation = JsonConvert.DeserializeObject(JSONData);

            string certificateNo = CertificateInformation.certificate_id;
            string fullname = CertificateInformation.full_name;
            string marks = CertificateInformation.marks_obtained + "/" + CertificateInformation.max_marks + " (" + CertificateInformation.percentage + "%)";
            string usn = "(" + CertificateInformation.university_seat_number + ")";
            string department = CertificateInformation.department;
            string certificatedate = CertificateInformation.certificate_date;
            string year = CertificateInformation.academic_year;
            string certificate_hash = SILICON64.GenerateHash(certificateNo);

            MailBody.Append("<div class=\"certificate-web-template\" style=\"background-image: url(\"https://www.linkpicture.com/q/vector-top.jpg\"), url(\"https://www.linkpicture.com/q/vector-bottom.jpg\");background-position: topright, bottom left;background-repeat: no-repeat;height: 500px;margin-left: auto;margin-right: auto;position: center;margin: 10px;border: 3px solid #0094ff;\">");
            MailBody.Append("<div class=\"certificate-header\" style=\"padding:20px;\">");
            MailBody.Append("    <div style=\"max-width: 320px;\">");
            MailBody.Append("        <div style=\"float: left; padding-right: 10px;\">");
            MailBody.Append("            <img id=\"logoid\" src=\"https://www.linkpicture.com/q/logo_320.png\" height =\"60\" />");
            MailBody.Append("        </div>");
            MailBody.Append("        <div style=\"float: right; padding-top: 10px;\">");
            MailBody.Append("            <a id=\"bmsit1\" style=\"color: #d30000;font-family: Arial;font-size: 32px;font-weight: 600;\" class=\"bmsit-text\">BMS</a><br />");
            MailBody.Append("            <a id=\"bmsit2\" style=\"color: #363491;font-family: Calibri;font-size: 22px;font-weight: 600;\" class=\"bmsit-text-s\">INSTITUTE OF TECHNOLOGY</a>");
            MailBody.Append("        </div>");
            MailBody.Append("    </div>");
            MailBody.Append("    <br />");
            MailBody.Append("    <br />");
            MailBody.Append("     <br />");
            MailBody.Append("    <br />");
            MailBody.Append("    <a style=\"font-family:Arial; font-size:20px; color:#722806\">Certificate No: ");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;\">"+certificateNo+"</a>");
            MailBody.Append("    </a><br />");
            MailBody.Append("    <a style=\"font-family:Arial;font-size:20px; color:#722806\">Date : ");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;\">"+certificatedate+"</a>");
            MailBody.Append("    </a>");
            MailBody.Append("    <br />");
            MailBody.Append("   ");
            MailBody.Append("    <div style=\"justify-content: center; text-align: center; width: 100%;\">");
            MailBody.Append("        <a style=\"font-family: Monotype Corsiva; color: #0094ff; font-size: 35px;\">Certificate of Graduation</a><br />");
            MailBody.Append("        <div style=\"margin-left: auto; margin-right: auto; position: center;\"><a style=\"font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;\">is awarded to</a></div>");
            MailBody.Append("    </div>");
            MailBody.Append("    <br />");
            MailBody.Append("    <p style=\"width: 60%; margin-left: auto; text-align: center; margin-right: auto;\">");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 25px;\">"+fullname+" "+usn+"</a>");
            MailBody.Append("        <br />");
            MailBody.Append("        <a style=\"font-size: 20px;\">who has satisfactorily pursued the studies, passed the examination and securing </a>");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;\">"+marks+"</a>");
            MailBody.Append("        <a style=\"font-size: 20px;\">and complied with all other requirements.</a>");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;\"></a><br /><br />");
            MailBody.Append("        <a style=\"font-size: 20px;\">Therefore, Bachelors degree in </a>");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;\">"+department+"</a>,");
            MailBody.Append("        <a style=\"font-size: 20px;\">Graduation year </a>");
            MailBody.Append("        <a style=\"text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;\">"+year+"</a>");
            MailBody.Append("    </p>");
            MailBody.Append("</div>");

            MailBody.Append("<div style=\"width:50%; position: center; margin-left: auto; margin-right: auto;\">");
            MailBody.Append("<a style=\"width:100%; padding:5px; background-color:#DEFF50; color:#000;\" href=\"https://localhost:44375/Images/" + certificate_hash + ".png \">Download Certificate</a>");
            MailBody.Append("</div>");
            
            return MailBody.ToString();
        }

        public static void MailFunction(string _mailadd, string JSON)
        {
            MailMessage _mail = new MailMessage();
            _mail.To.Add(_mailadd);
            _mail.Body = mailstruct(JSON);
            _mail.Subject = "Congratulations - Academic Certificate";
            _mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            try
            {
                _mail.From = new MailAddress("prashanth7514@gmail.com");
                smtp.Host = "smtp.gmail.com";
                string u = "prashanth7514@gmail.com", v = "Hunter21#";
                smtp.Credentials = new System.Net.NetworkCredential(u, v);
                smtp.EnableSsl = true;
                smtp.Send(_mail);
            }
            catch (Exception MX2)
            {
                System.Diagnostics.Debug.WriteLine(MX2.Message);
            }
        }
    }
}