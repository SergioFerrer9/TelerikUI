namespace Telerik.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model21")
        {
        }

        public virtual DbSet<Carro> Carro { get; set; }
        public virtual DbSet<Moto> Moto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .Property(e => e.NombreC)
                .IsUnicode(false);

            modelBuilder.Entity<Carro>()
                .Property(e => e.ModeloC)
                .IsUnicode(false);

            modelBuilder.Entity<Moto>()
                .Property(e => e.NombreM)
                .IsUnicode(false);

            modelBuilder.Entity<Moto>()
                .Property(e => e.ModeloM)
                .IsUnicode(false);
        }
    }
}
