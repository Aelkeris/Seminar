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
    public class VlasnikKosariceTests
    {
        [TestMethod()]
        public void VlasnikKosariceTest()
        {

            Poslovna_Logika.VlasnikKosarice vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Ivica Kičmanović", "Mlinarska 8");
            Assert.IsInstanceOfType(vlasnik, vlasnik.GetType());
        }

        [TestMethod()]
        public void VratiIDTest()
        {
            Poslovna_Logika.VlasnikKosarice vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Ivica Kičmanović", "Mlinarska 8");
            Assert.AreEqual(vlasnik.VratiID(), "0");
            
        }

        [TestMethod()]
        public void VratiNazivTest()
        {
            Poslovna_Logika.VlasnikKosarice vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Ivica Kičmanović", "Mlinarska 8");
            Assert.AreEqual(vlasnik.VratiNaziv(), "Ivica Kičmanović");
        }

        [TestMethod()]
        public void PromijeniNazivTest()
        {
            Poslovna_Logika.VlasnikKosarice vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Ivica Kičmanović", "Mlinarska 8");
            vlasnik.PromijeniNaziv("Andrija Kičmanović");
            Assert.AreEqual(vlasnik.VratiNaziv(), "Andrija Kičmanović");
        }

        [TestMethod()]
        public void VratiAdresuTest()
        {

            Poslovna_Logika.VlasnikKosarice vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Ivica Kičmanović", "Mlinarska 8");
            
            Assert.AreEqual(vlasnik.VratiAdresu(), "Mlinarska 8");
        }

        [TestMethod()]
        public void PromijeniAdresuTest()
        {

            Poslovna_Logika.VlasnikKosarice vlasnik = new Poslovna_Logika.VlasnikKosarice("0", "Ivica Kičmanović", "Mlinarska 8");
            vlasnik.PromijeniAdresu("Poljodjelska 4A");
            Assert.AreEqual(vlasnik.VratiAdresu(), "Poljodjelska 4A");
        }

    }
}