using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Hesap
{
    public partial class Dondur : System.Web.UI.Page
    {
        private AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();
        }
        protected void dondurButton(object sender, EventArgs e)
        {
            string txtParola = Request.Form["txtParola"].ToString();
            int id = Convert.ToInt32(HttpContext.Current.Session["uyeId"]);
            Kullanici kullanici = db.Kullanici.Where(a => a.Kullanici_ID == id).FirstOrDefault();
            if (kullanici.Kullanici_Parola != txtParola)
            {
                Mesaj.Text = "Parola yanlış";
                Mesaj.CssClass = "alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                return;
            }
            else
            {
                kullanici.Durum = false;
                Mesaj.Text = "Hesap donduruldu";
                Mesaj.CssClass = "alert alert-success";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                db.SaveChanges();
            }

        }
    }
}