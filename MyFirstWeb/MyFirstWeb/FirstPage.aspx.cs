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
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "Message Displayed";
        }

        protected void btnAdd_click(object Sender, EventArgs e)
        {
            txtPerminantAdd.Text = txtPressentAdd.Text;
            txtPerminantAdd.Text = "First Name";
        }
    }
}
