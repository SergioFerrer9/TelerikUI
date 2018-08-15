namespace Telerik.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Album)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Cancion)
                .IsUnicode(false);
        }
    }
}
