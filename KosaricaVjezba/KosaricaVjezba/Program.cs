using KosaricaVjezba.Poslovna_Logika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaVjezba
{
    
    public class Program
    {
        static void IspisiKosaricu(Kosarica k)
        {
            Console.WriteLine("Kosarica ID:{0}",k.VratiID());
            Console.WriteLine("Kupac:{0}",k.vratiVlasnika());
            Console.WriteLine("-------------------------------");

            List<StavkaKosarice> sk = k.VratiStavke();
            for(int i=0; i<sk.Count;i++)
            {
                Console.WriteLine("{0}.\t{1}\t{2} kn", i + 1, sk[i].VratiOpis(),sk[i].VratiVrijednost());
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ukupno za platiti: {0} kn", k.VratiVrijednost());
            Console.WriteLine("Status: {0}\n\n",k.VratiStatus().ToString());



        }
        static void Main(string[] args)
        {
            Kosarica k = new Kosarica(new VlasnikKosarice("1", "Ivica Ivić", "Mihovljanska 2, Čakovec"));
            k.DodajStavku("USB kabel", 1,(decimal)10.49);
            k.DodajStavku("Baterije AA", 4, (decimal)2.19);
            k.Plati();
            IspisiKosaricu(k);
            Console.ReadLine();
        }
    }
}
