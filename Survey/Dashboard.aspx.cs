using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            txtAnketSayisi.Text = db.Anketler.Count().ToString();
            txtKatilimci.Text = db.Yanitlar.Count().ToString();
            txtUyeler.Text = db.Kullanici.Count().ToString();
        }
    }
}