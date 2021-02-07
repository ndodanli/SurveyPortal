using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey.Models
{
    public class ApiAnketler
    {
        public int Anket_ID { get; set; }
        public string Anket_Adi { get; set; }
        public DateTime? Anket_Baslangic_Tarih { get; set; }
        public DateTime? Anket_Bitis_Tarih { get; set; }
        public int? Anket_Katilim { get; set; }
        public bool? Anket_Durum { get; set; }
        public DateTime? Anket_Olusturulma_Tarih { get; set; }
        public string Anket_Basligi { get; set; }
        public string Anket_Aciklamasi { get; set; }
    }
}