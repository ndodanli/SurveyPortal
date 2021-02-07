namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KatilimcilarIP")]
    public partial class KatilimcilarIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KatilimcilarIP()
        {
        }

        [Key]
        public int Katilimci_ID { get; set; }
        public int? Anket_ID { get; set; }
        public string IP { get; set; }
        public virtual Anketler Anketler { get; set; }
    }
}
