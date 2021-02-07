using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey.Admin.Anket
{
    public partial class qrkod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["anket-id"]))
            {
                panelQr.Visible = false;
                hata.Text = "Gösterilecek Bir QR Kod Yok!";
                hata.CssClass = "alert alert-danger";
            }
            panelQr.Visible = true;
            string id = Request.QueryString["anket-id"].ToString();
            string link = "http://localhost:59848/Admin/Anket/Onizleme.aspx?anket-id=" + id;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap resim = encoder.Encode(link);
            qrResim.Height = 150;
            qrResim.Width = 150;
            qrResim.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(BitmapToByte(resim));
        }

        private byte[] BitmapToByte(Bitmap resim)
        {
            MemoryStream stream = new MemoryStream();
            resim.Save(stream, ImageFormat.Png);
            byte[] resimBytelari = stream.ToArray();
            resim.Dispose();
            stream.Close();
            return resimBytelari;
        }
    }
}