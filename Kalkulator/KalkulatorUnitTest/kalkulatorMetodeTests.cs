using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Kalkulator.Tests
{
    [TestClass()]
    public class kalkulatorMetodeTests
    {
        kalkulatorMetode m = new kalkulatorMetode();

        [TestMethod()]
        public void setZbrajanjeTest()
        {
            m.setZbrajanje();
            Assert.AreEqual(true, m.zbrajanje);
            Assert.AreEqual(false,m.oduzimanje);
            Assert.AreEqual(false,m.mnozenje);
            Assert.AreEqual(false,m.dijeljenje);
        }

        [TestMethod()]
        public void setOduzimanjeTest()
        {
            m.setOduzimanje();
            Assert.AreEqual(false, m.zbrajanje);
            Assert.AreEqual(true, m.oduzimanje);
            Assert.AreEqual(false, m.mnozenje);
            Assert.AreEqual(false, m.dijeljenje);
        }

        [TestMethod()]
        public void setMnozenjeTest()
        {
            m.setMnozenje();
            Assert.AreEqual(false, m.zbrajanje);
            Assert.AreEqual(false, m.oduzimanje);
            Assert.AreEqual(true, m.mnozenje);
            Assert.AreEqual(false, m.dijeljenje);
        }

        [TestMethod()]
        public void setDijeljenjeTest()
        {
            m.setDijeljenje();
            Assert.AreEqual(false, m.zbrajanje);
            Assert.AreEqual(false, m.oduzimanje);
            Assert.AreEqual(false, m.mnozenje);
            Assert.AreEqual(true, m.dijeljenje);
        }

        [TestMethod()]
        public void promjenaPredznakaTest()
        {
            TextBox prazan = new TextBox();
            prazan.Text = "";
            TextBox pozitivan = new TextBox();
            pozitivan.Text = "6";
            TextBox negativan = new TextBox();
            negativan.Text = "-6";

            m.promjenaPredznaka(prazan);
            Assert.AreEqual("",prazan.Text);

            m.promjenaPredznaka(pozitivan);
            Assert.AreEqual("-6", pozitivan.Text);

            m.promjenaPredznaka(negativan);
            Assert.AreEqual("6", negativan.Text);
        }

        [TestMethod()]
        public void jedanKrozBrojTest()
        {
            TextBox prazan = new TextBox();
            prazan.Text = "";
            m.jedanKrozBroj(prazan);
            Assert.AreEqual("",prazan.Text);


            TextBox broj = new TextBox();
            broj.Text = "2";
            m.jedanKrozBroj(broj);
            Assert.AreEqual("0,5", broj.Text);
            
        }

        [TestMethod()]
        public void korijenTest()
        {
            TextBox broj = new TextBox();
            broj.Text="36";
            m.korijen(broj);
            Assert.AreEqual("6",broj.Text);

        }

        [TestMethod()]
        public void postotakTest()
        {
            m.broj1 = 5;
            TextBox br2 = new TextBox();
            br2.Text = "2";
            m.postotak(br2);
            Assert.AreEqual("0,1", br2.Text);
            
        }

        [TestMethod()]
        public void upisBrojaTest()
        {
            TextBox box1 = new TextBox();
            TextBox box2 = new TextBox();
            m.upisBroja(box1, box2, "2", true);
            Assert.AreEqual("2", box1.Text);
            Assert.AreEqual("", box2.Text);

        }

        [TestMethod()]
        public void zbrTest()
        {
            TextBox box1 = new TextBox();
            box1.Text = "1";
            TextBox box2 = new TextBox();
            m.zbr(box1,box2);
            
            Assert.IsTrue(m.zbrajanje==true);
            Assert.AreEqual("1 + ", box2.Text);
            Assert.AreEqual("", box1.Text);
        }

        [TestMethod()]
        public void mnozTest()
        {
            TextBox box1 = new TextBox();
            box1.Text = "1";
            TextBox box2 = new TextBox();
            m.mnoz(box1, box2);
            Assert.IsTrue(m.mnozenje==true);
            Assert.AreEqual("1 * ", box2.Text);
            Assert.AreEqual("", box1.Text);
        }

        [TestMethod()]
        public void dijTest()
        {
            TextBox box1 = new TextBox();
            box1.Text = "1";
            TextBox box2 = new TextBox();
            m.dij(box1, box2);
            Assert.IsTrue(m.dijeljenje==true);
            Assert.AreEqual("1 / ", box2.Text);
            Assert.AreEqual("", box1.Text);
        }

        [TestMethod()]
        public void oduzTest()
        {
            TextBox box1 = new TextBox();
            box1.Text = "1";
            TextBox box2 = new TextBox();
            m.oduz(box1, box2);
            Assert.IsTrue(m.oduzimanje==true);
            Assert.AreEqual("1 - ", box2.Text);
            Assert.AreEqual("", box1.Text);
        }

        [TestMethod()]
        public void ispisRezultataTest()
        {
            TextBox box1 = new TextBox();
            box1.Text = "1";
            TextBox box2 = new TextBox();
            box2.Text = "2";
            double broj = 45;
            m.ispisRezultata(box1, box2, broj);
            Assert.AreEqual("45", box2.Text);
            Assert.AreEqual("", box1.Text);
        }

        [TestMethod()]
        public void izracunajTest()
        {
            TextBox box1 = new TextBox();
            TextBox box2 = new TextBox();
            box1.Text = "2";
            box2.Text = "2";
            m.setZbrajanje();
            m.izracunaj(box1, box2, 5);
            Assert.IsTrue(m.zbrajanje == true);
            Assert.AreEqual("7", box2.Text);
            Assert.AreEqual("", box1.Text);
        }
    }
}