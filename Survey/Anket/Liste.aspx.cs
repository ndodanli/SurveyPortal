using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;
using System.Data.Entity.Core.Objects;

namespace Survey.Admin.Anket
{
    public partial class Liste : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();
            surveyApp.mevcutKullanici = Session["uyeKadi"]?.ToString();

            if (!IsPostBack)
            {
                BindListView();
            }        

        }

        protected void btnSil_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            db.Secenekler.RemoveRange(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault().Sorular.SelectMany(b => b.Secenekler));
            db.Yanitlar.RemoveRange(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault().Sorular.SelectMany(b => b.Yanitlar));
            db.Sorular.RemoveRange(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault().Sorular);
            db.Anketler.Remove(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault());
            db.SaveChanges();
            Response.Redirect("Liste.aspx");
        }

        protected void BindListView()
        {
           
            dynamic liste = new List<dynamic>();
            foreach (Anketler a in db.Anketler.Where(a => a.Anket_Sahibi == surveyApp.mevcutKullanici))
            {
                liste.Add(new
                {
                    Anket_ID = a.Anket_ID,
                    Anket_Adi = a.Anket_Adi,
                    basTarih = a.Anket_Baslangic_Tarih,
                    bitTarih = a.Anket_Bitis_Tarih,
                    Anket_Durum = a.Anket_Baslangic_Tarih < System.DateTime.Now && a.Anket_Bitis_Tarih > System.DateTime.Now ? a.Anket_Durum : false,
                    Anket_Sahibi = a.Anket_Sahibi.Equals(surveyApp.mevcutKullanici),
                    Soru_Sayi = a.Sorular.Count,
                });

            }
            lvAnketListe.DataSource = liste;
            lvAnketListe.DataBind();
            
        }

        protected void lvAnketListe_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            BindListView();
        }
    }
}