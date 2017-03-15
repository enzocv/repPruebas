using Financiera.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Financiera.Infraestructura.Datos.Mapeos
{
    public class CuentaAhorrosMapeo : EntityTypeConfiguration<CuentaAhorros>
    {
        public CuentaAhorrosMapeo()
        {
            ToTable("CUENTA_AHORROS", "FI");
            HasKey(k => k.NumeroCuenta);
            Property(p => p.NumeroCuenta).HasColumnName("NUM_CUENTA").IsRequired();
            Property(p => p.CodigoCuenta).HasColumnName("COD_CUENTA").IsRequired();
            Property(p => p.SaldoDisponible).HasColumnName("SAL_DISPONIBLE").IsRequired();
            Property(p => p.EstadoCuenta).HasColumnName("EST_CUENTA").IsRequired();
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            HasRequired(m => m.Propietario).WithMany().HasForeignKey(f => f.CodigoCliente);
        }
    }
}
