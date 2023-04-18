using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrivadasIoT.Models
{
    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<Privada> Privada { get; set; }
        public virtual DbSet<Casa> Casa { get; set; }
        public virtual DbSet<Historial> Historial { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

    }
}
