using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using Silicon;
using System.Web.UI.WebControls;

namespace Certib
{
    public partial class verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["key"] = null;
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(FileUpload1.HasFile)
                {
                    string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    fileName = SILICON64.GenerateHash(fileName + DateTime.Now.ToString("yyyyMMddHHmmssffff"));
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("/TempImage/") + fileName);

                    Session["key"] = fileName;
                    Response.Redirect("view");
                }
                else
                {
                    message.Text = "Select a File";
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}