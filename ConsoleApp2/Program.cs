using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double urun = 1000.0;
            Musteri muster = new Musteri("Uluğ","Bey");
            OzelMusteri ozelmuster = new OzelMusteri("Bey","Uluğ");

            Console.WriteLine($"Normal musteri fiyati {urun} olan urunu {muster.indirimliHesapla(urun)} fiyata alabiliyor.");
            Console.WriteLine($"Ozel musteri fiyati {urun} olan urunu {ozelmuster.indirimliHesapla(urun)} fiyata alabiliyor.");

            ozelmuster--;
            ozelmuster.indirimliHesapla(15000.0);
          //  Console.WriteLine($"{ozelmuster.guncelindirimOrani}");
            ozelmuster--;
          //  Console.WriteLine($"{ozelmuster.guncelindirimOrani}");

        }
    }
}
