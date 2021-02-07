using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Hesap
{
    public partial class Email : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            id = Convert.ToInt32(Session["uyeId"].ToString());

            if (!IsPostBack)
            {
                ViewState["SonSayfa"] = Request.UrlReferrer;
            }
        }

        protected void btnVazgec_Click(object sender, EventArgs e)
        {
            if (ViewState["SonSayfa"] != null)
            {
                Response.Redirect(ViewState["SonSayfa"].ToString());
            }
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            var sorgu = db.Kullanici.Where(k => k.Kullanici_ID == id).FirstOrDefault();
            if (sorgu.Kullanici_Email != txtMevcutEmail.Value.ToString())
            {
                sonuc.Text = "Mevcut Email Hatalı!";
                sonuc.CssClass = "col-md-6 alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + sonuc.ClientID + "').style.display='none'\",4000)</script>");
                return;
            }
            else
            {
                if (txtYeniEmail.Value.ToString() != txtYeniEmailTek.Value.ToString())
                {
                    sonuc.Text = "Email Adresleri Eşleşmiyor!";
                    sonuc.CssClass = "col-md-6 alert alert-danger";
                    ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + sonuc.ClientID + "').style.display='none'\",4000)</script>");
                    return;
                }
                else
                {
                    sorgu.Kullanici_Email = txtYeniEmailTek.Value.ToString();
                    db.SaveChanges();
                    sonuc.Text = "Email Değiştirme Başarılı";
                    sonuc.CssClass = "col-md-6 alert alert-success";
                    ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + sonuc.ClientID + "').style.display='none'\",4000)</script>");
                }
            }
        }
    }
}