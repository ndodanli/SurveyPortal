using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Anket.Soru
{
    public partial class Ekle : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            if (IsPostBack)
            {
                return;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSoruAd.Text == "")
            {
                Mesaj.Text = "Bilgiler Boş Olamaz";
                Mesaj.CssClass = "alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                return;
            }
            else
            {
                Sorular Ekle = new Sorular();
                Ekle.Soru_Baslik = txtSoruAd.Text.Trim();
                Ekle.Anket_ID = surveyApp.anketid;
                Ekle.Soru_Tipi = Convert.ToInt32(ddlSoruTipi.SelectedValue);
                Ekle.Soru_Olusturma_Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                if (rbZorunlu.SelectedValue == "1")
                {
                    Ekle.Soru_Durum = true;
                }
                else
                {
                    Ekle.Soru_Durum = false;
                }
                db.Sorular.Add(Ekle);
                db.SaveChanges();
                Mesaj.Text = "Anket Oluşturuldu. Soru Listesine Yönlendiriliyorsunuz...";
                Mesaj.CssClass = "alert alert-success";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");

                Response.Redirect("Liste.aspx?anket-id=" + surveyApp.anketid);
            }
        }

        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Liste.aspx?anket-id=" + surveyApp.anketid);
        }
    }
}