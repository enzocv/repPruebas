using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    public class CuentaAhorros
    {

        #region Propiedades
        public int NumeroCuenta { get; private set; }
        public string CodigoCuenta { get; private set; }
        public decimal SaldoDisponible { get; private set; }
        public int CodigoCliente { get; private set; }
        public virtual Cliente Propietario { get; private set; }
        public byte EstadoCuenta { get; private set; }

        #endregion

        #region Constructor
        private CuentaAhorros() { }

        #endregion

        #region Metodos

        public static CuentaAhorros Aperturar(string as_cod_cuenta
            , Cliente ao_propietario)
        {
            return new CuentaAhorros()
            {
                CodigoCuenta = as_cod_cuenta,
                SaldoDisponible = 0,
                CodigoCliente = ao_propietario.CodigoCliente,
                Propietario = ao_propietario,
                EstadoCuenta = 1
            };
        }

        public void Depositar(decimal monto)
        {
            SaldoDisponible += monto;
        }

        public void Retirar(decimal monto)
        {
            SaldoDisponible -= monto;
        }

        public void Cancelar()
        {
            SaldoDisponible = 0;
            EstadoCuenta = 5;
        }

        #endregion
    }
}
