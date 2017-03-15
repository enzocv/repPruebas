using Financiera.Dominio;
using Financiera.Infraestructura.Datos.Mapeos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructura.Datos
{
    public class FinancieraContexto : DbContext
    {
        public FinancieraContexto() : base("CadenaDeConexion")
        {
            Database.SetInitializer<FinancieraContexto>(null);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaAhorros> Cuentas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ClienteMapeo());
            modelBuilder.Configurations.Add(new CuentaAhorrosMapeo());
        }

    }
}
