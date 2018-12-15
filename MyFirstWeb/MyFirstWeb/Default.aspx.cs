using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace MyFirstWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "CWS_MRB_ERRORS_REPORTS_07-06-2017.pdf";
                string ServerPath = @"D:\MAPFRE_CD_Files\CWS\MRB_ERRORS_REPORTS\" + fileName;
                    //"http://172.18.108.33/D:/MAPFRE_CD_Files/CWS/MRB_ERRORS_REPORTS/" + fileName;
                    //System.Configuration.ConfigurationManager.AppSettings["pdfFilePath"] + "CWS" + "/" + "MRB_ERRORS_REPORTS" + "/" + fileName;
                System.IO.FileInfo file = new System.IO.FileInfo(ServerPath);

                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                //HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());
                HttpContext.Current.Response.ContentType = "application/octet-stream";
                HttpContext.Current.Response.TransmitFile(file.FullName);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void findString()
        {
            try
            {
                string totStr = "N14*aBC*123~SBN*sdffg*12345*hij~N12*1433*sdf*rgte61~";
                string findStr = "hij";
                string[] strbuild;

                strbuild = totStr.Split('~');
                for(int i=0;i<=strbuild.Length;i++)
                {                    
                    string str = strbuild[i];
                    if (strbuild[i].Contains(findStr))
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
