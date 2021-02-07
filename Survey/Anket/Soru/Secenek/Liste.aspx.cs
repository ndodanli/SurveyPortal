using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Anket.Soru.Secenek
{
    public partial class Liste : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            if (string.IsNullOrEmpty(Request.QueryString["soru-id"]))
            {
                Response.Redirect("/Admin/Dashboard.aspx");
            }
            if (IsPostBack)
            {
                return;
            }
            surveyApp.soruid = Convert.ToInt32(Request.QueryString["soru-id"]);
            lvSecenekListe.DataSource = db.Secenekler.Where(s => s.Soru_ID == surveyApp.soruid).ToList();
            lvSecenekListe.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSecenek.Text == "")
            {
                Mesaj.Text = "Bilgiler Boş Olamaz";
                Mesaj.CssClass = "alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                return;
            }
            else
            {
                Secenekler Ekle = new Secenekler();
                Ekle.Secenek_Adi = txtSecenek.Text.Trim();
                Ekle.Soru_ID = surveyApp.soruid;
                db.Secenekler.Add(Ekle);
                db.SaveChanges();
                txtSecenek.Text = "";
                lvSecenekListe.DataSource = db.Secenekler.Where(s => s.Soru_ID == surveyApp.soruid).ToList();
                lvSecenekListe.DataBind();
                Mesaj.Text = "Seçenek Oluşturuldu.";
                Mesaj.CssClass = "alert alert-success";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
            }
        }

        protected void btnSil_Command(object sender, CommandEventArgs e)
        {
            int sID = Convert.ToInt32(e.CommandArgument);

            var sil = db.Secenekler.Where(s => s.Secenek_ID == sID).FirstOrDefault();
            db.Yanitlar.RemoveRange(db.Yanitlar.Where(i => i.Secenek_ID == sil.Secenek_ID));
            db.Secenekler.Remove(sil);
            db.SaveChanges();
            lvSecenekListe.DataSource = db.Secenekler.Where(s => s.Soru_ID == surveyApp.soruid).ToList();
            lvSecenekListe.DataBind();
            
        }

        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Anket/Soru/Liste.aspx?anket-id=" + surveyApp.anketid);
        }
    }
}