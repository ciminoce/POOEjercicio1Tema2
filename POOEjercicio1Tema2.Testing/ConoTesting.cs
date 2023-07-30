using POOEjercicio1Tema2.Entidades;
using System.Text;

namespace POOEjercicio1Tema2.Testing
{
    [TestClass]
    public class ConoTesting
    {
        [TestMethod]
        public void CrearConoValidoTest()
        {
            int altura = 10;
            int radio = 10;
            Cono pc = new Cono(altura, radio);
            Assert.AreEqual(14.14.ToString(), pc.GetGeneratriz().ToString("N"));

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CrearConoInvalidoTest()
        {
            int altura = -10;
            int radio = 10;
            Cono pc = new Cono(altura, radio);

        }
        [TestMethod]
        public void ConoGetAreaTest()
        {
            int altura = 10;
            int radio = 10;
            Cono pc = new Cono(altura, radio);
            Assert.AreEqual(758.45.ToString(), pc.GetArea().ToString("N"));

        }
        [TestMethod]
        public void ConoGetVolumenTest()
        {
            int altura = 10;
            int radio = 10;
            Cono pc = new Cono(altura, radio);
            Assert.AreEqual(942.48.ToString(), pc.GetVolumen().ToString("N"));

        }
        [TestMethod]
        public void ConoMostrarDatosTest()
        {
            int altura = 10;
            int radio = 10;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cono");
            sb.AppendLine($"Radio........: 10");
            sb.AppendLine($"Altura.......: 10");
            sb.AppendLine($"Generatríz...: 14,14");
            sb.AppendLine($"Superficie...: 758,45");
            sb.AppendLine($"Volumen......: 942,48");
            var c = new Cono(altura, radio);
            Assert.AreEqual(sb.ToString(), c.MostrarDatos());
        }

    }
}