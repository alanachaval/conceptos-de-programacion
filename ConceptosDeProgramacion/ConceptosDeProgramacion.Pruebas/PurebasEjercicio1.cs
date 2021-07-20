using ConceptosDeProgramacion.Ejercicios;
using NUnit.Framework;

namespace ConceptosDeProgramacion.Pruebas
{
    [TestFixture]
    public class PurebasEjercicio1
    {
        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(5, 6)]
        [TestCase(10, 11)]
        public void SumarUno_Parameterized(int x, int resultadoEsperado)
        {
            var resultado = Ejercicio1.SumarUno(x);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(5, 8)]
        [TestCase(10, 13)]
        public void SumarTres_Parameterized(int x, int resultadoEsperado)
        {
            var resultado = Ejercicio1.SumarTres(x);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 3, 4)]
        [TestCase(5, 5, 10)]
        [TestCase(10, -5, 5)]
        public void SumarValores_Parameterized(int x, int y, int resultadoEsperado)
        {
            var resultado = Ejercicio1.SumarValores(x, y);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        [TestCase(0f, 0f, 0f, 0f)]
        [TestCase(0f, 1f, 0f, 1f)]
        [TestCase(1f, 0f, 1f, 1f)]
        [TestCase(1f, 0f, 2f, 2f)]
        [TestCase(2f, 0f, 2f, 4f)]
        [TestCase(1f, 1f, 1f, 2f)]
        [TestCase(3f, 5f, 4f, 17f)]
        [TestCase(3f, 5f, 6f, 23f)]
        [TestCase(13f, 33f, 1235f, 16088f)]
        public void FuncionLineal_Parameterized(float a, float b, float x, float resultadoEsperado)
        {
            var resultado = Ejercicio1.FuncionLineal(a, b, x);

            Assert.AreEqual(resultadoEsperado, resultado, 0.1);
        }

        [Test]
        [TestCase(0f, 0f, 0f, 0f, 0f)]
        [TestCase(0f, 0f, 1f, 0f, 1f)]
        [TestCase(0f, 1f, 0f, 1f, 1f)]
        [TestCase(0f, 1f, 0f, 2f, 2f)]
        [TestCase(0f, 2f, 0f, 2f, 4f)]
        [TestCase(1f, 0f, 0f, 1f, 1f)]
        [TestCase(3f, 0f, 0f, 3f, 27f)]
        [TestCase(3f, 5f, 4f, 1f, 12f)]
        [TestCase(3f, 5f, 6f, 3f, 48f)]
        [TestCase(13f, 33f, 1235f, 555f, 4023875f)]
        public void FuncionCuadratica_Parameterized(float a, float b, float c, float x, float resultadoEsperado)
        {
            var resultado = Ejercicio1.FuncionCuadratica(a, b, c, x);

            Assert.AreEqual(resultadoEsperado, resultado, 0.1);
        }

        [Test]
        [TestCase(0, true)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(25, false)]
        [TestCase(30, true)]
        public void EsPar_Parameterized(int x, bool resultadoEsperado)
        {
            var resultado = Ejercicio1.EsPar(x);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        [TestCase(0, false)]
        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(25, true)]
        [TestCase(30, false)]
        public void EsInpar_Parameterized(int x, bool resultadoEsperado)
        {
            var resultado = Ejercicio1.EsInpar(x);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
