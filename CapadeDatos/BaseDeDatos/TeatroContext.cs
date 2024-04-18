using CapadeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeDatos.BaseDeDatos
{
    public class TeatroContext:DbContext
    {
        public TeatroContext() : base("Teatro")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<ClientesModel> Clientes { get; set; }
        public DbSet<FuncionesModel> Funciones { get; set; }
        public DbSet<ReservacionesModel> Reservaciones { get; set; }
    }
}
