namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [Key]
        public int Kullanici_ID { get; set; }

        [StringLength(50)]
        public string Kullanici_Adi { get; set; }

        [StringLength(50)]
        public string Kullanici_Parola { get; set; }

        [StringLength(50)]
        public string Kullanici_Email { get; set; }

        public int? Rol_ID { get; set; }

        public DateTime? Kayıt_Tarihi { get; set; }

        public DateTime? Son_Giris_Tarihi { get; set; }

        public bool? Durum { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
