using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    /// <summary>
    /// Clase que representa un cliente
    /// </summary>
    public class Cliente
    {
        #region Propiedades
        /// <summary>
        /// Propiedad que representa el Código del Cliente
        /// </summary>
        public int CodigoCliente { get; private set; }
        public string NombreCliente { get; private set; }
        public DateTime FechaNacimiento { get; private set; }

        #endregion

        #region Constructor
        private Cliente() { }
        #endregion

        #region Metodos
        /// <summary>
        /// Clase estatica que crea una nueva instancia de un cliente
        /// </summary>
        /// <param name="ai_cod_cliente">Código del cliente</param>
        /// <param name="as_nom_cliente">Nombre del cliente</param>
        /// <param name="adt_fec_nacimiento">Fecha de nacimiento</param>
        /// <returns>Objeto que representa una nueva instancia de la clase Cliente</returns>
        public static Cliente Crear(int ai_cod_cliente
            , string as_nom_cliente, DateTime adt_fec_nacimiento)
        {
            return new Cliente()
            {
                CodigoCliente = ai_cod_cliente,
                NombreCliente = as_nom_cliente,
                FechaNacimiento = adt_fec_nacimiento
            };
        }

        public void ModificarNombre(string as_nuevo_nombre)
        {
            NombreCliente = as_nuevo_nombre;
        } 
        #endregion
    }
}
