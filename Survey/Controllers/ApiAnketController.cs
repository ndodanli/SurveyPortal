using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Survey.Models;

namespace Survey.Controllers
{
    public class ApiAnketController : ApiController
    {
        private AnketModel db = new AnketModel();

        // GET işlemi örnek kullanımı: api/ApiAnket
        public List<ApiAnketler> GetAnketler()
        {
            var anketler = db.Anketler.ToList();
            var response = new List<ApiAnketler>();

            foreach (var anket in anketler)
            {
                response.Add(new ApiAnketler()
                {
                    Anket_ID = anket.Anket_ID,
                    Anket_Adi = anket.Anket_Adi,
                    Anket_Basligi = anket.Anket_Basligi,
                    Anket_Aciklamasi = anket.Anket_Aciklamasi,
                    Anket_Olusturulma_Tarih = anket.Anket_Olusturulma_Tarih,
                    Anket_Baslangic_Tarih = anket.Anket_Baslangic_Tarih,
                    Anket_Bitis_Tarih = anket.Anket_Bitis_Tarih,
                    Anket_Katilim = anket.Anket_Katilim, 
                    Anket_Durum = anket.Anket_Durum
                });
            }
            return response;
        }


        // GET işlemi id ile örnek kullanımı: api/ApiAnket/5
        [ResponseType(typeof(Anketler))]
        public List<ApiAnketler> GetAnketler(int id)
        {
            var anketler = db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault();
            var response = new List<ApiAnketler>();

            response.Add(new ApiAnketler()
            {
                Anket_ID = anketler.Anket_ID,
                Anket_Adi = anketler.Anket_Adi,
                Anket_Basligi = anketler.Anket_Basligi,
                Anket_Aciklamasi = anketler.Anket_Aciklamasi,
                Anket_Olusturulma_Tarih = anketler.Anket_Olusturulma_Tarih,
                Anket_Baslangic_Tarih = anketler.Anket_Baslangic_Tarih,
                Anket_Bitis_Tarih = anketler.Anket_Bitis_Tarih,
                Anket_Katilim = anketler.Anket_Katilim,
                Anket_Durum = anketler.Anket_Durum
            });
            
            return response;
        }

        // POST işlemi örnek kullanımı: api/ApiAnket
        [ResponseType(typeof(Anketler))]
        public ApiDurumMesaj PostAnketler(Anketler anketler)
        {
            ApiDurumMesaj mesaj = new ApiDurumMesaj();

            if (!ModelState.IsValid)
            {
                mesaj.Api_Durum = false;
                mesaj.Api_Mesaj = "Anket ekleme işlemi başarısız!";
                return mesaj;
            }

            db.Anketler.Add(anketler);
            db.SaveChanges();

            mesaj.Api_Durum = true;
            mesaj.Api_Mesaj = "Anket ekleme işlemi başarılı";
            return mesaj;
        }

        // PUT işlemi örnek kullanımı :api/ApiAnket/5
        [ResponseType(typeof(void))]
        public ApiDurumMesaj PutAnketler(int id, Anketler anketler)
        {
            ApiDurumMesaj mesaj = new ApiDurumMesaj();

            if (!ModelState.IsValid)
            {
                mesaj.Api_Durum = false;
                mesaj.Api_Mesaj = "Hatalı istek!";
                return mesaj;
            }

            if (id != anketler.Anket_ID)
            {
                mesaj.Api_Durum = false;
                mesaj.Api_Mesaj = "ID bulunamadı!";
                return mesaj;
            }

            db.Entry(anketler).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
                mesaj.Api_Durum = true;
                mesaj.Api_Mesaj = "Anket güncelleme işlemi başarılı!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnketlerExists(id))
                {
                    mesaj.Api_Durum = false;
                    mesaj.Api_Mesaj = "ID bulunamadı!";
                    return mesaj;
                }
                else
                {
                    throw;
                }
            }

            return mesaj;
        }

        // DELETE işlemi örnek kullanımı: api/ApiAnket/5
        [ResponseType(typeof(Anketler))]
        public ApiDurumMesaj DeleteAnketler(int id)
        {
            Anketler anketler = db.Anketler.Find(id);
            ApiDurumMesaj mesaj = new ApiDurumMesaj();

            if (anketler == null)
            {
                mesaj.Api_Durum = false;
                mesaj.Api_Mesaj = "Anket silme işlemi başarısız!";
                return mesaj;
            }

            db.Secenekler.RemoveRange(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault().Sorular.SelectMany(b => b.Secenekler));
            db.Yanitlar.RemoveRange(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault().Sorular.SelectMany(b => b.Yanitlar));
            db.Sorular.RemoveRange(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault().Sorular);
            db.Anketler.Remove(db.Anketler.Where(a => a.Anket_ID == id).FirstOrDefault());
            db.SaveChanges();

            mesaj.Api_Durum = true;
            mesaj.Api_Mesaj = "Anket silme işlemi başarılı";

            return mesaj;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AnketlerExists(int id)
        {
            return db.Anketler.Count(e => e.Anket_ID == id) > 0;
        }
    }
}