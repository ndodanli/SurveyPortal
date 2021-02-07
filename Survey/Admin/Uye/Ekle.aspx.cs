using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Uye
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

        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Liste.aspx");
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "" || txtParola.Text == "" || txtParolaTek.Text == "" || txtEmail.Text == "" || ddlKullaniciTip.SelectedIndex == -1)
            {
                Mesaj.Text = "Bilgiler Boş Olamaz";
                Mesaj.CssClass = "alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                return;
            }

            if (txtParola.Text != txtParolaTek.Text)
            {
                Mesaj.Text = "Parolalar Eşleşmiyor. Lütfen Kontrol Ediniz.";
                Mesaj.CssClass = "alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                return;
            }

            Kullanici ekle = new Kullanici();
            ekle.Kullanici_Adi = txtKullanici.Text.Trim();
            ekle.Kullanici_Parola = txtParolaTek.Text.Trim();
            ekle.Kullanici_Email = txtEmail.Text.Trim(); 
            ekle.Kayıt_Tarihi = DateTime.Now;
            ekle.Rol_ID = Convert.ToInt32(ddlKullaniciTip.SelectedValue);
            if (rbKullaniciDurum.SelectedValue == "1")
            {
                ekle.Durum = true;
            }
            else
            {
                ekle.Durum = false;
            }
            db.Kullanici.Add(ekle);
            db.SaveChanges();

            Mesaj.Text = "Yeni Kullanıcı Oluşturuldu.";
            Mesaj.CssClass = "alert alert-success";
            ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
            Response.Redirect("Liste.aspx");
        }
    }
}