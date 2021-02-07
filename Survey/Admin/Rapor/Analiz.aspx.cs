using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Rapor
{
    public partial class Analiz : System.Web.UI.Page
    {
        private AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();
            if (IsPostBack)
            {
                return;
            }
            surveyApp.anketid = Convert.ToInt32(Request.QueryString["anket-id"]);
            List<Anketler> list = new List<Anketler>();
            list.Add(db.Anketler.Where(a => a.Anket_ID == surveyApp.anketid).FirstOrDefault());
            lvAnket.DataSource = list;
            lvAnket.DataBind();
        }
    }
}