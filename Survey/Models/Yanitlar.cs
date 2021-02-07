namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yanitlar")]
    public partial class Yanitlar
    {
        [Key]
        public int Yanit_ID { get; set; }

        public int? Anket_ID { get; set; }

        public int? Soru_ID { get; set; }

        public int? Secenek_ID { get; set; }

        public virtual Anketler Anketler { get; set; }

        public virtual Secenekler Secenekler { get; set; }

        public virtual Sorular Sorular { get; set; }
    }
}
