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
        public void ZakljucanaTest()
        {
            Poslovna_Logika.Kosarica Kosarica = new Poslovna_Logika.Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            Kosarica.Plati();
            Assert.IsTrue(Kosarica.VratiStatus() == StatusKosarice.Placena);
        }
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
            Poslovna_Logika.VlasnikKosarice Vlasnik = new Poslovna_Logika.VlasnikKosarice("1", "Stjepan Lokar", "Đurđevačka 4");
            string imeVlasnika = Vlasnik.VratiNaziv();
            Assert.AreEqual("Stjepan Lokar", imeVlasnika);
        }
        [TestMethod()]
        public void VratiVrijednostTest()
        {
            Kosarica K = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            K.DodajStavku(new StavkaKosarice("Burek", (decimal)8.50));
            K.DodajStavku(new StavkaKosarice("Krafna", 4));
            K.DodajStavku(new StavkaKosarice("Pizza", 8));
            K.DodajStavku(new StavkaKosarice("Slanci", 2));
            decimal vrijednost = K.VratiVrijednost();
            Assert.AreEqual((decimal)22.50, vrijednost);
        }
        [TestMethod()]
        public void VratiIDTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("45", "Andrija Čordaš", "Mihovljanska 2"));
            string id = k.VratiID();
            Assert.AreEqual("45", id);
        }
        [TestMethod()]
        public void VratiStatusTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("45", "Andrija Čordaš", "Mihovljanska 2"));
            k.Storniraj();
            Assert.AreEqual(k.VratiStatus(), StatusKosarice.Stornirana);
        }
        [TestMethod()]
        public void VratiStavkeTest()
        {
            /*
            Vrati Stavke Test NE FUNKCIONIRA !!
            Assert.AreEqual metoda uspoređuje samo broj objekata u listama
            , što nam ne govori da li su objekti u 2 liste,
            jedna ručno napravljena, a druga bi trebala koristeći metodu 
            VratiStavke iz košarice vratiti nazad cijelu listu stavaka , jednaki.
            Te nakon toga bi uspoređivanje lista trebalo zaključiti da su 
            liste ekvivalentne, tj, da se nalaze objekti sa istim vrijednostima u obje liste.
            */
            Kosarica Actual = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            Actual.DodajStavku(new StavkaKosarice("Burek", (decimal)8.50));
            Actual.DodajStavku(new StavkaKosarice("Krafna", 2));

            Kosarica Expected = new Kosarica(new VlasnikKosarice("2", "Dundo Maroje", "Stjepana Hausera 4"));
            Expected.DodajStavku(new StavkaKosarice("Burek", (decimal)8.50));
            Expected.DodajStavku(new StavkaKosarice("Krafna", 2));

            List<StavkaKosarice> exp = Expected.VratiStavke();
            List<StavkaKosarice> act = Actual.VratiStavke();

            Assert.AreEqual(exp.Count, act.Count);
        }
        [TestMethod()]
        public void DodajStavkuTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            StavkaKosarice s = new StavkaKosarice("Burek", (decimal)8.50);

            k.DodajStavku(s);

            Assert.IsTrue(k.VratiStavke().Count == 1);
        }
        [TestMethod()]
        public void DodajStavkuTest1()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));

            k.DodajStavku(new StavkaKosarice("Burek", 1, (decimal)8.50));

            Assert.IsTrue(k.VratiStavke().Count == 1);
        }
        [TestMethod()]
        public void DodajStavkuTest2()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));

            k.DodajStavku(new StavkaKosarice("Burek", (decimal)8.50));

            Assert.IsTrue(k.VratiStavke().Count == 1);
        }
        [TestMethod()]
        public void OmoguciIzmjeneTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            k.Storniraj();
            k.OmoguciIzmjene();

            Assert.AreEqual(k.VratiStatus(), StatusKosarice.Aktivna);
        }
        [TestMethod()]
        public void PlatiTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            k.Plati();


            Assert.AreEqual(k.VratiStatus(), StatusKosarice.Placena);
        }
        [TestMethod()]
        public void StornirajTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Andrija Čordaš", "Savska 24"));
            k.Storniraj();


            Assert.AreEqual(k.VratiStatus(), StatusKosarice.Stornirana);
        }
        [TestMethod()]
        public void ObrisiStavkuTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Ivanka Boljkovac", "Đure Grubišića 3"));
            k.DodajStavku(new StavkaKosarice("Majica", 240));
            k.ObrisiStavku(0);
            Assert.IsTrue(k.VratiStavke().Count == 0);
        }
        [TestMethod()]
        public void ObrisiStavkuTest1()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Ivanka Boljkovac", "Đure Grubišića 3"));
            StavkaKosarice st = new StavkaKosarice("Majica", 240);
            k.DodajStavku(st);
            k.ObrisiStavku(st);
            Assert.IsTrue(k.VratiStavke().Count == 0);
        }
        [TestMethod()]
        public void IsprazniTest()
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("0", "Ivanka Boljkovac", "Đure Grubišića 3"));
            k.DodajStavku(new StavkaKosarice("Majica", 240));
            k.DodajStavku(new StavkaKosarice("Džemper", 200));
            k.DodajStavku(new StavkaKosarice("Hlače", 150));
            k.DodajStavku(new StavkaKosarice("Haljina", 600));
            k.DodajStavku(new StavkaKosarice("Rukavice", 100));
            k.Isprazni();
            Assert.IsTrue(k.VratiStavke().Count == 0);
        }

    }
}