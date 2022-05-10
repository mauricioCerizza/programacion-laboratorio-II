using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "tyry plkgh;";

            // Act
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoTieneDosVocalesEnMinuscula_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "casa";

            // Act
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoTieneTresVocalesEnMayuscula_DeberiaRetornarTres()
        {
            // Arrange
            int expected = 3;
            string text = "LA COSA";

            // Act
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaLanzarBusinessException()
        {
            // Arrange
            string text = null;

            // Act
            text.ContarVocales();
        }

        [TestMethod]
        public void ContarVocales_CuandoElTextoEsVacio_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = string.Empty;

            // Act
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCaracteres_CuandoNoTieneElCaracter_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "tyry plkgh";
            char caracter = ';';

            // Act
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCaracteres_CuandoTieneElCaracterDosVeces_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "tyry. plkgh.";
            char caracter = '.';

            // Act
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ContarCaracteres_CuandoElTextoEsNulo_DeberiaLanzarBusinessException()
        {
            // Arrange
            string text = null;
            char caracter = '.';

            // Act
            text.ContarCaracteres(caracter);
        }

        [TestMethod]
        public void ContarCaracteres_CuandoElTextoEsVacio_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = string.Empty;
            char caracter = '.';

            // Act
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
