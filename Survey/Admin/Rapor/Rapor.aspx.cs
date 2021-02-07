using Survey.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Rapor
{
    public partial class Rapor : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            if (!IsPostBack)
            {
                BindListView();
            }
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
                    Anket_Katilim = a.Anket_Katilim
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