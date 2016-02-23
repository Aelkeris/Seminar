using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public class kalkulatorMetode
    {

        //globalne varijable 2 broja koji će se računati
        public  double broj1 = 0;
        public  double broj2 = 0;
        //zastavice operacije koja će se izvršiti
        public  bool decTocka = false;
        public  bool zbrajanje = false;
        public  bool oduzimanje = false;
        public  bool dijeljenje = false;
        public  bool mnozenje = false;
        //zastavica koja detektira da li je jednako bilo pritisnutio, ako je, postavlja se u true, te nakon toga, na pritisak broja, čisti se textbox, 
        //te se upisuje broj na prazni texbox
        public bool jednakoPritisnuto = false;
        //ovo je zastavica koja nam govori da li je decimalni zarez postavljen na broj
        public  bool decZarez = false;

        public  bool pozNeg = false;

        //Postavlja flag za zbrajanje
        public void setZbrajanje()
        {
            zbrajanje = true;
            dijeljenje = false;
            mnozenje = false;
            oduzimanje = false;
        }
        //Postavlja flag za oduzimanje
        public void setOduzimanje()
        {
            zbrajanje = false;
            dijeljenje = false;
            mnozenje = false;
            oduzimanje = true;
        }
        //Postavlja flag za mnozenje
        public void setMnozenje()
        {
            zbrajanje = false;
            dijeljenje = false;
            mnozenje = true;
            oduzimanje = false;
        }
        //Postavlja flag za dijeljenje
        public void setDijeljenje()
        {
            zbrajanje = false;
            dijeljenje = true;
            mnozenje = false;
            oduzimanje = false;
        }
        public void promjenaPredznaka(TextBox t)
        {
            //uvijet za provjeru da li se vrši promjena broja sa pozitivnog u negativni i obrnuto (+/-)
            //Ako je texbox prazan ne radi se nikakva promjena;
            if (t.Text == "")
            { }
            else
            {
                //provjera da li je vec promjenjen predznak ili ne
                double checkBr = double.Parse(t.Text);
                if (checkBr > 0)
                {
                    t.Text = "-" + t.Text;
                }
                else if (checkBr < 0)
                {
                    string str = t.Text.Remove(0, 1);
                    t.Text = str;
                }
                else
                { }
            }
        }
        public void jedanKrozBroj(TextBox t)
        {
            if (t.Text == "")
            {

            }
            else
            {
                double br = 1 / double.Parse(t.Text);
                t.Text = br.ToString();
            }
        }
        public void korijen(TextBox t)
        {
            if (t.Text == "")
            {

            }
            else
            {
                double d = Math.Sqrt(double.Parse(t.Text));
                t.Text = d.ToString();
            }

        }
        public void postotak(TextBox t)
        {
            if (t.Text == "")
            {

            }
            else
            {
                if (broj1 != 0)
                {
                    double br2 = broj1 * double.Parse(t.Text) / 100;

                    t.Text = br2.ToString();
                }
            }
        }
        //Upisuje određeni broj kao string u navedeni textbox.Te provjerava da li je jednako bilo pritisnuto, ako je, onda briše oba texboxa,
        //te upisuje broj na prazno
        public void upisBroja(TextBox t, TextBox c, string number, bool zastavica)
        {
            if (zastavica == true)
            {
                t.Clear();
                c.Clear();
                t.Text = t.Text + number;
                zastavica = false;
            }
            else
            {
                t.Text = t.Text + number;
            }
            jednakoPritisnuto = false;
        }
        //Poziva se pritiskom na tipku "+".Metoda postavlja zastavicu za zbrajanje, pretvara vrijednosti iz navedenog textboxa, iz stringa u double broj
        //te ga sprema u globalnu varijablu broj1,kopira vrijednosti iz većeg textboxa u manji, te mu dodaje znak zbrajanja, te čisti veći textbox. 
        public void zbr(TextBox t, TextBox c)
        {
            setZbrajanje();
            broj1 = double.Parse(t.Text);
            c.Text = t.Text + " + ";
            t.Clear();
            decZarez = false;
        }
        //Poziva se pritiskom na tipku "*".Metoda postavlja zastavicu za zbrajanje, pretvara vrijednosti iz navedenog textboxa, iz stringa u double broj
        //te ga sprema u globalnu varijablu broj1,kopira vrijednosti iz većeg textboxa u manji, te mu dodaje znak mnozenja, te čisti veći textbox. 
        public void mnoz(TextBox t, TextBox c)
        {
            setMnozenje();
            broj1 = double.Parse(t.Text);
            c.Text = t.Text + " * ";
            t.Clear();
            decZarez = false;
        }
        //Poziva se pritiskom na tipku "/".Metoda postavlja zastavicu za zbrajanje, pretvara vrijednosti iz navedenog textboxa, iz stringa u double broj
        //te ga sprema u globalnu varijablu broj1,kopira vrijednosti iz većeg textboxa u manji, te mu dodaje znak dijeljenja, te čisti veći textbox. 
        public void dij(TextBox t, TextBox c)
        {
            setDijeljenje();
            broj1 = double.Parse(t.Text);
            c.Text = t.Text + " / ";
            t.Clear();
            decZarez = false;
        }
        //Poziva se pritiskom na tipku "-".Metoda postavlja zastavicu za zbrajanje, pretvara vrijednosti iz navedenog textboxa, iz stringa u double broj
        //te ga sprema u globalnu varijablu broj1,kopira vrijednosti iz većeg textboxa u manji, te mu dodaje znak oduzimanja, te čisti veći textbox. 
        public void oduz(TextBox t, TextBox c)
        {
            setOduzimanje();
            broj1 = double.Parse(t.Text);
            c.Text = t.Text + " - ";
            t.Clear();
            decZarez = false;
        }
        //poziva se unutar metode izracunaj, koja se pozove pritiskom na tipku "=", te metoda čisti oba texboxa, te u veći ispisuje rezultat, koji se 
        //prenese u varijablu br
        public void ispisRezultata(TextBox c, TextBox t, double br)
        {
            c.Clear();
            t.Clear();
            t.Text = br.ToString();
        }
        //postavlja drugi broj računice, iz većeg textboxa u varijablu br2, provjerava koja je zastavica postavljena, te radi operaciju sukladno
        //postavljenoj zastavici. Poziva metodu ispis rezultata;
        public void izracunaj(TextBox c, TextBox t, double br1)
        {
            double rez;
            double br2 = double.Parse(t.Text);
            if (zbrajanje == true)
            {
                rez = br1 + br2;
                ispisRezultata(c, t, rez);
            }
            if (oduzimanje == true)
            {
                rez = br1 - br2;
                ispisRezultata(c, t, rez);
            }
            if (mnozenje == true)
            {
                rez = br1 * br2;
                ispisRezultata(c, t, rez);
            }
            if (dijeljenje == true)
            {
                rez = br1 / br2;
                ispisRezultata(c, t, rez);
            }
            jednakoPritisnuto = true;

        }
    }
}
