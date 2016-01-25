using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KosaricaVjezba.Poslovna_Logika
{
    public class Kosarica
    {
        private Guid id;
        private VlasnikKosarice vlasnik;
        private List<StavkaKosarice> stavke=new List<StavkaKosarice>();
        private StatusKosarice status;
        private bool zakljucano=false;
        private void zakljucana()
        {
            //metoda se mora pozvati nakon sto se status kosarice promijeni, kako bi se privatni boolean postavio u odgovarajuću vrijednost
            //ako je false, metode za brisanje i upisivanje rade
            //ako je true, metode za brisanje i upisivanje NE rade
            if(status==StatusKosarice.Placena ||status==StatusKosarice.Stornirana)
            {
                zakljucano=true;
            }
            else
            {
                zakljucano=false;
            }
        }
        public Kosarica(VlasnikKosarice _vlasnik)
        {
            vlasnik = _vlasnik;
        }
        public string vratiVlasnika()
        {
            return vlasnik.VratiNaziv();
        }
        public decimal VratiVrijednost()
        {
            //vraca vrijednost svih stavki u kosariciS
            decimal d=0;
            for(int i=0; i<stavke.Count;i++)
            {
                d = d+stavke.ElementAt(i).VratiVrijednost();
            }
            return d;
            
        }
        public String VratiID()
        {
            return vlasnik.VratiID();
        }
        public StatusKosarice VratiStatus()
        {
            return status;
        }
        public List<StavkaKosarice> VratiStavke()
        {
            return stavke;
        }
        public void DodajStavku(StavkaKosarice _stavka)
        {
            if(zakljucano==false)
            {
                stavke.Add(_stavka);
            }
            else { };
            
        }
        public void DodajStavku(string _opis, int _kolicina, decimal _cijena)
        {
            if (zakljucano == false)
            {
                StavkaKosarice sk = new StavkaKosarice(_opis, _kolicina, _cijena);
                stavke.Add(sk);
            }
            else { };         
        }
        public void DodajStavku(string _opis, decimal _cijena)
        {
            if (zakljucano == false)
            {
                StavkaKosarice x = new StavkaKosarice(_opis, 1, _cijena);
                stavke.Add(x);
            }
            else { };
        }
        public void OmoguciIzmjene()
        {
            status = StatusKosarice.Aktivna;
            zakljucana();
        }
        public void Plati()
        {
            status = StatusKosarice.Placena;
            zakljucana();
        }
        public void Storniraj()
        {
            status = StatusKosarice.Stornirana;
            zakljucana();
        }
        public void ObrisiStavku(int indeks)
        {
            if (zakljucano==false)
            {
                stavke.RemoveAt(indeks);
            }
            else { };
            
        }
        public void ObrisiStavku(StavkaKosarice _stavka)
        {
            if (zakljucano == false)
            {
                stavke.Remove(_stavka);
            }
            else { };        
        }
        public void Isprazni()
        {
            if (zakljucano == false)
            {
                stavke.Clear();
            }
            else { };


            
        }
    }
}
