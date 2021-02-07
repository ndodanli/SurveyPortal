using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Hesap
{
    public partial class GuvenliCikis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}