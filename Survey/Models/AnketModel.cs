namespace Survey.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Survey.Admin.Anket;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class AnketModel : DbContext
    {
        public AnketModel()
            : base("AnketModelDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AnketModel,Survey.Migrations.Configuration>("AnketModelDB"));
        }

        public virtual DbSet<Anketler> Anketler { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Secenekler> Secenekler { get; set; }
        public virtual DbSet<Sorular> Sorular { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yanitlar> Yanitlar { get; set; }
        public virtual DbSet<KatilimcilarIP> KatilimcilarIP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
