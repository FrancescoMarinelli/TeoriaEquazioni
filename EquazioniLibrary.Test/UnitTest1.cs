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
            bool resp = Equazioni.IsDetermined(a);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDeterminedTest2()
        {
            double a = 1;
            bool resp = Equazioni.IsDetermined(a);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsInconsisted1()
        {
            double a = 1, b = 1;
            bool resp = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsInconsisted2()
        {
            double a = 1, b = 0;
            bool resp = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsInconsisted3()
        {
            double a = 0, b = 1;
            bool resp = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDegree2_1()
        {
            double x = 1, esponente = 1;
            bool resp = Equazioni.IsDegree2(esponente, x);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDegree2_2()
        {
            double x = 1, esponente = 2;
            bool resp = Equazioni.IsDegree2(esponente, x);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
    }
}

