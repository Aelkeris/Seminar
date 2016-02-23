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
    public class StavkaKosariceTests
    {
        [TestMethod()]
        public void StavkaKosariceTest()
        {
            StavkaKosarice s = new StavkaKosarice("Knjiga", 5, 50);
            StavkaKosarice r = new StavkaKosarice("Knjiga", 5, 50);

            Assert.AreEqual(s.VratiCijenu(), r.VratiCijenu());
            Assert.AreEqual(s.VratiKolicinu(), r.VratiKolicinu());
            Assert.AreEqual(s.VratiOpis(), r.VratiOpis());
        }

        [TestMethod()]
        public void StavkaKosariceTest1()
        {
            StavkaKosarice s = new StavkaKosarice("Knjiga", 50);
            StavkaKosarice r = new StavkaKosarice("Knjiga", 50);

            Assert.AreEqual(s.VratiCijenu(), r.VratiCijenu());
            Assert.AreEqual(s.VratiKolicinu(), 1);
            Assert.AreEqual(r.VratiKolicinu(), 1);
            Assert.AreEqual(s.VratiOpis(), r.VratiOpis());

        }

        [TestMethod()]
        public void VratiOpisTest()
        {
            StavkaKosarice s = new StavkaKosarice("Knjiga", 50);
            Assert.AreEqual("Knjiga",s.VratiOpis());
        }

        [TestMethod()]
        public void VratiKolicinuTest()
        {
            StavkaKosarice s = new StavkaKosarice("Knjiga", 50);
            Assert.AreEqual(1, s.VratiKolicinu());
        }

        [TestMethod()]
        public void VratiCijenuTest()
        {
            StavkaKosarice s = new StavkaKosarice("Knjiga", 50);
            Assert.AreEqual(50, s.VratiCijenu());
            
        }

        [TestMethod()]
        public void VratiVrijednostTest()
        {
            StavkaKosarice s = new StavkaKosarice("Knjiga",2, 50);
            Assert.AreEqual(100, s.VratiVrijednost());
            
        }

        
    }
}