namespace model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CLUBPRBContext : DbContext
    {
        public CLUBPRBContext()
            : base("name=CLUBPRBContext")
        {
        }

        public virtual DbSet<ConfigDetNiv1> ConfigDetNiv1 { get; set; }
        public virtual DbSet<ConfigTipos> ConfigTipos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfigDetNiv1>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigDetNiv1>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigDetNiv1>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTipos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
