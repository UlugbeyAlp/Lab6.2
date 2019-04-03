using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Musteri
    {
        private String ad, soyad;

        public String Ad
        {
            get { return ad; }
            set { value = ad; }
        }

        public String Soyad
        {
            get { return soyad; }
            set { value = soyad; }
        }
        public const double indirimOrani = 0.1;

        public Musteri(String ad, String soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        public virtual double indirimliHesapla(double x)
        {
            x = x * (1 - indirimOrani);
            return x;
        }
    }

    class OzelMusteri : Musteri
    {
        private double toplamAlisveris;
        public double AsgariAlisverisLimiti = 5000.0;
        public double ToplamAlisveris { get; set; }
        public const double ozelindirimOrani = 0.2;
        public double guncelindirimOrani { get; set; }
        
        public OzelMusteri(String ad, String soyad):base(ad,soyad)
        {
            guncelindirimOrani = ozelindirimOrani;
            ToplamAlisveris = 0;
        }

        public override double indirimliHesapla(double x)
        {
            x = x - (x * 0.2);
            ToplamAlisveris = ToplamAlisveris + x;
            return x;
        }
        public static OzelMusteri operator-- (OzelMusteri muste)
        {
            if(muste.ToplamAlisveris < muste.AsgariAlisverisLimiti)
            {
                if (muste.guncelindirimOrani > indirimOrani)
                {
                    muste.guncelindirimOrani = Musteri.indirimOrani;
                    Console.WriteLine("yeterli alışveriş yapılmadı indirim oranı düşürüldü");
                }
            }
            else if(muste.ToplamAlisveris>=muste.AsgariAlisverisLimiti)
            {
                if(muste.guncelindirimOrani<OzelMusteri.ozelindirimOrani)
                {
                    Console.WriteLine("yeterli alışveriş yapıldı indirim oranı arttırıldı");
                    muste.guncelindirimOrani = OzelMusteri.ozelindirimOrani;
                }
            }
            return muste;
        }
    }
}
