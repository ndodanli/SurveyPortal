using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Hesap
{
    public partial class Profil : System.Web.UI.Page
    {
        AnketModel db = new AnketModel();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            surveyApp.loginKontrol();

            id = Convert.ToInt32(Session["uyeId"].ToString());
            var sorgu = db.Kullanici.Where(k => k.Kullanici_ID == id).FirstOrDefault();
            if (!IsPostBack)
            {
                ViewState["SonSayfa"] = Request.UrlReferrer;
                txtKullaniciAdi.Text = sorgu.Kullanici_Adi;
                txtKayitTarihi.Text = sorgu.Kayıt_Tarihi.ToString();
                txtEposta.Text = sorgu.Kullanici_Email;
            }
        }

        protected void btnVazgec_Click(object sender, EventArgs e)
        {
            if (ViewState["SonSayfa"] != null)
            {
                Response.Redirect(ViewState["SonSayfa"].ToString());
            }
        }
    }
}