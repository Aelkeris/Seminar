using Microsoft.VisualStudio.TestTools.UnitTesting;
using KosaricaVjezba.Poslovna_Logika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaVjezba.Poslovna_Logika.Tests
{
    [TestClass()]
    public class KosaricaTests
    {
        [TestMethod()]
        public void KosaricaTest()
        {
            Poslovna_Logika.VlasnikKosarice Vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Andrija Čordaš", "Savska 24");
            Kosarica kosarica = new Kosarica(Vlasnik);
            Assert.IsInstanceOfType(kosarica, kosarica.GetType());
        }

        [TestMethod()]
        public void vratiVlasnikaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void VratiVrijednostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void VratiIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void VratiStatusTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void VratiStavkeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DodajStavkuTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DodajStavkuTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DodajStavkuTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void OmoguciIzmjeneTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PlatiTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void StornirajTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ObrisiStavkuTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ObrisiStavkuTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsprazniTest()
        {
            Assert.Fail();
        }
    }
}