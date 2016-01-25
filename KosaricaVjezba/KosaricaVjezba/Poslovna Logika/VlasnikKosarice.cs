using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaVjezba.Poslovna_Logika
{
    public class VlasnikKosarice
    {
        private string id;
        private string naziv;
        private string adresa;

        public VlasnikKosarice(string _id, string _naziv, string _adresa)
        {
            id = _id;
            naziv = _naziv;
            adresa = _adresa;
        }

        public string VratiID()
        {
            return id;
        }

        public string VratiNaziv()
        {
            return naziv;
        }
        public void PromijeniNaziv(string _naziv)
        {
            naziv = _naziv;
        }
        public string VratiAdresu()
        {
            return adresa;
        }
        public void PromijeniAdresu(string _adresa)
        {
            adresa = _adresa;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
