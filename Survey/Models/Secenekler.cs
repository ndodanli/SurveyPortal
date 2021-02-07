namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Secenekler")]
    public partial class Secenekler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Secenekler()
        {
            Yanitlar = new HashSet<Yanitlar>();
        }

        [Key]
        public int Secenek_ID { get; set; }

        public string Secenek_Adi { get; set; }

        public int? Soru_ID { get; set; }

        public virtual Sorular Sorular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yanitlar> Yanitlar { get; set; }
    }
}
