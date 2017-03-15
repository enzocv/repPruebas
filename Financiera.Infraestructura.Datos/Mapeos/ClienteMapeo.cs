using Financiera.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Financiera.Infraestructura.Datos.Mapeos
{
    public class ClienteMapeo : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapeo()
        {
            ToTable("CLIENTES","FI");
            HasKey(k => k.CodigoCliente);
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.NombreCliente).HasColumnName("NOM_CLIENTE").IsRequired();
            Property(p => p.FechaNacimiento).HasColumnName("FEC_NACIMIENTO").IsRequired();
        }
    }
}
