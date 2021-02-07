using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Anket.Soru.Secenek
{
    public partial class Guncelle : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                return;
            }
            if (string.IsNullOrEmpty(Request.QueryString["secenek-id"]))
            {
                Response.Redirect("Liste.aspx");
            }
            surveyApp.secenekid = Convert.ToInt32(Request.QueryString["secenek-id"]);

            var doldur = db.Secenekler.Where(s => s.Secenek_ID == surveyApp.secenekid).FirstOrDefault();

            txtSecenekAd.Text = doldur.Secenek_Adi;
        }

        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Liste.aspx?soru-id=" + (int)db.Secenekler.Where(i => i.Secenek_ID == surveyApp.secenekid).FirstOrDefault().Sorular.Soru_ID);
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Secenekler guncelle = db.Secenekler.Where(s => s.Secenek_ID == surveyApp.secenekid).FirstOrDefault();
            guncelle.Secenek_Adi = txtSecenekAd.Text.Trim();
            db.SaveChanges();
            Mesaj.Text = "Seçenek Güncellendi. Seçenek Listesine Yönlendiriliyorsunuz...";
            Mesaj.CssClass = "alert alert-success";
            ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");

            Response.Redirect("Liste.aspx?soru-id=" + (int)db.Secenekler.Where(i => i.Secenek_ID == surveyApp.secenekid).FirstOrDefault().Sorular.Soru_ID);
        }
    }
}