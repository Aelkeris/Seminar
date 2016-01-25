

namespace KosaricaVjezba.Poslovna_Logika
{
    public class StavkaKosarice
    {
        private string opis;
        private int kolicina;
        private decimal cijena;


        public StavkaKosarice(string _opis, int _kolicina, decimal _cijena)
        {
            opis = _opis;
            kolicina = _kolicina;
            cijena = _cijena;
        }
        public StavkaKosarice(string _opis,decimal _cijena)
        {
            opis = _opis;
            cijena = _cijena;
        }
        public string VratiOpis()
        {
            return opis;
        }
        public int VratiKolicinu()
        {
            return kolicina;
        }
        public decimal VratiCijenu()
        {
            return cijena;
        }
        public decimal VratiVrijednost()
        {
            return kolicina * cijena;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
