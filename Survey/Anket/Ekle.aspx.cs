using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Anket
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
            if (txtAnketAd.Text == "" || txtBaslangicTarih.Text == "" || txtBitisTarih.Text == "" || anketDurum.SelectedIndex == -1)
            {
                Mesaj.Text = "Bilgiler Boş Olamaz";
                Mesaj.CssClass = "alert alert-danger";
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
                return; 
            }
            else
            {
                string baslangictarihsaat = txtBaslangicTarih.Text + " " + txtBaslangicSaati.Text;
                string bitistarihsaat = txtBitisTarih.Text + " " + txtBitisSaati.Text;


                Anketler Ekle = new Anketler();
                Ekle.Anket_Sahibi = surveyApp.mevcutKullanici;
                Ekle.Anket_Adi = txtAnketAd.Text.Trim();
                Ekle.Anket_Basligi = txtAnketBasligi.Text.Trim();
                Ekle.Anket_Aciklamasi = txtAnketAciklamasi.Text.Trim();
                Ekle.Anket_Olusturulma_Tarih = DateTime.Now;
                Ekle.Anket_Baslangic_Tarih = Convert.ToDateTime(baslangictarihsaat);
                Ekle.Anket_Bitis_Tarih = Convert.ToDateTime(bitistarihsaat);
                Ekle.Anket_Katilim = 0;
                Ekle.Anket_Kapali = false;
                if (anketDurum.SelectedValue == "1")
                {
                    Ekle.Anket_Durum = true;
                }
                else
                {
                    Ekle.Anket_Durum = false;
                }
                if (Ekle.Anket_Baslangic_Tarih < Ekle.Anket_Bitis_Tarih && Ekle.Anket_Bitis_Tarih > System.DateTime.Now)
                {
                    db.Anketler.Add(Ekle);
                    db.SaveChanges();
                    Mesaj.Text = "Anket Oluşturuldu.";
                    Mesaj.CssClass = "alert alert-success";
                }
                else
                {
                    Mesaj.Text = "Anket Tarihi Hatalı.";
                    Mesaj.CssClass = "alert alert-danger";
                }
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + Mesaj.ClientID + "').style.display='none'\",4000)</script>");
            }         
        }

        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Liste.aspx");
        }
    }
}