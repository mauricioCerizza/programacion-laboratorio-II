using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class SerializacionTest
    {
        [TestMethod]
        public void CuandoSerializoDeberiaGuardarCorrectamente()
        {
            Planeta planeta = new Planeta(2, 1, 10, null);
            Xml<Planeta> serializador = new Xml<Planeta>();
            serializador.Guardar("Planeta.xml", planeta);
            Planeta planetaDeserializado;
            serializador.Leer("Planeta.xml", out planetaDeserializado);

            Assert.IsTrue(planeta.VelocidadTraslacion == planetaDeserializado.VelocidadTraslacion
                && planeta.RadioRespectoSol == planetaDeserializado.RadioRespectoSol
                && planeta.PosicionActual == planetaDeserializado.PosicionActual);
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void CuandoLaRutaEsInvalidaDeberiaLanzarErrorArchivosException()
        {
            Xml<Planeta> serializador = new Xml<Planeta>();
            Planeta planetaDeserializado;
            serializador.Leer("C:\\planeta.xml", out planetaDeserializado);
        }
    }
}
