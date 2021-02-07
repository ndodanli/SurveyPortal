using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Anket.Soru
{
    public partial class Liste : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            if (string.IsNullOrEmpty(Request.QueryString["anket-id"]))
            {
                Response.Redirect("/Admin/Dashboard.aspx");
            }
            if (IsPostBack)
            {
                return;
            }
            surveyApp.anketid = Convert.ToInt32(Request.QueryString["anket-id"]);
            lvSoruListe.DataSource = db.Sorular.Where(s => s.Anket_ID == surveyApp.anketid).ToList();
            lvSoruListe.DataBind();
        }

        protected void btnSoru_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ekle.aspx");
        }

        protected void btnGeri_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Anket/Liste.aspx");
        }

        protected void btnSil_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            db.Yanitlar.RemoveRange(db.Sorular.Where(i => i.Soru_ID == id).FirstOrDefault().Yanitlar);
            db.Secenekler.RemoveRange(db.Sorular.Where(i => i.Soru_ID == id).FirstOrDefault().Secenekler);
            Sorular sil = db.Sorular.Where(s => s.Soru_ID == id).FirstOrDefault();
            db.Sorular.Remove(sil);
            db.SaveChanges();
            Response.Redirect("~/Anket/Soru/Liste.aspx?anket-id=" + surveyApp.anketid);
        }
    }
}