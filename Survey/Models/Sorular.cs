namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sorular")]
    public partial class Sorular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sorular()
        {
            Secenekler = new HashSet<Secenekler>();
            Yanitlar = new HashSet<Yanitlar>();
        }

        [Key]
        public int Soru_ID { get; set; }

        public int? Anket_ID { get; set; }

        public string Soru_Baslik { get; set; }

        public int? Soru_Tipi { get; set; }

        public bool? Soru_Durum { get; set; }

        public DateTime? Soru_Olusturma_Tarih { get; set; }

        public DateTime? Soru_Guncelle_Tarih { get; set; }

        public virtual Anketler Anketler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Secenekler> Secenekler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yanitlar> Yanitlar { get; set; }
    }
}
