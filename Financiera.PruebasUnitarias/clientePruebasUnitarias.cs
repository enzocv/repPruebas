using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financiera.Dominio;
using Financiera.Dominio.Repositorios;
using Financiera.Infraestructura.Datos.Repositorios;

namespace Financiera.PruebasUnitarias
{
    [TestClass]
    public class ClientePruebasUnitarias
    {
        [TestMethod]
        public void ListarClientesSatisfactorio()
        {
            //Config
            IRepositorioGeneral<Cliente> repCliente = new RepositorioGeneral<Cliente>();

            //Act
            var clientes = repCliente.Listar();

            //Assert
            Assert.IsTrue(clientes.Count() == 1);
        }
    }
}
