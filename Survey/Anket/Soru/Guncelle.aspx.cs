using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Anket.Soru
{
    public partial class Guncelle : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            if (IsPostBack)
            {
                return;
            }
            if (string.IsNullOrEmpty(Request.QueryString["soru-id"]))
            {
                Response.Redirect("~/Anket/Liste.aspx");
            }
            surveyApp.soruid = Convert.ToInt32(Request.QueryString["soru-id"]);

            var doldur = db.Sorular.Where(s => s.Soru_ID == surveyApp.soruid).FirstOrDefault();
            txtSoruAd.Text = doldur.Soru_Baslik;
            ddlSoruTipi.SelectedValue = doldur.Soru_Tipi.ToString();
            if (doldur.Soru_Durum == true)
            {
                rbZorunlu.SelectedValue = "1";
            }
            else
            {
                rbZorunlu.SelectedValue = "0";
            }
        }

        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Anket/Soru/Liste.aspx?anket-id=" + surveyApp.anketid);
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Sorular guncelle = db.Sorular.Where(s => s.Soru_ID == surveyApp.soruid).FirstOrDefault();
            guncelle.Soru_Baslik = txtSoruAd.Text.Trim();
            guncelle.Anket_ID = surveyApp.anketid;
            guncelle.Soru_Tipi = Convert.ToInt32(ddlSoruTipi.SelectedValue);
            guncelle.Soru_Guncelle_Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            if (rbZorunlu.SelectedValue == "1")
            {
                guncelle.Soru_Durum = true;
            }
            else
            {
                guncelle.Soru_Durum = false;
            }
            db.SaveChanges();
            Mesaj.Text = "Soru Güncellendi. Soru Listesine Yönlendiriliyorsunuz...";
            Mesaj.CssClass = "alert alert-success";
            ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");

            Response.Redirect("Liste.aspx?anket-id=" + surveyApp.anketid);
        }
    }
}