using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey
{
    public partial class KayitOl : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.Form["txtKullaniciAdi"]) || string.IsNullOrEmpty(Request.Form["txtParola"]) || string.IsNullOrEmpty(Request.Form["txtParolaTekrar"]) || string.IsNullOrEmpty(Request.Form["txtEmail"]))
            {
                Response.Redirect("Signup.aspx?h=1");
            }
            string kullaniciAdi = Request.Form["txtKullaniciAdi"].ToString();
            string parola = Request.Form["txtParola"].ToString();
            string parolaTekrar = Request.Form["txtParolaTekrar"].ToString();
            string email = Request.Form["txtEmail"].ToString();
            var sorgu = db.Kullanici.Where(k => k.Kullanici_Adi.Equals(kullaniciAdi)).FirstOrDefault();
            Kullanici yeniKullanici = new Kullanici();
            if (sorgu == null)
            {
                if (parola != parolaTekrar)
                {
                    Response.Redirect("Signup.aspx?h=3");
                }
                else
                {
                    yeniKullanici.Kullanici_Adi = kullaniciAdi;
                    yeniKullanici.Kullanici_Parola = parolaTekrar;
                    yeniKullanici.Kullanici_Email = email;
                    yeniKullanici.Kayıt_Tarihi = DateTime.Now;
                    yeniKullanici.Durum = true;
                    db.Kullanici.Add(yeniKullanici);
                    db.SaveChanges();
                    Response.Redirect("Login.aspx");
                }               
            }
            else
            {
                Response.Redirect("Signup.aspx?h=2");
            }
        }
    }
}