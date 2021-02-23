using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GestioneTest()
        {
            double a = 0;
            bool respettivo = Equazioni.IsDetermined(a);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void IsDeterminedTest2()
        {
            double a = 1;
            bool respettivo = Equazioni.IsDetermined(a);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void IsInconsisted1()
        {
            double a = 1, b = 1;
            bool respettivo = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void IsInconsisted2()
        {
            double a = 1, b = 0;
            bool respettivo = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void IsInconsisted3()
        {
            double a = 0, b = 1;
            bool respettivo = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void IsDegree2_1()
        {
            double x = 1, esponente = 1;
            bool respettivo = Equazioni.IsDegree2(esponente, x);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void IsDegree2_2()
        {
            double x = 1, esponente = 2;
            bool respettivo = Equazioni.IsDegree2(esponente, x);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void Delta()
        {
            double a = 3, b = 3, c = 4;
            double respettivo = Equazioni.Delta(a, b, c);
            double risultato_aspettato = -39;
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void SoluzioniEquazione1Grade1()
        {
            double a = 0, b = 0;
            string respettivo = Equazioni.SoluzioneEq1Grado(a, b);
            string risultato_aspettato = "Indeterminato";
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
        [TestMethod]
        public void SoluzioniEquazione1Grade2()
        {
            double a = 1, b = 0;
            string respettivo = Equazioni.SoluzioneEq1Grado(a, b);
            string risultato_aspettato = "Impossibile";
            Assert.AreEqual(risultato_aspettato, respettivo);
        }
    }
}

