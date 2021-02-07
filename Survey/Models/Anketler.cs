namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anketler")]
    public partial class Anketler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anketler()
        {
            Sorular = new HashSet<Sorular>();
            Yanitlar = new HashSet<Yanitlar>();
            KatilimcilarIP = new HashSet<KatilimcilarIP>();
        }

        [Key]
        public int Anket_ID { get; set; }

        [StringLength(150)]
        public string Anket_Adi { get; set; }

        public DateTime? Anket_Baslangic_Tarih { get; set; }

        public DateTime? Anket_Bitis_Tarih { get; set; }

        public int? Anket_Katilim { get; set; }

        public bool? Anket_Durum { get; set; }

        public DateTime? Anket_Olusturulma_Tarih { get; set; }

        [StringLength(150)]
        public string Anket_Basligi { get; set; }

        public string Anket_Aciklamasi { get; set; }

        public string Anket_Sahibi { get; set; }

        public bool? Anket_Kapali { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sorular> Sorular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yanitlar> Yanitlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KatilimcilarIP> KatilimcilarIP { get; set; }
    }
}
