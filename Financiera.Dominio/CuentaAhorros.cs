using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    public class CuentaAhorros
    {
        public int NumeroCuenta { get; set; }
        public string CodigoCuenta { get; set; }
        public decimal SaldoDisponible { get; set; }
        public int CodigoCliente { get; set; }
        public virtual Cliente Propietario { get; set; }
        public byte EstadoCuenta { get; set; }
    }
}
