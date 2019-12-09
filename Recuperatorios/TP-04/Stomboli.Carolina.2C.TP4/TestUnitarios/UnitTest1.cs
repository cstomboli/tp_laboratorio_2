using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// El test unitario verifica que la lista de Paquetes del 
        /// correo este instanciada.
        /// </summary>
        [TestMethod]
        public void TestListaInstanciada()
        {
            Correo correo = new Correo();

            Assert.IsNotNull(correo.Paquete);
        }

        /// <summary>
        /// El test unitario verifica que no se puedan cargar dos
        /// paquetes con el mismo tracking id.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestPaquetesId()
        {
            Correo correo = new Correo();

            Paquete paquete1 = new Paquete("Laprida 580", "123-123-123");
            Paquete paquete2 = new Paquete("Loria 580", "123-123-123");

            correo += paquete1;
            correo += paquete2;
        }
    }
}
